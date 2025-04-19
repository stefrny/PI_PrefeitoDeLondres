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
        public int Pontos { get { return pontos; } set { pontos = value; } }

        private int quantidadeVotos;
        public int QuantidadeVotos { get { return quantidadeVotos; } set { quantidadeVotos = value; } }

        public string Carta
        {
            get
            {
                string cartaStr = "";
                List<Personagem> carta = this.api.ListarCarta(this.id, this.senha);
                foreach (Personagem p in carta)
                    cartaStr += p.Inicial;
                return cartaStr;
            }
        }

        private APIAdapter api;

        public Jogador(int id, string nome, string senha, int pontos)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.pontos = pontos;
            this.api = new APIAdapter();
        }

        public List<Personagem> ListarCarta()
        {
            return this.api.ListarCarta(this.id, this.senha);
        }

        public EstadoTabuleiro ColocarPersonagem(int setor, char personagem)
        {
            return this.api.ColocarPersonagem(this.id, this.senha, setor, personagem);
        }

        public EstadoTabuleiro Promover(char personagem)
        {
            return this.api.Promover(this.id, this.senha, personagem);
        }

        public EstadoTabuleiro Votar(char voto)
        {
            return this.api.Votar(this.id, this.senha, voto);
        }
    }

    public class JogadorView
    {
        public string Nome { get; set; }
        public int QuantidadeVotos { get; set; }
        public int Pontos { get; set; }

        private JogadorView(string nome, int quantidadeVotos, int pontos)
        {
            Nome = nome;
            QuantidadeVotos = quantidadeVotos;
            Pontos = pontos;
        }

        public static JogadorView MapearParaView(Jogador jogador)
        {
            return new JogadorView(jogador.Nome, jogador.QuantidadeVotos, jogador.Pontos);
        }
    }
}
