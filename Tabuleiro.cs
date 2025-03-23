﻿using System;
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
    }
}
