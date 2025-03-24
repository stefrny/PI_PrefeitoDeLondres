using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PI_PrefeitoDeLondres
{
    public class Tabuleiro
    {
        private Dictionary<int, List<Personagem>> setores;
        private Dictionary<char, Panel> paineisPersonagens;

        public Tabuleiro()
        {
            this.setores = new Dictionary<int, List<Personagem>>();
            this.paineisPersonagens = new Dictionary<char, Panel>();
        }
    }
}
