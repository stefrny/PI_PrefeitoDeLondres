using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_PrefeitoDeLondres
{
    internal abstract class Estrategia
    {
        protected Jogador jogador;
        protected Partida partida;
        protected Tabuleiro tabuleiro;

        public abstract void Posicionar();
        public abstract void Promover();
        public abstract void Votar();

        public Estrategia(Jogador jogador, Partida partida, Tabuleiro tabuleiro)
        {
            this.jogador = jogador;
            this.partida = partida;
            this.tabuleiro = tabuleiro;
        }
    }
}
