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
    }
}
