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
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblPartidaID = new System.Windows.Forms.Label();
            this.txtPartidaID = new System.Windows.Forms.TextBox();
            this.bntEntrarPartida = new System.Windows.Forms.Button();
            this.bntIniciarJogo = new System.Windows.Forms.Button();
            this.lblJogadorID = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.txtIDJogador = new System.Windows.Forms.TextBox();
            this.lblIDJogador = new System.Windows.Forms.Label();
            this.txtSenhaAtualPartida = new System.Windows.Forms.TextBox();
            this.lblSenhaAtualPartida = new System.Windows.Forms.Label();
            this.btnAbrirTabuleiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarPartidas
            // 
            this.btnMostrarPartidas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPartidas.Location = new System.Drawing.Point(24, 282);
            this.btnMostrarPartidas.Name = "btnMostrarPartidas";
            this.btnMostrarPartidas.Size = new System.Drawing.Size(176, 26);
            this.btnMostrarPartidas.TabIndex = 4;
            this.btnMostrarPartidas.Text = "Listar Partidas";
            this.btnMostrarPartidas.UseVisualStyleBackColor = true;
            this.btnMostrarPartidas.Click += new System.EventHandler(this.btnMostrarPartidas_Click);
            // 
            // lstListaDePartidas
            // 
            this.lstListaDePartidas.FormattingEnabled = true;
            this.lstListaDePartidas.Location = new System.Drawing.Point(24, 314);
            this.lstListaDePartidas.Name = "lstListaDePartidas";
            this.lstListaDePartidas.Size = new System.Drawing.Size(269, 95);
            this.lstListaDePartidas.TabIndex = 5;
            this.lstListaDePartidas.SelectedIndexChanged += new System.EventHandler(this.lstListaDePartidas_SelectedIndexChanged);
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGrupo.Location = new System.Drawing.Point(342, 9);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(168, 21);
            this.lblNomeGrupo.TabIndex = 3;
            this.lblNomeGrupo.Text = "Prefeitos De Londres";
            // 
            // lstListaDeJogadores
            // 
            this.lstListaDeJogadores.FormattingEnabled = true;
            this.lstListaDeJogadores.Location = new System.Drawing.Point(23, 526);
            this.lstListaDeJogadores.Name = "lstListaDeJogadores";
            this.lstListaDeJogadores.Size = new System.Drawing.Size(269, 95);
            this.lstListaDeJogadores.TabIndex = 99;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.Location = new System.Drawing.Point(182, 65);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(111, 42);
            this.btnCriarPartida.TabIndex = 3;
            this.btnCriarPartida.Text = "Criar partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(24, 87);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(100, 20);
            this.txtNomePartida.TabIndex = 0;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.Location = new System.Drawing.Point(21, 69);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(87, 15);
            this.lblNomePartida.TabIndex = 0;
            this.lblNomePartida.Text = "Nome da Partida";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPartida.Location = new System.Drawing.Point(21, 124);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(86, 15);
            this.lblSenhaPartida.TabIndex = 1;
            this.lblSenhaPartida.Text = "Senha da partida";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(24, 142);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaPartida.TabIndex = 1;
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartida.Location = new System.Drawing.Point(200, 124);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(0, 15);
            this.lblIdPartida.TabIndex = 15;
            // 
            // lblVersaoDLL
            // 
            this.lblVersaoDLL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersaoDLL.AutoSize = true;
            this.lblVersaoDLL.Location = new System.Drawing.Point(1017, 608);
            this.lblVersaoDLL.Name = "lblVersaoDLL";
            this.lblVersaoDLL.Size = new System.Drawing.Size(0, 13);
            this.lblVersaoDLL.TabIndex = 16;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.Location = new System.Drawing.Point(21, 412);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(91, 15);
            this.lblNomeJogador.TabIndex = 6;
            this.lblNomeJogador.Text = "Nome do Jogador";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(24, 430);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(143, 20);
            this.txtNomeJogador.TabIndex = 6;
            // 
            // lblPartidaID
            // 
            this.lblPartidaID.AutoSize = true;
            this.lblPartidaID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaID.Location = new System.Drawing.Point(21, 219);
            this.lblPartidaID.Name = "lblPartidaID";
            this.lblPartidaID.Size = new System.Drawing.Size(57, 15);
            this.lblPartidaID.TabIndex = 99;
            this.lblPartidaID.Text = "ID Partida";
            // 
            // txtPartidaID
            // 
            this.txtPartidaID.Location = new System.Drawing.Point(24, 237);
            this.txtPartidaID.Name = "txtPartidaID";
            this.txtPartidaID.Size = new System.Drawing.Size(100, 20);
            this.txtPartidaID.TabIndex = 99;
            // 
            // bntEntrarPartida
            // 
            this.bntEntrarPartida.Location = new System.Drawing.Point(187, 419);
            this.bntEntrarPartida.Name = "bntEntrarPartida";
            this.bntEntrarPartida.Size = new System.Drawing.Size(105, 30);
            this.bntEntrarPartida.TabIndex = 7;
            this.bntEntrarPartida.Text = "Entrar em Partida";
            this.bntEntrarPartida.UseVisualStyleBackColor = true;
            this.bntEntrarPartida.Click += new System.EventHandler(this.bntEntrarPartida_Click);
            // 
            // bntIniciarJogo
            // 
            this.bntIniciarJogo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntIniciarJogo.Location = new System.Drawing.Point(346, 65);
            this.bntIniciarJogo.Name = "bntIniciarJogo";
            this.bntIniciarJogo.Size = new System.Drawing.Size(96, 42);
            this.bntIniciarJogo.TabIndex = 8;
            this.bntIniciarJogo.Text = "Iniciar Partida";
            this.bntIniciarJogo.UseVisualStyleBackColor = true;
            this.bntIniciarJogo.Click += new System.EventHandler(this.bntIniciarJogo_Click);
            // 
            // lblJogadorID
            // 
            this.lblJogadorID.AutoSize = true;
            this.lblJogadorID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorID.Location = new System.Drawing.Point(43, 461);
            this.lblJogadorID.Name = "lblJogadorID";
            this.lblJogadorID.Size = new System.Drawing.Size(109, 15);
            this.lblJogadorID.TabIndex = 27;
            this.lblJogadorID.Text = "ID obtido do Jogador";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogador.Location = new System.Drawing.Point(218, 461);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(35, 15);
            this.lblSenhaJogador.TabIndex = 28;
            this.lblSenhaJogador.Text = "Senha";
            // 
            // txtIDJogador
            // 
            this.txtIDJogador.Location = new System.Drawing.Point(347, 133);
            this.txtIDJogador.Name = "txtIDJogador";
            this.txtIDJogador.Size = new System.Drawing.Size(100, 20);
            this.txtIDJogador.TabIndex = 33;
            // 
            // lblIDJogador
            // 
            this.lblIDJogador.AutoSize = true;
            this.lblIDJogador.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDJogador.Location = new System.Drawing.Point(344, 115);
            this.lblIDJogador.Name = "lblIDJogador";
            this.lblIDJogador.Size = new System.Drawing.Size(60, 15);
            this.lblIDJogador.TabIndex = 32;
            this.lblIDJogador.Text = "ID Jogador";
            // 
            // txtSenhaAtualPartida
            // 
            this.txtSenhaAtualPartida.Location = new System.Drawing.Point(347, 180);
            this.txtSenhaAtualPartida.Name = "txtSenhaAtualPartida";
            this.txtSenhaAtualPartida.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaAtualPartida.TabIndex = 31;
            // 
            // lblSenhaAtualPartida
            // 
            this.lblSenhaAtualPartida.AutoSize = true;
            this.lblSenhaAtualPartida.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAtualPartida.Location = new System.Drawing.Point(344, 162);
            this.lblSenhaAtualPartida.Name = "lblSenhaAtualPartida";
            this.lblSenhaAtualPartida.Size = new System.Drawing.Size(35, 15);
            this.lblSenhaAtualPartida.TabIndex = 30;
            this.lblSenhaAtualPartida.Text = "Senha";
            // 
            // btnAbrirTabuleiro
            // 
            this.btnAbrirTabuleiro.Location = new System.Drawing.Point(496, 69);
            this.btnAbrirTabuleiro.Name = "btnAbrirTabuleiro";
            this.btnAbrirTabuleiro.Size = new System.Drawing.Size(75, 34);
            this.btnAbrirTabuleiro.TabIndex = 113;
            this.btnAbrirTabuleiro.Text = "Abrir Tabuleiro";
            this.btnAbrirTabuleiro.UseVisualStyleBackColor = true;
            this.btnAbrirTabuleiro.Click += new System.EventHandler(this.btnAbrirTabuleiro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 633);
            this.Controls.Add(this.btnAbrirTabuleiro);
            this.Controls.Add(this.txtIDJogador);
            this.Controls.Add(this.lblIDJogador);
            this.Controls.Add(this.txtSenhaAtualPartida);
            this.Controls.Add(this.lblSenhaAtualPartida);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblJogadorID);
            this.Controls.Add(this.bntIniciarJogo);
            this.Controls.Add(this.bntEntrarPartida);
            this.Controls.Add(this.txtPartidaID);
            this.Controls.Add(this.lblPartidaID);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblNomeJogador);
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
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblPartidaID;
        private System.Windows.Forms.TextBox txtPartidaID;
        private System.Windows.Forms.Button bntEntrarPartida;
        private System.Windows.Forms.Button bntIniciarJogo;
        private System.Windows.Forms.Label lblJogadorID;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.TextBox txtIDJogador;
        private System.Windows.Forms.Label lblIDJogador;
        private System.Windows.Forms.TextBox txtSenhaAtualPartida;
        private System.Windows.Forms.Label lblSenhaAtualPartida;
        private System.Windows.Forms.Button btnAbrirTabuleiro;
    }
}

