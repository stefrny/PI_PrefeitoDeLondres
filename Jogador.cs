using System;
using System.Collections.Generic;

namespace PI_PrefeitoDeLondres
{
    public class Jogador
    {
        private int id;
        public int Id { get { return id; } }

        private string nome;
        public string Nome { get { return nome; } }

        private string senha;
        public string Senha { get { return senha; } }

        private int pontos;
        public int Pontos { get { return pontos; } }

        private List<Personagem> carta;

        public Jogador(int id, string nome, string senha, int pontos)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.pontos = pontos;
            this.carta = null;
        }

        public List<Personagem> ListarCarta()
        {
            if (this.carta != null)
                this.carta = APIAdapter.ListarCarta(this.id, this.senha);

            return this.carta;
        }
    }
}
