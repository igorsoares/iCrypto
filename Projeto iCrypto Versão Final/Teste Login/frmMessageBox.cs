using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_Login.Properties;

namespace Teste_Login
{
    public partial class frmMessageBox : Form
    {
        bool YesNo = false;
        string simNao = "closed";
        public frmMessageBox(string icon, string texto, string titulo, bool DarkTheme, bool botaoYesNo)
        {
            InitializeComponent();

            btn2.Hide();
            btn2.Enabled = false;

            if (botaoYesNo)
            {
                btn1.Text = "No";
                btn2.Text = "Yes";
                btn2.Show();
                btn2.Enabled = true;
                YesNo = true;
            }

            if (DarkTheme)
            {
                this.BackColor = SystemColors.ControlDarkDark;
            }

            switch (icon.ToLower())
            {
                case "warning":
                    picIcon.Image = DarkTheme ? Resources.DarkWarning : Resources.Warning; 
                    break;
            } 

            lbTexto.Text = texto;
            this.Text = titulo;

            if (lbTexto.Width > 178)
            {
                this.Width += lbTexto.Width - 178;
            }

            if (lbTexto.Height > 13)
            {
                this.Height += lbTexto.Height - 13;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!YesNo)
            {
                this.Close();
            }
            else
            {
                simNao = "sim";
                this.Close();
            }
        }

        public string retornaYesNo()
        {
            return simNao;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            simNao = "nao";
            this.Close();
        }
    }
}
