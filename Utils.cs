using System.Windows.Forms;

namespace PI_PrefeitoDeLondres
{
    public static class Utils
    {
        public static bool VerificarErro(string str)
        {
            return str.Substring(0, 4) == "ERRO";
        }

        public static void ExibirErro(string mensagem)
        {
            if (VerificarErro(mensagem))
                mensagem = mensagem.Substring(5);

            MessageBox.Show(mensagem, "some", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
