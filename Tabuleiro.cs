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

        private void btnPosicionar_Click(object sender, EventArgs e)
        {

        }

        private void pnlSetor1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnPainel10_Click(object sender, EventArgs e)
        {
            //btnPainel10.FlatStyle = FlatStyle.Standard;
            btnPainel4.FlatAppearance.BorderSize = 3;
            btnPainel4.FlatAppearance.BorderColor = Color.Red;
        }
    }
}
