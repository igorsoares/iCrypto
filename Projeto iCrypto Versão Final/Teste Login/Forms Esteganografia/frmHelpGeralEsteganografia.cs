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
    public partial class frmHelpGeralEsteganografia : Form
    {
        public frmHelpGeralEsteganografia(bool DarkTheme)
        {
            InitializeComponent();
            if (DarkTheme)
            {
                this.BackColor = SystemColors.ControlDarkDark;
            }
        }
    }
}
