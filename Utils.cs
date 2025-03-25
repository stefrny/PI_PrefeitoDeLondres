using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PI_PrefeitoDeLondres
{
    public static class Utils
    {
        public static bool VerificarErro(string str)
        {
            if (str.Length < 4) return false;
            else return str.Substring(0, 4) == "ERRO";
        }

        public static void ExibirErro(string mensagem)
        {
            if (VerificarErro(mensagem))
                mensagem = mensagem.Substring(5);

            MessageBox.Show(mensagem, "King Me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // string str -> <setor>,<personagem>\r\n... -> "2,B\r\n4,G\r\n..."
        public static Dictionary<int, string> FormatarSetores(string str)
        {
            Dictionary<int, string> setores = new Dictionary<int, string>();
            string[] linhas = str.Replace("\r", "").Split('\n');

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] dados = linhas[i].Split(',');
                int id = Convert.ToInt32(dados[0]);
                string personagem = dados[1];

                if (setores.ContainsKey(id))
                    setores[id] += "," + personagem;
                else
                    setores.Add(id, personagem);
            }

            return setores;
        }
    }
}
