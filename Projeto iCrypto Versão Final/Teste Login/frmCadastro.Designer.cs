namespace Teste_Login
{
    partial class frmCadastro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cboxSenha = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.picAjudaSenha = new System.Windows.Forms.PictureBox();
            this.ttpMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.gboxSMTP = new System.Windows.Forms.GroupBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenhaSMTP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailSMTP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picHelpSMTP = new System.Windows.Forms.PictureBox();
            this.cboxSMTP = new System.Windows.Forms.CheckBox();
            this.cboxDarkTheme = new System.Windows.Forms.CheckBox();
            this.cboxSSL = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAjudaSenha)).BeginInit();
            this.gboxSMTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelpSMTP)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(246, 244);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(267, 153);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(188, 21);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(267, 110);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(256, 21);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(267, 71);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(414, 21);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.Location = new System.Drawing.Point(267, 199);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(188, 21);
            this.txtConfirmarSenha.TabIndex = 5;
            this.txtConfirmarSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarSenha_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Confirmar senha";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(570, 235);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(111, 30);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cboxSenha
            // 
            this.cboxSenha.AutoSize = true;
            this.cboxSenha.Location = new System.Drawing.Point(490, 155);
            this.cboxSenha.Name = "cboxSenha";
            this.cboxSenha.Size = new System.Drawing.Size(61, 17);
            this.cboxSenha.TabIndex = 18;
            this.cboxSenha.Text = "Mostrar";
            this.cboxSenha.UseVisualStyleBackColor = true;
            this.cboxSenha.CheckedChanged += new System.EventHandler(this.cboxSenha_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(267, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(414, 21);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // picAjudaSenha
            // 
            this.picAjudaSenha.Cursor = System.Windows.Forms.Cursors.Help;
            this.picAjudaSenha.Image = global::Teste_Login.Properties.Resources.Information;
            this.picAjudaSenha.Location = new System.Drawing.Point(461, 151);
            this.picAjudaSenha.Name = "picAjudaSenha";
            this.picAjudaSenha.Size = new System.Drawing.Size(23, 23);
            this.picAjudaSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAjudaSenha.TabIndex = 19;
            this.picAjudaSenha.TabStop = false;
            this.picAjudaSenha.MouseEnter += new System.EventHandler(this.picAjudaSenha_MouseEnter);
            this.picAjudaSenha.MouseLeave += new System.EventHandler(this.picAjudaSenha_MouseLeave);
            // 
            // ttpMensagem
            // 
            this.ttpMensagem.AutoPopDelay = 30000;
            this.ttpMensagem.InitialDelay = 100;
            this.ttpMensagem.ReshowDelay = 100;
            this.ttpMensagem.ToolTipTitle = "Parâmetros da senha";
            // 
            // gboxSMTP
            // 
            this.gboxSMTP.Controls.Add(this.cboxSSL);
            this.gboxSMTP.Controls.Add(this.txtPorta);
            this.gboxSMTP.Controls.Add(this.label9);
            this.gboxSMTP.Controls.Add(this.txtServidor);
            this.gboxSMTP.Controls.Add(this.label8);
            this.gboxSMTP.Controls.Add(this.txtSenhaSMTP);
            this.gboxSMTP.Controls.Add(this.label7);
            this.gboxSMTP.Controls.Add(this.txtEmailSMTP);
            this.gboxSMTP.Controls.Add(this.label6);
            this.gboxSMTP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSMTP.Location = new System.Drawing.Point(687, 28);
            this.gboxSMTP.Name = "gboxSMTP";
            this.gboxSMTP.Size = new System.Drawing.Size(326, 237);
            this.gboxSMTP.TabIndex = 20;
            this.gboxSMTP.TabStop = false;
            this.gboxSMTP.Text = "Configurar servidor SMTP ";
            // 
            // txtPorta
            // 
            this.txtPorta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorta.Location = new System.Drawing.Point(6, 171);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(86, 21);
            this.txtPorta.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Porta";
            // 
            // txtServidor
            // 
            this.txtServidor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServidor.Location = new System.Drawing.Point(6, 125);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(175, 21);
            this.txtServidor.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Servidor";
            // 
            // txtSenhaSMTP
            // 
            this.txtSenhaSMTP.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaSMTP.Location = new System.Drawing.Point(6, 82);
            this.txtSenhaSMTP.Name = "txtSenhaSMTP";
            this.txtSenhaSMTP.Size = new System.Drawing.Size(256, 21);
            this.txtSenhaSMTP.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Senha do e-mail";
            // 
            // txtEmailSMTP
            // 
            this.txtEmailSMTP.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailSMTP.Location = new System.Drawing.Point(6, 43);
            this.txtEmailSMTP.Name = "txtEmailSMTP";
            this.txtEmailSMTP.Size = new System.Drawing.Size(314, 21);
            this.txtEmailSMTP.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "E-mail";
            // 
            // picHelpSMTP
            // 
            this.picHelpSMTP.Cursor = System.Windows.Forms.Cursors.Help;
            this.picHelpSMTP.Image = global::Teste_Login.Properties.Resources.Information;
            this.picHelpSMTP.Location = new System.Drawing.Point(446, 231);
            this.picHelpSMTP.Name = "picHelpSMTP";
            this.picHelpSMTP.Size = new System.Drawing.Size(23, 23);
            this.picHelpSMTP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelpSMTP.TabIndex = 21;
            this.picHelpSMTP.TabStop = false;
            this.picHelpSMTP.MouseEnter += new System.EventHandler(this.picHelpSMTP_MouseEnter);
            this.picHelpSMTP.MouseLeave += new System.EventHandler(this.picHelpSMTP_MouseLeave);
            // 
            // cboxSMTP
            // 
            this.cboxSMTP.AutoSize = true;
            this.cboxSMTP.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSMTP.Location = new System.Drawing.Point(267, 235);
            this.cboxSMTP.Name = "cboxSMTP";
            this.cboxSMTP.Size = new System.Drawing.Size(183, 17);
            this.cboxSMTP.TabIndex = 22;
            this.cboxSMTP.Text = "Utilizar SMTP personalizado";
            this.cboxSMTP.UseVisualStyleBackColor = true;
            this.cboxSMTP.CheckedChanged += new System.EventHandler(this.cboxSMTP_CheckedChanged);
            // 
            // cboxDarkTheme
            // 
            this.cboxDarkTheme.AutoSize = true;
            this.cboxDarkTheme.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxDarkTheme.Location = new System.Drawing.Point(914, 5);
            this.cboxDarkTheme.Name = "cboxDarkTheme";
            this.cboxDarkTheme.Size = new System.Drawing.Size(99, 17);
            this.cboxDarkTheme.TabIndex = 23;
            this.cboxDarkTheme.Text = "Tema escuro";
            this.cboxDarkTheme.UseVisualStyleBackColor = true;
            this.cboxDarkTheme.CheckedChanged += new System.EventHandler(this.cboxDarkTheme_CheckedChanged);
            // 
            // cboxSSL
            // 
            this.cboxSSL.AutoSize = true;
            this.cboxSSL.Location = new System.Drawing.Point(8, 206);
            this.cboxSSL.Name = "cboxSSL";
            this.cboxSSL.Size = new System.Drawing.Size(96, 18);
            this.cboxSSL.TabIndex = 31;
            this.cboxSSL.Text = "Utilizar SSL";
            this.cboxSSL.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 273);
            this.Controls.Add(this.cboxDarkTheme);
            this.Controls.Add(this.picHelpSMTP);
            this.Controls.Add(this.cboxSMTP);
            this.Controls.Add(this.gboxSMTP);
            this.Controls.Add(this.picAjudaSenha);
            this.Controls.Add(this.cboxSenha);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCrypto : Cadastrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastro_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAjudaSenha)).EndInit();
            this.gboxSMTP.ResumeLayout(false);
            this.gboxSMTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelpSMTP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox cboxSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox picAjudaSenha;
        private System.Windows.Forms.ToolTip ttpMensagem;
        private System.Windows.Forms.GroupBox gboxSMTP;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenhaSMTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailSMTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picHelpSMTP;
        private System.Windows.Forms.CheckBox cboxSMTP;
        public System.Windows.Forms.CheckBox cboxDarkTheme;
        private System.Windows.Forms.CheckBox cboxSSL;
    }
}