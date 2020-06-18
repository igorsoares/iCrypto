using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_Login.Properties;

namespace Teste_Login
{
    class metodosDarkTheme
    {
        public void darkDataGrid(DataGridView dataGrid)
        {
            dataGrid.BackgroundColor = SystemColors.ControlDarkDark;
            dataGrid.DefaultCellStyle.BackColor = SystemColors.ActiveBorder;
            dataGrid.DefaultCellStyle.ForeColor = Color.Black;
            dataGrid.DefaultCellStyle.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGrid.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public void darkTextBox(TextBox textBox)
        {
            textBox.BackColor = SystemColors.ControlDark;
        }

        public void darkComboBox(ComboBox comboBox)
        {
            comboBox.BackColor = SystemColors.ScrollBar;
        }

        public void darkLogo(PictureBox logo)
        {
            logo.Image = Resources.logo2;
        }

        public void darkMenuStrip(MenuStrip menu)
        {
            menu.BackColor = Color.Black;
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.ForeColor = SystemColors.AppWorkspace;
                item.BackColor = Color.Black;
                foreach (ToolStripDropDownItem teste in item.DropDownItems)
                {
                    teste.BackColor = SystemColors.ControlDark;
                }
                
            }
            
        }
    }
}
