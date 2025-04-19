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
            this.jogadores = new List<Jogador>();
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
            this.jogadores.Add(jogador);
            return jogador;
        }

        public List<Jogador> ListarJogadores()
        {
            List<Jogador> jogadores = this.api.ListarJogadores(this.id);

            foreach (Jogador jogador in jogadores)
            {
                int index = this.jogadores.FindIndex(j => j.Id == jogador.Id);
                if (index == -1)
                    this.jogadores.Add(jogador);
                else
                    this.jogadores[index].Pontos = jogador.Pontos;
            }

            return this.jogadores;
        }

        public void Iniciar(int idJogador, string senhaJogador)
        {
            this.api.Iniciar(idJogador, senhaJogador);

            this.status = 'J';
            this.rodada = 1;
            this.fase = 'S';
            this.jogadores = this.ListarJogadores();

            this.ResetarVotosJogadores();
        }

        public (Jogador, EstadoTabuleiro) VerificarVez()
        {
            (Jogador j, char status, int rodada, char fase, EstadoTabuleiro e) = this.api.VerificarVez(this.id);
            this.status = status;

            if (this.fase == 'V' && fase == 'P')
                this.AtualizarVotosJogadores(this.api.ExibirUltimaVotacao(this.id));
            this.fase = fase;

            if (this.rodada != rodada)
                this.ResetarVotosJogadores();
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
            Voto[] votacao = this.api.ExibirUltimaVotacao(this.id);
            string votacaoStr = "";

            foreach (Voto voto in votacao)
                votacaoStr += voto.ToString();

            return votacaoStr;
        }

        public string ConsultarHistorico(bool formatado, bool completo)
        {
            return this.api.ConsultarHistorico(this.id, formatado, completo);
        }

        private void AtualizarVotosJogadores(Voto[] votacao)
        {
            foreach (Voto voto in votacao)
            {
                if (voto.tipo != 'N') continue;

                int index = this.jogadores.FindIndex(j => j.Id == voto.idJogador);
                if (index != -1)
                    this.jogadores[index].QuantidadeVotos--;
            }
        }

        private void ResetarVotosJogadores()
        {
            int quantidadeJogadores = this.ListarJogadores().Count;
            int quantidadeVotos;

            switch (quantidadeJogadores)
            {
                case 2:
                case 3:
                    quantidadeVotos = 4;
                    break;
                case 4:
                    quantidadeVotos = 3;
                    break;
                default:
                    quantidadeVotos = 2;
                    break;
            }

            foreach (Jogador j in this.jogadores)
                j.QuantidadeVotos = quantidadeVotos;
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
