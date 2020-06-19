using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Login.Forms_AES
{
    public partial class SobreAES : Form
    {
        public SobreAES(bool DarkTheme)
        {
            InitializeComponent();
            if (DarkTheme)
            {
                this.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pplware.sapo.pt/tutoriais/networking/criptografia-simetrica-e-assimetrica-sabe-a-diferenca/");
        }

        private void SobreAES_Load(object sender, EventArgs e)
        {
            
        }
    }
}
