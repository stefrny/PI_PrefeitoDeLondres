using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_PrefeitoDeLondres
{
    internal class EstrategiaConservadora : Estrategia
    {
        public override void Posicionar()
        {
            List<Personagem> naoEscolhidos = this.partida.ListarPersonagens();
            List<int> idSetorVazios = new List<int> {1, 2, 3, 4};
            int i;

            foreach (int id in this.tabuleiro.setores.Keys)
            {
                SetorTabuleiro setor = this.tabuleiro.setores[id];
                foreach (Personagem personagemTabuleiro in setor.personagens)
                {
                    i = naoEscolhidos.FindIndex(p => p.Inicial == personagemTabuleiro.Inicial);
                    if (i != -1)
                        naoEscolhidos.RemoveAt(i);
                }

                if (setor.personagens.Count == 4 && id >= 1 && id <= 4)
                    idSetorVazios.Remove(id);
            }

            if (idSetorVazios.Count == 0 || naoEscolhidos.Count == 0) return;

            Personagem personagemEscolhido = null;

            foreach(Personagem personagem in naoEscolhidos)
            {
                if(this.jogador.Carta.Contains(personagem.Inicial))
                    personagemEscolhido = personagem;
            }

            if(personagemEscolhido == null)
            {
                i = 4;
            }
            else
            {
                i = 3;
            }

            for(; i > 0; i--)
            {
                int retornoDaBusca = idSetorVazios.FindIndex(id => id == i);
                if (retornoDaBusca != -1)
                {
                    break;
                }
            }
            if (i == 0 && personagemEscolhido != null) 
            {
                i = 4;
            }
            if (personagemEscolhido == null)
            {
                personagemEscolhido = naoEscolhidos[0];
            }
            try
            {
                this.jogador.ColocarPersonagem(i, personagemEscolhido.Inicial);
            }
            catch (Exception erro)
            {
                Utils.ExibirErro(erro.Message);
                return;
            }
        }

        public override void Promover()
        {

        }

        public override void Votar()
        {

        }

        public EstrategiaConservadora(Jogador jogador, Partida partida, Tabuleiro tabuleiro) : base(jogador, partida, tabuleiro)
        {

        }
    }
}
