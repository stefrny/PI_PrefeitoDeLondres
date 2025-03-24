using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace PI_PrefeitoDeLondres
{
    public struct Setor
    {

        public Panel painel;
        public string personagens;
        public Setor(Panel painel, string personagens)
        {
            this.painel = painel;
            this.personagens = personagens;


        }
        

    }
    public partial class TabuleiroForm : Form
    {
        public int idJogador;
        public string senhaJogador;
        int setorEscolhido;
        public int idPartida;

        Dictionary<char,Panel> paineis;

        Dictionary<int, Setor> setores;


        public TabuleiroForm()
        {
            InitializeComponent();
            lblVersaoJogo.Text = Jogo.versao;
            cboTipoVoto.SelectedIndex = 0;
            paineis = new Dictionary<char, Panel>();
            paineis.Add('A', pnlLetraA);
            paineis.Add('B', pnlLetraB);
            paineis.Add('T', pnlLetraT);
            paineis.Add('R', pnlLetraR);
            paineis.Add('Q', pnlLetraQ);
            paineis.Add('M', pnlLetraM);
            paineis.Add('L', pnlLetraL);
            paineis.Add('K', pnlLetraK);
            paineis.Add('H', pnlLetraH);
            paineis.Add('G', pnlLetraG);
            paineis.Add('E', pnlLetraE);
            paineis.Add('D', pnlLetraD);
            paineis.Add('C', pnlLetraC);

            setores = new Dictionary<int, Setor>();
            ResetarSetor();
        }



        private void lblVersaoJogo_Click(object sender, EventArgs e)
        {

        }

        private void cboTipoVoto_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnPosicionar_Click(object sender, EventArgs e)
        {
            string personagemEscolhido = cboPosicionarPersonagens.SelectedItem.ToString();
            personagemEscolhido = personagemEscolhido[0].ToString();
            string retorno = Jogo.ColocarPersonagem(idJogador, senhaJogador, setorEscolhido, personagemEscolhido);
            if (Utils.VerificarErro(retorno))
            {
                Utils.ExibirErro(retorno);
                return;
            }

            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] estadotabuleiro = retorno.Split('\n');

            ResetarSetor();
            for (int i = 0; i < estadotabuleiro.Length; i++)
            {
                string[] posicao = estadotabuleiro[i].Split(',');

                int idsetor = Convert.ToInt32(posicao[0]);
                string personagem = posicao[1];

                Setor setor = setores[idsetor];

                if (setor.personagens == null)
                {
                    setor.personagens = personagem;
                }
                else
                {
                    setor.personagens += "," + personagem;
                }
                setores[idsetor] = setor;
            }

            foreach (int chave in setores.Keys)
            {
                Panel pnlSetor = setores[chave].painel;
                string personagensStr = setores[chave].personagens;
                if(personagensStr == null)
                {
                    continue;
                }

                string[] personagens = setores[chave].personagens.Split(',');



                for (int i = 0; i < personagens.Length; i++)
                {
                    char personagem = Convert.ToChar(personagens[i]);
                    Panel pnlpersonagem = paineis[personagem];
                    int x = pnlSetor.Location.X + (pnlpersonagem.Width * i);
                    int y = pnlSetor.Location.Y;
                    pnlpersonagem.Location = new Point(x,y);
                    pnlpersonagem.Visible = true;
                    paineis[personagem] = pnlpersonagem;
                }
                
            }


        }

        private void pnlSetor1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnPainel4_Click(object sender, EventArgs e)
        {
            btnPainel1.FlatAppearance.BorderSize = 0;
            btnPainel2.FlatAppearance.BorderSize = 0;
            btnPainel3.FlatAppearance.BorderSize = 0;
            btnPainel4.FlatAppearance.BorderSize = 3;
            this.setorEscolhido = 4;
        }

        private void btnPainel3_Click(object sender, EventArgs e)
        {
            btnPainel1.FlatAppearance.BorderSize = 0;
            btnPainel2.FlatAppearance.BorderSize = 0;
            btnPainel3.FlatAppearance.BorderSize = 3;
            btnPainel4.FlatAppearance.BorderSize = 0;
            this.setorEscolhido = 3;
        }

        private void btnPainel2_Click(object sender, EventArgs e)
        {
            btnPainel1.FlatAppearance.BorderSize = 0;
            btnPainel2.FlatAppearance.BorderSize = 3;
            btnPainel3.FlatAppearance.BorderSize = 0;
            btnPainel4.FlatAppearance.BorderSize = 0;
            this.setorEscolhido = 2;
        }

        private void btnPainel1_Click(object sender, EventArgs e)
        {
            btnPainel1.FlatAppearance.BorderSize = 3;
            btnPainel2.FlatAppearance.BorderSize = 0;
            btnPainel3.FlatAppearance.BorderSize = 0;
            btnPainel4.FlatAppearance.BorderSize = 0;
            this.setorEscolhido = 1;
        }

        private void Tabuleiro_Load(object sender, EventArgs e)
        {

        }

        private void ResetarSetor()
        {
            setores.Clear();

            setores.Add(0, new Setor(pnlSetor0, null));
            setores.Add(1, new Setor(pnlSetor1, null));
            setores.Add(2, new Setor(pnlSetor2, null));
            setores.Add(3, new Setor(pnlSetor3, null));
            setores.Add(4, new Setor(pnlSetor4, null));
            setores.Add(5, new Setor(pnlSetor5, null));
            setores.Add(10, new Setor(pnlSetor10, null));
        }
    }
}
