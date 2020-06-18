namespace Projeto_AES
{
    partial class frmAES
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAES));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSalvarEm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btEnviaEmail = new System.Windows.Forms.Button();
            this.cmbModo = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btSaidaCopia = new System.Windows.Forms.Button();
            this.btSaidaLimpa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btColar = new System.Windows.Forms.Button();
            this.btPuroCopia = new System.Windows.Forms.Button();
            this.btPuroLimpa = new System.Windows.Forms.Button();
            this.btAcao = new System.Windows.Forms.Button();
            this.richTexto2 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.richTexto1 = new System.Windows.Forms.RichTextBox();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btDeDiretorio = new System.Windows.Forms.Button();
            this.chkEnviaArquivo = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDescripta = new System.Windows.Forms.Button();
            this.btEncripta = new System.Windows.Forms.Button();
            this.btFileDialog = new System.Windows.Forms.Button();
            this.tbArquivo = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colunaArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaExtensao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarFile = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem});
            this.opçõesToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.arquivosToolStripMenuItem.Text = "Trocar senha ";
            this.arquivosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.arquivosToolStripMenuItem.Click += new System.EventHandler(this.arquivosToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(14, 27);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 401);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btAcao);
            this.tabPage1.Controls.Add(this.richTexto2);
            this.tabPage1.Controls.Add(this.lblTexto2);
            this.tabPage1.Controls.Add(this.richTexto1);
            this.tabPage1.Controls.Add(this.lblTexto1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Texto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSalvarEm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btEnviaEmail);
            this.groupBox1.Controls.Add(this.cmbModo);
            this.groupBox1.Location = new System.Drawing.Point(6, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 71);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // btSalvarEm
            // 
            this.btSalvarEm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvarEm.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarEm.Location = new System.Drawing.Point(467, 27);
            this.btSalvarEm.Name = "btSalvarEm";
            this.btSalvarEm.Size = new System.Drawing.Size(233, 31);
            this.btSalvarEm.TabIndex = 11;
            this.btSalvarEm.Text = "Salvar em";
            this.btSalvarEm.UseVisualStyleBackColor = true;
            this.btSalvarEm.Click += new System.EventHandler(this.btSalvarEm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modo :";
            // 
            // btEnviaEmail
            // 
            this.btEnviaEmail.Enabled = false;
            this.btEnviaEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEnviaEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviaEmail.Location = new System.Drawing.Point(228, 27);
            this.btEnviaEmail.Name = "btEnviaEmail";
            this.btEnviaEmail.Size = new System.Drawing.Size(233, 31);
            this.btEnviaEmail.TabIndex = 10;
            this.btEnviaEmail.Text = "Enviar cifragem por e-mail";
            this.btEnviaEmail.UseVisualStyleBackColor = true;
            this.btEnviaEmail.Click += new System.EventHandler(this.btEnviaEmail_Click);
            // 
            // cmbModo
            // 
            this.cmbModo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbModo.FormattingEnabled = true;
            this.cmbModo.Items.AddRange(new object[] {
            "Criptografar",
            "Descriptografar"});
            this.cmbModo.Location = new System.Drawing.Point(9, 36);
            this.cmbModo.Name = "cmbModo";
            this.cmbModo.Size = new System.Drawing.Size(186, 22);
            this.cmbModo.TabIndex = 8;
            this.cmbModo.SelectedIndexChanged += new System.EventHandler(this.cmbModo_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btSaidaCopia);
            this.groupBox4.Controls.Add(this.btSaidaLimpa);
            this.groupBox4.Location = new System.Drawing.Point(605, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(101, 100);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // btSaidaCopia
            // 
            this.btSaidaCopia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSaidaCopia.Location = new System.Drawing.Point(7, 21);
            this.btSaidaCopia.Name = "btSaidaCopia";
            this.btSaidaCopia.Size = new System.Drawing.Size(87, 23);
            this.btSaidaCopia.TabIndex = 14;
            this.btSaidaCopia.Text = "Copiar";
            this.btSaidaCopia.UseVisualStyleBackColor = true;
            this.btSaidaCopia.Click += new System.EventHandler(this.btSaidaCopia_Click);
            // 
            // btSaidaLimpa
            // 
            this.btSaidaLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSaidaLimpa.Location = new System.Drawing.Point(7, 50);
            this.btSaidaLimpa.Name = "btSaidaLimpa";
            this.btSaidaLimpa.Size = new System.Drawing.Size(87, 23);
            this.btSaidaLimpa.TabIndex = 15;
            this.btSaidaLimpa.Text = "Limpar";
            this.btSaidaLimpa.UseVisualStyleBackColor = true;
            this.btSaidaLimpa.Click += new System.EventHandler(this.btSaidaLimpa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btColar);
            this.groupBox3.Controls.Add(this.btPuroCopia);
            this.groupBox3.Controls.Add(this.btPuroLimpa);
            this.groupBox3.Location = new System.Drawing.Point(605, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(101, 114);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // btColar
            // 
            this.btColar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btColar.Location = new System.Drawing.Point(7, 79);
            this.btColar.Name = "btColar";
            this.btColar.Size = new System.Drawing.Size(87, 23);
            this.btColar.TabIndex = 14;
            this.btColar.Text = "Colar";
            this.btColar.UseVisualStyleBackColor = true;
            this.btColar.Click += new System.EventHandler(this.btColar_Click);
            // 
            // btPuroCopia
            // 
            this.btPuroCopia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPuroCopia.Location = new System.Drawing.Point(7, 21);
            this.btPuroCopia.Name = "btPuroCopia";
            this.btPuroCopia.Size = new System.Drawing.Size(87, 23);
            this.btPuroCopia.TabIndex = 12;
            this.btPuroCopia.Text = "Copiar";
            this.btPuroCopia.UseVisualStyleBackColor = true;
            this.btPuroCopia.Click += new System.EventHandler(this.btPuroCopia_Click);
            // 
            // btPuroLimpa
            // 
            this.btPuroLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPuroLimpa.Location = new System.Drawing.Point(7, 50);
            this.btPuroLimpa.Name = "btPuroLimpa";
            this.btPuroLimpa.Size = new System.Drawing.Size(87, 23);
            this.btPuroLimpa.TabIndex = 13;
            this.btPuroLimpa.Text = "Limpar";
            this.btPuroLimpa.UseVisualStyleBackColor = true;
            this.btPuroLimpa.Click += new System.EventHandler(this.btPuroLimpa_Click);
            // 
            // btAcao
            // 
            this.btAcao.BackColor = System.Drawing.Color.Transparent;
            this.btAcao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAcao.Location = new System.Drawing.Point(6, 335);
            this.btAcao.Name = "btAcao";
            this.btAcao.Size = new System.Drawing.Size(727, 23);
            this.btAcao.TabIndex = 4;
            this.btAcao.Text = "Criptografar";
            this.btAcao.UseVisualStyleBackColor = false;
            this.btAcao.Click += new System.EventHandler(this.btAcao_Click);
            // 
            // richTexto2
            // 
            this.richTexto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTexto2.ContextMenuStrip = this.contextMenuStrip1;
            this.richTexto2.DetectUrls = false;
            this.richTexto2.Location = new System.Drawing.Point(38, 150);
            this.richTexto2.Name = "richTexto2";
            this.richTexto2.ReadOnly = true;
            this.richTexto2.Size = new System.Drawing.Size(544, 102);
            this.richTexto2.TabIndex = 3;
            this.richTexto2.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarTextoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 26);
            // 
            // copiarTextoToolStripMenuItem
            // 
            this.copiarTextoToolStripMenuItem.Name = "copiarTextoToolStripMenuItem";
            this.copiarTextoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.copiarTextoToolStripMenuItem.Text = "Copiar texto";
            this.copiarTextoToolStripMenuItem.Click += new System.EventHandler(this.copiarTextoToolStripMenuItem_Click);
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTexto2.Location = new System.Drawing.Point(278, 133);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(42, 14);
            this.lblTexto2.TabIndex = 2;
            this.lblTexto2.Text = "Saída";
            // 
            // richTexto1
            // 
            this.richTexto1.BackColor = System.Drawing.Color.White;
            this.richTexto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTexto1.DetectUrls = false;
            this.richTexto1.Location = new System.Drawing.Point(38, 28);
            this.richTexto1.Name = "richTexto1";
            this.richTexto1.Size = new System.Drawing.Size(544, 102);
            this.richTexto1.TabIndex = 0;
            this.richTexto1.Text = "";
            // 
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Location = new System.Drawing.Point(264, 11);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(74, 14);
            this.lblTexto1.TabIndex = 1;
            this.lblTexto1.Text = "Texto puro";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.btDeDiretorio);
            this.tabPage2.Controls.Add(this.chkEnviaArquivo);
            this.tabPage2.Controls.Add(this.lblStatus);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btDescripta);
            this.tabPage2.Controls.Add(this.btEncripta);
            this.tabPage2.Controls.Add(this.btFileDialog);
            this.tabPage2.Controls.Add(this.tbArquivo);
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Controls.Add(this.progressBarFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Arquivo";
            // 
            // btDeDiretorio
            // 
            this.btDeDiretorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDeDiretorio.Location = new System.Drawing.Point(618, 295);
            this.btDeDiretorio.Name = "btDeDiretorio";
            this.btDeDiretorio.Size = new System.Drawing.Size(121, 23);
            this.btDeDiretorio.TabIndex = 9;
            this.btDeDiretorio.Text = "De um diretório";
            this.btDeDiretorio.UseVisualStyleBackColor = true;
            this.btDeDiretorio.Click += new System.EventHandler(this.btDeDiretorio_Click);
            // 
            // chkEnviaArquivo
            // 
            this.chkEnviaArquivo.AutoSize = true;
            this.chkEnviaArquivo.Location = new System.Drawing.Point(561, 321);
            this.chkEnviaArquivo.Name = "chkEnviaArquivo";
            this.chkEnviaArquivo.Size = new System.Drawing.Size(178, 18);
            this.chkEnviaArquivo.TabIndex = 8;
            this.chkEnviaArquivo.Text = "Enviar arquivo por email";
            this.chkEnviaArquivo.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(60, 321);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 14);
            this.lblStatus.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status:";
            // 
            // btDescripta
            // 
            this.btDescripta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDescripta.Location = new System.Drawing.Point(311, 295);
            this.btDescripta.Name = "btDescripta";
            this.btDescripta.Size = new System.Drawing.Size(301, 23);
            this.btDescripta.TabIndex = 5;
            this.btDescripta.Text = "Descriptografar";
            this.btDescripta.UseVisualStyleBackColor = true;
            this.btDescripta.Click += new System.EventHandler(this.btDescripta_Click);
            // 
            // btEncripta
            // 
            this.btEncripta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEncripta.Location = new System.Drawing.Point(9, 295);
            this.btEncripta.Name = "btEncripta";
            this.btEncripta.Size = new System.Drawing.Size(301, 23);
            this.btEncripta.TabIndex = 4;
            this.btEncripta.Text = "Criptografar";
            this.btEncripta.UseVisualStyleBackColor = true;
            this.btEncripta.Click += new System.EventHandler(this.btEncripta_Click);
            // 
            // btFileDialog
            // 
            this.btFileDialog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btFileDialog.Location = new System.Drawing.Point(618, 268);
            this.btFileDialog.Name = "btFileDialog";
            this.btFileDialog.Size = new System.Drawing.Size(121, 23);
            this.btFileDialog.TabIndex = 3;
            this.btFileDialog.Text = "...";
            this.btFileDialog.UseVisualStyleBackColor = true;
            this.btFileDialog.Click += new System.EventHandler(this.btFileDialog_Click);
            // 
            // tbArquivo
            // 
            this.tbArquivo.Location = new System.Drawing.Point(8, 268);
            this.tbArquivo.Name = "tbArquivo";
            this.tbArquivo.ReadOnly = true;
            this.tbArquivo.Size = new System.Drawing.Size(604, 22);
            this.tbArquivo.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaArquivo,
            this.colunaTamanho,
            this.colunaExtensao,
            this.colunaDir});
            this.dataGridView.ContextMenuStrip = this.contextMenuDataGrid;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(743, 256);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseDown);
            // 
            // colunaArquivo
            // 
            this.colunaArquivo.HeaderText = "Nome";
            this.colunaArquivo.Name = "colunaArquivo";
            // 
            // colunaTamanho
            // 
            this.colunaTamanho.HeaderText = "Tamanho";
            this.colunaTamanho.Name = "colunaTamanho";
            // 
            // colunaExtensao
            // 
            this.colunaExtensao.HeaderText = "Extensão";
            this.colunaExtensao.Name = "colunaExtensao";
            // 
            // colunaDir
            // 
            this.colunaDir.HeaderText = "Diretório";
            this.colunaDir.Name = "colunaDir";
            // 
            // contextMenuDataGrid
            // 
            this.contextMenuDataGrid.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarToolStripMenuItem,
            this.deletarTodosToolStripMenuItem});
            this.contextMenuDataGrid.Name = "contextMenuDataGrid";
            this.contextMenuDataGrid.Size = new System.Drawing.Size(161, 48);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // deletarTodosToolStripMenuItem
            // 
            this.deletarTodosToolStripMenuItem.Name = "deletarTodosToolStripMenuItem";
            this.deletarTodosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deletarTodosToolStripMenuItem.Text = "Deletar todos";
            this.deletarTodosToolStripMenuItem.Click += new System.EventHandler(this.deletarTodosToolStripMenuItem_Click);
            // 
            // progressBarFile
            // 
            this.progressBarFile.Location = new System.Drawing.Point(6, 345);
            this.progressBarFile.Name = "progressBarFile";
            this.progressBarFile.Size = new System.Drawing.Size(736, 23);
            this.progressBarFile.TabIndex = 0;
            // 
            // frmAES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 455);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AES";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAES_FormClosed);
            this.Load += new System.EventHandler(this.frmAES_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTexto2;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.RichTextBox richTexto1;
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btAcao;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.Button btDescripta;
        private System.Windows.Forms.Button btEncripta;
        private System.Windows.Forms.Button btFileDialog;
        private System.Windows.Forms.TextBox tbArquivo;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaArquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaExtensao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDir;
        private System.Windows.Forms.ProgressBar progressBarFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbModo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copiarTextoToolStripMenuItem;
        private System.Windows.Forms.Button btEnviaEmail;
        private System.Windows.Forms.ContextMenuStrip contextMenuDataGrid;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.Button btSaidaLimpa;
        private System.Windows.Forms.Button btSaidaCopia;
        private System.Windows.Forms.Button btPuroLimpa;
        private System.Windows.Forms.Button btPuroCopia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEnviaArquivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSalvarEm;
        private System.Windows.Forms.ToolStripMenuItem deletarTodosToolStripMenuItem;
        private System.Windows.Forms.Button btDeDiretorio;
        private System.Windows.Forms.Button btColar;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

