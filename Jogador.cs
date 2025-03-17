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

        private APIAdapter api;

        public Jogador(int id, string nome, string senha, int pontos)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.pontos = pontos;
            this.carta = null;
            this.api = new APIAdapter();
        }

        public List<Personagem> ListarCarta()
        {
            if (this.carta == null)
                this.carta = this.api.ListarCarta(this.id, this.senha);

            return this.carta;
        }

        public string ColocarPersonagem(int setor, char personagem)
        {
            return this.api.ColocarPersonagem(this.id, this.senha, setor, personagem);
        }
    }
}
