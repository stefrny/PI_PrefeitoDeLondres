using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KingMeServer;  //utilização de dll do PI

namespace PI_PrefeitoDeLondres
{
    public partial class Form1 : Form
    {
        public Partida partida;
        public Jogador jogador;

        public Form1()
        {
            InitializeComponent();
            lblVersaoDLL.Text = Jogo.versao;
        }

        private void btnMostrarPartidas_Click(object sender, EventArgs e)     //ao clicar no bnt
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

            lstListaDePartidas.Items.Clear();                     //limpando a lista pra não repetir as mesmas partidas anteriormente solicitadas 
            for (int i = 0; i < partidas.Count; i++)
            {
                int id = partidas[i].Id;
                string nome = partidas[i].Nome;
                string data = partidas[i].Data.ToShortDateString();
                string status = partidas[i].StatusCompleto;

                lstListaDePartidas.Items.Add($"{id} | {nome} | {data} | {status}");
            }
        }

        private void lstListaDePartidas_SelectedIndexChanged(object sender, EventArgs e) // ao clicar em um item da lista...
        {
            string partidaStr = lstListaDePartidas.SelectedItem.ToString();       // separando e convertendo os dados da partida
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

            lstListaDeJogadores.Items.Clear();                                  // limpando a lista pra não repetir os mesmos nomes anteriormente solicitados
            for (int i = 0; i < jogadores.Count; i++)
            {
                int idJogador = jogadores[i].Id;
                string nomeJogador = jogadores[i].Nome;
                int pontos = jogadores[i].Pontos;

                lstListaDeJogadores.Items.Add($"{idJogador} | {nomeJogador} | {pontos}");                    // jogando na lstListaDeJogadores todos os jogadores da partida selecionada
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            lblNomeIDPartida.Text = "ID da Partida";
            string nomePartida = txtNomePartida.Text;                     //pega o nome e senha inseridos nas textboxes
            string senhaPartida = txtSenhaPartida.Text;
            string nomeGrupo = txtGrupoNome.Text;

            try
            {
                this.partida = Partida.CriarPartida(nomePartida, senhaPartida, nomeGrupo);
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return;
            }

            lblIdPartida.Text = this.partida.Id.ToString();
            txtPartidaID.Text = this.partida.Id.ToString(); // campo abaixo de ID partida mostra o ID da partida
        }

        private void bntEntrarPartida_Click(object sender, EventArgs e)
        {
            string nomeJogador = txtNomeJogador.Text;                     //pega o nome e senha inseridos nas textboxes
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

            lblJogadorID.Text = this.jogador.Id.ToString();                 //id de jogador
            lblSenhaJogador.Text = this.jogador.Senha;                      //id de senha

            txtIDJogador.Text = this.jogador.Id.ToString(); // txt ID Jogador recebe lbl ID do jogador
            txtSenhaAtualPartida.Text = this.jogador.Senha; // txt Senha recebe lbl da senha do jogador

            List<Setor> setores = this.partida.ListarSetores();
            lstSetores.Items.Clear();
            for (int i = 0; i < setores.Count; i++)
                lstSetores.Items.Add($"{setores[i].Id} | {setores[i].Nome}");                    // jogando na lstListaDeJogadores todos os jogadores da partida selecionada

            List<Personagem> personagens = this.partida.ListarPersonagens();
            lstPersonagens.Items.Clear();
            for (int i = 0; i < personagens.Count; i++)
                lstPersonagens.Items.Add(personagens[i].Nome);                    // jogando na lstListaDeJogadores todos os jogadores da partida selecionada
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

            TabuleiroForm tabuleiro = new TabuleiroForm();
            tabuleiro.idJogador = this.idJogador;
            tabuleiro.senhaJogador = this.senhaJogador;
            tabuleiro.idPartida = this.idPartida;

            tabuleiro.ShowDialog();
        }

        private void btnExibirCartas_Click(object sender, EventArgs e)
        {
            List<Personagem> personagens = null;

            try
            {
                if (this.partida == null || this.jogador == null)
                    throw new Exception("Entre em uma partida");

                personagens = this.jogador.ListarCarta();
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return;
            }

            lblCartas.Text = "Carta: ";
            for (int i = 0; i < personagens.Count; i++)
                lblCartas.Text += personagens[i].Inicial;
        }

        private void bntColocarPersonagem_Click(object sender, EventArgs e)
        {
            if (txtSetor.Text == "" || txtPersonagem.Text == "")
            {
                Utils.ExibirErro("Insira o número do setor e a inicial do personagem");
                return;
            }
            int setor = Convert.ToInt32(txtSetor.Text);
            char personagem = Convert.ToChar(txtPersonagem.Text);

            string retorno = null;

            try
            {
                if (this.partida == null || this.jogador == null)
                    throw new Exception("Entre em uma partida");

                retorno = this.jogador.ColocarPersonagem(setor, personagem);
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return;
            }

            lstJogo.Items.Add(retorno);
        }

        private void btnAbrirTabuleiro_Click(object sender, EventArgs e)
        {
            TabuleiroForm tabuleiro = new TabuleiroForm();
            tabuleiro.idJogador = this.idJogador;
            tabuleiro.senhaJogador = this.senhaJogador;
            tabuleiro.idPartida = this.idPartida;

            tabuleiro.ShowDialog();
        }
    }
}
