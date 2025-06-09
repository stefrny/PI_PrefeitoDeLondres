using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace PI_PrefeitoDeLondres
{
    public struct EstadoTabuleiro
    {
        public Dictionary<int, string> setores;

        public EstadoTabuleiro(Dictionary<int, string> setores)
        {
            this.setores = setores;
        }
    }

    public class SetorTabuleiro
    {
        public Panel painel;
        public List<Personagem> personagens;

        public SetorTabuleiro(Panel painel, List<Personagem> personagens)
        {
            this.painel = painel;
            this.personagens = personagens;
        }
    }

    public class Tabuleiro
    {
        public readonly Dictionary<int, SetorTabuleiro> setores = new Dictionary<int, SetorTabuleiro>();
        private Dictionary<char, Panel> cacheImagens = new Dictionary<char, Panel>();
        private APIAdapter api = new APIAdapter();

        private const int LARGURA_IMG_PERSONAGEM = 66;
        private const int ALTURA_IMG_PERSONAGEM = 100;

        public void Atualizar(EstadoTabuleiro estado, Control.ControlCollection controlesForm)
        {
            foreach (int id in this.setores.Keys)
                this.setores[id].personagens?.Clear();

            List<Personagem> personagensDisponiveis = this.api.ListarPersonagens();

            foreach (int id in estado.setores.Keys)
            {
                if (estado.setores[id] == null) continue;

                string iniciais = estado.setores[id].Replace(",", "");
                for (int i = 0; i < iniciais.Length; i++)
                {
                    Personagem personagem = personagensDisponiveis.Find(p => p.Inicial == iniciais[i]);

                    if (this.setores[id].personagens == null)
                        this.setores[id].personagens = new List<Personagem>();

                    this.setores[id].personagens.Add(personagem);
                    personagensDisponiveis.Remove(personagem);

                    (Panel pnlPersonagem, bool usouCache) = this.ObterPainelParaPersonagem(personagem.Inicial);
                    Panel pnlSetor = this.setores[id].painel;

                    pnlPersonagem.Location = this.CalcularPosicaoPainel(pnlSetor, i);
                    pnlPersonagem.Visible = true;

                    if (!usouCache)
                    {
                        controlesForm.Add(pnlPersonagem);
                        pnlPersonagem.BringToFront();
                        pnlSetor.SendToBack();
                    }
                }
            }

            // Torna invisíveis os painéis dos personagens que não estão no tabuleiro
            foreach (Personagem p in personagensDisponiveis)
            {
                if (this.cacheImagens.TryGetValue(p.Inicial, out Panel pnlpersonagem))
                    pnlpersonagem.Visible = false;
            }
        }

        public void AdicionarSetor(int id, Panel pnlSetor)
        {
            if (this.setores.ContainsKey(id)) return;

            this.setores.Add(id, new SetorTabuleiro(pnlSetor, new List<Personagem>()));
        }

        private (Panel, bool usouCache) ObterPainelParaPersonagem(char inicialPersonagem)
        {
            if (cacheImagens.ContainsKey(inicialPersonagem))
                return (cacheImagens[inicialPersonagem], true);

            ResourceManager rm = Properties.Resources.ResourceManager;
            Image img = (Bitmap)rm.GetObject(inicialPersonagem.ToString());

            cacheImagens[inicialPersonagem] = new Panel
            {
                BackgroundImage = img,
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent,
                Size = new Size(LARGURA_IMG_PERSONAGEM, ALTURA_IMG_PERSONAGEM),
                Name = inicialPersonagem.ToString(),

            };

            return (cacheImagens[inicialPersonagem], false);
        }

        private Point CalcularPosicaoPainel(Panel pnlSetor, int indice)
        {
            int x = pnlSetor.Location.X + LARGURA_IMG_PERSONAGEM + (LARGURA_IMG_PERSONAGEM * indice + 5);
            int y = pnlSetor.Location.Y;

            return new Point(x, y);
        }
    }

    public struct Voto
    {
        public char personagem;
        public int idJogador;
        public char tipo;

        public Voto(char personagem, int idJogador, char tipoVoto)
        {
            this.personagem = personagem;
            this.idJogador = idJogador;
            this.tipo = tipoVoto;
        }

        public override string ToString()
        {
            return $"{personagem},{idJogador},{tipo}\n";
        }
    }
}
