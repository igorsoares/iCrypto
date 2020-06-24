namespace Projeto1_semestre
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuSuperior = new System.Windows.Forms.MenuStrip();
            this.tsmiCriptografia = new System.Windows.Forms.ToolStripMenuItem();
            this.aESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esteganografiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cifraDeCesarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoMorseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.hisóricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTema = new System.Windows.Forms.ToolStripMenuItem();
            this.temaEscuroOn = new System.Windows.Forms.ToolStripMenuItem();
            this.temaEscuroOff = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogo1 = new System.Windows.Forms.PictureBox();
            this.tpMinhaConta = new System.Windows.Forms.TabPage();
            this.cboxAlterarSenha = new System.Windows.Forms.CheckBox();
            this.tbxNovaSenhaConfirm = new System.Windows.Forms.TextBox();
            this.lbConfirmarSenha = new System.Windows.Forms.Label();
            this.cboxAlterarInfos = new System.Windows.Forms.CheckBox();
            this.tbxNovaSenha = new System.Windows.Forms.TextBox();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcInfosConta = new System.Windows.Forms.TabControl();
            this.tpServerSMTP = new System.Windows.Forms.TabPage();
            this.cboxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluirSMTP = new System.Windows.Forms.Button();
            this.btnAlterarSMTP = new System.Windows.Forms.Button();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenhaSMTP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailSMTP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpLimparHistorico = new System.Windows.Forms.TabPage();
            this.btnLimparTodosHistoricos = new System.Windows.Forms.Button();
            this.btnLimparEspecifico = new System.Windows.Forms.Button();
            this.picLogo2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEsteganografia = new System.Windows.Forms.RadioButton();
            this.rbMorse = new System.Windows.Forms.RadioButton();
            this.rbCifra = new System.Windows.Forms.RadioButton();
            this.rbRSA = new System.Windows.Forms.RadioButton();
            this.rbFileAES = new System.Windows.Forms.RadioButton();
            this.rbAES = new System.Windows.Forms.RadioButton();
            this.cboxSSL = new System.Windows.Forms.CheckBox();
            this.menuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
            this.tpMinhaConta.SuspendLayout();
            this.tbcInfosConta.SuspendLayout();
            this.tpServerSMTP.SuspendLayout();
            this.tpLimparHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSuperior
            // 
            this.menuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCriptografia,
            this.tsmiOpcoes,
            this.tsmiSair,
            this.tsmiTema});
            this.menuSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.Size = new System.Drawing.Size(594, 24);
            this.menuSuperior.TabIndex = 1;
            this.menuSuperior.Text = "menuStrip1";
            // 
            // tsmiCriptografia
            // 
            this.tsmiCriptografia.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiCriptografia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aESToolStripMenuItem,
            this.rSAToolStripMenuItem,
            this.esteganografiaToolStripMenuItem,
            this.cifraDeCesarToolStripMenuItem,
            this.códigoMorseToolStripMenuItem});
            this.tsmiCriptografia.Name = "tsmiCriptografia";
            this.tsmiCriptografia.Size = new System.Drawing.Size(82, 20);
            this.tsmiCriptografia.Text = "&Criptografia";
            // 
            // aESToolStripMenuItem
            // 
            this.aESToolStripMenuItem.Name = "aESToolStripMenuItem";
            this.aESToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aESToolStripMenuItem.Text = "&AES";
            this.aESToolStripMenuItem.Click += new System.EventHandler(this.aESToolStripMenuItem_Click);
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rSAToolStripMenuItem.Text = "&RSA";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.rSAToolStripMenuItem_Click);
            // 
            // esteganografiaToolStripMenuItem
            // 
            this.esteganografiaToolStripMenuItem.Name = "esteganografiaToolStripMenuItem";
            this.esteganografiaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.esteganografiaToolStripMenuItem.Text = "&Esteganografia";
            this.esteganografiaToolStripMenuItem.Click += new System.EventHandler(this.esteganografiaToolStripMenuItem_Click);
            // 
            // cifraDeCesarToolStripMenuItem
            // 
            this.cifraDeCesarToolStripMenuItem.Name = "cifraDeCesarToolStripMenuItem";
            this.cifraDeCesarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cifraDeCesarToolStripMenuItem.Text = "Cifra de &Cesar";
            this.cifraDeCesarToolStripMenuItem.Click += new System.EventHandler(this.cifraDeCesarToolStripMenuItem_Click);
            // 
            // códigoMorseToolStripMenuItem
            // 
            this.códigoMorseToolStripMenuItem.Name = "códigoMorseToolStripMenuItem";
            this.códigoMorseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.códigoMorseToolStripMenuItem.Text = "Código &Morse";
            this.códigoMorseToolStripMenuItem.Click += new System.EventHandler(this.códigoMorseToolStripMenuItem_Click);
            // 
            // tsmiOpcoes
            // 
            this.tsmiOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hisóricoToolStripMenuItem});
            this.tsmiOpcoes.Name = "tsmiOpcoes";
            this.tsmiOpcoes.Size = new System.Drawing.Size(59, 20);
            this.tsmiOpcoes.Text = "&Opções";
            // 
            // hisóricoToolStripMenuItem
            // 
            this.hisóricoToolStripMenuItem.Name = "hisóricoToolStripMenuItem";
            this.hisóricoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.hisóricoToolStripMenuItem.Text = "&Histórico ";
            this.hisóricoToolStripMenuItem.Click += new System.EventHandler(this.hisóricoToolStripMenuItem_Click);
            // 
            // tsmiSair
            // 
            this.tsmiSair.Name = "tsmiSair";
            this.tsmiSair.Size = new System.Drawing.Size(38, 20);
            this.tsmiSair.Text = "&Sair";
            this.tsmiSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // tsmiTema
            // 
            this.tsmiTema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temaEscuroOn,
            this.temaEscuroOff});
            this.tsmiTema.Name = "tsmiTema";
            this.tsmiTema.Size = new System.Drawing.Size(47, 20);
            this.tsmiTema.Text = "Tema";
            // 
            // temaEscuroOn
            // 
            this.temaEscuroOn.Name = "temaEscuroOn";
            this.temaEscuroOn.Size = new System.Drawing.Size(109, 22);
            this.temaEscuroOn.Text = "Escuro";
            this.temaEscuroOn.Click += new System.EventHandler(this.temaEscuroOn_Click);
            // 
            // temaEscuroOff
            // 
            this.temaEscuroOff.Name = "temaEscuroOff";
            this.temaEscuroOff.Size = new System.Drawing.Size(109, 22);
            this.temaEscuroOff.Text = "Claro";
            this.temaEscuroOff.Click += new System.EventHandler(this.temaEscuroOff_Click);
            // 
            // picLogo1
            // 
            this.picLogo1.Image = global::Teste_Login.Properties.Resources.logo1;
            this.picLogo1.Location = new System.Drawing.Point(4, 27);
            this.picLogo1.Name = "picLogo1";
            this.picLogo1.Size = new System.Drawing.Size(169, 164);
            this.picLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo1.TabIndex = 2;
            this.picLogo1.TabStop = false;
            // 
            // tpMinhaConta
            // 
            this.tpMinhaConta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpMinhaConta.Controls.Add(this.cboxAlterarSenha);
            this.tpMinhaConta.Controls.Add(this.tbxNovaSenhaConfirm);
            this.tpMinhaConta.Controls.Add(this.lbConfirmarSenha);
            this.tpMinhaConta.Controls.Add(this.cboxAlterarInfos);
            this.tpMinhaConta.Controls.Add(this.tbxNovaSenha);
            this.tpMinhaConta.Controls.Add(this.tbxUser);
            this.tpMinhaConta.Controls.Add(this.tbxEmail);
            this.tpMinhaConta.Controls.Add(this.tbxNome);
            this.tpMinhaConta.Controls.Add(this.lbSenha);
            this.tpMinhaConta.Controls.Add(this.btnExcluir);
            this.tpMinhaConta.Controls.Add(this.btnAlterar);
            this.tpMinhaConta.Controls.Add(this.label4);
            this.tpMinhaConta.Controls.Add(this.label3);
            this.tpMinhaConta.Controls.Add(this.label2);
            this.tpMinhaConta.Location = new System.Drawing.Point(4, 22);
            this.tpMinhaConta.Name = "tpMinhaConta";
            this.tpMinhaConta.Padding = new System.Windows.Forms.Padding(3);
            this.tpMinhaConta.Size = new System.Drawing.Size(399, 224);
            this.tpMinhaConta.TabIndex = 3;
            this.tpMinhaConta.Text = "Minha Conta";
            // 
            // cboxAlterarSenha
            // 
            this.cboxAlterarSenha.AutoSize = true;
            this.cboxAlterarSenha.Location = new System.Drawing.Point(208, 120);
            this.cboxAlterarSenha.Name = "cboxAlterarSenha";
            this.cboxAlterarSenha.Size = new System.Drawing.Size(105, 17);
            this.cboxAlterarSenha.TabIndex = 16;
            this.cboxAlterarSenha.Text = "Alterar Senha";
            this.cboxAlterarSenha.UseVisualStyleBackColor = true;
            this.cboxAlterarSenha.CheckedChanged += new System.EventHandler(this.cboxAlterarSenha_CheckedChanged);
            // 
            // tbxNovaSenhaConfirm
            // 
            this.tbxNovaSenhaConfirm.Location = new System.Drawing.Point(208, 154);
            this.tbxNovaSenhaConfirm.Name = "tbxNovaSenhaConfirm";
            this.tbxNovaSenhaConfirm.PasswordChar = '*';
            this.tbxNovaSenhaConfirm.Size = new System.Drawing.Size(170, 21);
            this.tbxNovaSenhaConfirm.TabIndex = 15;
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.AutoSize = true;
            this.lbConfirmarSenha.Location = new System.Drawing.Point(205, 138);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(140, 13);
            this.lbConfirmarSenha.TabIndex = 14;
            this.lbConfirmarSenha.Text = "Confirmar nova senha:";
            // 
            // cboxAlterarInfos
            // 
            this.cboxAlterarInfos.AutoSize = true;
            this.cboxAlterarInfos.Location = new System.Drawing.Point(208, 101);
            this.cboxAlterarInfos.Name = "cboxAlterarInfos";
            this.cboxAlterarInfos.Size = new System.Drawing.Size(139, 17);
            this.cboxAlterarInfos.TabIndex = 13;
            this.cboxAlterarInfos.Text = "Alterar informações";
            this.cboxAlterarInfos.UseVisualStyleBackColor = true;
            this.cboxAlterarInfos.CheckedChanged += new System.EventHandler(this.cboxAlterarInfos_CheckedChanged);
            // 
            // tbxNovaSenha
            // 
            this.tbxNovaSenha.Location = new System.Drawing.Point(21, 154);
            this.tbxNovaSenha.Name = "tbxNovaSenha";
            this.tbxNovaSenha.PasswordChar = '*';
            this.tbxNovaSenha.Size = new System.Drawing.Size(170, 21);
            this.tbxNovaSenha.TabIndex = 9;
            // 
            // tbxUser
            // 
            this.tbxUser.Location = new System.Drawing.Point(21, 114);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.ReadOnly = true;
            this.tbxUser.Size = new System.Drawing.Size(170, 21);
            this.tbxUser.TabIndex = 5;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(21, 74);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ReadOnly = true;
            this.tbxEmail.Size = new System.Drawing.Size(357, 21);
            this.tbxEmail.TabIndex = 3;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(21, 34);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.ReadOnly = true;
            this.tbxNome.Size = new System.Drawing.Size(357, 21);
            this.tbxNome.TabIndex = 1;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(18, 138);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(79, 13);
            this.lbSenha.TabIndex = 8;
            this.lbSenha.Text = "Nova senha:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Location = new System.Drawing.Point(21, 181);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 27);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir conta";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Location = new System.Drawing.Point(147, 181);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(123, 27);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar cadastro";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // tbcInfosConta
            // 
            this.tbcInfosConta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcInfosConta.Controls.Add(this.tpMinhaConta);
            this.tbcInfosConta.Controls.Add(this.tpServerSMTP);
            this.tbcInfosConta.Controls.Add(this.tpLimparHistorico);
            this.tbcInfosConta.Location = new System.Drawing.Point(175, 27);
            this.tbcInfosConta.Name = "tbcInfosConta";
            this.tbcInfosConta.SelectedIndex = 0;
            this.tbcInfosConta.Size = new System.Drawing.Size(407, 250);
            this.tbcInfosConta.TabIndex = 3;
            // 
            // tpServerSMTP
            // 
            this.tpServerSMTP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpServerSMTP.Controls.Add(this.cboxSSL);
            this.tpServerSMTP.Controls.Add(this.cboxMostrarSenha);
            this.tpServerSMTP.Controls.Add(this.btnCadastrar);
            this.tpServerSMTP.Controls.Add(this.btnExcluirSMTP);
            this.tpServerSMTP.Controls.Add(this.btnAlterarSMTP);
            this.tpServerSMTP.Controls.Add(this.txtPorta);
            this.tpServerSMTP.Controls.Add(this.label9);
            this.tpServerSMTP.Controls.Add(this.txtServidor);
            this.tpServerSMTP.Controls.Add(this.label8);
            this.tpServerSMTP.Controls.Add(this.txtSenhaSMTP);
            this.tpServerSMTP.Controls.Add(this.label7);
            this.tpServerSMTP.Controls.Add(this.txtEmailSMTP);
            this.tpServerSMTP.Controls.Add(this.label6);
            this.tpServerSMTP.Location = new System.Drawing.Point(4, 22);
            this.tpServerSMTP.Name = "tpServerSMTP";
            this.tpServerSMTP.Padding = new System.Windows.Forms.Padding(3);
            this.tpServerSMTP.Size = new System.Drawing.Size(399, 224);
            this.tpServerSMTP.TabIndex = 4;
            this.tpServerSMTP.Text = "Servidor SMTP";
            // 
            // cboxMostrarSenha
            // 
            this.cboxMostrarSenha.AutoSize = true;
            this.cboxMostrarSenha.Location = new System.Drawing.Point(305, 79);
            this.cboxMostrarSenha.Name = "cboxMostrarSenha";
            this.cboxMostrarSenha.Size = new System.Drawing.Size(69, 17);
            this.cboxMostrarSenha.TabIndex = 43;
            this.cboxMostrarSenha.Text = "Mostrar";
            this.cboxMostrarSenha.UseVisualStyleBackColor = true;
            this.cboxMostrarSenha.CheckedChanged += new System.EventHandler(this.cboxMostrarSenha_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Location = new System.Drawing.Point(233, 183);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(155, 27);
            this.btnCadastrar.TabIndex = 42;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluirSMTP
            // 
            this.btnExcluirSMTP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirSMTP.Location = new System.Drawing.Point(233, 150);
            this.btnExcluirSMTP.Name = "btnExcluirSMTP";
            this.btnExcluirSMTP.Size = new System.Drawing.Size(75, 27);
            this.btnExcluirSMTP.TabIndex = 40;
            this.btnExcluirSMTP.Text = "Excluir";
            this.btnExcluirSMTP.UseVisualStyleBackColor = true;
            this.btnExcluirSMTP.Click += new System.EventHandler(this.btnExcluirSMTP_Click);
            // 
            // btnAlterarSMTP
            // 
            this.btnAlterarSMTP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarSMTP.Location = new System.Drawing.Point(313, 150);
            this.btnAlterarSMTP.Name = "btnAlterarSMTP";
            this.btnAlterarSMTP.Size = new System.Drawing.Size(75, 27);
            this.btnAlterarSMTP.TabIndex = 39;
            this.btnAlterarSMTP.Text = "Alterar";
            this.btnAlterarSMTP.UseVisualStyleBackColor = true;
            this.btnAlterarSMTP.Click += new System.EventHandler(this.btnAlterarSMTP_Click);
            // 
            // txtPorta
            // 
            this.txtPorta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorta.Location = new System.Drawing.Point(23, 166);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(142, 21);
            this.txtPorta.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Porta";
            // 
            // txtServidor
            // 
            this.txtServidor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServidor.Location = new System.Drawing.Point(23, 120);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(231, 21);
            this.txtServidor.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Servidor";
            // 
            // txtSenhaSMTP
            // 
            this.txtSenhaSMTP.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaSMTP.Location = new System.Drawing.Point(23, 77);
            this.txtSenhaSMTP.Name = "txtSenhaSMTP";
            this.txtSenhaSMTP.PasswordChar = '*';
            this.txtSenhaSMTP.Size = new System.Drawing.Size(276, 21);
            this.txtSenhaSMTP.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Senha do e-mail";
            // 
            // txtEmailSMTP
            // 
            this.txtEmailSMTP.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailSMTP.Location = new System.Drawing.Point(23, 38);
            this.txtEmailSMTP.Name = "txtEmailSMTP";
            this.txtEmailSMTP.Size = new System.Drawing.Size(356, 21);
            this.txtEmailSMTP.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "E-mail";
            // 
            // tpLimparHistorico
            // 
            this.tpLimparHistorico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpLimparHistorico.Controls.Add(this.btnLimparTodosHistoricos);
            this.tpLimparHistorico.Controls.Add(this.btnLimparEspecifico);
            this.tpLimparHistorico.Controls.Add(this.picLogo2);
            this.tpLimparHistorico.Controls.Add(this.groupBox1);
            this.tpLimparHistorico.Location = new System.Drawing.Point(4, 22);
            this.tpLimparHistorico.Name = "tpLimparHistorico";
            this.tpLimparHistorico.Padding = new System.Windows.Forms.Padding(3);
            this.tpLimparHistorico.Size = new System.Drawing.Size(399, 224);
            this.tpLimparHistorico.TabIndex = 5;
            this.tpLimparHistorico.Text = "Limpar histórico";
            // 
            // btnLimparTodosHistoricos
            // 
            this.btnLimparTodosHistoricos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparTodosHistoricos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparTodosHistoricos.Location = new System.Drawing.Point(6, 191);
            this.btnLimparTodosHistoricos.Name = "btnLimparTodosHistoricos";
            this.btnLimparTodosHistoricos.Size = new System.Drawing.Size(387, 27);
            this.btnLimparTodosHistoricos.TabIndex = 44;
            this.btnLimparTodosHistoricos.Text = "Limpar todos os históricos";
            this.btnLimparTodosHistoricos.UseVisualStyleBackColor = true;
            this.btnLimparTodosHistoricos.Click += new System.EventHandler(this.btnLimparTodosHistoricos_Click);
            // 
            // btnLimparEspecifico
            // 
            this.btnLimparEspecifico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparEspecifico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparEspecifico.Location = new System.Drawing.Point(6, 158);
            this.btnLimparEspecifico.Name = "btnLimparEspecifico";
            this.btnLimparEspecifico.Size = new System.Drawing.Size(387, 27);
            this.btnLimparEspecifico.TabIndex = 43;
            this.btnLimparEspecifico.Text = "Limpar histórico";
            this.btnLimparEspecifico.UseVisualStyleBackColor = true;
            this.btnLimparEspecifico.Click += new System.EventHandler(this.btnLimparEspecifico_Click);
            // 
            // picLogo2
            // 
            this.picLogo2.Image = global::Teste_Login.Properties.Resources.logo1;
            this.picLogo2.Location = new System.Drawing.Point(216, 6);
            this.picLogo2.Name = "picLogo2";
            this.picLogo2.Size = new System.Drawing.Size(147, 146);
            this.picLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo2.TabIndex = 4;
            this.picLogo2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEsteganografia);
            this.groupBox1.Controls.Add(this.rbMorse);
            this.groupBox1.Controls.Add(this.rbCifra);
            this.groupBox1.Controls.Add(this.rbRSA);
            this.groupBox1.Controls.Add(this.rbFileAES);
            this.groupBox1.Controls.Add(this.rbAES);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar histórico";
            // 
            // rbEsteganografia
            // 
            this.rbEsteganografia.AutoSize = true;
            this.rbEsteganografia.Location = new System.Drawing.Point(28, 69);
            this.rbEsteganografia.Name = "rbEsteganografia";
            this.rbEsteganografia.Size = new System.Drawing.Size(110, 17);
            this.rbEsteganografia.TabIndex = 5;
            this.rbEsteganografia.TabStop = true;
            this.rbEsteganografia.Text = "Esteganografia";
            this.rbEsteganografia.UseVisualStyleBackColor = true;
            this.rbEsteganografia.CheckedChanged += new System.EventHandler(this.rbEsteganografia_CheckedChanged);
            // 
            // rbMorse
            // 
            this.rbMorse.AutoSize = true;
            this.rbMorse.Location = new System.Drawing.Point(28, 115);
            this.rbMorse.Name = "rbMorse";
            this.rbMorse.Size = new System.Drawing.Size(103, 17);
            this.rbMorse.TabIndex = 4;
            this.rbMorse.TabStop = true;
            this.rbMorse.Text = "Código Morse";
            this.rbMorse.UseVisualStyleBackColor = true;
            this.rbMorse.CheckedChanged += new System.EventHandler(this.rbMorse_CheckedChanged);
            // 
            // rbCifra
            // 
            this.rbCifra.AutoSize = true;
            this.rbCifra.Location = new System.Drawing.Point(28, 92);
            this.rbCifra.Name = "rbCifra";
            this.rbCifra.Size = new System.Drawing.Size(109, 17);
            this.rbCifra.TabIndex = 3;
            this.rbCifra.TabStop = true;
            this.rbCifra.Text = "Cifra de Cesar";
            this.rbCifra.UseVisualStyleBackColor = true;
            this.rbCifra.CheckedChanged += new System.EventHandler(this.rbCifra_CheckedChanged);
            // 
            // rbRSA
            // 
            this.rbRSA.AutoSize = true;
            this.rbRSA.Location = new System.Drawing.Point(82, 23);
            this.rbRSA.Name = "rbRSA";
            this.rbRSA.Size = new System.Drawing.Size(49, 17);
            this.rbRSA.TabIndex = 2;
            this.rbRSA.TabStop = true;
            this.rbRSA.Text = "RSA";
            this.rbRSA.UseVisualStyleBackColor = true;
            this.rbRSA.CheckedChanged += new System.EventHandler(this.rbRSA_CheckedChanged);
            // 
            // rbFileAES
            // 
            this.rbFileAES.AutoSize = true;
            this.rbFileAES.Location = new System.Drawing.Point(28, 46);
            this.rbFileAES.Name = "rbFileAES";
            this.rbFileAES.Size = new System.Drawing.Size(112, 17);
            this.rbFileAES.TabIndex = 1;
            this.rbFileAES.TabStop = true;
            this.rbFileAES.Text = "AES (Arquivos)";
            this.rbFileAES.UseVisualStyleBackColor = true;
            this.rbFileAES.CheckedChanged += new System.EventHandler(this.rbFileAES_CheckedChanged);
            // 
            // rbAES
            // 
            this.rbAES.AutoSize = true;
            this.rbAES.Location = new System.Drawing.Point(28, 23);
            this.rbAES.Name = "rbAES";
            this.rbAES.Size = new System.Drawing.Size(48, 17);
            this.rbAES.TabIndex = 0;
            this.rbAES.TabStop = true;
            this.rbAES.Text = "AES";
            this.rbAES.UseVisualStyleBackColor = true;
            this.rbAES.CheckedChanged += new System.EventHandler(this.rbAES_CheckedChanged);
            // 
            // cboxSSL
            // 
            this.cboxSSL.AutoSize = true;
            this.cboxSSL.Location = new System.Drawing.Point(23, 193);
            this.cboxSSL.Name = "cboxSSL";
            this.cboxSSL.Size = new System.Drawing.Size(91, 17);
            this.cboxSSL.TabIndex = 44;
            this.cboxSSL.Text = "Utilizar SSL";
            this.cboxSSL.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 294);
            this.Controls.Add(this.tbcInfosConta);
            this.Controls.Add(this.picLogo1);
            this.Controls.Add(this.menuSuperior);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuSuperior;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCrypto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuSuperior.ResumeLayout(false);
            this.menuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
            this.tpMinhaConta.ResumeLayout(false);
            this.tpMinhaConta.PerformLayout();
            this.tbcInfosConta.ResumeLayout(false);
            this.tpServerSMTP.ResumeLayout(false);
            this.tpServerSMTP.PerformLayout();
            this.tpLimparHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuSuperior;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpcoes;
        private System.Windows.Forms.ToolStripMenuItem tsmiSair;
        private System.Windows.Forms.ToolStripMenuItem tsmiCriptografia;
        private System.Windows.Forms.ToolStripMenuItem aESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esteganografiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cifraDeCesarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoMorseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hisóricoToolStripMenuItem;
        private System.Windows.Forms.PictureBox picLogo1;
        private System.Windows.Forms.TabPage tpMinhaConta;
        private System.Windows.Forms.TextBox tbxNovaSenha;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tbcInfosConta;
        private System.Windows.Forms.TabPage tpServerSMTP;
        private System.Windows.Forms.Button btnExcluirSMTP;
        private System.Windows.Forms.Button btnAlterarSMTP;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenhaSMTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailSMTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cboxAlterarInfos;
        private System.Windows.Forms.TextBox tbxNovaSenhaConfirm;
        private System.Windows.Forms.Label lbConfirmarSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox cboxAlterarSenha;
        private System.Windows.Forms.TabPage tpLimparHistorico;
        private System.Windows.Forms.CheckBox cboxMostrarSenha;
        private System.Windows.Forms.Button btnLimparTodosHistoricos;
        private System.Windows.Forms.Button btnLimparEspecifico;
        private System.Windows.Forms.PictureBox picLogo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMorse;
        private System.Windows.Forms.RadioButton rbCifra;
        private System.Windows.Forms.RadioButton rbRSA;
        private System.Windows.Forms.RadioButton rbFileAES;
        private System.Windows.Forms.RadioButton rbAES;
        private System.Windows.Forms.RadioButton rbEsteganografia;
        private System.Windows.Forms.ToolStripMenuItem tsmiTema;
        private System.Windows.Forms.ToolStripMenuItem temaEscuroOn;
        private System.Windows.Forms.ToolStripMenuItem temaEscuroOff;
        private System.Windows.Forms.CheckBox cboxSSL;
    }
}

