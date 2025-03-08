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
            this.lstListaDePartidas = new System.Windows.Forms.ListBox();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.lstListaDeJogadores = new System.Windows.Forms.ListBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.lblVersaoDLL = new System.Windows.Forms.Label();
            this.lblNomeIDPartida = new System.Windows.Forms.Label();
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
            // lstListaDePartidas
            // 
            this.lstListaDePartidas.FormattingEnabled = true;
            this.lstListaDePartidas.ItemHeight = 16;
            this.lstListaDePartidas.Location = new System.Drawing.Point(39, 134);
            this.lstListaDePartidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstListaDePartidas.Name = "lstListaDePartidas";
            this.lstListaDePartidas.Size = new System.Drawing.Size(233, 292);
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
            this.lblNomeGrupo.Size = new System.Drawing.Size(219, 27);
            this.lblNomeGrupo.TabIndex = 3;
            this.lblNomeGrupo.Text = "Prefeitos De Londres";
            // 
            // lstListaDeJogadores
            // 
            this.lstListaDeJogadores.FormattingEnabled = true;
            this.lstListaDeJogadores.ItemHeight = 16;
            this.lstListaDeJogadores.Location = new System.Drawing.Point(339, 134);
            this.lstListaDeJogadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstListaDeJogadores.Name = "lstListaDeJogadores";
            this.lstListaDeJogadores.Size = new System.Drawing.Size(233, 292);
            this.lstListaDeJogadores.TabIndex = 5;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(628, 84);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(235, 32);
            this.btnCriarPartida.TabIndex = 6;
            this.btnCriarPartida.Text = "Criar partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(635, 183);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(132, 22);
            this.txtNomePartida.TabIndex = 7;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(631, 164);
            this.lblNomePartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(109, 16);
            this.lblNomePartida.TabIndex = 8;
            this.lblNomePartida.Text = "Nome da Partida";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Location = new System.Drawing.Point(631, 256);
            this.lblSenhaPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(110, 16);
            this.lblSenhaPartida.TabIndex = 11;
            this.lblSenhaPartida.Text = "Senha da partida";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(640, 282);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(132, 22);
            this.txtSenhaPartida.TabIndex = 13;
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(875, 276);
            this.lblIdPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(0, 16);
            this.lblIdPartida.TabIndex = 15;
            // 
            // lblVersaoDLL
            // 
            this.lblVersaoDLL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersaoDLL.AutoSize = true;
            this.lblVersaoDLL.Location = new System.Drawing.Point(1004, 527);
            this.lblVersaoDLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersaoDLL.Name = "lblVersaoDLL";
            this.lblVersaoDLL.Size = new System.Drawing.Size(44, 16);
            this.lblVersaoDLL.TabIndex = 16;
            this.lblVersaoDLL.Text = "label1";
            // 
            // lblNomeIDPartida
            // 
            this.lblNomeIDPartida.AutoSize = true;
            this.lblNomeIDPartida.Location = new System.Drawing.Point(875, 256);
            this.lblNomeIDPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeIDPartida.Name = "lblNomeIDPartida";
            this.lblNomeIDPartida.Size = new System.Drawing.Size(0, 16);
            this.lblNomeIDPartida.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblNomeIDPartida);
            this.Controls.Add(this.lblVersaoDLL);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.lstListaDeJogadores);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lstListaDePartidas);
            this.Controls.Add(this.btnMostrarPartidas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarPartidas;
        private System.Windows.Forms.ListBox lstListaDePartidas;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.ListBox lstListaDeJogadores;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.Label lblVersaoDLL;
        private System.Windows.Forms.Label lblNomeIDPartida;
    }
}

