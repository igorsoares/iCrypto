namespace CifraDeCesarProjeto1
{
    partial class CifraCesar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CifraCesar));
            this.rtbxTPuro = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbxTextoCifrado = new System.Windows.Forms.RichTextBox();
            this.tbxChave = new System.Windows.Forms.TextBox();
            this.lblChave = new System.Windows.Forms.Label();
            this.cbxModo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopiar2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxAutoSalvar = new System.Windows.Forms.CheckBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCopiar1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMaisChave = new System.Windows.Forms.Button();
            this.btnMenosChave = new System.Windows.Forms.Button();
            this.btnColar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbxTPuro
            // 
            this.rtbxTPuro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbxTPuro.Location = new System.Drawing.Point(19, 29);
            this.rtbxTPuro.Name = "rtbxTPuro";
            this.rtbxTPuro.Size = new System.Drawing.Size(866, 131);
            this.rtbxTPuro.TabIndex = 0;
            this.rtbxTPuro.Text = "";
            this.rtbxTPuro.TextChanged += new System.EventHandler(this.rtbxTPuro_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 10;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rtbxTPuro);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Texto Puro";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rtbxTextoCifrado);
            this.groupBox2.Location = new System.Drawing.Point(14, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(919, 280);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Texto em Cifra de Cesar";
            // 
            // rtbxTextoCifrado
            // 
            this.rtbxTextoCifrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbxTextoCifrado.Location = new System.Drawing.Point(19, 36);
            this.rtbxTextoCifrado.Name = "rtbxTextoCifrado";
            this.rtbxTextoCifrado.ReadOnly = true;
            this.rtbxTextoCifrado.Size = new System.Drawing.Size(866, 226);
            this.rtbxTextoCifrado.TabIndex = 0;
            this.rtbxTextoCifrado.Text = "";
            // 
            // tbxChave
            // 
            this.tbxChave.Location = new System.Drawing.Point(282, 210);
            this.tbxChave.Name = "tbxChave";
            this.tbxChave.Size = new System.Drawing.Size(116, 21);
            this.tbxChave.TabIndex = 3;
            this.tbxChave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxChave_MouseClick);
            this.tbxChave.TextChanged += new System.EventHandler(this.tbxChave_TextChanged);
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Location = new System.Drawing.Point(227, 213);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(49, 13);
            this.lblChave.TabIndex = 4;
            this.lblChave.Text = "Chave:";
            // 
            // cbxModo
            // 
            this.cbxModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModo.FormattingEnabled = true;
            this.cbxModo.Items.AddRange(new object[] {
            "Cifrar ",
            "Decifrar"});
            this.cbxModo.Location = new System.Drawing.Point(69, 210);
            this.cbxModo.Name = "cbxModo";
            this.cbxModo.Size = new System.Drawing.Size(140, 21);
            this.cbxModo.TabIndex = 5;
            this.cbxModo.SelectedIndexChanged += new System.EventHandler(this.cbxModo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modo:";
            // 
            // btnCopiar2
            // 
            this.btnCopiar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopiar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopiar2.Location = new System.Drawing.Point(36, 46);
            this.btnCopiar2.Name = "btnCopiar2";
            this.btnCopiar2.Size = new System.Drawing.Size(87, 27);
            this.btnCopiar2.TabIndex = 7;
            this.btnCopiar2.Text = "Copiar";
            this.btnCopiar2.UseVisualStyleBackColor = true;
            this.btnCopiar2.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnColar);
            this.groupBox3.Controls.Add(this.cbxAutoSalvar);
            this.groupBox3.Controls.Add(this.btnLimpar);
            this.groupBox3.Controls.Add(this.btnCopiar1);
            this.groupBox3.Location = new System.Drawing.Point(952, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 185);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opções";
            // 
            // cbxAutoSalvar
            // 
            this.cbxAutoSalvar.AutoSize = true;
            this.cbxAutoSalvar.Location = new System.Drawing.Point(36, 140);
            this.cbxAutoSalvar.Name = "cbxAutoSalvar";
            this.cbxAutoSalvar.Size = new System.Drawing.Size(94, 17);
            this.cbxAutoSalvar.TabIndex = 11;
            this.cbxAutoSalvar.Text = "Auto-Salvar";
            this.cbxAutoSalvar.UseVisualStyleBackColor = true;
            this.cbxAutoSalvar.CheckedChanged += new System.EventHandler(this.cbxAutoSalvar_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Location = new System.Drawing.Point(36, 107);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 27);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCopiar1
            // 
            this.btnCopiar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopiar1.Location = new System.Drawing.Point(36, 42);
            this.btnCopiar1.Name = "btnCopiar1";
            this.btnCopiar1.Size = new System.Drawing.Size(87, 27);
            this.btnCopiar1.TabIndex = 8;
            this.btnCopiar1.Text = "Copiar";
            this.btnCopiar1.UseVisualStyleBackColor = true;
            this.btnCopiar1.Click += new System.EventHandler(this.btnCopiar1_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnEnviarEmail);
            this.groupBox4.Controls.Add(this.btnResetar);
            this.groupBox4.Controls.Add(this.btnCopiar2);
            this.groupBox4.Location = new System.Drawing.Point(952, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 278);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opções";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(36, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSalvar);
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviarEmail.Location = new System.Drawing.Point(36, 146);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(87, 44);
            this.btnEnviarEmail.TabIndex = 9;
            this.btnEnviarEmail.Text = "Enviar por Email";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetar.Location = new System.Drawing.Point(36, 96);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(87, 27);
            this.btnResetar.TabIndex = 8;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMaisChave
            // 
            this.btnMaisChave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaisChave.Location = new System.Drawing.Point(404, 210);
            this.btnMaisChave.Name = "btnMaisChave";
            this.btnMaisChave.Size = new System.Drawing.Size(23, 21);
            this.btnMaisChave.TabIndex = 10;
            this.btnMaisChave.Text = "+";
            this.btnMaisChave.UseVisualStyleBackColor = true;
            this.btnMaisChave.Click += new System.EventHandler(this.btnMaisChave_Click);
            // 
            // btnMenosChave
            // 
            this.btnMenosChave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenosChave.Location = new System.Drawing.Point(433, 210);
            this.btnMenosChave.Name = "btnMenosChave";
            this.btnMenosChave.Size = new System.Drawing.Size(23, 21);
            this.btnMenosChave.TabIndex = 11;
            this.btnMenosChave.Text = "-";
            this.btnMenosChave.UseVisualStyleBackColor = true;
            this.btnMenosChave.Click += new System.EventHandler(this.btnMenosChave_Click);
            // 
            // btnColar
            // 
            this.btnColar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColar.Location = new System.Drawing.Point(36, 75);
            this.btnColar.Name = "btnColar";
            this.btnColar.Size = new System.Drawing.Size(87, 27);
            this.btnColar.TabIndex = 12;
            this.btnColar.Text = "Colar";
            this.btnColar.UseVisualStyleBackColor = true;
            this.btnColar.Click += new System.EventHandler(this.btnColar_Click);
            // 
            // CifraCesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1121, 532);
            this.Controls.Add(this.btnMenosChave);
            this.Controls.Add(this.btnMaisChave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxModo);
            this.Controls.Add(this.lblChave);
            this.Controls.Add(this.tbxChave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CifraCesar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCrypto: Cifra de Cesar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CifraCesar_FormClosing);
            this.Load += new System.EventHandler(this.CifraCesar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxTPuro;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbxTextoCifrado;
        private System.Windows.Forms.TextBox tbxChave;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.ComboBox cbxModo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopiar2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCopiar1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbxAutoSalvar;
        private System.Windows.Forms.Button btnMaisChave;
        private System.Windows.Forms.Button btnMenosChave;
        private System.Windows.Forms.Button btnColar;
    }
}

