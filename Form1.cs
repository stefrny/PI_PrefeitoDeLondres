using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;  //utilização de dll do PI

namespace PI_PrefeitoDeLondres
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MostrarPartidas_Click(object sender, EventArgs e)     //ao clicar no bnt
        {
            string retorno = Jogo.ListarPartidas("T");             //retorno recebe status de todas as partidas
            VizualizaçãoPartidas.Text = retorno;                   //txt recebe lista de partidas

            retorno = retorno.Replace("\r", "");                   //troca de /r por " "-vazio
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');               // /n realiza a divisão de linhas, colocando as partidas em itens individuais


            for (int i = 0; i < partidas.Length - 1; i++)         //em andamento...
            {
                listBox1.Items.Add(partidas[i]); 

            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
