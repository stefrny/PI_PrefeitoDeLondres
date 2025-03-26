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

        public SetorTabuleiro(Panel painel,  List<Personagem> personagens)
        {
            this.painel = painel;
            this.personagens = personagens;
        }
    }

    public class Tabuleiro
    {
        private string fase;
        public Dictionary<int, SetorTabuleiro> setores;
        private Dictionary<char, Panel> cacheImagens;
        private APIAdapter api;

        public Tabuleiro()
        {
            this.setores = new Dictionary<int, SetorTabuleiro>();
            this.cacheImagens = new Dictionary<char, Panel>();
            this.api = new APIAdapter();
        }

        public void Atualizar(EstadoTabuleiro estado)
        {
            if (estado.fase != null)
                this.fase = estado.fase;

            if (estado.setores == null) return;

            foreach (int chave in this.setores.Keys)
                this.setores[chave].personagens?.Clear();

            List<Personagem> personagens = this.api.ListarPersonagens();

            foreach (int chave in estado.setores.Keys)
            {
                if (estado.setores[chave] == null) continue;

                string[] personagensStr = estado.setores[chave].Split(',');
                for (int i = 0; i < personagensStr.Length; i++)
                {
                    char incial = Convert.ToChar(personagensStr[i]);
                    Personagem personagem = personagens.Find(p => p.Inicial == incial);
                    if (this.setores[chave].personagens == null)
                    {
                        SetorTabuleiro setor = this.setores[chave];
                        setor.personagens = new List<Personagem>();
                        this.setores[chave] = setor;
                    }
                    this.setores[chave].personagens.Add(personagem);
                    personagens.Remove(personagem);

                    Panel pnlPersonagem = this.ObterPainelParaPersonagem(personagem.Inicial);
                    Panel pnlSetor = this.setores[chave].painel;

                    int x = pnlSetor.Location.X + pnlPersonagem.Width + (pnlPersonagem.Width * i);
                    int y;
                    if (i % 2 != 0)
                        y = pnlSetor.Location.Y + 5;
                    else
                        y = pnlSetor.Location.Y - 5 + pnlSetor.Height - pnlPersonagem.Height;

                    pnlPersonagem.Location = new Point(x, y);
                }
            }
        }

        private Panel ObterPainelParaPersonagem(char inicialPersonagem)
        {
            if (cacheImagens.ContainsKey(inicialPersonagem))
            {
                return cacheImagens[inicialPersonagem];
            }

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
                case 'K':
                    img = Properties.Resources.H;
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
                    img = Properties.Resources.T;
                    break;
            }

            cacheImagens[inicialPersonagem] = new Panel
            {
                BackgroundImage = img,
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent,
                Size = new Size(85, 85)
            };

            return cacheImagens[inicialPersonagem];
        }
    }
}
