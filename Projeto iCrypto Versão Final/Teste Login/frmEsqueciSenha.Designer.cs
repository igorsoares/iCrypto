namespace Teste_Login
{
    partial class frmEsqueciSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEsqueciSenha));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cboxEmail = new System.Windows.Forms.CheckBox();
            this.ttpMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.cboxDarkTheme = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(205, 202);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(226, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(314, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 56);
            this.label1.TabIndex = 16;
            this.label1.Text = "Insira seu endereço de e-mail no campo abaixo e clique \r\nem \'Enviar\'. Você recebe" +
    "rá um e-mail contendo uma \r\nnova senha. Faça login com esta nova senha e altere-" +
    "a \r\nposteriormente\r\n";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(225, 174);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(111, 30);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cboxEmail
            // 
            this.cboxEmail.AutoSize = true;
            this.cboxEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEmail.Location = new System.Drawing.Point(383, 82);
            this.cboxEmail.Name = "cboxEmail";
            this.cboxEmail.Size = new System.Drawing.Size(170, 17);
            this.cboxEmail.TabIndex = 2;
            this.cboxEmail.Text = "Utilizar e-mail alternativo";
            this.cboxEmail.UseVisualStyleBackColor = true;
            this.cboxEmail.CheckedChanged += new System.EventHandler(this.cboxEmail_CheckedChanged);
            // 
            // ttpMensagem
            // 
            this.ttpMensagem.AutoPopDelay = 30000;
            this.ttpMensagem.InitialDelay = 100;
            this.ttpMensagem.ReshowDelay = 100;
            this.ttpMensagem.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpMensagem.ToolTipTitle = "Quando utilizar esta caixa?";
            // 
            // picHelp
            // 
            this.picHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.picHelp.Image = ((System.Drawing.Image)(resources.GetObject("picHelp.Image")));
            this.picHelp.Location = new System.Drawing.Point(546, 78);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(23, 23);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 17;
            this.picHelp.TabStop = false;
            this.picHelp.MouseEnter += new System.EventHandler(this.picHelp_MouseEnter);
            this.picHelp.MouseLeave += new System.EventHandler(this.picHelp_MouseLeave);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(226, 101);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(344, 20);
            this.txtNome.TabIndex = 18;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Enabled = false;
            this.lbNome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(223, 82);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(44, 16);
            this.lbNome.TabIndex = 19;
            this.lbNome.Text = "Nome";
            // 
            // cboxDarkTheme
            // 
            this.cboxDarkTheme.AutoSize = true;
            this.cboxDarkTheme.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxDarkTheme.Location = new System.Drawing.Point(492, 197);
            this.cboxDarkTheme.Name = "cboxDarkTheme";
            this.cboxDarkTheme.Size = new System.Drawing.Size(99, 17);
            this.cboxDarkTheme.TabIndex = 24;
            this.cboxDarkTheme.Text = "Tema escuro";
            this.cboxDarkTheme.UseVisualStyleBackColor = true;
            this.cboxDarkTheme.CheckedChanged += new System.EventHandler(this.cboxDarkTheme_CheckedChanged);
            // 
            // frmEsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 226);
            this.Controls.Add(this.cboxDarkTheme);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.picHelp);
            this.Controls.Add(this.cboxEmail);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEsqueciSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCrypto : Esqueci minha senha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEsqueciSenha_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox cboxEmail;
        private System.Windows.Forms.ToolTip ttpMensagem;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.CheckBox cboxDarkTheme;
    }
}