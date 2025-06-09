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
            this.lstListaDeJogadores = new System.Windows.Forms.ListBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.lblVersaoDLL = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.txtPartidaID = new System.Windows.Forms.TextBox();
            this.bntEntrarPartida = new System.Windows.Forms.Button();
            this.bntIniciarJogo = new System.Windows.Forms.Button();
            this.txtIDJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaAtualPartida = new System.Windows.Forms.TextBox();
            this.btnAbrirTabuleiro = new System.Windows.Forms.Button();
            this.btnPrefeitosDeLondres = new System.Windows.Forms.Button();
            this.btnNomeDaPartida = new System.Windows.Forms.Button();
            this.btnSenhaDaPartida = new System.Windows.Forms.Button();
            this.btnIdDoJogador = new System.Windows.Forms.Button();
            this.btnSenha = new System.Windows.Forms.Button();
            this.btnIdDaPartida = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblJogadorID = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarPartidas
            // 
            this.btnMostrarPartidas.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarPartidas.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.ListarPartida;
            this.btnMostrarPartidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarPartidas.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnMostrarPartidas.FlatAppearance.BorderSize = 3;
            this.btnMostrarPartidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnMostrarPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarPartidas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPartidas.Location = new System.Drawing.Point(32, 347);
            this.btnMostrarPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarPartidas.Name = "btnMostrarPartidas";
            this.btnMostrarPartidas.Size = new System.Drawing.Size(235, 32);
            this.btnMostrarPartidas.TabIndex = 4;
            this.btnMostrarPartidas.UseVisualStyleBackColor = false;
            this.btnMostrarPartidas.Click += new System.EventHandler(this.btnMostrarPartidas_Click);
            // 
            // lstListaDePartidas
            // 
            this.lstListaDePartidas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstListaDePartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaDePartidas.FormattingEnabled = true;
            this.lstListaDePartidas.ItemHeight = 16;
            this.lstListaDePartidas.Location = new System.Drawing.Point(32, 386);
            this.lstListaDePartidas.Margin = new System.Windows.Forms.Padding(4);
            this.lstListaDePartidas.Name = "lstListaDePartidas";
            this.lstListaDePartidas.Size = new System.Drawing.Size(357, 116);
            this.lstListaDePartidas.TabIndex = 5;
            this.lstListaDePartidas.SelectedIndexChanged += new System.EventHandler(this.lstListaDePartidas_SelectedIndexChanged);
            // 
            // lstListaDeJogadores
            // 
            this.lstListaDeJogadores.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstListaDeJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaDeJogadores.ForeColor = System.Drawing.Color.Black;
            this.lstListaDeJogadores.FormattingEnabled = true;
            this.lstListaDeJogadores.ItemHeight = 16;
            this.lstListaDeJogadores.Location = new System.Drawing.Point(31, 647);
            this.lstListaDeJogadores.Margin = new System.Windows.Forms.Padding(4);
            this.lstListaDeJogadores.Name = "lstListaDeJogadores";
            this.lstListaDeJogadores.Size = new System.Drawing.Size(357, 116);
            this.lstListaDeJogadores.TabIndex = 99;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarPartida.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.CriarPartida;
            this.btnCriarPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriarPartida.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnCriarPartida.FlatAppearance.BorderSize = 3;
            this.btnCriarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnCriarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPartida.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.Location = new System.Drawing.Point(84, 191);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(212, 49);
            this.btnCriarPartida.TabIndex = 3;
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePartida.ForeColor = System.Drawing.Color.Black;
            this.txtNomePartida.Location = new System.Drawing.Point(31, 146);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(132, 22);
            this.txtNomePartida.TabIndex = 0;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtSenhaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaPartida.Location = new System.Drawing.Point(221, 146);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(132, 22);
            this.txtSenhaPartida.TabIndex = 1;
            // 
            // lblVersaoDLL
            // 
            this.lblVersaoDLL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersaoDLL.AutoSize = true;
            this.lblVersaoDLL.Location = new System.Drawing.Point(657, 748);
            this.lblVersaoDLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersaoDLL.Name = "lblVersaoDLL";
            this.lblVersaoDLL.Size = new System.Drawing.Size(0, 16);
            this.lblVersaoDLL.TabIndex = 16;
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogador.Location = new System.Drawing.Point(32, 529);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(189, 22);
            this.txtNomeJogador.TabIndex = 6;
            // 
            // txtPartidaID
            // 
            this.txtPartidaID.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtPartidaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartidaID.Location = new System.Drawing.Point(123, 279);
            this.txtPartidaID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartidaID.Name = "txtPartidaID";
            this.txtPartidaID.Size = new System.Drawing.Size(132, 22);
            this.txtPartidaID.TabIndex = 99;
            // 
            // bntEntrarPartida
            // 
            this.bntEntrarPartida.BackColor = System.Drawing.Color.Transparent;
            this.bntEntrarPartida.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.EntrarPartida;
            this.bntEntrarPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntEntrarPartida.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bntEntrarPartida.FlatAppearance.BorderSize = 3;
            this.bntEntrarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.bntEntrarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntEntrarPartida.Location = new System.Drawing.Point(229, 514);
            this.bntEntrarPartida.Margin = new System.Windows.Forms.Padding(4);
            this.bntEntrarPartida.Name = "bntEntrarPartida";
            this.bntEntrarPartida.Size = new System.Drawing.Size(164, 37);
            this.bntEntrarPartida.TabIndex = 7;
            this.bntEntrarPartida.UseVisualStyleBackColor = false;
            this.bntEntrarPartida.Click += new System.EventHandler(this.bntEntrarPartida_Click);
            // 
            // bntIniciarJogo
            // 
            this.bntIniciarJogo.BackColor = System.Drawing.Color.Transparent;
            this.bntIniciarJogo.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.IniciarPartida;
            this.bntIniciarJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntIniciarJogo.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bntIniciarJogo.FlatAppearance.BorderSize = 3;
            this.bntIniciarJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.bntIniciarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntIniciarJogo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntIniciarJogo.Location = new System.Drawing.Point(494, 136);
            this.bntIniciarJogo.Margin = new System.Windows.Forms.Padding(4);
            this.bntIniciarJogo.Name = "bntIniciarJogo";
            this.bntIniciarJogo.Size = new System.Drawing.Size(212, 49);
            this.bntIniciarJogo.TabIndex = 8;
            this.bntIniciarJogo.UseVisualStyleBackColor = false;
            this.bntIniciarJogo.Click += new System.EventHandler(this.bntIniciarJogo_Click);
            // 
            // txtIDJogador
            // 
            this.txtIDJogador.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtIDJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDJogador.Location = new System.Drawing.Point(539, 225);
            this.txtIDJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDJogador.Name = "txtIDJogador";
            this.txtIDJogador.Size = new System.Drawing.Size(132, 22);
            this.txtIDJogador.TabIndex = 33;
            // 
            // txtSenhaAtualPartida
            // 
            this.txtSenhaAtualPartida.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtSenhaAtualPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAtualPartida.Location = new System.Drawing.Point(539, 283);
            this.txtSenhaAtualPartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaAtualPartida.Name = "txtSenhaAtualPartida";
            this.txtSenhaAtualPartida.Size = new System.Drawing.Size(132, 22);
            this.txtSenhaAtualPartida.TabIndex = 31;
            // 
            // btnAbrirTabuleiro
            // 
            this.btnAbrirTabuleiro.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirTabuleiro.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.AbrirTabuleiro;
            this.btnAbrirTabuleiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbrirTabuleiro.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnAbrirTabuleiro.FlatAppearance.BorderSize = 3;
            this.btnAbrirTabuleiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnAbrirTabuleiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirTabuleiro.Location = new System.Drawing.Point(421, 323);
            this.btnAbrirTabuleiro.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirTabuleiro.Name = "btnAbrirTabuleiro";
            this.btnAbrirTabuleiro.Size = new System.Drawing.Size(338, 443);
            this.btnAbrirTabuleiro.TabIndex = 113;
            this.btnAbrirTabuleiro.UseVisualStyleBackColor = false;
            this.btnAbrirTabuleiro.Click += new System.EventHandler(this.btnAbrirTabuleiro_Click);
            // 
            // btnPrefeitosDeLondres
            // 
            this.btnPrefeitosDeLondres.BackColor = System.Drawing.Color.Transparent;
            this.btnPrefeitosDeLondres.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.PrefeitosDeLondres;
            this.btnPrefeitosDeLondres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrefeitosDeLondres.FlatAppearance.BorderSize = 0;
            this.btnPrefeitosDeLondres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrefeitosDeLondres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrefeitosDeLondres.Location = new System.Drawing.Point(160, 12);
            this.btnPrefeitosDeLondres.Name = "btnPrefeitosDeLondres";
            this.btnPrefeitosDeLondres.Size = new System.Drawing.Size(458, 101);
            this.btnPrefeitosDeLondres.TabIndex = 114;
            this.btnPrefeitosDeLondres.UseVisualStyleBackColor = false;
            // 
            // btnNomeDaPartida
            // 
            this.btnNomeDaPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnNomeDaPartida.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.NomeDaPartida1;
            this.btnNomeDaPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNomeDaPartida.CausesValidation = false;
            this.btnNomeDaPartida.FlatAppearance.BorderSize = 0;
            this.btnNomeDaPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNomeDaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNomeDaPartida.Location = new System.Drawing.Point(16, 124);
            this.btnNomeDaPartida.Name = "btnNomeDaPartida";
            this.btnNomeDaPartida.Size = new System.Drawing.Size(158, 17);
            this.btnNomeDaPartida.TabIndex = 115;
            this.btnNomeDaPartida.UseVisualStyleBackColor = false;
            // 
            // btnSenhaDaPartida
            // 
            this.btnSenhaDaPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnSenhaDaPartida.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.SenhaDaPartida;
            this.btnSenhaDaPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSenhaDaPartida.CausesValidation = false;
            this.btnSenhaDaPartida.FlatAppearance.BorderSize = 0;
            this.btnSenhaDaPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSenhaDaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSenhaDaPartida.Location = new System.Drawing.Point(209, 124);
            this.btnSenhaDaPartida.Name = "btnSenhaDaPartida";
            this.btnSenhaDaPartida.Size = new System.Drawing.Size(158, 17);
            this.btnSenhaDaPartida.TabIndex = 116;
            this.btnSenhaDaPartida.UseVisualStyleBackColor = false;
            // 
            // btnIdDoJogador
            // 
            this.btnIdDoJogador.BackColor = System.Drawing.Color.Transparent;
            this.btnIdDoJogador.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.IdDoJogador;
            this.btnIdDoJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIdDoJogador.CausesValidation = false;
            this.btnIdDoJogador.FlatAppearance.BorderSize = 0;
            this.btnIdDoJogador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIdDoJogador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdDoJogador.Location = new System.Drawing.Point(540, 203);
            this.btnIdDoJogador.Name = "btnIdDoJogador";
            this.btnIdDoJogador.Size = new System.Drawing.Size(133, 18);
            this.btnIdDoJogador.TabIndex = 117;
            this.btnIdDoJogador.UseVisualStyleBackColor = false;
            // 
            // btnSenha
            // 
            this.btnSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnSenha.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.Senha;
            this.btnSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSenha.CausesValidation = false;
            this.btnSenha.FlatAppearance.BorderSize = 0;
            this.btnSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSenha.Location = new System.Drawing.Point(523, 258);
            this.btnSenha.Name = "btnSenha";
            this.btnSenha.Size = new System.Drawing.Size(168, 21);
            this.btnSenha.TabIndex = 118;
            this.btnSenha.UseVisualStyleBackColor = false;
            // 
            // btnIdDaPartida
            // 
            this.btnIdDaPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnIdDaPartida.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.IdDaPartida;
            this.btnIdDaPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIdDaPartida.CausesValidation = false;
            this.btnIdDaPartida.FlatAppearance.BorderSize = 0;
            this.btnIdDaPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIdDaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdDaPartida.Location = new System.Drawing.Point(124, 254);
            this.btnIdDaPartida.Name = "btnIdDaPartida";
            this.btnIdDaPartida.Size = new System.Drawing.Size(133, 18);
            this.btnIdDaPartida.TabIndex = 119;
            this.btnIdDaPartida.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.NomeDoJogador;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.CausesValidation = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(32, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 17);
            this.button1.TabIndex = 120;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.IdObtidoDoJogador;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.CausesValidation = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(32, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 17);
            this.button2.TabIndex = 121;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.Senha;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.CausesValidation = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(221, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 21);
            this.button3.TabIndex = 122;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lblJogadorID
            // 
            this.lblJogadorID.AutoSize = true;
            this.lblJogadorID.BackColor = System.Drawing.Color.Transparent;
            this.lblJogadorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorID.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblJogadorID.Location = new System.Drawing.Point(29, 592);
            this.lblJogadorID.Name = "lblJogadorID";
            this.lblJogadorID.Size = new System.Drawing.Size(0, 16);
            this.lblJogadorID.TabIndex = 123;
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogador.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblSenhaJogador.Location = new System.Drawing.Point(279, 592);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(0, 16);
            this.lblSenhaJogador.TabIndex = 124;
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartida.Location = new System.Drawing.Point(129, 279);
            this.lblIdPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(0, 19);
            this.lblIdPartida.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI_PrefeitoDeLondres.Properties.Resources.FundoAzul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 779);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblJogadorID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIdDaPartida);
            this.Controls.Add(this.btnSenha);
            this.Controls.Add(this.btnIdDoJogador);
            this.Controls.Add(this.btnSenhaDaPartida);
            this.Controls.Add(this.btnNomeDaPartida);
            this.Controls.Add(this.btnPrefeitosDeLondres);
            this.Controls.Add(this.btnAbrirTabuleiro);
            this.Controls.Add(this.txtIDJogador);
            this.Controls.Add(this.txtSenhaAtualPartida);
            this.Controls.Add(this.bntIniciarJogo);
            this.Controls.Add(this.bntEntrarPartida);
            this.Controls.Add(this.txtPartidaID);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblVersaoDLL);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.lstListaDeJogadores);
            this.Controls.Add(this.lstListaDePartidas);
            this.Controls.Add(this.btnMostrarPartidas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Prefeitos de Londes - King Me!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarPartidas;
        private System.Windows.Forms.ListBox lstListaDePartidas;
        private System.Windows.Forms.ListBox lstListaDeJogadores;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label lblVersaoDLL;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.TextBox txtPartidaID;
        private System.Windows.Forms.Button bntEntrarPartida;
        private System.Windows.Forms.Button bntIniciarJogo;
        private System.Windows.Forms.TextBox txtIDJogador;
        private System.Windows.Forms.TextBox txtSenhaAtualPartida;
        private System.Windows.Forms.Button btnAbrirTabuleiro;
        private System.Windows.Forms.Button btnPrefeitosDeLondres;
        private System.Windows.Forms.Button btnNomeDaPartida;
        private System.Windows.Forms.Button btnSenhaDaPartida;
        private System.Windows.Forms.Button btnIdDoJogador;
        private System.Windows.Forms.Button btnSenha;
        private System.Windows.Forms.Button btnIdDaPartida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblJogadorID;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Label lblIdPartida;
    }
}

