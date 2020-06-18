namespace Teste_Login
{
    partial class frmGerarEImportarChaveRSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerarEImportarChaveRSA));
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.rbChavePublica = new System.Windows.Forms.RadioButton();
            this.rbChavePrivada = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Deseja importar uma das chaves geradas?";
            // 
            // btnImportar
            // 
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportar.Location = new System.Drawing.Point(144, 46);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnNao
            // 
            this.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNao.Location = new System.Drawing.Point(225, 46);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(75, 23);
            this.btnNao.TabIndex = 3;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // rbChavePublica
            // 
            this.rbChavePublica.AutoSize = true;
            this.rbChavePublica.Location = new System.Drawing.Point(15, 37);
            this.rbChavePublica.Name = "rbChavePublica";
            this.rbChavePublica.Size = new System.Drawing.Size(106, 17);
            this.rbChavePublica.TabIndex = 4;
            this.rbChavePublica.TabStop = true;
            this.rbChavePublica.Text = "Chave Pública";
            this.rbChavePublica.UseVisualStyleBackColor = true;
            // 
            // rbChavePrivada
            // 
            this.rbChavePrivada.AutoSize = true;
            this.rbChavePrivada.Location = new System.Drawing.Point(15, 60);
            this.rbChavePrivada.Name = "rbChavePrivada";
            this.rbChavePrivada.Size = new System.Drawing.Size(109, 17);
            this.rbChavePrivada.TabIndex = 5;
            this.rbChavePrivada.TabStop = true;
            this.rbChavePrivada.Text = "Chave Privada";
            this.rbChavePrivada.UseVisualStyleBackColor = true;
            // 
            // frmGerarEImportarChaveRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(312, 91);
            this.Controls.Add(this.rbChavePrivada);
            this.Controls.Add(this.rbChavePublica);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerarEImportarChaveRSA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar chave gerada?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.RadioButton rbChavePublica;
        private System.Windows.Forms.RadioButton rbChavePrivada;
    }
}