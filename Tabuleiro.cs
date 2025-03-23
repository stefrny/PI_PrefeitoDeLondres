using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace PI_PrefeitoDeLondres
{
    public partial class Tabuleiro : Form
    {
        public int idJogador;
        public string senhaJogador;
        int setorEscolhido;
        public int idPartida;


        public Tabuleiro()
        {
            InitializeComponent();
            lblVersaoJogo.Text = Jogo.versao;
            cboTipoVoto.SelectedIndex = 0;

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
    }
}
