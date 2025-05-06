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
            List<Personagem> personagensCarta = this.jogador.ListarCarta();
            Personagem personagemEscolhido = null;
            Personagem primeiroPersonagem = null;
            bool setorAcimaVazio = false;

            for (int i = 0; i < 6; i++)
            {
                SetorTabuleiro setor = this.tabuleiro.setores[i];
                this.tabuleiro.setores.TryGetValue(i + 1, out SetorTabuleiro setorAcima);

                foreach (Personagem personagem in setor.personagens)
                    personagemEscolhido = personagensCarta.Find(p => p.Inicial == personagem.Inicial);

                setorAcimaVazio = i == 5 ? true : setorAcima.personagens.Count < 4;

                if (personagemEscolhido != null && setorAcimaVazio)
                {
                    this.jogador.Promover(personagemEscolhido.Inicial);
                    return;
                }
            }

            for (int i = 5; i > 0; i--)
            {
                SetorTabuleiro setor = this.tabuleiro.setores[i];

                if (setor.personagens.Count == 0)
                    continue;

                primeiroPersonagem = setor.personagens[0];
                break;
            }

            this.jogador.Promover(primeiroPersonagem.Inicial);
            return;
        }

        public override void Votar()
        {
            List<Personagem> personagensCarta = this.jogador.ListarCarta();
            Personagem possivelRei = this.tabuleiro.setores[10].personagens[0];
            bool personagemEstaNaCarta = false;

            foreach (Personagem p in personagensCarta)
                if (p.Inicial == possivelRei.Inicial)
                    personagemEstaNaCarta = true;

            bool votoSim = personagemEstaNaCarta || this.jogador.QuantidadeVotos == 0;
            this.jogador.Votar(votoSim ? 'S' : 'N');
        }

        public EstrategiaConservadora(Jogador jogador, Partida partida, Tabuleiro tabuleiro) : base(jogador, partida, tabuleiro)
        {

        }
    }
}
