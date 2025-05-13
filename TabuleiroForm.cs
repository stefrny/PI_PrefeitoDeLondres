using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PI_PrefeitoDeLondres
{
    public partial class TabuleiroForm : Form
    {
        private Partida partida;
        private Jogador jogador;
        private Tabuleiro tabuleiro;
        private Estrategia estrategia;

        public TabuleiroForm(Partida partida, Jogador jogador)
        {
            InitializeComponent();
            this.partida = partida;
            this.jogador = jogador;
            this.tabuleiro = new Tabuleiro();
            this.estrategia = new EstrategiaConservadora(this.jogador, this.partida, this.tabuleiro);

            this.tabuleiro.AdicionarSetor(0, pnlSetor0);
            this.tabuleiro.AdicionarSetor(1, pnlSetor1);
            this.tabuleiro.AdicionarSetor(2, pnlSetor2);
            this.tabuleiro.AdicionarSetor(3, pnlSetor3);
            this.tabuleiro.AdicionarSetor(4, pnlSetor4);
            this.tabuleiro.AdicionarSetor(5, pnlSetor5);
            this.tabuleiro.AdicionarSetor(10, pnlSetor10);

            this.ConfigurarDGVPartida();
            this.ConfigurarDGVJogadores();

            lblCarta.Text = $"Carta: {this.jogador.Carta}";

            tmrVerificarVez.Enabled = true;
        }

        private bool VerificarVez()
        {
            Jogador jogador;
            EstadoTabuleiro estado;
            int rodadaAntes = this.partida.Rodada;

            try
            {
                (jogador, estado) = this.partida.VerificarVez();
                this.tabuleiro.Atualizar(estado, this.Controls);
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return false;
            }

            this.ConfigurarDGVPartida();
            this.ConfigurarDGVJogadores();

            lblJogadorDaVez.Text = $"Vez de: {jogador.Nome}";
            if (rodadaAntes != this.partida.Rodada)
                lblCarta.Text = $"Carta: {this.jogador.Carta}";

            return jogador.Id == this.jogador.Id;
        }

        private void tmrVerificarVez_Tick(object sender, EventArgs e)
        {
            if (this.VerificarVez()) tmrVerificarVez.Enabled = false;
            else return;

            switch (this.partida.Fase)
            {
                case 'S':
                    this.estrategia.Posicionar();
                    break;
                case 'P':
                    this.estrategia.Promover();
                    break;
                case 'V':
                    this.estrategia.Votar();
                    break;
                default:
                    break;
            }

            this.VerificarVez();
            tmrVerificarVez.Enabled = true;
        }

        private void ConfigurarDGVJogadores()
        {
            Utils.ConfigurarDGVPadrao(dgvJogadores);

            List<JogadorView> jogadoresViews = new List<JogadorView>();
            foreach (Jogador jogador in this.partida.ListarJogadores())
                jogadoresViews.Add(JogadorView.MapearParaView(jogador));

            dgvJogadores.DataSource = jogadoresViews;
        }

        private void ConfigurarDGVPartida()
        {
            Utils.ConfigurarDGVPadrao(dgvPartida);
            List<PartidaView> partidasViews = new List<PartidaView>
            {
                PartidaView.MapearParaView(this.partida)
            };
            dgvPartida.DataSource = partidasViews;
        }
    }
}
