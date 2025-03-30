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
        private int setorEscolhido;

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

            // Voto 'Sim' aparece selecionado
            cboTipoVoto.SelectedIndex = 0;

            // Adiciona todos os personagens na combobox
            List<Personagem> personagens = this.partida.ListarPersonagens();
            for (int i = 0; i < personagens.Count; i++)
                cboPosicionarPersonagens.Items.Add(personagens[i].Nome);
        }

        private void btnExibirCartas_Click(object sender, EventArgs e)
        {
            List<Personagem> personagens;

            try
            {
                personagens = this.jogador.ListarCarta();
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return;
            }

            lblCartas.Text = "Carta: ";
            for (int i = 0; i < personagens.Count; i++)
                lblCartas.Text += $"{personagens[i].Inicial}";
        }

        private void bntVerificarVez_Click(object sender, EventArgs e)
        {
            Jogador jogador;
            EstadoTabuleiro estado;

            try
            {
                (jogador, estado) = this.partida.VerificarVez();
                this.tabuleiro.Atualizar(estado, this.Controls);
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return;
            }

            lblVezJogador.Text = $"ID: {jogador.Id}";
            lblNomeVez.Text = $"Nome: {jogador.Nome}";
        }

        private void btnPosicionar_Click(object sender, EventArgs e)
        {
            try
            {
                char personagemEscolhido = Convert.ToChar(((string)cboPosicionarPersonagens.SelectedItem)[0]);
                EstadoTabuleiro estado = this.jogador.ColocarPersonagem(this.setorEscolhido, personagemEscolhido);

                this.tabuleiro.Atualizar(estado, this.Controls);
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return;
            }
        }

        private void btnPainel_Click(object sender, EventArgs e)
        {
            Button btnSetorClicado = (Button)sender;
            bool estaSelecionado = btnSetorClicado.FlatAppearance.BorderSize == 3;

            btnPainel1.FlatAppearance.BorderSize = 0;
            btnPainel2.FlatAppearance.BorderSize = 0;
            btnPainel3.FlatAppearance.BorderSize = 0;
            btnPainel4.FlatAppearance.BorderSize = 0;

            if (estaSelecionado)
            {
                this.setorEscolhido = -1;
            }
            else
            {
                btnSetorClicado.FlatAppearance.BorderSize = 3;
                this.setorEscolhido = Convert.ToInt32(btnSetorClicado.Name.Substring(9));
            }
        }
    }
}
