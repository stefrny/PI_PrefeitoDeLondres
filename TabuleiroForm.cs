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

            this.jogador.QuantidadeVotos = this.partida.QuantidadeVotos;
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



        private void Promover()
        {
            List<Personagem> personagensCarta = this.jogador.ListarCarta();
            Personagem personagemEscolhido = null;
            Personagem primeiroPersonagem = null;
            EstadoTabuleiro estado = new EstadoTabuleiro();
            bool setorAcimaVazio = false;

            for (int i = 5; i > 0; i--)
            {
                SetorTabuleiro setor = this.tabuleiro.setores[i];
                this.tabuleiro.setores.TryGetValue(i + 1, out SetorTabuleiro setorAcima);


                foreach (Personagem personagem in setor.personagens)
                {
                    personagemEscolhido = personagensCarta.Find(p => p.Inicial == personagem.Inicial);
                }

                setorAcimaVazio = i == 5 ? true : setorAcima.personagens.Count < 4;


                if(personagemEscolhido != null && setorAcimaVazio)
                {
                    estado = this.jogador.Promover(personagemEscolhido.Inicial);
                    this.tabuleiro.Atualizar(estado, this.Controls);
                    return;
                }

                if  (primeiroPersonagem == null && setor.personagens.Count > 0)
                {
                        primeiroPersonagem = setor.personagens[0];
                }
            }
                estado = this.jogador.Promover(primeiroPersonagem.Inicial);
                this.tabuleiro.Atualizar(estado, this.Controls);
            return;
        }

        private void Votar()
        {
            List<Personagem> personagensCarta = this.jogador.ListarCarta();
            Personagem possivelRei = this.tabuleiro.setores[10].personagens[0];
            bool personagemEstaNaCarta = false;

            foreach (Personagem p in personagensCarta)
            {
                if (p.Inicial == possivelRei.Inicial)
                {
                    personagemEstaNaCarta = true;
                }
            }

            bool votoNao = !personagemEstaNaCarta && this.jogador.QuantidadeVotos > 0;
            EstadoTabuleiro estado = this.jogador.Votar(votoNao ?  'N' : 'S');
            //this.tabuleiro.Atualizar(estado, this.Controls);
        }

        private void tmrVerificarVez_Tick(object sender, EventArgs e)
        {
            bool teste = this.VerificarVez();
            if (teste) tmrVerificarVez.Enabled = false;
            else return;

            switch (this.partida.Fase)
            {
                case 'S':
                    this.Posicionar();
                    break;
                case 'P':
                    this.Promover();
                    break;
                case 'V':
                    this.Votar();
                    break;
                default:
                    break;
            }

            tmrVerificarVez.Enabled = true;
        }
    }
}
