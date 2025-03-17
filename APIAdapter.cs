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
        void ColocarPersonagem(int idJogador, string senhaJogador, int setor, char personagem);
        Jogador VerificarVez(int idPartida);
        void Promover(int idJogador, string senhaJogador, char personagem);
        void Votar(int idJogador, string senhaJogador, char voto);
        List<Personagem> ListarPersonagens();
        List<Setor> ListarSetores();
        List<Personagem> ListarCarta(int idJogador, string senhaJogador);
        string ExibirUltimaVotacao(int idJogador, string senhaJogador);
        string ConsultarHistorico(int idJogador, string senhaJogador, bool formatado);
    }

    public static class APIAdapter : IAPIAdapter
    {
        public static Partida CriarPartida(string nomePartida, string senhaPartida, string grupo)
        {
            grupo = grupo ?? "Prefeitos de Londres";
            string retorno = Jogo.CriarPartida(nomePartida, senhaPartida, grupo);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            return new Partida(Convert.ToInt32(retorno), nomePartida, senhaPartida, null, 'A');
        }

        public static List<Partida> ListarPartidas(string status)
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
                partidas.Add(new Partida(Convert.Toint32(dados[0]), dados[1], null, dados[2], dados[3]));
            }

            return partidas;
        }

        public static Jogador Entrar(int idPartida, string nomeJogador, string senhaPartida)
        {
            string retorno = Jogo.Entrar(idPartida, nomeJogador, senhaPartida);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            // [id, senha]
            string[] dados = retorno.Split(',');
            return new Jogador(Convert.ToInt32(dados[0]), nomeJogador, Convert.ToInt32(dados[1]), 0);
        }

        public static void Iniciar(int idJogador, string senhaJogador)
        {
            string retorno = Jogo.Iniciar(idJogador, senhaJogador);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);
        }

        public static List<Jogador> ListarJogadores(int idPartida)
        {
            string retorno = Jogo.ListarJogadores(idPartida); 
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            retorno = retorno.Substring(0, retorno.Length - 1).Replace("\r", "");
            string[] linhas = retorno.Split('\n');

            List<Jogador> jogadores = new List<Jogador>();
            for (int i = 0; i < linhas.Length; i++)
            {
                // [id, nome, pontos]
                string[] dados = linhas[i].Split(',');
                jogadores.Add(new Jogador(Convert.Toint32(dados[0]), dados[1], null, Convert.ToInt32(dados[2])));
            }

            return jogadores;
        }

        public static void ColocarPersonagem(int idJogador, string senhaJogador, int setor, char personagem)
        {
            string retorno = Jogo.ColocarPersonagem(idJogador, senhaJogador, setor, personagem);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);
        }

        public static Jogador VerificarVez(int idPartida)
        {
            string retorno = Jogo.VerificarVez(idPartida);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            string[] dados = retorno.Split(',');
            int idJogador = Convert.ToInt32(dados[0]);

            List<Jogador> jogadores = this.ListarJogadores(idPartida);
            return jogadores.Find(j => j.Id == idJogador);
        }

        public static void Promover(int idJogador, string senhaJogador, char personagem)
        {
            string retorno = Jogo.Promover(idJogador, senhaJogador, personagem);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);
        }

        public static void Votar(int idJogador, string senhaJogador, char voto)
        {
            string retorno = Jogo.Votar(idJogador, senhaJogador, voto);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);
        }

        public static List<Personagem> ListarPersonagens()
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

        public static List<Setor> ListarSetores()
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
                setores.Add(new Setor(Convert.Toint32(dados[0]), dados[1]));
            }

            return setores;
        }

        public static List<Personagem> ListarCarta(int idJogador, string senhaJogador)
        {
            string retorno = Jogo.ListarCartas(idJogador, senhaJogador);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            List<Personagem> personagens = this.ListarPersonagens();
            personagens.RemoveAll(p => !retorno.Contains(p.Inicial));

            return personagens;
        }

        public static string ExibirUltimaVotacao(int idJogador, string senhaJogador)
        {
            string retorno = Jogo.ExibirUltimaVotacao(idJogador, senhaJogador);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            return retorno;
        }

        public static string ConsultarHistorico(int idJogador, string senhaJogador, bool formatado)
        {
            string retorno = Jogo.ConsultarHistorico(idJogador, senhaJogador, formatado);
            if (Utils.VerificarErro(retorno))
                throw new Exception(retorno);

            return retorno;
        }
    }
}
