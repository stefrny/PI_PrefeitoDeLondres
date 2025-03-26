using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KingMeServer;

namespace PI_PrefeitoDeLondres
{
    public partial class Form1 : Form
    {
        public Partida partida;
        public Jogador jogador;

        public Form1()
        {
            InitializeComponent();
            lblVersaoDLL.Text = "Versão: " + Jogo.versao;
        }

        private void btnMostrarPartidas_Click(object sender, EventArgs e)
        {
            List<Partida> partidas = null;

            try
            {
                partidas = Partida.ListarPartidas("T");
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return;
            }

            lstListaDePartidas.Items.Clear();
            for (int i = 0; i < partidas.Count; i++)
            {
                int id = partidas[i].Id;
                string nome = partidas[i].Nome;
                string data = partidas[i].Data.ToShortDateString();
                string status = partidas[i].StatusCompleto;

                lstListaDePartidas.Items.Add($"{id} | {nome} | {data} | {status}");
            }
        }

        private void lstListaDePartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partidaStr = lstListaDePartidas.SelectedItem.ToString();
            // [id, nome, data, status]
            string[] dadosDaPartida = partidaStr.Split('|');

            int idPartida = Convert.ToInt32(dadosDaPartida[0]);
            string nomePartida = dadosDaPartida[1].Trim();
            string data = dadosDaPartida[2].Trim();
            char status = dadosDaPartida[3].Trim()[0];

            Partida partida = new Partida(idPartida, nomePartida, null, data, status);
            List<Jogador> jogadores = null;

            try
            {
                jogadores = partida.ListarJogadores();
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return;
            }

            lstListaDeJogadores.Items.Clear();
            for (int i = 0; i < jogadores.Count; i++)
            {
                int idJogador = jogadores[i].Id;
                string nomeJogador = jogadores[i].Nome;
                int pontos = jogadores[i].Pontos;

                lstListaDeJogadores.Items.Add($"{idJogador} | {nomeJogador} | {pontos}");
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNomePartida.Text;
            string senhaPartida = txtSenhaPartida.Text;

            try
            {
                this.partida = Partida.CriarPartida(nomePartida, senhaPartida);
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return;
            }

            lblIdPartida.Text = this.partida.Id.ToString();
            txtPartidaID.Text = this.partida.Id.ToString();
        }

        private void bntEntrarPartida_Click(object sender, EventArgs e)
        {
            string nomeJogador = txtNomeJogador.Text;
            if (txtPartidaID.Text == "")
            {
                Utils.ExibirErro("Insira o ID da partida");
                return;
            }
            int idPartida = Convert.ToInt32(txtPartidaID.Text);
            string senhaPartida = txtSenhaPartida.Text;

            if (this.partida == null)
                this.partida = new Partida(idPartida, null, senhaPartida, null, 'A');

            try
            {
                this.jogador = this.partida.Entrar(nomeJogador, senhaPartida);
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return;
            }

            lblJogadorID.Text = this.jogador.Id.ToString();
            lblSenhaJogador.Text = this.jogador.Senha;

            txtIDJogador.Text = this.jogador.Id.ToString();
            txtSenhaAtualPartida.Text = this.jogador.Senha;
        }

        private void bntIniciarJogo_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.partida == null || this.jogador == null)
                    throw new Exception("Entre em uma partida");

                this.partida.Iniciar(this.jogador.Id, this.jogador.Senha);
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return;
            }

            new TabuleiroForm(this.partida, this.jogador).ShowDialog();
        }

        private void btnAbrirTabuleiro_Click(object sender, EventArgs e)
        {
            new TabuleiroForm(this.partida, this.jogador).ShowDialog();
        }
    }
}
