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
    public partial class HelpAbrirWinRarEsteganografia : Form
    {
        public HelpAbrirWinRarEsteganografia(bool DarkTheme)
        {
            InitializeComponent();
            if (DarkTheme)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                picLogo.Image = Resources.logo2;
            }
        }
    }
}
