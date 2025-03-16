using System;
using System.Windows.Forms;
using KingMeServer;  //utilização de dll do PI

namespace PI_PrefeitoDeLondres
{
    public partial class Form1 : Form
    {
        public string nomePartida;
        public string senhaPartida;
        public int idPartida;
        public string nomeGrupo;
        public string nomeJogador;
        public string senhaJogador;
        public int idJogador;

        public Form1()
        {
            InitializeComponent();
            lblVersaoDLL.Text = Jogo.versao;
        }

        private void btnMostrarPartidas_Click(object sender, EventArgs e)     //ao clicar no bnt
        {
            string retorno = Jogo.ListarPartidas("T");             //retorno recebe status de todas as partidas

            retorno = retorno.Replace("\r", "");                   //troca de /r por " "-vazio
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');               // /n realiza a divisão de linhas, colocando as partidas em itens individuais

            lstListaDePartidas.Items.Clear();                     //limpando a lista pra não repetir as mesmas partidas anteriormente solicitadas 
            for (int i = 0; i < partidas.Length; i++)
            {
                lstListaDePartidas.Items.Add(partidas[i]);
            }
        }

        private void lstListaDePartidas_SelectedIndexChanged(object sender, EventArgs e) // ao clicar em um item da lista...
        {
            string partida = lstListaDePartidas.SelectedItem.ToString();       // separando e convertendo os dados da partida
            string[] dadosDaPartida = partida.Split(',');

            int idPartida = Convert.ToInt32(dadosDaPartida[0]);                 // atribuindo cada dado a uma variavel pra facilitar manuseio
            string nomePartida = dadosDaPartida[1];                             // os dados "nome" e "data" não estão sendo usados no momento, remover ou fazer uso no futuro
            string dataPartida = dadosDaPartida[2];

            string retorno = Jogo.ListarJogadores(idPartida);                   // usando o dado "idPartida" para verificar os jogadores da partida
            if (Utils.VerificarErro(retorno))
            {
                Utils.ExibirErro(retorno);
                return;
            }

            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');                           // guardando os jogadores em uma variável pra facilitar o manuseio

            lstListaDeJogadores.Items.Clear();                                  // limpando a lista pra não repetir os mesmos nomes anteriormente solicitados
            for (int i = 0; i < jogadores.Length; i++)
            {
                lstListaDeJogadores.Items.Add(jogadores[i]);                    // jogando na lstListaDeJogadores todos os jogadores da partida selecionada
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            lblNomeIDPartida.Text = "ID da Partida";
            this.nomePartida = txtNomePartida.Text;                     //pega o nome e senha inseridos nas textboxes
            this.senhaPartida = txtSenhaPartida.Text;
            this.nomeGrupo = txtGrupoNome.Text;

            string retorno = Jogo.CriarPartida(this.nomePartida, this.senhaPartida, this.nomeGrupo);   //cria a partida e escreve o id da mesma ao lado
            if (Utils.VerificarErro(retorno))
            {
                Utils.ExibirErro(retorno);
                return;
            }
            this.idPartida = Convert.ToInt32(retorno);

            lblIdPartida.Text = this.idPartida.ToString();
            txtPartidaID.Text = this.idPartida.ToString(); // campo abaixo de ID partida mostra o ID da partida
        }

        private void bntEntrarPartida_Click(object sender, EventArgs e)
        {
            this.nomeJogador = txtNomeJogador.Text;                     //pega o nome e senha inseridos nas textboxes
            this.idPartida = Convert.ToInt32(txtPartidaID.Text);
            this.senhaPartida = txtSenhaPartida.Text;

            string retorno = Jogo.Entrar(this.idPartida, this.nomeJogador, this.senhaPartida);             //retorno recebe dados do IDJogador
            if (Utils.VerificarErro(retorno))
            {
                Utils.ExibirErro(retorno);
                return;
            }

            string[] idesenha = retorno.Split(',');                                       // , realiza a divisão de dados, colocando as partidas em itens individuais       

            this.idJogador = Convert.ToInt32(idesenha[0]);
            this.senhaJogador = idesenha[1];

            lblJogadorID.Text = this.idJogador.ToString();                 //id de jogador
            lblSenhaJogador.Text = this.senhaJogador;                      //id de senha

            txtIDJogador.Text = this.idJogador.ToString(); // txt ID Jogador recebe lbl ID do jogador
            txtSenhaAtualPartida.Text = this.senhaJogador; // txt Senha recebe lbl da senha do jogador
        }

        private void bntIniciarJogo_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.Iniciar(this.idJogador, this.senhaJogador);
            if (Utils.VerificarErro(retorno))
            {
                Utils.ExibirErro(retorno);
                return;
            }

            string lstSetor = Jogo.ListarSetores();

            lstSetor = lstSetor.Replace("\r", "");
            lstSetor = lstSetor.Substring(0, lstSetor.Length - 1);
            string[] setores = lstSetor.Split('\n');                           // guardando os jogadores em uma variável pra facilitar o manuseio

            for (int i = 0; i < setores.Length; i++)
            {
                lstSetores.Items.Add(setores[i]);                    // jogando na lstListaDeJogadores todos os jogadores da partida selecionada
            }

            string lstPersonagem = Jogo.ListarPersonagens();

            lstPersonagem = lstPersonagem.Replace("\r", "");
            lstPersonagem = lstPersonagem.Substring(0, lstPersonagem.Length - 1);
            string[] personagens = lstPersonagem.Split('\n');                           // guardando os jogadores em uma variável pra facilitar o manuseio

            for (int i = 0; i < personagens.Length; i++)
            {
                lstPersonagens.Items.Add(personagens[i]);                    // jogando na lstListaDeJogadores todos os jogadores da partida selecionada
            }

        }

        private void btnExibirCartas_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarCartas(this.idJogador, this.senhaJogador);
            if (Utils.VerificarErro(retorno))
            {
                Utils.ExibirErro(retorno);
                return;
            }

            lblCartas.Text = "Carta: " + retorno;
        }

        private void bntColocarPersonagem_Click(object sender, EventArgs e)
        {
            int setor = Convert.ToInt32(txtSetor.Text);
            string personagem = txtPersonagem.Text;

            string retorno = Jogo.ColocarPersonagem(this.idJogador, this.senhaJogador, setor, personagem);
            lstJogo.Items.Add(retorno);
        }

        private void bntVerificarVez_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.VerificarVez(this.idPartida);
            if (Utils.VerificarErro(retorno))
            {
                Utils.ExibirErro(retorno);
                return;
            }
            string idJogadorVez = retorno.Split(',')[0];

            string retorno2 = Jogo.ListarJogadores(this.idPartida);
            if (Utils.VerificarErro(retorno2))
            {
                Utils.ExibirErro(retorno2);
                return;
            }
            retorno2 = retorno2.Replace("\r", "");
            retorno2 = retorno2.Substring(0, retorno2.Length - 1);
            string[] jogadores = retorno2.Split('\n');

            string nomeJogador = "";
            for (int i = 0; i < jogadores.Length; i++)
            {
                string[] infJogador = jogadores[i].Split(',');

                if (idJogadorVez == infJogador[0])
                {
                    nomeJogador = infJogador[1];
                }
            }

            lblVezJogador.Text = $"ID: {idJogadorVez}";
            lblNomeVez.Text = $"Nome: {nomeJogador}";
        }
    }
}
