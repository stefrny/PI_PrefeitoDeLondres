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

            tmrVerificarVez.Enabled = true;
        }

        private bool VerificarVez()
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
                return false;
            }

            return jogador.Id == this.jogador.Id;
        }

        private void Posicionar()
        {
            List<Personagem> naoEscolhidos = this.partida.ListarPersonagens();
            int idSetor = -1;

            foreach (int id in this.tabuleiro.setores.Keys)
            {
                SetorTabuleiro setor = this.tabuleiro.setores[id];
                foreach (Personagem personagemTabuleiro in setor.personagens)
                {
                    int i = naoEscolhidos.FindIndex(p => p.Inicial == personagemTabuleiro.Inicial);
                    if (i != -1)
                        naoEscolhidos.RemoveAt(i);
                }

                if (setor.personagens.Count <= 3 && id >= 1 && id <= 4)
                    idSetor = id;
            }

            if (idSetor == -1 || naoEscolhidos.Count == 0) return;

            try
            {
                EstadoTabuleiro estado = this.jogador.ColocarPersonagem(idSetor, naoEscolhidos[0].Inicial);
                this.tabuleiro.Atualizar(estado, this.Controls);
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return;
            }
        }

        //private void btnPromover_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        char personagemEscolhido = Convert.ToChar(((string)cboPosicionarPersonagens.SelectedItem)[0]);
        //        EstadoTabuleiro estado = this.jogador.Promover(personagemEscolhido);

        //        this.tabuleiro.Atualizar(estado, this.Controls);
        //    }
        //    catch (Exception erro)
        //    {
        //        Utils.ExibirErro(erro.Message);
        //        return;
        //    }
        //}

        //private void btnConfirmarVoto_Click(object sender, EventArgs e)
        //{
        //    string voto = cboTipoVoto.SelectedItem.ToString();
        //    try
        //    {
        //        EstadoTabuleiro estado = this.jogador.Votar(voto[0]);
        //        this.tabuleiro.Atualizar(estado, this.Controls);
        //    }
        //    catch (Exception erro)
        //    {
        //        Utils.ExibirErro(erro.Message);
        //        return;
        //    }
        //}

        private void tmrVerificarVez_Tick(object sender, EventArgs e)
        {
            if (this.VerificarVez()) tmrVerificarVez.Enabled = false;
            else return;

            switch (this.partida.Fase)
            {
                case 'S':
                    this.Posicionar();
                    break;
                default:
                    break;
            }

            tmrVerificarVez.Enabled = true;
        }
    }
}
