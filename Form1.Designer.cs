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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NomeGrupo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MostrarPartidas
            // 
            this.MostrarPartidas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarPartidas.Location = new System.Drawing.Point(29, 68);
            this.MostrarPartidas.Name = "MostrarPartidas";
            this.MostrarPartidas.Size = new System.Drawing.Size(176, 26);
            this.MostrarPartidas.TabIndex = 0;
            this.MostrarPartidas.Text = "Partidas";
            this.MostrarPartidas.UseVisualStyleBackColor = true;
            this.MostrarPartidas.Click += new System.EventHandler(this.MostrarPartidas_Click);
            // 
            // VizualizaçãoPartidas
            // 
            this.VizualizaçãoPartidas.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VizualizaçãoPartidas.Location = new System.Drawing.Point(29, 100);
            this.VizualizaçãoPartidas.Multiline = true;
            this.VizualizaçãoPartidas.Name = "VizualizaçãoPartidas";
            this.VizualizaçãoPartidas.Size = new System.Drawing.Size(176, 270);
            this.VizualizaçãoPartidas.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(258, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 147);
            this.listBox1.TabIndex = 2;
            // 
            // NomeGrupo
            // 
            this.NomeGrupo.AutoSize = true;
            this.NomeGrupo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeGrupo.Location = new System.Drawing.Point(342, 9);
            this.NomeGrupo.Name = "NomeGrupo";
            this.NomeGrupo.Size = new System.Drawing.Size(161, 21);
            this.NomeGrupo.TabIndex = 3;
            this.NomeGrupo.Text = "Prefeito De Londres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(744, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "1.0.0.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeGrupo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.VizualizaçãoPartidas);
            this.Controls.Add(this.MostrarPartidas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MostrarPartidas;
        private System.Windows.Forms.TextBox VizualizaçãoPartidas;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label NomeGrupo;
        private System.Windows.Forms.Label label1;
    }
}

