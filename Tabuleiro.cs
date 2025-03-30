using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PI_PrefeitoDeLondres
{
    public struct EstadoTabuleiro
    {
        public string fase;
        public Dictionary<int, string> setores;

        public EstadoTabuleiro(string fase, Dictionary<int, string> setores)
        {
            this.fase = fase;
            this.setores = setores;
        }
    }

    public struct SetorTabuleiro
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
        private string fase;
        private int round;
        private string status;
        private Dictionary<int, SetorTabuleiro> setores = new Dictionary<int, SetorTabuleiro>();
        private Dictionary<char, Panel> cacheImagens = new Dictionary<char, Panel>();
        private APIAdapter api = new APIAdapter();

        private const int TAMANHO_IMG_PERSONAGEM = 85;

        public void Atualizar(EstadoTabuleiro estado, Control.ControlCollection controlesForm)
        {
            if (estado.fase != null)
                this.fase = estado.fase;

            if (estado.setores == null) return;

            foreach (int id in this.setores.Keys)
                this.setores[id].personagens?.Clear();

            List<Personagem> personagens = this.api.ListarPersonagens();

            foreach (int id in estado.setores.Keys)
            {
                if (estado.setores[id] == null) continue;

                string[] personagensStr = estado.setores[id].Split(',');
                for (int i = 0; i < personagensStr.Length; i++)
                {
                    char inicial = Convert.ToChar(personagensStr[i]);
                    Personagem personagem = personagens.Find(p => p.Inicial == inicial);
                    if (this.setores[id].personagens == null)
                    {
                        SetorTabuleiro setor = this.setores[id];
                        setor.personagens = new List<Personagem>();
                        this.setores[id] = setor;
                    }
                    this.setores[id].personagens.Add(personagem);
                    personagens.Remove(personagem);

                    (Panel pnlPersonagem, bool usouCache) = this.ObterPainelParaPersonagem(personagem.Inicial);
                    Panel pnlSetor = this.setores[id].painel;

                    int x = pnlSetor.Location.X + pnlPersonagem.Width + (pnlPersonagem.Width * i);
                    int y;
                    if (i % 2 != 0)
                        y = pnlSetor.Location.Y + 5;
                    else
                        y = pnlSetor.Location.Y - 5 + pnlSetor.Height - pnlPersonagem.Height;

                    pnlPersonagem.Location = new Point(x, y);
                    pnlPersonagem.Visible = true;

                    if (!usouCache)
                    {
                        controlesForm.Add(pnlPersonagem);
                        pnlPersonagem.BringToFront();
                        pnlSetor.SendToBack();
                    }
                }
            }

            for (int i = 0; i < personagens.Count; i++)
            {
                Panel pnlPersonagem = this.cacheImagens[personagens[i].Inicial];

                if (pnlPersonagem != null)
                    pnlPersonagem.Visible = false;
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

            Image img = null;

            switch (inicialPersonagem)
            {
                case 'A':
                    img = Properties.Resources.A;
                    break;
                case 'B':
                    img = Properties.Resources.B;
                    break;
                case 'C':
                    img = Properties.Resources.C;
                    break;
                case 'D':
                    img = Properties.Resources.D;
                    break;
                case 'E':
                    img = Properties.Resources.E;
                    break;
                case 'G':
                    img = Properties.Resources.G;
                    break;
                case 'H':
                    img = Properties.Resources.H;
                    break;
                case 'K':
                    img = Properties.Resources.K;
                    break;
                case 'L':
                    img = Properties.Resources.L;
                    break;
                case 'M':
                    img = Properties.Resources.M;
                    break;
                case 'Q':
                    img = Properties.Resources.Q;
                    break;
                case 'R':
                    img = Properties.Resources.R;
                    break;
                case 'T':
                    img = Properties.Resources.T1;
                    break;
            }

            cacheImagens[inicialPersonagem] = new Panel
            {
                BackgroundImage = img,
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent,
                Size = new Size(TAMANHO_IMG_PERSONAGEM, TAMANHO_IMG_PERSONAGEM),
                Name = inicialPersonagem.ToString(),
            };

            return (cacheImagens[inicialPersonagem], false);
        }
    }
}
