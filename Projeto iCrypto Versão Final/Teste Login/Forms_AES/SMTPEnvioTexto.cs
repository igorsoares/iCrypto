using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Collections;
using System.IO;
using Teste_Login;
using Db4objects.Db4o;

namespace Projeto_AES
{
    public partial class SMTPEnvioTexto : Form
    {
        string conteudo_enviar = "";
        string fromMail = "";
        string password = "";
        Usuario usuario;
        SmtpClient cliente;
        ArrayList arquivos_email;
        bool DarkTheme =  false;
        metodosDarkTheme temaEscuro = new metodosDarkTheme();
        ShowMessageBox MessageBox = new ShowMessageBox();

        public SMTPEnvioTexto(string conteudo, ArrayList arquivos_email, Usuario usuario, bool DarkTheme)
        {
            InitializeComponent();

            if (DarkTheme)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                this.DarkTheme = true;
                temaEscuro.darkDataGrid(dataGridViewAnexo);
                temaEscuro.darkTextBox(tbEmail, true);
                temaEscuro.darkTextBox(tbEmailTo, true);
                temaEscuro.darkTextBox(tbPorta, true);
                temaEscuro.darkTextBox(tbSenha, true);
                temaEscuro.darkTextBox(tbSmtp, true);
                temaEscuro.darkRichTextBox(richAssunto);
                temaEscuro.darkRichTextBox(richConteudo);
            }

            conteudo_enviar = conteudo;
            this.arquivos_email = arquivos_email;
            this.usuario = usuario;
            SmtpDefault();
        }
        private void SmtpDefault()
        {
            try
            {
                if (usuario.servidorSMTP.emailSMTP.Length > 0)
                {
                    // Se o email tem tamanho maior que 0, então o resto das propriedads
                    // estão populados
                    tbEmail.Text = usuario.servidorSMTP.emailSMTP;
                    tbPorta.Text = usuario.servidorSMTP.portaSMTP.ToString();
                    tbSenha.Text = usuario.servidorSMTP.senhaSMTP;
                    tbSmtp.Text = usuario.servidorSMTP.servidorSMTP;

                }
            }
            catch (Exception)
            {
                // se cair aqui, nao existe configuração configurada para email
                return;

            }

        }
        private void SMTPEnvioTexto_Load(object sender, EventArgs e)
        {
            richConteudo.Text = conteudo_enviar;

            if (arquivos_email.Count > 0)
            {

                foreach (string arquivo in arquivos_email)
                {
                    FileInfo infos = new FileInfo(arquivo);
                    dataGridViewAnexo.Rows.Add(arquivo.Split('\\')[arquivo.Split('\\').Length - 1], infos.Length, infos.Extension, infos.Directory);
                }
            }

        }
        private bool VerificaEmail()
        {
            char[] arrayEmail = tbEmail.Text.ToCharArray();
            bool verifyEmail = false;
            foreach (char i in arrayEmail)
            {
                if ('@' == i)
                {
                    verifyEmail = true;
                }
            }
            if (!verifyEmail)
            {
                MessageBox.ShowMessageBoxOK("erro", "Insira um e-mail válido", "Erro", DarkTheme);
                tbEmail.Focus();
                return false;
            }
            return true;
        }

