using System;
using System.Collections.Generic;
using KingMeServer;

namespace PI_PrefeitoDeLondres
{
    public interface IAPIAdapter
    {
        Partida CriarPartida(string nomePartida, string senhaPartida, string grupo);
        List<Partida> ListarPartidas(string status);
        Jogador Entrar(int idPartida, string nomeJogador, string senhaPartida);
        void Iniciar(int idJogador, string senhaJogador);
        List<Jogador> ListarJogadores(int idPartida);
        EstadoTabuleiro ColocarPersonagem(int idJogador, string senhaJogador, int setor, char personagem);
        (Jogador, EstadoTabuleiro) VerificarVez(int idPartida);
        void Promover(int idJogador, string senhaJogador, char personagem);
        void Votar(int idJogador, string senhaJogador, char voto);
        List<Personagem> ListarPersonagens();
        List<Setor> ListarSetores();
        List<Personagem> ListarCarta(int idJogador, string senhaJogador);
        string ExibirUltimaVotacao(int idPartida);
        string ConsultarHistorico(int idPartida, bool formatado);
    }

    public class APIAdapter : IAPIAdapter
    {
        public Partida CriarPartida(string nomePartida, string senhaPartida, string grupo)
        {
            grupo = grupo ?? "Prefeitos de Londres";
            string retorno = Jogo.CriarPartida(nomePartida, senhaPartida, grupo);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            return new Partida(Convert.ToInt32(retorno), nomePartida, senhaPartida, null, 'A');
        }

        public List<Partida> ListarPartidas(string status)
        {
            string retorno = Jogo.ListarPartidas(status);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            retorno = retorno.Substring(0, retorno.Length - 1).Replace("\r", "");
            string[] linhas = retorno.Split('\n');

            List<Partida> partidas = new List<Partida>();
            for (int i = 0; i < linhas.Length; i++)
            {
                // [id, nome, data, status]
                string[] dados = linhas[i].Split(',');
                partidas.Add(new Partida(Convert.ToInt32(dados[0]), dados[1], null, dados[2], Convert.ToChar(dados[3])));
            }

            return partidas;
        }

        public Jogador Entrar(int idPartida, string nomeJogador, string senhaPartida)
        {
            string retorno = Jogo.Entrar(idPartida, nomeJogador, senhaPartida);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            // [id, senha]
            string[] dados = retorno.Split(',');
            return new Jogador(Convert.ToInt32(dados[0]), nomeJogador, dados[1], 0);
        }

        public void Iniciar(int idJogador, string senhaJogador)
        {
            string retorno = Jogo.Iniciar(idJogador, senhaJogador);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);
        }

        public List<Jogador> ListarJogadores(int idPartida)
        {
            string retorno = Jogo.ListarJogadores(idPartida);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            if (retorno.Length == 0) return new List<Jogador>();

            retorno = retorno.Substring(0, retorno.Length - 1).Replace("\r", "");
            string[] linhas = retorno.Split('\n');

            List<Jogador> jogadores = new List<Jogador>();
            for (int i = 0; i < linhas.Length; i++)
            {
                // [id, nome, pontos]
                string[] dados = linhas[i].Split(',');
                jogadores.Add(new Jogador(Convert.ToInt32(dados[0]), dados[1], null, Convert.ToInt32(dados[2])));
            }

            return jogadores;
        }

        public EstadoTabuleiro ColocarPersonagem(int idJogador, string senhaJogador, int setor, char personagem)
        {
            // int,char \r\n int,char \r\n ...
            string retorno = Jogo.ColocarPersonagem(idJogador, senhaJogador, setor, personagem.ToString());
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            Dictionary<int, string> setores = Utils.FormatarSetores(retorno);

            return new EstadoTabuleiro(null, setores);
        }

        public (Jogador, EstadoTabuleiro) VerificarVez(int idPartida)
        {
            // int,char,int,char \r\n int,char \r\n ...
            string retorno = Jogo.VerificarVez(idPartida);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            string[] linhas = retorno.Substring(0, retorno.Length - 1).Replace("\r", "").Split('\n');
            string[] dadosPrimeiraLinha = linhas[0].Split(',');

            int idJogador = Convert.ToInt32(dadosPrimeiraLinha[0]);
            string fase = dadosPrimeiraLinha[1];

            Dictionary<int, string> setores = null;
            if (linhas.Length > 1)
            {
                string setoresStr = null;
                for (int i = 1; i < linhas.Length; i++)
                    setoresStr += linhas[i] + "\r\n";

                setores = Utils.FormatarSetores(setoresStr);
            }

            List<Jogador> jogadores = this.ListarJogadores(idPartida);
            Jogador jogadorDaVez = jogadores.Find(j => j.Id == idJogador);

            return (jogadorDaVez, new EstadoTabuleiro(fase, setores));
        }

        public void Promover(int idJogador, string senhaJogador, char personagem)
        {
            string retorno = Jogo.Promover(idJogador, senhaJogador, personagem.ToString());
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);
        }

        public void Votar(int idJogador, string senhaJogador, char voto)
        {
            string retorno = Jogo.Votar(idJogador, senhaJogador, voto.ToString());
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);
        }

        public List<Personagem> ListarPersonagens()
        {
            string retorno = Jogo.ListarPersonagens();
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            retorno = retorno.Substring(0, retorno.Length - 1).Replace("\r", "");
            string[] personagensStr = retorno.Split('\n');

            List<Personagem> personagens = new List<Personagem>();
            for (int i = 0; i < personagensStr.Length; i++)
                personagens.Add(new Personagem(personagensStr[i]));

            return personagens;
        }

        public List<Setor> ListarSetores()
        {
            string retorno = Jogo.ListarSetores();
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            retorno = retorno.Substring(0, retorno.Length - 1).Replace("\r", "");
            string[] linhas = retorno.Split('\n');

            List<Setor> setores = new List<Setor>();
            for (int i = 0; i < linhas.Length; i++)
            {
                // [id, nome]
                string[] dados = linhas[i].Split(',');
                setores.Add(new Setor(Convert.ToInt32(dados[0]), dados[1]));
            }

            return setores;
        }

        public List<Personagem> ListarCarta(int idJogador, string senhaJogador)
        {
            string retorno = Jogo.ListarCartas(idJogador, senhaJogador);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            List<Personagem> personagens = this.ListarPersonagens();
            personagens.RemoveAll(p => !retorno.Contains(p.Inicial.ToString()));

            return personagens;
        }

        public string ExibirUltimaVotacao(int idPartida)
        {
            string retorno = Jogo.ExibirUltimaVotacao(idPartida);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            return retorno;
        }

        public string ConsultarHistorico(int idPartida, bool formatado)
        {
            string retorno = Jogo.ConsultarHistorico(idPartida, formatado);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            return retorno;
        }
    }
}
