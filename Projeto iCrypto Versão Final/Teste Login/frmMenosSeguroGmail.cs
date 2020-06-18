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
    public partial class frmMenosSeguroGmail : Form
    {
        string retorno = string.Empty;
        public frmMenosSeguroGmail()
        {
            InitializeComponent();
        }


        private void btnSim_Click(object sender, EventArgs e)
        {
            retorno = "sim";
            this.Close();
        }

        public string retornoString()
        {
            return retorno;
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            retorno = "nao";
            this.Close();
        }

        private void btnAtivado_Click(object sender, EventArgs e)
        {
            retorno = "ativado";
            this.Close();
        }
    }
}
