using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Login
{
    
    class ShowMessageBox
    {
        frmMessageBox MessageBox;
        public void ShowMessageBoxOK(string icon, string texto, string titulo, bool DarkTheme)
        {
            MessageBox = new frmMessageBox(icon, texto, titulo, DarkTheme, false);
            MessageBox.ShowDialog();
        }

        public string ShowMessageBoxYesNo(string icon, string texto, string titulo, bool DarkTheme)
        {
            MessageBox = new frmMessageBox(icon, texto, titulo, DarkTheme, true);
            MessageBox.ShowDialog();
            return MessageBox.retornaYesNo();
        }
    }
}
