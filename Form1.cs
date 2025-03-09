using System;
using System.Windows.Forms;
using KingMeServer;  //utilização de dll do PI

namespace PI_PrefeitoDeLondres
{
    public partial class Form1 : Form
    {
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
            string nomePartidaCriada = txtNomePartida.Text;                     //pega o nome e senha inseridos nas textboxes
            string senhaPartidaCriada = txtSenhaPartida.Text;
            string grupoPartidaCriada = txtGrupoNome.Text;


            lblIdPartida.Text = Jogo.CriarPartida(nomePartidaCriada, senhaPartidaCriada, grupoPartidaCriada);   //cria a partida e escreve o id da mesma ao lado
            txtPartidaID.Text = lblIdPartida.Text; // campo abaixo de ID partida mostra o ID da partida
        }






        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntEntrarPartida_Click(object sender, EventArgs e)
        {
            string nomeJogador = txtNomeJogador.Text;                     //pega o nome e senha inseridos nas textboxes
            string senhaPartida = txtSenhaPartida.Text;
            int Partida = Convert.ToInt32(lblIdPartida.Text);

            string retorno = Jogo.Entrar(Partida, nomeJogador, senhaPartida);             //retorno recebe dados do IDJogador

            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] idesenha = retorno.Split(',');                                       // , realiza a divisão de dados, colocando as partidas em itens individuais       


            lblJogadorID.Text = idesenha[0];                         //id de jogador
            lblSenhaJogador.Text = idesenha[1];                      //id de senha

            txtIDJogador.Text = lblJogadorID.Text; // txt ID Jogador recebe lbl ID do jogador
            txtSenhaAtualPartida.Text = lblSenhaJogador.Text; // txt Senha recebe lbl da senha do jogador



        }
    }
}
