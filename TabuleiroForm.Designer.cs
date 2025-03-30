namespace PI_PrefeitoDeLondres
{
    partial class TabuleiroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPosicionar = new System.Windows.Forms.Button();
            this.btnPromover = new System.Windows.Forms.Button();
            this.btnConfirmarVoto = new System.Windows.Forms.Button();
            this.cboTipoVoto = new System.Windows.Forms.ComboBox();
            this.lblCartas = new System.Windows.Forms.Label();
            this.btnExibirCartas = new System.Windows.Forms.Button();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.cboPosicionarPersonagens = new System.Windows.Forms.ComboBox();
            this.pnlSetor4 = new System.Windows.Forms.Panel();
            this.btnPainel4 = new System.Windows.Forms.Button();
            this.pnlSetor5 = new System.Windows.Forms.Panel();
            this.pnlSetor2 = new System.Windows.Forms.Panel();
            this.btnPainel2 = new System.Windows.Forms.Button();
            this.pnlSetor10 = new System.Windows.Forms.Panel();
            this.pnlSetor3 = new System.Windows.Forms.Panel();
            this.btnPainel3 = new System.Windows.Forms.Button();
            this.pnlSetor1 = new System.Windows.Forms.Panel();
            this.btnPainel1 = new System.Windows.Forms.Button();
            this.pnlSetor0 = new System.Windows.Forms.Panel();
            this.lblVezJogador = new System.Windows.Forms.Label();
            this.lblNomeVez = new System.Windows.Forms.Label();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.pnlSetor4.SuspendLayout();
            this.pnlSetor2.SuspendLayout();
            this.pnlSetor3.SuspendLayout();
            this.pnlSetor1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPosicionar
            // 
            this.btnPosicionar.Location = new System.Drawing.Point(29, 241);
            this.btnPosicionar.Name = "btnPosicionar";
            this.btnPosicionar.Size = new System.Drawing.Size(75, 23);
            this.btnPosicionar.TabIndex = 1;
            this.btnPosicionar.Text = "Posicionar";
            this.btnPosicionar.UseVisualStyleBackColor = true;
            this.btnPosicionar.Click += new System.EventHandler(this.btnPosicionar_Click);
            // 
            // btnPromover
            // 
            this.btnPromover.Location = new System.Drawing.Point(29, 364);
            this.btnPromover.Name = "btnPromover";
            this.btnPromover.Size = new System.Drawing.Size(75, 23);
            this.btnPromover.TabIndex = 2;
            this.btnPromover.Text = "Promover";
            this.btnPromover.UseVisualStyleBackColor = true;
            this.btnPromover.Click += new System.EventHandler(this.btnPromover_Click);
            // 
            // btnConfirmarVoto
            // 
            this.btnConfirmarVoto.Location = new System.Drawing.Point(29, 497);
            this.btnConfirmarVoto.Name = "btnConfirmarVoto";
            this.btnConfirmarVoto.Size = new System.Drawing.Size(89, 23);
            this.btnConfirmarVoto.TabIndex = 3;
            this.btnConfirmarVoto.Text = "Confirmar Voto";
            this.btnConfirmarVoto.UseVisualStyleBackColor = true;
            // 
            // cboTipoVoto
            // 
            this.cboTipoVoto.FormattingEnabled = true;
            this.cboTipoVoto.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboTipoVoto.Location = new System.Drawing.Point(29, 455);
            this.cboTipoVoto.Name = "cboTipoVoto";
            this.cboTipoVoto.Size = new System.Drawing.Size(121, 21);
            this.cboTipoVoto.TabIndex = 4;
            // 
            // lblCartas
            // 
            this.lblCartas.AutoSize = true;
            this.lblCartas.Location = new System.Drawing.Point(26, 607);
            this.lblCartas.Name = "lblCartas";
            this.lblCartas.Size = new System.Drawing.Size(0, 13);
            this.lblCartas.TabIndex = 5;
            // 
            // btnExibirCartas
            // 
            this.btnExibirCartas.Location = new System.Drawing.Point(29, 563);
            this.btnExibirCartas.Name = "btnExibirCartas";
            this.btnExibirCartas.Size = new System.Drawing.Size(75, 23);
            this.btnExibirCartas.TabIndex = 6;
            this.btnExibirCartas.Text = "Exibir cartas";
            this.btnExibirCartas.UseVisualStyleBackColor = true;
            this.btnExibirCartas.Click += new System.EventHandler(this.btnExibirCartas_Click);
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.Location = new System.Drawing.Point(29, 72);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarVez.TabIndex = 7;
            this.btnVerificarVez.Text = "Verificar Vez";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            this.btnVerificarVez.Click += new System.EventHandler(this.bntVerificarVez_Click);
            // 
            // cboPosicionarPersonagens
            // 
            this.cboPosicionarPersonagens.FormattingEnabled = true;
            this.cboPosicionarPersonagens.Location = new System.Drawing.Point(29, 302);
            this.cboPosicionarPersonagens.Name = "cboPosicionarPersonagens";
            this.cboPosicionarPersonagens.Size = new System.Drawing.Size(121, 21);
            this.cboPosicionarPersonagens.TabIndex = 17;
            // 
            // pnlSetor4
            // 
            this.pnlSetor4.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.Setor4;
            this.pnlSetor4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSetor4.Controls.Add(this.btnPainel4);
            this.pnlSetor4.Location = new System.Drawing.Point(392, 285);
            this.pnlSetor4.Name = "pnlSetor4";
            this.pnlSetor4.Size = new System.Drawing.Size(514, 138);
            this.pnlSetor4.TabIndex = 22;
            // 
            // btnPainel4
            // 
            this.btnPainel4.BackColor = System.Drawing.Color.Transparent;
            this.btnPainel4.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnPainel4.FlatAppearance.BorderSize = 0;
            this.btnPainel4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPainel4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPainel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainel4.Location = new System.Drawing.Point(0, 0);
            this.btnPainel4.Name = "btnPainel4";
            this.btnPainel4.Size = new System.Drawing.Size(514, 138);
            this.btnPainel4.TabIndex = 20;
            this.btnPainel4.UseVisualStyleBackColor = false;
            this.btnPainel4.Click += new System.EventHandler(this.btnPainel_Click);
            // 
            // pnlSetor5
            // 
            this.pnlSetor5.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.Setor5;
            this.pnlSetor5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSetor5.Location = new System.Drawing.Point(392, 147);
            this.pnlSetor5.Name = "pnlSetor5";
            this.pnlSetor5.Size = new System.Drawing.Size(514, 138);
            this.pnlSetor5.TabIndex = 16;
            // 
            // pnlSetor2
            // 
            this.pnlSetor2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSetor2.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.Setor2;
            this.pnlSetor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSetor2.Controls.Add(this.btnPainel2);
            this.pnlSetor2.Location = new System.Drawing.Point(392, 561);
            this.pnlSetor2.Name = "pnlSetor2";
            this.pnlSetor2.Size = new System.Drawing.Size(514, 138);
            this.pnlSetor2.TabIndex = 15;
            // 
            // btnPainel2
            // 
            this.btnPainel2.BackColor = System.Drawing.Color.Transparent;
            this.btnPainel2.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnPainel2.FlatAppearance.BorderSize = 0;
            this.btnPainel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPainel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPainel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainel2.Location = new System.Drawing.Point(0, 0);
            this.btnPainel2.Name = "btnPainel2";
            this.btnPainel2.Size = new System.Drawing.Size(514, 138);
            this.btnPainel2.TabIndex = 23;
            this.btnPainel2.UseVisualStyleBackColor = false;
            this.btnPainel2.Click += new System.EventHandler(this.btnPainel_Click);
            // 
            // pnlSetor10
            // 
            this.pnlSetor10.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.Setor10;
            this.pnlSetor10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSetor10.Location = new System.Drawing.Point(392, 9);
            this.pnlSetor10.Name = "pnlSetor10";
            this.pnlSetor10.Size = new System.Drawing.Size(514, 138);
            this.pnlSetor10.TabIndex = 14;
            // 
            // pnlSetor3
            // 
            this.pnlSetor3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSetor3.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.Setor3;
            this.pnlSetor3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSetor3.Controls.Add(this.btnPainel3);
            this.pnlSetor3.Location = new System.Drawing.Point(392, 423);
            this.pnlSetor3.Name = "pnlSetor3";
            this.pnlSetor3.Size = new System.Drawing.Size(514, 138);
            this.pnlSetor3.TabIndex = 11;
            // 
            // btnPainel3
            // 
            this.btnPainel3.BackColor = System.Drawing.Color.Transparent;
            this.btnPainel3.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnPainel3.FlatAppearance.BorderSize = 0;
            this.btnPainel3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPainel3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPainel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainel3.Location = new System.Drawing.Point(0, 0);
            this.btnPainel3.Name = "btnPainel3";
            this.btnPainel3.Size = new System.Drawing.Size(514, 138);
            this.btnPainel3.TabIndex = 21;
            this.btnPainel3.UseVisualStyleBackColor = false;
            this.btnPainel3.Click += new System.EventHandler(this.btnPainel_Click);
            // 
            // pnlSetor1
            // 
            this.pnlSetor1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSetor1.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSetor1.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.Setor1;
            this.pnlSetor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSetor1.Controls.Add(this.btnPainel1);
            this.pnlSetor1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlSetor1.Location = new System.Drawing.Point(392, 696);
            this.pnlSetor1.Name = "pnlSetor1";
            this.pnlSetor1.Size = new System.Drawing.Size(514, 138);
            this.pnlSetor1.TabIndex = 9;
            // 
            // btnPainel1
            // 
            this.btnPainel1.BackColor = System.Drawing.Color.Transparent;
            this.btnPainel1.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnPainel1.FlatAppearance.BorderSize = 0;
            this.btnPainel1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPainel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPainel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainel1.Location = new System.Drawing.Point(0, 0);
            this.btnPainel1.Name = "btnPainel1";
            this.btnPainel1.Size = new System.Drawing.Size(514, 138);
            this.btnPainel1.TabIndex = 23;
            this.btnPainel1.UseVisualStyleBackColor = false;
            this.btnPainel1.Click += new System.EventHandler(this.btnPainel_Click);
            // 
            // pnlSetor0
            // 
            this.pnlSetor0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSetor0.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.Setor0;
            this.pnlSetor0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSetor0.Location = new System.Drawing.Point(392, 830);
            this.pnlSetor0.Name = "pnlSetor0";
            this.pnlSetor0.Size = new System.Drawing.Size(514, 138);
            this.pnlSetor0.TabIndex = 8;
            // 
            // lblVezJogador
            // 
            this.lblVezJogador.AutoSize = true;
            this.lblVezJogador.Location = new System.Drawing.Point(26, 119);
            this.lblVezJogador.Name = "lblVezJogador";
            this.lblVezJogador.Size = new System.Drawing.Size(0, 13);
            this.lblVezJogador.TabIndex = 34;
            // 
            // lblNomeVez
            // 
            this.lblNomeVez.AutoSize = true;
            this.lblNomeVez.Location = new System.Drawing.Point(26, 156);
            this.lblNomeVez.Name = "lblNomeVez";
            this.lblNomeVez.Size = new System.Drawing.Size(0, 13);
            this.lblNomeVez.TabIndex = 0;
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGrupo.Location = new System.Drawing.Point(101, 22);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(168, 21);
            this.lblNomeGrupo.TabIndex = 35;
            this.lblNomeGrupo.Text = "Prefeitos De Londres";
            // 
            // TabuleiroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 969);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lblNomeVez);
            this.Controls.Add(this.lblVezJogador);
            this.Controls.Add(this.cboPosicionarPersonagens);
            this.Controls.Add(this.btnVerificarVez);
            this.Controls.Add(this.btnExibirCartas);
            this.Controls.Add(this.lblCartas);
            this.Controls.Add(this.cboTipoVoto);
            this.Controls.Add(this.btnConfirmarVoto);
            this.Controls.Add(this.btnPromover);
            this.Controls.Add(this.btnPosicionar);
            this.Controls.Add(this.pnlSetor4);
            this.Controls.Add(this.pnlSetor5);
            this.Controls.Add(this.pnlSetor2);
            this.Controls.Add(this.pnlSetor10);
            this.Controls.Add(this.pnlSetor3);
            this.Controls.Add(this.pnlSetor1);
            this.Controls.Add(this.pnlSetor0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TabuleiroForm";
            this.Text = "Tabuleiro";
            this.pnlSetor4.ResumeLayout(false);
            this.pnlSetor2.ResumeLayout(false);
            this.pnlSetor3.ResumeLayout(false);
            this.pnlSetor1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPosicionar;
        private System.Windows.Forms.Button btnPromover;
        private System.Windows.Forms.Button btnConfirmarVoto;
        private System.Windows.Forms.ComboBox cboTipoVoto;
        private System.Windows.Forms.Label lblCartas;
        private System.Windows.Forms.Button btnExibirCartas;
        private System.Windows.Forms.Button btnVerificarVez;
        private System.Windows.Forms.Panel pnlSetor0;
        private System.Windows.Forms.Panel pnlSetor1;
        private System.Windows.Forms.Panel pnlSetor3;
        private System.Windows.Forms.Panel pnlSetor10;
        private System.Windows.Forms.Panel pnlSetor2;
        private System.Windows.Forms.Panel pnlSetor5;
        private System.Windows.Forms.ComboBox cboPosicionarPersonagens;
        private System.Windows.Forms.Button btnPainel4;
        private System.Windows.Forms.Panel pnlSetor4;
        private System.Windows.Forms.Button btnPainel2;
        private System.Windows.Forms.Button btnPainel3;
        private System.Windows.Forms.Button btnPainel1;
        private System.Windows.Forms.Panel pnlLetraR;
        private System.Windows.Forms.Panel pnlLetraT;
        private System.Windows.Forms.Label lblVezJogador;
        private System.Windows.Forms.Label lblNomeVez;
        private System.Windows.Forms.Label lblNomeGrupo;
    }
}
