using System;
using System.Collections.Generic;

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

        private const string GRUPO = "Prefeitos de Londres";

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

        private APIAdapter api;

        public Partida(int id, string nome, string senha, string data, char status)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.data = data != null ? Convert.ToDateTime(data) : new DateTime();
            this.status = char.ToUpper(status);
            this.jogadores = null;
            this.api = new APIAdapter();
        }

        public static Partida CriarPartida(string nome, string senha)
        {
            return new APIAdapter().CriarPartida(nome, senha, GRUPO);
        }

        public static List<Partida> ListarPartidas(string status)
        {
            return new APIAdapter().ListarPartidas(status);
        }

        public Jogador Entrar(string nomeJogador, string senhaPartida)
        {
            Jogador jogador = this.api.Entrar(this.id, nomeJogador, senhaPartida);
            this.senha = senhaPartida;
            return jogador;
        }

        public List<Jogador> ListarJogadores()
        {
            bool partidaAberta = this.status == 'A';
            bool listaJogadoresVazia = this.jogadores == null;

            if (partidaAberta)
                return this.api.ListarJogadores(this.id);

            if (listaJogadoresVazia)
                this.jogadores = this.api.ListarJogadores(this.id);

            return this.jogadores;
        }

        public void Iniciar(int idJogador, string senhaJogador)
        {
            this.api.Iniciar(idJogador, senhaJogador);

            this.status = 'J';
            this.jogadores = this.api.ListarJogadores(this.id);
        }

        public (Jogador, EstadoTabuleiro) VerificarVez()
        {
            return this.api.VerificarVez(this.id);
        }

        public List<Personagem> ListarPersonagens()
        {
            return this.api.ListarPersonagens();
        }

        public List<Setor> ListarSetores()
        {
            return this.api.ListarSetores();
        }
    }
}
