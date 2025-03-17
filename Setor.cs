using System;

namespace PI_PrefeitoDeLondres
{
    public class Setor
    {
        private int id;
        public int Id { get { return id; } }

        private string nome;
        public string Nome { get { return nome; } }

        public Setor(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }
}
