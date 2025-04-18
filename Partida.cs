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
                    case 'E':
                        return "Encerrada";
                    default:
                        return "Desconhecido";
                }
            }
        }

        private int rodada;
        public int Rodada { get { return rodada; } }

        private char fase;
        public char Fase { get { return fase; } }
        public string FaseCompleta
        {
            get
            {
                switch (fase)
                {
                    case 'S':
                        return "Setup";
                    case 'P':
                        return "Promoção";
                    case 'V':
                        return "Votação";
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
            bool listaJogadoresVazia = this.jogadores == null || this.jogadores.Count == 0;

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
            this.rodada = 1;
            this.fase = 'S';
            this.jogadores = this.api.ListarJogadores(this.id);

            foreach (Jogador j in this.jogadores)
                j.ResetarVotos(this.id);
        }

        public (Jogador, EstadoTabuleiro) VerificarVez()
        {
            (Jogador j, char status, int rodada, char fase, EstadoTabuleiro e) = this.api.VerificarVez(this.id);
            this.status = status;
            this.fase = fase;

            if (this.rodada != rodada)
            {
                foreach (Jogador jo in this.ListarJogadores())
                    jo.ResetarVotos(this.id);
            }
            this.rodada = rodada;

            return (j, e);
        }

        public List<Personagem> ListarPersonagens()
        {
            return this.api.ListarPersonagens();
        }

        public List<Setor> ListarSetores()
        {
            return this.api.ListarSetores();
        }

        public string ExibirUltimaVotacao()
        {
            return this.api.ExibirUltimaVotacao(this.id);
        }

        public string ConsultarHistorico(bool formatado, bool completo)
        {
            return this.api.ConsultarHistorico(this.id, formatado, completo);
        }
    }

    public class PartidaView
    {
        public string Nome { get; set; }
        public string Fase { get; set; }
        public int Rodada { get; set; }

        private PartidaView(string nome, string fase, int rodada)
        {
            Nome = nome;
            Fase = fase;
            Rodada = rodada;
        }

        public static PartidaView MapearParaView(Partida partida)
        {
            return new PartidaView(partida.Nome, partida.FaseCompleta, partida.Rodada);
        }
    }
}
