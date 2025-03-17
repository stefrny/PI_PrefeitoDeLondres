using System;

namespace PI_PrefeitoDeLondres
{
    public class Personagem
    {
        private string nome;
        public string Nome { get { return nome; } }

        private char inicial;
        public string Inicial { get { return nome.Substring(0, 1); } }

        public Personagem(string nome)
        {
            this.nome = nome;
            this.inicial = (char)nome.Substring(0, 1);
        }
    }
}
