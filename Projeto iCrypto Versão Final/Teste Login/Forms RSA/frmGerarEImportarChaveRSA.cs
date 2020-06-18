using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Login
{
    public partial class frmGerarEImportarChaveRSA : Form
    {
        string chaveImportar = string.Empty;
        public frmGerarEImportarChaveRSA(bool DarkTheme)
        {
            InitializeComponent();
            if (DarkTheme)
            {
                this.BackColor = SystemColors.ControlDarkDark;
            }
        }

        public string retornarTipoChave()
        {
            return chaveImportar;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (rbChavePrivada.Checked)
            {
                chaveImportar = "Privada";
                this.Close();
            }
            else if (rbChavePublica.Checked)
            {
                chaveImportar = "Publica";
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um tipo de chave para importar", "Nenhuma chave selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            chaveImportar = "nao";
            this.Close();
        }
    }
}
