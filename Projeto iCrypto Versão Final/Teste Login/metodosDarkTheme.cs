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

        public void darkTextBox(TextBox textBox, bool dark)
        {
            if (dark)
                textBox.BackColor = SystemColors.ControlDark;
            else
                textBox.BackColor = Color.White;
        }

        public void darkComboBox(ComboBox comboBox)
        {
            comboBox.BackColor = SystemColors.ScrollBar;
        }

        public void darkLogo(PictureBox logo, bool dark)
        {
            if (dark)
                logo.Image = Resources.logo2;
            else
                logo.Image = Resources.logo1;
        }

        public void darkButton(Button botao)
        {
            botao.BackColor = SystemColors.ControlDarkDark;
        }

        public void darkMenuStrip(MenuStrip menu, bool dark)
        {
            if (dark)
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
            else
            {
                menu.BackColor = Color.White;
                foreach (ToolStripMenuItem item in menu.Items)
                {
                    item.ForeColor = Color.Black;
                    item.BackColor = Color.White;
                    foreach (ToolStripDropDownItem teste in item.DropDownItems)
                    {
                        teste.BackColor = Color.White;
                    }

                }
            }
        }

        public void darkTabControl(TabControl menu, bool dark)
        {
            foreach (TabPage pagina in menu.TabPages)
            {
                if (dark)
                    pagina.BackColor = SystemColors.ControlDarkDark;
                else
                    pagina.BackColor = SystemColors.ActiveCaption;
            }
        }
    }
}
