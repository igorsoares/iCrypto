using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Login
{
    public partial class EnviarMensagem : Form
    {
        string textoSaida;
        Usuario usuario;
        string servidor, respostaGmail;
        int porta;
        string[] enderecoEmail;
        bool DarkTheme = false;

        public EnviarMensagem(string textoSaida, Usuario usuarioLogado, bool DarkTheme)
        {
            InitializeComponent();
            this.textoSaida = textoSaida;
            usuario = usuarioLogado;

            if (DarkTheme)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                //TextBoxes
                txtAssunto.BackColor = SystemColors.ControlDark;
                txtDestinatario.BackColor = SystemColors.ControlDark;
                txtEmail.BackColor = SystemColors.ControlDark;
                txtMensagem.BackColor = SystemColors.ControlDark;
                txtSenha.BackColor = SystemColors.ControlDark;
                this.DarkTheme = true;
            }
        }

        private void rbConta_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Text = usuario.email;
            txtEmail.ReadOnly = true;
            txtSenha.ResetText();
            txtSenha.ReadOnly = false;
            gboxLoginEmail.Enabled = true;
            cboxMostrarSenha.Enabled = true;
            gboxConteudoEmail.Enabled = true;
        }

        private void rbOutro_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.ResetText();
            txtSenha.ResetText();
            gboxLoginEmail.Enabled = true;
            cboxMostrarSenha.Enabled = true;
            gboxConteudoEmail.Enabled = true;
            txtEmail.ReadOnly = false;
            txtSenha.ReadOnly = false;
        }

        private void rbSMTP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSMTP.Checked)
            {
                try
                {
                    txtEmail.ReadOnly = true;
                    txtSenha.ReadOnly = true;
                    txtEmail.Text = usuario.servidorSMTP.emailSMTP;
                    txtSenha.Text = usuario.servidorSMTP.senhaSMTP;
                    gboxConteudoEmail.Enabled = true;
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Certifique-se de que você possui um " +
                        "\nservidor SMTP personalizado em seu cadastro", "Um erro inesperado aconteceu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxMostrarSenha.Checked)
            {
                txtSenha.PasswordChar = char.MinValue;
                cboxMostrarSenha.Text = "Ocultar";
            }
            else
            {
                txtSenha.PasswordChar = '*';
                cboxMostrarSenha.Text = "Mostrar";
            }
        }

        private bool validarCamposEmail()
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                System.Windows.Forms.MessageBox.Show("Nenhum endereço de e-mail foi inserido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtSenha.Text))
            {
                System.Windows.Forms.MessageBox.Show("A senha do e-mail é necessária!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtDestinatario.Text))
            {
                System.Windows.Forms.MessageBox.Show("Nenhum endereço de e-mail destinatário foi inserido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDestinatario.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCamposEmail())
                {
                    if (rbSMTP.Checked)
                    {
                        servidor = usuario.servidorSMTP.servidorSMTP;
                        porta = usuario.servidorSMTP.portaSMTP;
                        goto enviarEmail;
                    }
                    enderecoEmail = txtEmail.Text.Split('@');
                    if (enderecoEmail[1].Equals("gmail.com"))
                    {
                        servidor = "smtp.gmail.com";
                        porta = 587;
                    }
                    else if (enderecoEmail[1].Equals("hotmail.com") || enderecoEmail[1].Equals("outlook.com") || enderecoEmail[1].Equals("live.com"))
                    {
                        servidor = "smtp.live.com";
                        porta = 587;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Não temos suporte para este tipo de servidor." +
                            "\nTente utilizar um email do google (gmail), hotmail, live.com ou" +
                            "\noutlook e confira se o e-mail está correto", "Servidor sem suporte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                enviarEmail:
                    MailMessage email = new MailMessage();
                    email.From = new MailAddress(txtEmail.Text);
                    email.To.Add(new MailAddress(txtDestinatario.Text));
                    email.Subject = txtAssunto.Text;
                    email.Body = txtMensagem.Text;
                    email.Body += "\n" +
                        "\n" +
                        "" + textoSaida;



                    SmtpClient cliente = new SmtpClient(servidor, porta);
                    using (cliente)
                    {
                        cliente.Credentials = new System.Net.NetworkCredential(txtEmail.Text, txtSenha.Text);
                        cliente.EnableSsl = true;

                        if (rbSMTP.Checked)
                        {
                            try
                            {
                                cliente.Send(email);
                                System.Windows.Forms.MessageBox.Show("E-mail enviado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }

                        if (enderecoEmail[1].Equals("gmail.com"))
                        {
                            frmMenosSeguroGmail teste = new frmMenosSeguroGmail(DarkTheme);
                            teste.ShowDialog();
                            respostaGmail = teste.retornoString();
                            if (respostaGmail.Equals("sim"))
                            {
                                Process.Start("https://myaccount.google.com/lesssecureapps");
                                System.Threading.Thread.Sleep(1000);
                                DialogResult ativou = System.Windows.Forms.MessageBox.Show("A opção menos segura foi ativada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (ativou.Equals(DialogResult.Yes))
                                {
                                    cliente.Send(email);
                                    System.Windows.Forms.MessageBox.Show("E-mail enviado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                else
                                {
                                    System.Windows.Forms.MessageBox.Show("Não será possível enviar o e-mail", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                            else if (respostaGmail.Equals("nao"))
                            {
                                System.Windows.Forms.MessageBox.Show("Não será possível enviar o e-mail", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else if (respostaGmail.Equals("ativado"))
                            {
                                try
                                {
                                    cliente.Send(email);
                                    System.Windows.Forms.MessageBox.Show("E-mail enviado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                catch (Exception)
                                {
                                    System.Windows.Forms.MessageBox.Show("O envio falhou!" +
                    "\n" +
                    "\nCertifique que o e-mail está correto e é válido" +
                    "\nCertifique que a senha está correta (Deve ser a senha do e-mail e não do iCrypto)" +
                    "\nCaso seja gmail, certique que a opção 'Acesso a apps menos seguros' está ativada", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                        else
                        {
                            try
                            {
                                cliente.Send(email);
                                System.Windows.Forms.MessageBox.Show("E-mail enviado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("O envio falhou!" +
                    "\n" +
                    "\nCertifique que o e-mail está correto e é válido" +
                    "\nCertifique que a senha está correta (Deve ser a senha do e-mail e não do iCrypto)" +
                    "\nCaso seja gmail, certique que a opção 'Acesso a apps menos seguros' está ativada", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
