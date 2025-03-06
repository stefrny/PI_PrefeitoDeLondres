namespace PI_PrefeitoDeLondres
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MostrarPartidas = new System.Windows.Forms.Button();
            this.VizualizaçãoPartidas = new System.Windows.Forms.TextBox();
            this.lstListaDePartidas = new System.Windows.Forms.ListBox();
            this.NomeGrupo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstListaDeJogadores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MostrarPartidas
            // 
            this.MostrarPartidas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarPartidas.Location = new System.Drawing.Point(39, 84);
            this.MostrarPartidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MostrarPartidas.Name = "MostrarPartidas";
            this.MostrarPartidas.Size = new System.Drawing.Size(235, 32);
            this.MostrarPartidas.TabIndex = 0;
            this.MostrarPartidas.Text = "Partidas";
            this.MostrarPartidas.UseVisualStyleBackColor = true;
            this.MostrarPartidas.Click += new System.EventHandler(this.MostrarPartidas_Click);
            // 
            // VizualizaçãoPartidas
            // 
            this.VizualizaçãoPartidas.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VizualizaçãoPartidas.Location = new System.Drawing.Point(39, 123);
            this.VizualizaçãoPartidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VizualizaçãoPartidas.Multiline = true;
            this.VizualizaçãoPartidas.Name = "VizualizaçãoPartidas";
            this.VizualizaçãoPartidas.Size = new System.Drawing.Size(233, 331);
            this.VizualizaçãoPartidas.TabIndex = 1;
            // 
            // lstListaDePartidas
            // 
            this.lstListaDePartidas.FormattingEnabled = true;
            this.lstListaDePartidas.ItemHeight = 16;
            this.lstListaDePartidas.Location = new System.Drawing.Point(344, 123);
            this.lstListaDePartidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstListaDePartidas.Name = "lstListaDePartidas";
            this.lstListaDePartidas.Size = new System.Drawing.Size(205, 180);
            this.lstListaDePartidas.TabIndex = 2;
            this.lstListaDePartidas.SelectedIndexChanged += new System.EventHandler(this.lstListaDePartidas_SelectedIndexChanged);
            // 
            // NomeGrupo
            // 
            this.NomeGrupo.AutoSize = true;
            this.NomeGrupo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeGrupo.Location = new System.Drawing.Point(456, 11);
            this.NomeGrupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NomeGrupo.Name = "NomeGrupo";
            this.NomeGrupo.Size = new System.Drawing.Size(210, 27);
            this.NomeGrupo.TabIndex = 3;
            this.NomeGrupo.Text = "Prefeito De Londres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(992, 524);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "1.0.0.0";
            // 
            // lstListaDeJogadores
            // 
            this.lstListaDeJogadores.FormattingEnabled = true;
            this.lstListaDeJogadores.ItemHeight = 16;
            this.lstListaDeJogadores.Location = new System.Drawing.Point(703, 123);
            this.lstListaDeJogadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstListaDeJogadores.Name = "lstListaDeJogadores";
            this.lstListaDeJogadores.Size = new System.Drawing.Size(205, 180);
            this.lstListaDeJogadores.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lstListaDeJogadores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeGrupo);
            this.Controls.Add(this.lstListaDePartidas);
            this.Controls.Add(this.VizualizaçãoPartidas);
            this.Controls.Add(this.MostrarPartidas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MostrarPartidas;
        private System.Windows.Forms.TextBox VizualizaçãoPartidas;
        private System.Windows.Forms.ListBox lstListaDePartidas;
        private System.Windows.Forms.Label NomeGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstListaDeJogadores;
    }
}

