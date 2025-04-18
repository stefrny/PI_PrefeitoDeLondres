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

        private int quantidadeVotos;
        public int QuantidadeVotos { get { return quantidadeVotos; } }

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

        public EstadoTabuleiro ColocarPersonagem(int setor, char personagem)
        {
            return this.api.ColocarPersonagem(this.id, this.senha, setor, personagem);
        }

        public EstadoTabuleiro Promover(char personagemEscolhido)
        {
            return this.api.Promover(this.id, this.senha, personagemEscolhido);
        }

        public EstadoTabuleiro Votar(char voto)
        {
            if (voto == 'N') this.quantidadeVotos--;
            return this.api.Votar(this.id, this.senha, voto);
        }

        public void ResetarVotos(int idPartida)
        {
            List<Jogador> jogadores = this.api.ListarJogadores(idPartida);

            switch (jogadores.Count)
            {
                case 2:
                case 3:
                    this.quantidadeVotos = 4;
                    break;
                case 4:
                    this.quantidadeVotos = 3;
                    break;
                default:
                    this.quantidadeVotos = 2;
                    break;
            }
        }
    }

    public class JogadorView
    {
        public string Nome { get; set; }
        public int QuantidadeVotos { get; set; }

        private JogadorView(string nome, int quantidadeVotos)
        {
            this.Nome = nome;
            QuantidadeVotos = quantidadeVotos;
        }

        public static JogadorView MapearParaView(Jogador jogador)
        {
            return new JogadorView(jogador.Nome, jogador.QuantidadeVotos);
        }
    }
}
