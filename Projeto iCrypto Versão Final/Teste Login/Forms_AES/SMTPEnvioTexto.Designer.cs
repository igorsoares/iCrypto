namespace Projeto_AES
{
    partial class SMTPEnvioTexto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMTPEnvioTexto));
            this.richConteudo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbkMostra = new System.Windows.Forms.CheckBox();
            this.tbPorta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSmtp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAnexo = new System.Windows.Forms.DataGridView();
            this.columNameFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDiretorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemoverAnexo = new System.Windows.Forms.Button();
            this.btAnexa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richAssunto = new System.Windows.Forms.RichTextBox();
            this.tbEmailTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btEnvia = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnexo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richConteudo
            // 
            this.richConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richConteudo.Location = new System.Drawing.Point(8, 97);
            this.richConteudo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richConteudo.Name = "richConteudo";
            this.richConteudo.Size = new System.Drawing.Size(525, 144);
            this.richConteudo.TabIndex = 0;
            this.richConteudo.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbkMostra);
            this.groupBox1.Controls.Add(this.tbPorta);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbSmtp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbSenha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(354, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // cbkMostra
            // 
            this.cbkMostra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbkMostra.AutoSize = true;
            this.cbkMostra.Location = new System.Drawing.Point(279, 67);
            this.cbkMostra.Name = "cbkMostra";
            this.cbkMostra.Size = new System.Drawing.Size(74, 18);
            this.cbkMostra.TabIndex = 12;
            this.cbkMostra.Text = "Mostrar";
            this.cbkMostra.UseVisualStyleBackColor = true;
            this.cbkMostra.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbPorta
            // 
            this.tbPorta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPorta.Location = new System.Drawing.Point(111, 131);
            this.tbPorta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPorta.Name = "tbPorta";
            this.tbPorta.Size = new System.Drawing.Size(162, 22);
            this.tbPorta.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "Porta :";
            // 
            // tbSmtp
            // 
            this.tbSmtp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSmtp.Location = new System.Drawing.Point(111, 97);
            this.tbSmtp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSmtp.Name = "tbSmtp";
            this.tbSmtp.Size = new System.Drawing.Size(162, 22);
            this.tbSmtp.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "Servidor SMTP:";
            // 
            // tbSenha
            // 
            this.tbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenha.Location = new System.Drawing.Point(111, 65);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(162, 22);
            this.tbSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(111, 30);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(162, 22);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewAnexo);
            this.groupBox2.Controls.Add(this.btRemoverAnexo);
            this.groupBox2.Controls.Add(this.btAnexa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.richAssunto);
            this.groupBox2.Controls.Add(this.richConteudo);
            this.groupBox2.Controls.Add(this.tbEmailTo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(391, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(543, 438);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para";
            // 
            // dataGridViewAnexo
            // 
            this.dataGridViewAnexo.AllowUserToOrderColumns = true;
            this.dataGridViewAnexo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAnexo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAnexo.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewAnexo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAnexo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAnexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnexo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columNameFile,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.clnDiretorio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAnexo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAnexo.EnableHeadersVisualStyles = false;
            this.dataGridViewAnexo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewAnexo.Location = new System.Drawing.Point(11, 271);
            this.dataGridViewAnexo.Name = "dataGridViewAnexo";
            this.dataGridViewAnexo.ReadOnly = true;
            this.dataGridViewAnexo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAnexo.Size = new System.Drawing.Size(525, 127);
            this.dataGridViewAnexo.TabIndex = 9;
            // 
            // columNameFile
            // 
            this.columNameFile.HeaderText = "Nome";
            this.columNameFile.Name = "columNameFile";
            this.columNameFile.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Tamanho";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Extensão";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // clnDiretorio
            // 
            this.clnDiretorio.HeaderText = "Diretório";
            this.clnDiretorio.Name = "clnDiretorio";
            this.clnDiretorio.ReadOnly = true;
            // 
            // btRemoverAnexo
            // 
            this.btRemoverAnexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemoverAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRemoverAnexo.Location = new System.Drawing.Point(272, 408);
            this.btRemoverAnexo.Name = "btRemoverAnexo";
            this.btRemoverAnexo.Size = new System.Drawing.Size(242, 23);
            this.btRemoverAnexo.TabIndex = 8;
            this.btRemoverAnexo.Text = "Remover";
            this.btRemoverAnexo.UseVisualStyleBackColor = true;
            this.btRemoverAnexo.Click += new System.EventHandler(this.btRemoverAnexo_Click);
            // 
            // btAnexa
            // 
            this.btAnexa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnexa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAnexa.Location = new System.Drawing.Point(11, 408);
            this.btAnexa.Name = "btAnexa";
            this.btAnexa.Size = new System.Drawing.Size(242, 23);
            this.btAnexa.TabIndex = 7;
            this.btAnexa.Text = "Anexar";
            this.btAnexa.UseVisualStyleBackColor = true;
            this.btAnexa.Click += new System.EventHandler(this.btAnexa_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Anexo(s)";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Assunto";
            // 
            // richAssunto
            // 
            this.richAssunto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richAssunto.Location = new System.Drawing.Point(64, 61);
            this.richAssunto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richAssunto.Name = "richAssunto";
            this.richAssunto.Size = new System.Drawing.Size(469, 22);
            this.richAssunto.TabIndex = 1;
            this.richAssunto.Text = "";
            // 
            // tbEmailTo
            // 
            this.tbEmailTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmailTo.Location = new System.Drawing.Point(64, 30);
            this.tbEmailTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbEmailTo.Name = "tbEmailTo";
            this.tbEmailTo.Size = new System.Drawing.Size(469, 22);
            this.tbEmailTo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email:";
            // 
            // btEnvia
            // 
            this.btEnvia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEnvia.Location = new System.Drawing.Point(13, 331);
            this.btEnvia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btEnvia.Name = "btEnvia";
            this.btEnvia.Size = new System.Drawing.Size(353, 36);
            this.btEnvia.TabIndex = 6;
            this.btEnvia.Text = "Enviar email";
            this.btEnvia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEnvia.UseVisualStyleBackColor = true;
            this.btEnvia.Click += new System.EventHandler(this.btEnvia_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(13, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 123);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aviso";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(262, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "\"opções menos seguras\" antes de continuar.";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(306, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "3) Caso utilize email do gmail, é necessário habilitar";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "do servidor SMTP do domínio;";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(300, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "2) Consulte o administrador da rede para obtenção";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "fatores;";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "1) A conta não pode possuir autenticação de dois";
            // 
            // SMTPEnvioTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(947, 468);
            this.Controls.Add(this.btEnvia);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SMTPEnvioTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCrypto : Enviar mensagem por e-mail : AES";
            this.Load += new System.EventHandler(this.SMTPEnvioTexto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnexo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richConteudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbEmailTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btEnvia;
        private System.Windows.Forms.TextBox tbPorta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSmtp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richAssunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAnexa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btRemoverAnexo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbkMostra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewAnexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columNameFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDiretorio;
    }
}