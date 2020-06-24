using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_Login.Properties;

namespace Teste_Login
{
    class metodosEDarkTheme
    {
        ShowMessageBox MessageBox = new ShowMessageBox();
        string respostaGmail, retornoGmail;
        string caminhoBanco = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\database.db";
        public void darkDataGrid(DataGridView dataGrid)
        {
            dataGrid.BackgroundColor = SystemColors.ControlDarkDark;
            dataGrid.DefaultCellStyle.BackColor = SystemColors.ActiveBorder;
            dataGrid.DefaultCellStyle.ForeColor = Color.Black;
            dataGrid.DefaultCellStyle.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGrid.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGrid.RowHeadersDefaultCellStyle.BackColor = Color.White;
            dataGrid.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGrid.RowHeadersDefaultCellStyle.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGrid.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
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

        public void darkContextMenuStrip(ContextMenuStrip menu)
        {
            menu.BackColor = SystemColors.ControlDark;
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

        public void darkRichTextBox(RichTextBox textBox)
        {
            textBox.BackColor = SystemColors.ControlDark;
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

        public void darkToolTip(ToolTip ToolTip, bool DarkTheme)
        {
            if (DarkTheme)
            {
                ToolTip.BackColor = SystemColors.ControlDarkDark;
                ToolTip.ForeColor = SystemColors.ScrollBar;
            }
            else
            {
                ToolTip.BackColor = Color.White;
                ToolTip.ForeColor = Color.Black;
            }
        }

        public void enviarEmail(string servidor, int porta, bool SMTP, bool SSL, MailMessage conteudoEmail, string cred_Email, string cred_Password, bool DarkTheme)
        {
            SmtpClient cliente = new SmtpClient(servidor, porta);
            using (cliente)
            {
                cliente.Credentials = new System.Net.NetworkCredential(cred_Email, cred_Password);
                cliente.EnableSsl = true;

                if (SMTP)
                {
                    try
                    {
                        cliente.Send(conteudoEmail);
                        MessageBox.ShowMessageBoxOK("correct", "E-mail enviado com sucesso!", "Aviso", DarkTheme);
                        return;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }

                if (servidor.Equals("smtp.gmail.com"))
                {
                    frmMenosSeguroGmail teste = new frmMenosSeguroGmail(DarkTheme);
                    teste.ShowDialog();
                    respostaGmail = teste.retornoString();
                    if (respostaGmail.Equals("sim"))
                    {
                        Process.Start("https://myaccount.google.com/lesssecureapps");
                        System.Threading.Thread.Sleep(1000);
                        retornoGmail = MessageBox.ShowMessageBoxYesNo("question", "A opção menos segura foi ativada?", "", DarkTheme);
                        if (retornoGmail.Equals("sim"))
                        {
                            try
                            {
                                cliente.Send(conteudoEmail);
                                MessageBox.ShowMessageBoxOK("correct", "E-mail enviado com sucesso!", "Aviso", DarkTheme);
                                return;
                            }
                            catch
                            {
                                throw;
                            }
                        }
                        else
                        {
                            MessageBox.ShowMessageBoxOK("information", "Não será possível enviar o e-mail", "", DarkTheme);
                            return;
                        }
                    }
                    else if (respostaGmail.Equals("nao"))
                    {
                        MessageBox.ShowMessageBoxOK("information", "Não será possível enviar o e-mail", "", DarkTheme);
                        return;
                    }
                    else if (respostaGmail.Equals("ativado"))
                    {
                        try
                        {
                            cliente.Send(conteudoEmail);
                            MessageBox.ShowMessageBoxOK("correct", "E-mail enviado com sucesso!", "Aviso", DarkTheme);
                            return;
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
                else
                {
                    try
                    {
                        cliente.Send(conteudoEmail);
                        MessageBox.ShowMessageBoxOK("correct", "E-mail enviado com sucesso!", "Aviso", DarkTheme);
                        return;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public void abreFechaBanco(IObjectContainer banco)
        {
            try
            {
                banco = Db4oFactory.OpenFile(caminhoBanco);
            }
            catch
            {

            }
            finally
            {
                banco.Close();
            }
        }
    }
}
