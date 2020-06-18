namespace Teste_Login
{
    partial class frmEnviarChaveRSAEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnviarChaveRSAEmail));
            this.gboxEmail = new System.Windows.Forms.GroupBox();
            this.gboxConteudoEmail = new System.Windows.Forms.GroupBox();
            this.cboxSalvarNovamente = new System.Windows.Forms.CheckBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxMetodoEnvio = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.gboxLoginEmail = new System.Windows.Forms.GroupBox();
            this.cboxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbSMTP = new System.Windows.Forms.RadioButton();
            this.rbOutro = new System.Windows.Forms.RadioButton();
            this.rbConta = new System.Windows.Forms.RadioButton();
            this.sfdSalvarChaves = new System.Windows.Forms.SaveFileDialog();
            this.gboxEmail.SuspendLayout();
            this.gboxConteudoEmail.SuspendLayout();
            this.gboxLoginEmail.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxEmail
            // 
            this.gboxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxEmail.Controls.Add(this.gboxConteudoEmail);
            this.gboxEmail.Controls.Add(this.gboxLoginEmail);
            this.gboxEmail.Controls.Add(this.groupBox4);
            this.gboxEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxEmail.Location = new System.Drawing.Point(12, 12);
            this.gboxEmail.Name = "gboxEmail";
            this.gboxEmail.Size = new System.Drawing.Size(531, 529);
            this.gboxEmail.TabIndex = 8;
            this.gboxEmail.TabStop = false;
            this.gboxEmail.Text = "Enviar chaves por e-mail";
            // 
            // gboxConteudoEmail
            // 
            this.gboxConteudoEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxConteudoEmail.Controls.Add(this.cboxSalvarNovamente);
            this.gboxConteudoEmail.Controls.Add(this.btnEnviar);
            this.gboxConteudoEmail.Controls.Add(this.label1);
            this.gboxConteudoEmail.Controls.Add(this.cboxMetodoEnvio);
            this.gboxConteudoEmail.Controls.Add(this.label9);
            this.gboxConteudoEmail.Controls.Add(this.txtDestinatario);
            this.gboxConteudoEmail.Controls.Add(this.label7);
            this.gboxConteudoEmail.Controls.Add(this.txtMensagem);
            this.gboxConteudoEmail.Controls.Add(this.label5);
            this.gboxConteudoEmail.Controls.Add(this.txtAssunto);
            this.gboxConteudoEmail.Location = new System.Drawing.Point(6, 145);
            this.gboxConteudoEmail.Name = "gboxConteudoEmail";
            this.gboxConteudoEmail.Size = new System.Drawing.Size(519, 370);
            this.gboxConteudoEmail.TabIndex = 6;
            this.gboxConteudoEmail.TabStop = false;
            this.gboxConteudoEmail.Text = "Conteúdo do E-mail";
            // 
            // cboxSalvarNovamente
            // 
            this.cboxSalvarNovamente.AutoSize = true;
            this.cboxSalvarNovamente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSalvarNovamente.Location = new System.Drawing.Point(214, 118);
            this.cboxSalvarNovamente.Name = "cboxSalvarNovamente";
            this.cboxSalvarNovamente.Size = new System.Drawing.Size(178, 17);
            this.cboxSalvarNovamente.TabIndex = 17;
            this.cboxSalvarNovamente.Text = "Salvar arquivo novamente";
            this.cboxSalvarNovamente.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Location = new System.Drawing.Point(6, 341);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 16;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Método de envio";
            // 
            // cboxMetodoEnvio
            // 
            this.cboxMetodoEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMetodoEnvio.FormattingEnabled = true;
            this.cboxMetodoEnvio.Items.AddRange(new object[] {
            "Arquivo .txt (recomendado)",
            "Mensagem (Texto)"});
            this.cboxMetodoEnvio.Location = new System.Drawing.Point(6, 115);
            this.cboxMetodoEnvio.Name = "cboxMetodoEnvio";
            this.cboxMetodoEnvio.Size = new System.Drawing.Size(196, 21);
            this.cboxMetodoEnvio.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "E-mail destinatário";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinatario.Location = new System.Drawing.Point(6, 35);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(507, 21);
            this.txtDestinatario.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mensagem (opcional)";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensagem.Location = new System.Drawing.Point(6, 155);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(507, 180);
            this.txtMensagem.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Assunto (Opcional)";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssunto.Location = new System.Drawing.Point(6, 75);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(507, 21);
            this.txtAssunto.TabIndex = 5;
            // 
            // gboxLoginEmail
            // 
            this.gboxLoginEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxLoginEmail.Controls.Add(this.cboxMostrarSenha);
            this.gboxLoginEmail.Controls.Add(this.lbEmail);
            this.gboxLoginEmail.Controls.Add(this.label6);
            this.gboxLoginEmail.Controls.Add(this.txtEmail);
            this.gboxLoginEmail.Controls.Add(this.txtSenha);
            this.gboxLoginEmail.Location = new System.Drawing.Point(214, 20);
            this.gboxLoginEmail.Name = "gboxLoginEmail";
            this.gboxLoginEmail.Size = new System.Drawing.Size(311, 119);
            this.gboxLoginEmail.TabIndex = 5;
            this.gboxLoginEmail.TabStop = false;
            this.gboxLoginEmail.Text = "Login do E-mail";
            // 
            // cboxMostrarSenha
            // 
            this.cboxMostrarSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxMostrarSenha.AutoSize = true;
            this.cboxMostrarSenha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMostrarSenha.Location = new System.Drawing.Point(229, 80);
            this.cboxMostrarSenha.Name = "cboxMostrarSenha";
            this.cboxMostrarSenha.Size = new System.Drawing.Size(69, 17);
            this.cboxMostrarSenha.TabIndex = 5;
            this.cboxMostrarSenha.Text = "Mostrar";
            this.cboxMostrarSenha.UseVisualStyleBackColor = true;
            this.cboxMostrarSenha.CheckedChanged += new System.EventHandler(this.cboxMostrarSenha_CheckedChanged);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(6, 24);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(43, 13);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(6, 39);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 21);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Location = new System.Drawing.Point(6, 78);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(217, 21);
            this.txtSenha.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbSMTP);
            this.groupBox4.Controls.Add(this.rbOutro);
            this.groupBox4.Controls.Add(this.rbConta);
            this.groupBox4.Location = new System.Drawing.Point(6, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 119);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Qual e-mail deseja utilizar?";
            // 
            // rbSMTP
            // 
            this.rbSMTP.AutoSize = true;
            this.rbSMTP.Location = new System.Drawing.Point(12, 76);
            this.rbSMTP.Name = "rbSMTP";
            this.rbSMTP.Size = new System.Drawing.Size(155, 17);
            this.rbSMTP.TabIndex = 3;
            this.rbSMTP.TabStop = true;
            this.rbSMTP.Text = "SMTP Personalizado";
            this.rbSMTP.UseVisualStyleBackColor = true;
            this.rbSMTP.CheckedChanged += new System.EventHandler(this.rbSMTP_CheckedChanged);
            // 
            // rbOutro
            // 
            this.rbOutro.AutoSize = true;
            this.rbOutro.Location = new System.Drawing.Point(12, 53);
            this.rbOutro.Name = "rbOutro";
            this.rbOutro.Size = new System.Drawing.Size(61, 17);
            this.rbOutro.TabIndex = 2;
            this.rbOutro.TabStop = true;
            this.rbOutro.Text = "Outro";
            this.rbOutro.UseVisualStyleBackColor = true;
            this.rbOutro.CheckedChanged += new System.EventHandler(this.rbOutro_CheckedChanged_1);
            // 
            // rbConta
            // 
            this.rbConta.AutoSize = true;
            this.rbConta.Location = new System.Drawing.Point(12, 29);
            this.rbConta.Name = "rbConta";
            this.rbConta.Size = new System.Drawing.Size(62, 17);
            this.rbConta.TabIndex = 1;
            this.rbConta.TabStop = true;
            this.rbConta.Text = "Conta";
            this.rbConta.UseVisualStyleBackColor = true;
            this.rbConta.CheckedChanged += new System.EventHandler(this.rbConta_CheckedChanged);
            // 
            // sfdSalvarChaves
            // 
            this.sfdSalvarChaves.DefaultExt = "txt";
            // 
            // frmEnviarChaveRSAEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 551);
            this.Controls.Add(this.gboxEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEnviarChaveRSAEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCrypto : RSA : Enviar chaves por e-mail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEnviarChaveRSAEmail_FormClosing);
            this.Load += new System.EventHandler(this.frmEnviarChaveRSAEmail_Load);
            this.gboxEmail.ResumeLayout(false);
            this.gboxConteudoEmail.ResumeLayout(false);
            this.gboxConteudoEmail.PerformLayout();
            this.gboxLoginEmail.ResumeLayout(false);
            this.gboxLoginEmail.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxEmail;
        private System.Windows.Forms.GroupBox gboxConteudoEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.GroupBox gboxLoginEmail;
        private System.Windows.Forms.CheckBox cboxMostrarSenha;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbSMTP;
        private System.Windows.Forms.RadioButton rbOutro;
        private System.Windows.Forms.RadioButton rbConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxMetodoEnvio;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.SaveFileDialog sfdSalvarChaves;
        private System.Windows.Forms.CheckBox cboxSalvarNovamente;
    }
}