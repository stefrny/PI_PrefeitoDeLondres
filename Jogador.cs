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

        public void AdicionarCarta(string carta)
        {
            if (this.carta != null)
                throw new Exception($"Jogador {this.nome} já possui uma carta.");

            this.carta = new List<Personagem>();
            for (int i = 0; i < carta.Length; i++)
                this.carta.Add(new Personagem(carta[i]));
        }
    }
}
