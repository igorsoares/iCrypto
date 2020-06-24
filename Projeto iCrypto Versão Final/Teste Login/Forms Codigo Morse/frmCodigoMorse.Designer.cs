namespace CodigoMorseProjeto1
{
    partial class frmCodigoMorse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodigoMorse));
            this.rtbxTPuro = new System.Windows.Forms.RichTextBox();
            this.gbxTPuro = new System.Windows.Forms.GroupBox();
            this.gbxCripto = new System.Windows.Forms.GroupBox();
            this.rtbxCripto = new System.Windows.Forms.RichTextBox();
            this.cbxModo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.btnCopiar2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnColar = new System.Windows.Forms.Button();
            this.cbxAutoSalvar = new System.Windows.Forms.CheckBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCopiar1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReproduzirSom = new System.Windows.Forms.Button();
            this.somMorseBackgorund = new System.ComponentModel.BackgroundWorker();
            this.gbxTPuro.SuspendLayout();
            this.gbxCripto.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbxTPuro
            // 
            this.rtbxTPuro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbxTPuro.Location = new System.Drawing.Point(16, 32);
            this.rtbxTPuro.Name = "rtbxTPuro";
            this.rtbxTPuro.Size = new System.Drawing.Size(820, 121);
            this.rtbxTPuro.TabIndex = 0;
            this.rtbxTPuro.Text = "";
            this.rtbxTPuro.TextChanged += new System.EventHandler(this.rtbxTPuro_TextChanged);
            // 
            // gbxTPuro
            // 
            this.gbxTPuro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTPuro.Controls.Add(this.rtbxTPuro);
            this.gbxTPuro.Location = new System.Drawing.Point(12, 12);
            this.gbxTPuro.Name = "gbxTPuro";
            this.gbxTPuro.Size = new System.Drawing.Size(852, 183);
            this.gbxTPuro.TabIndex = 1;
            this.gbxTPuro.TabStop = false;
            this.gbxTPuro.Text = "Texto Puro";
            // 
            // gbxCripto
            // 
            this.gbxCripto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCripto.Controls.Add(this.rtbxCripto);
            this.gbxCripto.Location = new System.Drawing.Point(13, 237);
            this.gbxCripto.Name = "gbxCripto";
            this.gbxCripto.Size = new System.Drawing.Size(851, 241);
            this.gbxCripto.TabIndex = 2;
            this.gbxCripto.TabStop = false;
            this.gbxCripto.Text = "Texto Morse";
            // 
            // rtbxCripto
            // 
            this.rtbxCripto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbxCripto.Location = new System.Drawing.Point(16, 34);
            this.rtbxCripto.Name = "rtbxCripto";
            this.rtbxCripto.ReadOnly = true;
            this.rtbxCripto.Size = new System.Drawing.Size(819, 180);
            this.rtbxCripto.TabIndex = 0;
            this.rtbxCripto.Text = "";
            // 
            // cbxModo
            // 
            this.cbxModo.AllowDrop = true;
            this.cbxModo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModo.FormattingEnabled = true;
            this.cbxModo.Items.AddRange(new object[] {
            "Criptografar",
            "Descriptografar"});
            this.cbxModo.Location = new System.Drawing.Point(57, 208);
            this.cbxModo.Name = "cbxModo";
            this.cbxModo.Size = new System.Drawing.Size(137, 21);
            this.cbxModo.TabIndex = 3;
            this.cbxModo.SelectedIndexChanged += new System.EventHandler(this.cbxModo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modo:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 10;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnEnviar);
            this.groupBox4.Controls.Add(this.btnResetar);
            this.groupBox4.Controls.Add(this.btnCopiar2);
            this.groupBox4.Location = new System.Drawing.Point(881, 238);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 240);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opções";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(36, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSalvar);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Location = new System.Drawing.Point(36, 127);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(87, 44);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar por Email";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetar.Location = new System.Drawing.Point(36, 77);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(87, 27);
            this.btnResetar.TabIndex = 8;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // btnCopiar2
            // 
            this.btnCopiar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopiar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopiar2.Location = new System.Drawing.Point(36, 27);
            this.btnCopiar2.Name = "btnCopiar2";
            this.btnCopiar2.Size = new System.Drawing.Size(87, 27);
            this.btnCopiar2.TabIndex = 7;
            this.btnCopiar2.Text = "Copiar";
            this.btnCopiar2.UseVisualStyleBackColor = true;
            this.btnCopiar2.Click += new System.EventHandler(this.btnCopiar2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnColar);
            this.groupBox3.Controls.Add(this.cbxAutoSalvar);
            this.groupBox3.Controls.Add(this.btnLimpar);
            this.groupBox3.Controls.Add(this.btnCopiar1);
            this.groupBox3.Location = new System.Drawing.Point(881, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 185);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opções";
            // 
            // btnColar
            // 
            this.btnColar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColar.Location = new System.Drawing.Point(36, 71);
            this.btnColar.Name = "btnColar";
            this.btnColar.Size = new System.Drawing.Size(87, 27);
            this.btnColar.TabIndex = 11;
            this.btnColar.Text = "Colar";
            this.btnColar.UseVisualStyleBackColor = true;
            this.btnColar.Click += new System.EventHandler(this.btnColar_Click);
            // 
            // cbxAutoSalvar
            // 
            this.cbxAutoSalvar.AutoSize = true;
            this.cbxAutoSalvar.Location = new System.Drawing.Point(36, 137);
            this.cbxAutoSalvar.Name = "cbxAutoSalvar";
            this.cbxAutoSalvar.Size = new System.Drawing.Size(94, 17);
            this.cbxAutoSalvar.TabIndex = 10;
            this.cbxAutoSalvar.Text = "Auto-Salvar";
            this.cbxAutoSalvar.UseVisualStyleBackColor = true;
            this.cbxAutoSalvar.CheckedChanged += new System.EventHandler(this.cbxAutoSalvar_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Location = new System.Drawing.Point(36, 104);
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
            this.btnCopiar1.Location = new System.Drawing.Point(36, 38);
            this.btnCopiar1.Name = "btnCopiar1";
            this.btnCopiar1.Size = new System.Drawing.Size(87, 27);
            this.btnCopiar1.TabIndex = 8;
            this.btnCopiar1.Text = "Copiar";
            this.btnCopiar1.UseVisualStyleBackColor = true;
            this.btnCopiar1.Click += new System.EventHandler(this.btnCopiar1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnReproduzirSom
            // 
            this.btnReproduzirSom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReproduzirSom.Location = new System.Drawing.Point(201, 207);
            this.btnReproduzirSom.Name = "btnReproduzirSom";
            this.btnReproduzirSom.Size = new System.Drawing.Size(124, 23);
            this.btnReproduzirSom.TabIndex = 12;
            this.btnReproduzirSom.Text = "Reproduzir som";
            this.btnReproduzirSom.UseVisualStyleBackColor = true;
            this.btnReproduzirSom.Click += new System.EventHandler(this.btnReproduzirSom_Click);
            // 
            // somMorseBackgorund
            // 
            this.somMorseBackgorund.WorkerSupportsCancellation = true;
            this.somMorseBackgorund.DoWork += new System.ComponentModel.DoWorkEventHandler(this.somMorseBackgorund_DoWork);
            // 
            // frmCodigoMorse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1050, 490);
            this.Controls.Add(this.btnReproduzirSom);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxModo);
            this.Controls.Add(this.gbxCripto);
            this.Controls.Add(this.gbxTPuro);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCodigoMorse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCrypto: Código Morse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCodigoMorse_FormClosing);
            this.gbxTPuro.ResumeLayout(false);
            this.gbxCripto.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxTPuro;
        private System.Windows.Forms.GroupBox gbxTPuro;
        private System.Windows.Forms.GroupBox gbxCripto;
        private System.Windows.Forms.RichTextBox rtbxCripto;
        private System.Windows.Forms.ComboBox cbxModo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Button btnCopiar2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCopiar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbxAutoSalvar;
        private System.Windows.Forms.Button btnColar;
        private System.Windows.Forms.Button btnReproduzirSom;
        private System.ComponentModel.BackgroundWorker somMorseBackgorund;
    }
}

