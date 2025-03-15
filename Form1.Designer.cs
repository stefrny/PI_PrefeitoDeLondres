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
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblPartidaID = new System.Windows.Forms.Label();
            this.txtPartidaID = new System.Windows.Forms.TextBox();
            this.bntEntrarPartida = new System.Windows.Forms.Button();
            this.bntIniciarJogo = new System.Windows.Forms.Button();
            this.txtGrupoNome = new System.Windows.Forms.TextBox();
            this.lblGrupoNome = new System.Windows.Forms.Label();
            this.lblJogadorID = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.txtIDJogador = new System.Windows.Forms.TextBox();
            this.lblIDJogador = new System.Windows.Forms.Label();
            this.txtSenhaAtualPartida = new System.Windows.Forms.TextBox();
            this.lblSenhaAtualPartida = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExibirCartas = new System.Windows.Forms.Button();
            this.lblCartas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarPartidas
            // 
            this.btnMostrarPartidas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPartidas.Location = new System.Drawing.Point(31, 368);
            this.btnMostrarPartidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarPartidas.Name = "btnMostrarPartidas";
            this.btnMostrarPartidas.Size = new System.Drawing.Size(235, 32);
            this.btnMostrarPartidas.TabIndex = 4;
            this.btnMostrarPartidas.Text = "Listar Partidas";
            this.btnMostrarPartidas.UseVisualStyleBackColor = true;
            this.btnMostrarPartidas.Click += new System.EventHandler(this.btnMostrarPartidas_Click);
            // 
            // lstListaDePartidas
            // 
            this.lstListaDePartidas.FormattingEnabled = true;
            this.lstListaDePartidas.ItemHeight = 16;
            this.lstListaDePartidas.Location = new System.Drawing.Point(31, 407);
            this.lstListaDePartidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstListaDePartidas.Name = "lstListaDePartidas";
            this.lstListaDePartidas.Size = new System.Drawing.Size(357, 116);
            this.lstListaDePartidas.TabIndex = 5;
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
            this.lstListaDeJogadores.Location = new System.Drawing.Point(31, 647);
            this.lstListaDeJogadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstListaDeJogadores.Name = "lstListaDeJogadores";
            this.lstListaDeJogadores.Size = new System.Drawing.Size(357, 116);
            this.lstListaDeJogadores.TabIndex = 99;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.Location = new System.Drawing.Point(241, 101);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(148, 52);
            this.btnCriarPartida.TabIndex = 3;
            this.btnCriarPartida.Text = "Criar partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(31, 128);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(132, 22);
            this.txtNomePartida.TabIndex = 0;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.Location = new System.Drawing.Point(27, 106);
            this.lblNomePartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(108, 17);
            this.lblNomePartida.TabIndex = 0;
            this.lblNomePartida.Text = "Nome da Partida";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPartida.Location = new System.Drawing.Point(27, 174);
            this.lblSenhaPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(106, 17);
            this.lblSenhaPartida.TabIndex = 1;
            this.lblSenhaPartida.Text = "Senha da partida";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(31, 196);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(132, 22);
            this.txtSenhaPartida.TabIndex = 1;
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartida.Location = new System.Drawing.Point(265, 174);
            this.lblIdPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(0, 19);
            this.lblIdPartida.TabIndex = 15;
            // 
            // lblVersaoDLL
            // 
            this.lblVersaoDLL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersaoDLL.AutoSize = true;
            this.lblVersaoDLL.Location = new System.Drawing.Point(1117, 752);
            this.lblVersaoDLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersaoDLL.Name = "lblVersaoDLL";
            this.lblVersaoDLL.Size = new System.Drawing.Size(44, 16);
            this.lblVersaoDLL.TabIndex = 16;
            this.lblVersaoDLL.Text = "label1";
            // 
            // lblNomeIDPartida
            // 
            this.lblNomeIDPartida.AutoSize = true;
            this.lblNomeIDPartida.Location = new System.Drawing.Point(45, 290);
            this.lblNomeIDPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeIDPartida.Name = "lblNomeIDPartida";
            this.lblNomeIDPartida.Size = new System.Drawing.Size(0, 16);
            this.lblNomeIDPartida.TabIndex = 17;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.Location = new System.Drawing.Point(27, 528);
            this.lblNomeJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(112, 17);
            this.lblNomeJogador.TabIndex = 6;
            this.lblNomeJogador.Text = "Nome do Jogador";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(31, 550);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(189, 22);
            this.txtNomeJogador.TabIndex = 6;
            // 
            // lblPartidaID
            // 
            this.lblPartidaID.AutoSize = true;
            this.lblPartidaID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaID.Location = new System.Drawing.Point(27, 290);
            this.lblPartidaID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartidaID.Name = "lblPartidaID";
            this.lblPartidaID.Size = new System.Drawing.Size(70, 17);
            this.lblPartidaID.TabIndex = 99;
            this.lblPartidaID.Text = "ID Partida";
            // 
            // txtPartidaID
            // 
            this.txtPartidaID.Location = new System.Drawing.Point(31, 313);
            this.txtPartidaID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPartidaID.Name = "txtPartidaID";
            this.txtPartidaID.Size = new System.Drawing.Size(132, 22);
            this.txtPartidaID.TabIndex = 99;
            // 
            // bntEntrarPartida
            // 
            this.bntEntrarPartida.Location = new System.Drawing.Point(248, 537);
            this.bntEntrarPartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntEntrarPartida.Name = "bntEntrarPartida";
            this.bntEntrarPartida.Size = new System.Drawing.Size(140, 37);
            this.bntEntrarPartida.TabIndex = 7;
            this.bntEntrarPartida.Text = "Entrar em Partida";
            this.bntEntrarPartida.UseVisualStyleBackColor = true;
            this.bntEntrarPartida.Click += new System.EventHandler(this.bntEntrarPartida_Click);
            // 
            // bntIniciarJogo
            // 
            this.bntIniciarJogo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntIniciarJogo.Location = new System.Drawing.Point(461, 101);
            this.bntIniciarJogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntIniciarJogo.Name = "bntIniciarJogo";
            this.bntIniciarJogo.Size = new System.Drawing.Size(128, 52);
            this.bntIniciarJogo.TabIndex = 8;
            this.bntIniciarJogo.Text = "Iniciar Partida";
            this.bntIniciarJogo.UseVisualStyleBackColor = true;
            this.bntIniciarJogo.Click += new System.EventHandler(this.bntIniciarJogo_Click);
            // 
            // txtGrupoNome
            // 
            this.txtGrupoNome.Location = new System.Drawing.Point(31, 255);
            this.txtGrupoNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGrupoNome.Name = "txtGrupoNome";
            this.txtGrupoNome.Size = new System.Drawing.Size(132, 22);
            this.txtGrupoNome.TabIndex = 2;
            // 
            // lblGrupoNome
            // 
            this.lblGrupoNome.AutoSize = true;
            this.lblGrupoNome.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupoNome.Location = new System.Drawing.Point(27, 233);
            this.lblGrupoNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrupoNome.Name = "lblGrupoNome";
            this.lblGrupoNome.Size = new System.Drawing.Size(102, 17);
            this.lblGrupoNome.TabIndex = 2;
            this.lblGrupoNome.Text = "Nome do Grupo";
            // 
            // lblJogadorID
            // 
            this.lblJogadorID.AutoSize = true;
            this.lblJogadorID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorID.Location = new System.Drawing.Point(56, 588);
            this.lblJogadorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJogadorID.Name = "lblJogadorID";
            this.lblJogadorID.Size = new System.Drawing.Size(131, 17);
            this.lblJogadorID.TabIndex = 27;
            this.lblJogadorID.Text = "ID obtido do Jogador";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogador.Location = new System.Drawing.Point(289, 588);
            this.lblSenhaJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(44, 17);
            this.lblSenhaJogador.TabIndex = 28;
            this.lblSenhaJogador.Text = "Senha";
            // 
            // txtIDJogador
            // 
            this.txtIDJogador.Location = new System.Drawing.Point(461, 185);
            this.txtIDJogador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDJogador.Name = "txtIDJogador";
            this.txtIDJogador.Size = new System.Drawing.Size(132, 22);
            this.txtIDJogador.TabIndex = 33;
            // 
            // lblIDJogador
            // 
            this.lblIDJogador.AutoSize = true;
            this.lblIDJogador.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDJogador.Location = new System.Drawing.Point(457, 162);
            this.lblIDJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDJogador.Name = "lblIDJogador";
            this.lblIDJogador.Size = new System.Drawing.Size(74, 17);
            this.lblIDJogador.TabIndex = 32;
            this.lblIDJogador.Text = "ID Jogador";
            // 
            // txtSenhaAtualPartida
            // 
            this.txtSenhaAtualPartida.Location = new System.Drawing.Point(461, 242);
            this.txtSenhaAtualPartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenhaAtualPartida.Name = "txtSenhaAtualPartida";
            this.txtSenhaAtualPartida.Size = new System.Drawing.Size(132, 22);
            this.txtSenhaAtualPartida.TabIndex = 31;
            // 
            // lblSenhaAtualPartida
            // 
            this.lblSenhaAtualPartida.AutoSize = true;
            this.lblSenhaAtualPartida.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAtualPartida.Location = new System.Drawing.Point(457, 220);
            this.lblSenhaAtualPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaAtualPartida.Name = "lblSenhaAtualPartida";
            this.lblSenhaAtualPartida.Size = new System.Drawing.Size(44, 17);
            this.lblSenhaAtualPartida.TabIndex = 30;
            this.lblSenhaAtualPartida.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 29;
            // 
            // btnExibirCartas
            // 
            this.btnExibirCartas.Location = new System.Drawing.Point(419, 708);
            this.btnExibirCartas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExibirCartas.Name = "btnExibirCartas";
            this.btnExibirCartas.Size = new System.Drawing.Size(117, 44);
            this.btnExibirCartas.TabIndex = 9;
            this.btnExibirCartas.Text = "Exibir Carta";
            this.btnExibirCartas.UseVisualStyleBackColor = true;
            this.btnExibirCartas.Click += new System.EventHandler(this.btnExibirCartas_Click);
            // 
            // lblCartas
            // 
            this.lblCartas.AutoSize = true;
            this.lblCartas.Location = new System.Drawing.Point(548, 722);
            this.lblCartas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCartas.Name = "lblCartas";
            this.lblCartas.Size = new System.Drawing.Size(39, 16);
            this.lblCartas.TabIndex = 35;
            this.lblCartas.Text = "Carta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 779);
            this.Controls.Add(this.lblCartas);
            this.Controls.Add(this.btnExibirCartas);
            this.Controls.Add(this.txtIDJogador);
            this.Controls.Add(this.lblIDJogador);
            this.Controls.Add(this.txtSenhaAtualPartida);
            this.Controls.Add(this.lblSenhaAtualPartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblJogadorID);
            this.Controls.Add(this.txtGrupoNome);
            this.Controls.Add(this.lblGrupoNome);
            this.Controls.Add(this.bntIniciarJogo);
            this.Controls.Add(this.bntEntrarPartida);
            this.Controls.Add(this.txtPartidaID);
            this.Controls.Add(this.lblPartidaID);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblNomeJogador);
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
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblPartidaID;
        private System.Windows.Forms.TextBox txtPartidaID;
        private System.Windows.Forms.Button bntEntrarPartida;
        private System.Windows.Forms.Button bntIniciarJogo;
        private System.Windows.Forms.TextBox txtGrupoNome;
        private System.Windows.Forms.Label lblGrupoNome;
        private System.Windows.Forms.Label lblJogadorID;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.TextBox txtIDJogador;
        private System.Windows.Forms.Label lblIDJogador;
        private System.Windows.Forms.TextBox txtSenhaAtualPartida;
        private System.Windows.Forms.Label lblSenhaAtualPartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExibirCartas;
        private System.Windows.Forms.Label lblCartas;
    }
}

