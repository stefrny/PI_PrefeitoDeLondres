using System;

namespace PI_PrefeitoDeLondres
{
    public class Partida
    {
        private int id;
        public int Id { get { return id; } }

        private string nome;
        public string Nome { get { return nome; } }

        private string senha;
        public string Senha { get { return senha; } }

        private DateTime data;
        public DateTime Data { get { return data; } }

        private char status;
        public char Status { get { return status; } }
        public string StatusCompleto
        {
            get
            {
                switch (status)
                {
                    case 'A':
                        return "Aberta";
                    case 'J':
                        return "Jogando";
                    case 'F':
                        return "Finalizada";
                    default:
                        return "Desconhecido";
                }
            }
        }

        private List<Jogador> jogadores;

        public Partida(int id, string nome, string senha, string data, char status)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.data = DateTime.Parse(data);
            this.status = status.ToUpper();
            this.jogadores = null;
        }

        public static Partida CriarPartida(string nome, string senha, string grupo)
        {
            return APIAdapter.CriarPartida(nome, senha, grupo);
        }

        public static List<Partida> ListarPartidas(string status)
        {
            return APIAdapter.ListarPartidas(status);
        }

        public Jogador Entrar(string nomeJogador, string senhaPartida)
        {
            Jogador jogador = APIAdapter.Entrar(this.id, nomeJogador, senhaPartida);
            this.senha = senhaPartida;
            return jogador;
        }

        public List<Jogador> ListarJogadores()
        {
            bool partidaAberta = this.status == 'A';
            bool listaJogadoresVazia = this.jogadores == null;

            if (partidaAberta)
                return APIAdapter.ListarJogadores(this.id);

            if (listaJogadoresVazia)
                this.jogadores = APIAdapter.ListarJogadores(this.id);

            return this.jogadores;
        }

        public void Iniciar(string idJogador, string senhaJogador)
        {
            APIAdapter.Iniciar(idJogador, senhaJogador);

            this.status = 'J';
            this.jogadores = APIAdapter.ListarJogadores(this.id);
        }

        public Jogador VerificarVez()
        {
            return APIAdapter.VerificarVez(this.id);
        }

        public List<Personagem> ListarPersonagens()
        {
            return APIAdapter.ListarPersonagens();
        }

        public List<Setor> ListarSetores()
        {
            return APIAdapter.ListarSetores();
        }
    }
}
