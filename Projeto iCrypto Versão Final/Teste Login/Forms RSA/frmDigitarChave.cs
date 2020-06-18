using RSA_versao_final;
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
    public partial class frmDigitarChave : Form
    {
        public bool fechou { get; set; }
        bool ok;
        public frmDigitarChave(bool DarkTheme)
        {
            InitializeComponent();
            if (DarkTheme)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                txtChaveDigitada.BackColor = SystemColors.ControlDark;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ok = true;
            this.Close();
        }

        private void frmDigitarChave_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ok)
                fechou = false;
            else
                fechou = true;
        }
    }
}
