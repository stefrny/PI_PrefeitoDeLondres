using System;
using System.Collections.Generic;
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
    }

    public class Tabuleiro
    {
        private fase;
        public Dictionary<int, SetorTabuleiro> setores;
        public Dictionary<char, Panel> paineisPersonagens;
        private APIAdapter api;

        public Tabuleiro()
        {
            this.setores = new Dictionary<int, SetorTabuleiro>();
            this.paineisPersonagens = new Dictionary<char, Panel>();
            this.api = new APIAdapter();
        }

        public void Atualizar(EstadoTabuleiro estado)
        {
            if (estado.fase != null)
                this.fase = estado.fase;

            foreach (int chave in this.setores.Keys)
            {
                if (this.setores[chave].personagens != null)
                    this.setores[chave].personagens.Clear();
            }

            List<Personagem> personagens = this.api.ListarPersonagens();

            foreach (int chave in estado.setores.Keys)
            {
                if (estado.setores[chave] == null) continue;

                string[] personagensStr = estado.setores[chave].Split(',');
                for (int i = 0; i < personagensStr.Length; i++)
                {
                    Personagem personagem = personagens.Find(p => p.Inicial == personagensStr[i]);
                    if (this.setores[chave].personagens == null)
                        this.setores[chave].personagens = new List<Personagem>();
                    this.setores[chave].personagens.Add(personagem);
                    personagens.Remove(personagem);

                    Panel pnlPersonagem = this.paineisPersonagens[personagem.Inicial];
                    Panel pnlSetor = this.setores[chave].painel;

                    int x = pnlSetor.Location.X + pnlPersonagem.Width + (pnlPersonagem.Width * i);
                    int y;
                    if (i % 2 != 0)
                        y = pnlSetor.Location.Y + 5;
                    else
                        y = pnlSetor.Location.Y - 5 + pnlSetor.Height - pnlPersonagem.Height;

                    pnlPersonagem.Location = new Point(x, y);
                    pnlPersonagem.Visible = true;
                    this.paineisPersonagens[personagem.Inicial] = pnlPersonagem;
                }
            }
        }
    }
}