        private void PassaArgumento(SmtpClient obj)
        {
            cliente = obj;
        }
        private void btEnvia_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(tbEmail.Text))
                {
                    MessageBox.ShowMessageBoxOK("error", "Insira um e-mail válido", "Erro", DarkTheme);
                    tbEmail.Focus();
                    return;
                }
                if (!tbEmail.Text.Split('@')[1].Contains('.'))
                {
                    MessageBox.ShowMessageBoxOK("error", "Insira um e-mail com domínio válido.", "Erro", DarkTheme);
                    tbEmail.Focus();
                    return;
                }

                if (String.IsNullOrEmpty(tbSenha.Text))
                {
                    MessageBox.ShowMessageBoxOK("error", "Insira uma senha", "Erro", DarkTheme);
                    tbSenha.Focus();
                    return;
                }
                if (!VerificaEmail())
                    return;
                // CASO NAO TENHA NADA DE ERRADO FAÇA O LOGIN..
                fromMail = tbEmail.Text;
                string password = tbSenha.Text;
                string servidor = tbSmtp.Text;
                if (servidor.Length <= 0)
                {
                    MessageBox.ShowMessageBoxOK("error", "Digite um servidor SMTP", "Erro", DarkTheme);
                    return;
                }
                int porta = 0;
                if (String.IsNullOrEmpty(tbPorta.Text.ToString()))
                {
                    MessageBox.ShowMessageBoxOK("error", "Campo de porta é obrigatório.", "Erro", DarkTheme);
                    return;
                }
                try
                {
                    porta = Convert.ToInt32(tbPorta.Text);

                }
                catch (FormatException)
                {
                    MessageBox.ShowMessageBoxOK("error", "Porta só deve ser digitada com números inteiros", "Erro", DarkTheme);
                    return;
                }


                var Login = new SmtpClient(servidor, porta);
                PassaArgumento(Login);

                // Faz login
                Login.UseDefaultCredentials = false;
                Login.Credentials = new NetworkCredential(fromMail, password);

                if (tbEmailTo.Text.Length == 0)
                {
                    MessageBox.ShowMessageBoxOK("error", "Digite um email destinatário", "Erro", DarkTheme);
                    return;
                }

                MailMessage messageMail = new MailMessage();
                messageMail.From = new MailAddress(fromMail);
                messageMail.To.Add(new MailAddress(tbEmailTo.Text));
                messageMail.Body = richConteudo.Text;
                messageMail.Subject = richAssunto.Text.Length > 0 ? messageMail.Subject = richAssunto.Text : messageMail.Subject = "";

                // Verifica se há anexos disponveis
                // Se houver, faça um Attachment e verifique o tamanho total deles.
                if (dataGridViewAnexo.Rows.Count > 1)
                {
                    long tamanho_arquivos = 0;
                    for (int i = 0; i < dataGridViewAnexo.Rows.Count - 1; i++)
                    {

                        string anexo = dataGridViewAnexo.Rows[i].Cells[0].Value.ToString();
                        string dir = dataGridViewAnexo.Rows[i].Cells[3].Value.ToString();
                        dir = dir + "\\" + anexo;
                        Attachment attach_anexo = new Attachment(dir);
                        messageMail.Attachments.Add(attach_anexo);

                        FileInfo tamanho = new FileInfo(dir);
                        tamanho_arquivos += tamanho.Length;

                    }
                    if (tamanho_arquivos > 26214400L)
                    {
                        System.Windows.Forms.MessageBox.Show("Os arquivos anexados resultam em um espaço maior que" +
                            " 25MB. Email não será enviado.", "Erro", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                }




                cliente.EnableSsl = true; // + segurança, envio criptografado


                try
                {

                    if (tbEmail.Text.Contains("@gmail"))
                    {

                        frmMenosSeguroGmail obj = new frmMenosSeguroGmail(DarkTheme);
                        obj.ShowDialog();
                        string ret = obj.retornoString();
                        if (ret.Equals("sim"))
                        {
                            System.Diagnostics.Process.Start("https://myaccount.google.com/lesssecureapps");
                            System.Threading.Thread.Sleep(1000);
                            DialogResult ativou = System.Windows.Forms.MessageBox.Show("A opção menos segura foi ativada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (ativou.Equals(DialogResult.Yes))
                            {
                                cliente.Send(messageMail);
                                System.Windows.Forms.MessageBox.Show("E-mail enviado para " + tbEmailTo.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("Não será possível enviar o e-mail", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        else if (ret.Equals("ativado"))
                        {
                            try
                            {
                                cliente.Send(messageMail);
                                System.Windows.Forms.MessageBox.Show("E-mail enviado para " + tbEmailTo.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show("O envio falhou!" +
                    "\n" +
                    "\nCertifique que o e-mail está correto e é válido" +
                    "\nCertifique que a senha está correta (Deve ser a senha do e-mail e não do iCrypto)" +
                    "\nCaso seja gmail, certique que a opção 'Acesso a apps menos seguros' está ativada", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Não será possível enviar o e-mail", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    else
                    {
                        cliente.Send(messageMail);
                        System.Windows.Forms.MessageBox.Show("E-mail enviado para " + tbEmailTo.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

                catch (Exception ex)
                {
                    return;
                }

                //cliente.Send(messageMail);
                //MessageBox.Show("E-mail enviado para " + tbEmailTo.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpException ex)
            {
                System.Windows.Forms.MessageBox.Show("Informações de configurações erradas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (FormatException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("O envio falhou!" +
                    "\n" +
                    "\nCertifique que o e-mail está correto e é válido" +
                    "\nCertifique que a senha está correta (Deve ser a senha do e-mail e não do iCrypto)" +
                    "\nCaso seja gmail, certique que a opção 'Acesso a apps menos seguros' está ativada", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void rbGmail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btRemoverAnexo_Click(object sender, EventArgs e)
        {
            try
            {
                //var arquivoSelecionado = lbArquivos.SelectedItem;
                //lbArquivos.Items.Remove(arquivoSelecionado);
                if (dataGridViewAnexo.SelectedRows.Count == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Nenhum arquivo foi selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    foreach (DataGridViewRow linha in dataGridViewAnexo.SelectedRows)
                    {
                        dataGridViewAnexo.Rows.Remove(linha);

                    }
                }


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
        }
        private bool VerificaMBArquivos(ArrayList arquivos_email)
        {
            long espaco = 0;
            long maximo = 26214400;

            foreach (string arquivo in arquivos_email)
            {
                FileInfo informacoes = new FileInfo(arquivo);
                espaco += informacoes.Length;
            }
            if (espaco > maximo)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerificaExistencia(string nome_arquivo)
        {
            int nlinhas = dataGridViewAnexo.Rows.Count;
            // pegue a ultima ocorrencia do split do filename
            nome_arquivo = nome_arquivo.Split('\\')[nome_arquivo.Split('\\').Length - 1];
            ArrayList nomes_arquivos_dt = new ArrayList();
            for (int i = 0; i < nlinhas - 1; i++)
            {
                nomes_arquivos_dt.Add(dataGridViewAnexo.Rows[i].Cells[0].Value.ToString());

            }
            foreach (string indice in nomes_arquivos_dt)
            {
                if (indice.Equals(nome_arquivo))
                    return true;
            }

            return false;
        }
        private void btAnexa_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Todos|*.*|AES|*.aes";
                openDialog.Title = "Selecione um arquivo";
                openDialog.ShowDialog();
                string nome_arquivo = openDialog.FileName;

                if (dataGridViewAnexo.Rows.Count > 1)
                {
                    if (VerificaExistencia(nome_arquivo))
                        return; // SE EXISTE , NAO FACA NADA.
                }

                if (nome_arquivo.EndsWith(".exe"))
                {
                    System.Windows.Forms.MessageBox.Show("Arquivos executáveis não podem ser enviados.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Verifica se o arquivo selecionado é maior que 25MB
                ArrayList arquivo = new ArrayList();
                arquivo.Add(nome_arquivo);
                if (!VerificaMBArquivos(arquivo))
                {
                    System.Windows.Forms.MessageBox.Show(nome_arquivo.Split('\\')[nome_arquivo.Split('\\').Length - 1] + " maior que 25MB. Impossível de ser enviado", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FileInfo tmp = new FileInfo(nome_arquivo);
                dataGridViewAnexo.Rows.Add(nome_arquivo.Split('\\')[nome_arquivo.Split('\\').Length - 1], tmp.Length, tmp.Extension, tmp.Directory);


            }
            catch (Exception ex)
            {
                return;
            }


        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            if (email.Contains("@gmail.com"))
            {
                tbSmtp.Text = "smtp.gmail.com";
                tbPorta.Text = "587";
            }
            else if (email.Contains("@outlook") || email.Contains("@live") || email.Contains("@hotmail"))
            {
                tbSmtp.Text = "smtp.outlook.com";
                tbPorta.Text = "587";
            }
            else
            {
                
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkMostra.Checked)
            {
                string senha = tbSenha.Text;
                tbSenha.PasswordChar = '\0'; //NADA
                tbSenha.Text = senha;
                cbkMostra.Text = "Ocultar";
            }
            else
            {
                string senha = tbSenha.Text;
                tbSenha.PasswordChar = '*';
                tbSenha.Text = senha;
                cbkMostra.Text = "Mostrar";
            }
        }

        private void lbArquivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
