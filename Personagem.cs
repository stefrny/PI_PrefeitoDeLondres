namespace PI_PrefeitoDeLondres
{
    public class Personagem
    {
        private string nome;
        public string Nome { get { return nome; } }

        public char Inicial { get { return nome[0]; } }

        public Personagem(string nome)
        {
            this.nome = nome;
        }
    }
}
