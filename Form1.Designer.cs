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
            this.btnMostrarPartidas = new System.Windows.Forms.Button();
            this.txtVizualizaçãoPartidas = new System.Windows.Forms.TextBox();
            this.lstListaDePartidas = new System.Windows.Forms.ListBox();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lstListaDeJogadores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMostrarPartidas
            // 
            this.btnMostrarPartidas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPartidas.Location = new System.Drawing.Point(39, 84);
            this.btnMostrarPartidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarPartidas.Name = "btnMostrarPartidas";
            this.btnMostrarPartidas.Size = new System.Drawing.Size(235, 32);
            this.btnMostrarPartidas.TabIndex = 0;
            this.btnMostrarPartidas.Text = "Partidas";
            this.btnMostrarPartidas.UseVisualStyleBackColor = true;
            this.btnMostrarPartidas.Click += new System.EventHandler(this.btnMostrarPartidas_Click);
            // 
            // txtVizualizaçãoPartidas
            // 
            this.txtVizualizaçãoPartidas.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVizualizaçãoPartidas.Location = new System.Drawing.Point(39, 123);
            this.txtVizualizaçãoPartidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVizualizaçãoPartidas.Multiline = true;
            this.txtVizualizaçãoPartidas.Name = "txtVizualizaçãoPartidas";
            this.txtVizualizaçãoPartidas.Size = new System.Drawing.Size(233, 331);
            this.txtVizualizaçãoPartidas.TabIndex = 1;
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
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGrupo.Location = new System.Drawing.Point(456, 11);
            this.lblNomeGrupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(210, 27);
            this.lblNomeGrupo.TabIndex = 3;
            this.lblNomeGrupo.Text = "Prefeito De Londres";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.Location = new System.Drawing.Point(992, 524);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(57, 19);
            this.lblVersao.TabIndex = 4;
            this.lblVersao.Text = "1.0.0.0";
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
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lstListaDePartidas);
            this.Controls.Add(this.txtVizualizaçãoPartidas);
            this.Controls.Add(this.btnMostrarPartidas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarPartidas;
        private System.Windows.Forms.TextBox txtVizualizaçãoPartidas;
        private System.Windows.Forms.ListBox lstListaDePartidas;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.ListBox lstListaDeJogadores;
    }
}

