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

        public TabuleiroForm(Partida partida, Jogador jogador)
        {
            InitializeComponent();
            this.partida = partida;
            this.jogador = jogador;
            this.tabuleiro = new Tabuleiro();

            this.tabuleiro.AdicionarSetor(0, pnlSetor0);
            this.tabuleiro.AdicionarSetor(1, pnlSetor1);
            this.tabuleiro.AdicionarSetor(2, pnlSetor2);
            this.tabuleiro.AdicionarSetor(3, pnlSetor3);
            this.tabuleiro.AdicionarSetor(4, pnlSetor4);
            this.tabuleiro.AdicionarSetor(5, pnlSetor5);
            this.tabuleiro.AdicionarSetor(10, pnlSetor10);

            this.jogador.ResetarVotos(this.partida.Id);

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

            if (rodadaAntes != this.partida.Rodada)
            {
                this.jogador.ResetarVotos(this.partida.Id);
                lblCarta.Text = $"Carta: {this.jogador.Carta}";
            }

            this.ConfigurarDGVPartida();
            this.ConfigurarDGVJogadores();

            lblJogadorDaVez.Text = $"Vez de: {jogador.Nome}";

            return jogador.Id == this.jogador.Id;
        }

        private void Posicionar()
        {
            List<Personagem> naoEscolhidos = this.partida.ListarPersonagens();
            int idSetor = -1;

            foreach (int id in this.tabuleiro.setores.Keys)
            {
                SetorTabuleiro setor = this.tabuleiro.setores[id];
                foreach (Personagem personagemTabuleiro in setor.personagens)
                {
                    int i = naoEscolhidos.FindIndex(p => p.Inicial == personagemTabuleiro.Inicial);
                    if (i != -1)
                        naoEscolhidos.RemoveAt(i);
                }

                if (setor.personagens.Count <= 3 && id >= 1 && id <= 4)
                    idSetor = id;
            }

            if (idSetor == -1 || naoEscolhidos.Count == 0) return;

            try
            {
                this.jogador.ColocarPersonagem(idSetor, naoEscolhidos[0].Inicial);
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return;
            }
        }

        private void Promover()
        {
            List<Personagem> personagensCarta = this.jogador.ListarCarta();
            Personagem personagemEscolhido = null;
            Personagem primeiroPersonagem = null;
            bool setorAcimaVazio = false;

            for (int i = 5; i > 0; i--)
            {
                SetorTabuleiro setor = this.tabuleiro.setores[i];
                this.tabuleiro.setores.TryGetValue(i + 1, out SetorTabuleiro setorAcima);

                foreach (Personagem personagem in setor.personagens)
                    personagemEscolhido = personagensCarta.Find(p => p.Inicial == personagem.Inicial);

                setorAcimaVazio = i == 5 ? true : setorAcima.personagens.Count < 4;

                if (personagemEscolhido != null && setorAcimaVazio)
                {
                    this.jogador.Promover(personagemEscolhido.Inicial);
                    return;
                }

                if (primeiroPersonagem == null && setor.personagens.Count > 0)
                    primeiroPersonagem = setor.personagens[0];
            }

            this.jogador.Promover(primeiroPersonagem.Inicial);
            return;
        }

        private void Votar()
        {
            List<Personagem> personagensCarta = this.jogador.ListarCarta();
            Personagem possivelRei = this.tabuleiro.setores[10].personagens[0];
            bool personagemEstaNaCarta = false;

            foreach (Personagem p in personagensCarta)
                if (p.Inicial == possivelRei.Inicial)
                    personagemEstaNaCarta = true;

            bool votoSim = personagemEstaNaCarta || this.jogador.QuantidadeVotos == 0;
            this.jogador.Votar(votoSim ? 'S' : 'N');
        }

        private void tmrVerificarVez_Tick(object sender, EventArgs e)
        {
            if (this.VerificarVez()) tmrVerificarVez.Enabled = false;
            else return;

            switch (this.partida.Fase)
            {
                case 'S':
                    this.Posicionar();
                    break;
                case 'P':
                    this.Promover();
                    break;
                case 'V':
                    this.Votar();
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
