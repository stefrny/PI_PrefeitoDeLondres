namespace PI_PrefeitoDeLondres
{
    partial class Tabuleiro
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
            this.lblVersaoJogo = new System.Windows.Forms.Label();
            this.btnPosicionar = new System.Windows.Forms.Button();
            this.btnPromover = new System.Windows.Forms.Button();
            this.btnConfirmarVoto = new System.Windows.Forms.Button();
            this.cboTipoVoto = new System.Windows.Forms.ComboBox();
            this.lblCartas = new System.Windows.Forms.Label();
            this.btnExibirCartas = new System.Windows.Forms.Button();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.pnlSetor5 = new System.Windows.Forms.Panel();
            this.pnlSetor2 = new System.Windows.Forms.Panel();
            this.pnlSetor10 = new System.Windows.Forms.Panel();
            this.pnlSetor3 = new System.Windows.Forms.Panel();
            this.pnlSetor1 = new System.Windows.Forms.Panel();
            this.pnlSetor0 = new System.Windows.Forms.Panel();
            this.cboPosicionarPersonagens = new System.Windows.Forms.ComboBox();
            this.btnPainel4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVersaoJogo
            // 
            this.lblVersaoJogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersaoJogo.AutoSize = true;
            this.lblVersaoJogo.Location = new System.Drawing.Point(831, 983);
            this.lblVersaoJogo.Name = "lblVersaoJogo";
            this.lblVersaoJogo.Size = new System.Drawing.Size(0, 13);
            this.lblVersaoJogo.TabIndex = 0;
            this.lblVersaoJogo.Click += new System.EventHandler(this.lblVersaoJogo_Click);
            // 
            // btnPosicionar
            // 
            this.btnPosicionar.Location = new System.Drawing.Point(29, 139);
            this.btnPosicionar.Name = "btnPosicionar";
            this.btnPosicionar.Size = new System.Drawing.Size(75, 23);
            this.btnPosicionar.TabIndex = 1;
            this.btnPosicionar.Text = "Posicionar";
            this.btnPosicionar.UseVisualStyleBackColor = true;
            this.btnPosicionar.Click += new System.EventHandler(this.btnPosicionar_Click);
            // 
            // btnPromover
            // 
            this.btnPromover.Location = new System.Drawing.Point(29, 282);
            this.btnPromover.Name = "btnPromover";
            this.btnPromover.Size = new System.Drawing.Size(75, 23);
            this.btnPromover.TabIndex = 2;
            this.btnPromover.Text = "Promover";
            this.btnPromover.UseVisualStyleBackColor = true;
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
            this.cboTipoVoto.SelectedIndexChanged += new System.EventHandler(this.cboTipoVoto_SelectedIndexChanged);
            // 
            // lblCartas
            // 
            this.lblCartas.AutoSize = true;
            this.lblCartas.Location = new System.Drawing.Point(26, 607);
            this.lblCartas.Name = "lblCartas";
            this.lblCartas.Size = new System.Drawing.Size(30, 13);
            this.lblCartas.TabIndex = 5;
            this.lblCartas.Text = "teste";
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
            this.pnlSetor2.Location = new System.Drawing.Point(392, 561);
            this.pnlSetor2.Name = "pnlSetor2";
            this.pnlSetor2.Size = new System.Drawing.Size(514, 138);
            this.pnlSetor2.TabIndex = 15;
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
            this.pnlSetor3.Location = new System.Drawing.Point(392, 423);
            this.pnlSetor3.Name = "pnlSetor3";
            this.pnlSetor3.Size = new System.Drawing.Size(514, 138);
            this.pnlSetor3.TabIndex = 11;
            // 
            // pnlSetor1
            // 
            this.pnlSetor1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSetor1.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSetor1.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.Setor1;
            this.pnlSetor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSetor1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlSetor1.Location = new System.Drawing.Point(392, 696);
            this.pnlSetor1.Name = "pnlSetor1";
            this.pnlSetor1.Size = new System.Drawing.Size(514, 138);
            this.pnlSetor1.TabIndex = 9;
            this.pnlSetor1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSetor1_Paint);
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
            // cboPosicionarPersonagens
            // 
            this.cboPosicionarPersonagens.FormattingEnabled = true;
            this.cboPosicionarPersonagens.Items.AddRange(new object[] {
            "Adilson Konrad",
            "Beatriz Paiva",
            "Claro",
            "Douglas Baquiao",
            "Eduardo Takeo",
            "Guilherme Rey",
            "Heredia",
            "Kelly Kiyumi",
            "Leonardo Takuno",
            "Mario Toledo",
            "Quintas",
            "Ranufo",
            "Toshio"});
            this.cboPosicionarPersonagens.Location = new System.Drawing.Point(29, 194);
            this.cboPosicionarPersonagens.Name = "cboPosicionarPersonagens";
            this.cboPosicionarPersonagens.Size = new System.Drawing.Size(121, 21);
            this.cboPosicionarPersonagens.TabIndex = 17;
            // 
            // btnPainel4
            // 
            this.btnPainel4.BackColor = System.Drawing.Color.Transparent;
            this.btnPainel4.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.Setor4;
            this.btnPainel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPainel4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPainel4.FlatAppearance.BorderSize = 0;
            this.btnPainel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainel4.Location = new System.Drawing.Point(392, 285);
            this.btnPainel4.Name = "btnPainel4";
            this.btnPainel4.Size = new System.Drawing.Size(514, 138);
            this.btnPainel4.TabIndex = 18;
            this.btnPainel4.UseVisualStyleBackColor = false;
            this.btnPainel4.Click += new System.EventHandler(this.btnPainel10_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(270, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 630);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 969);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPainel4);
            this.Controls.Add(this.cboPosicionarPersonagens);
            this.Controls.Add(this.pnlSetor5);
            this.Controls.Add(this.pnlSetor2);
            this.Controls.Add(this.pnlSetor10);
            this.Controls.Add(this.pnlSetor3);
            this.Controls.Add(this.pnlSetor1);
            this.Controls.Add(this.pnlSetor0);
            this.Controls.Add(this.btnVerificarVez);
            this.Controls.Add(this.btnExibirCartas);
            this.Controls.Add(this.lblCartas);
            this.Controls.Add(this.cboTipoVoto);
            this.Controls.Add(this.btnConfirmarVoto);
            this.Controls.Add(this.btnPromover);
            this.Controls.Add(this.btnPosicionar);
            this.Controls.Add(this.lblVersaoJogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tabuleiro";
            this.Text = "Tabuleiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersaoJogo;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}