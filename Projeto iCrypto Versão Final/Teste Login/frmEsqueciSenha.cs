using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using Teste_Login.Properties;

namespace Teste_Login
{
    public partial class frmEsqueciSenha : Form
    {
        IObjectContainer banco;
        Random gerador = new Random();
        metodosDarkTheme temaEscuro = new metodosDarkTheme();
        string informacoes, novaSenha = "";
        string mensagem = "Marque esta caixa apenas se quiser utilizar" +
            "\num e-mail na qual você possui acesso, porém " +
            "\nnão está cadastrado ou se seu e-mail cadastrado" +
            "\nfor inválido, utilize outro endereço de e-mail" +
            "\nque possa acessar";
        bool DarkTheme;
        ShowMessageBox MessageBox = new ShowMessageBox();

        string caminhoBanco = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\database.db";
        public frmEsqueciSenha(bool DarkTheme)
        {
            InitializeComponent();
            cboxDarkTheme.Checked = DarkTheme;
            this.DarkTheme = DarkTheme;
            banco = Db4oFactory.OpenFile(caminhoBanco);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.ShowMessageBoxOK("warning", "Insira um endereço de e-mail", "Aviso", DarkTheme);
                return;
            }
            else
            {
                if (!cboxEmail.Checked)
                {
                    Usuario usuario = new Usuario();
                    usuario.email = txtEmail.Text;
                    IObjectSet pesquisa = banco.QueryByExample(usuario);
                    if (pesquisa.HasNext())
                    {
                        usuario = (Usuario)pesquisa.Next();
                        //Gerar senha aleatoria
                        for (int i = 0; i < 5; i++)
                        {
                            novaSenha += Convert.ToChar(gerador.Next(65,90));
                            novaSenha += gerador.Next(0, 10).ToString();
                        }

                        MD5 md5 = MD5.Create();
                        byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(novaSenha));
                        StringBuilder stringg = new StringBuilder();
                        for (int i = 0; i < hash.Length; i++)
                        {
                            stringg.Append(hash[i].ToString("x2")); // hexa
                        }
                        usuario.senha = stringg.ToString();
                        banco.Store(usuario);
                        informacoes = "Informações da conta" +
                            "\n" +
                            "\nNome    : " + usuario.nome +
                            "\nUsuario : " + usuario.usuario +
                            "\n" +
                            "\nAbaixo está sua nova senha, utilize-a para" +
                            "\nfazer login e altere-a no Menu Principal" +
                            "\n" +
                            "\nNova senha : " + novaSenha;

                    }
                    else
                    {
                        MessageBox.ShowMessageBoxOK("warning", "Este e-mail não está cadastrado", "Aviso", DarkTheme);
                        txtEmail.Focus();
                        return;
                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(txtNome.Text))
                    {
                        MessageBox.ShowMessageBoxOK("warning", "Você deve digitar um nome!", "Aviso", DarkTheme);
                        txtNome.Focus();
                        return;
                    }
                    Usuario usuario = new Usuario();
                    usuario.nome = txtNome.Text;
                    IObjectSet pesquisa = banco.QueryByExample(usuario);
                    if (pesquisa.HasNext())
                    {
                        usuario = (Usuario)pesquisa.Next();
                        //Gerar senha aleatoria
                        for (int i = 0; i < 5; i++)
                        {
                            novaSenha += Convert.ToChar(gerador.Next(65, 90));
                            novaSenha += gerador.Next(0, 10).ToString();
                        }

                        MD5 md5 = MD5.Create();
                        byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(novaSenha));
                        StringBuilder stringg = new StringBuilder();
                        for (int i = 0; i < hash.Length; i++)
                        {
                            stringg.Append(hash[i].ToString("x2")); // hexa
                        }
                        usuario.senha = stringg.ToString();
                        banco.Store(usuario);
                        informacoes = "Informações da conta" +
                            "\n" +
                            "\nNome    : " + usuario.nome +
                            "\nUsuario : " + usuario.usuario +
                            "\n" +
                            "\nAbaixo está sua nova senha, utilize-a para" +
                            "\nfazer login e altere-a no Menu Principal" +
                            "\n" +
                            "\nNova senha : " + novaSenha;
                    }
                    else
                    {
                        MessageBox.ShowMessageBoxOK("warning", "Este nome não está cadastrado", "Aviso", DarkTheme);
                        return;
                    }
                }


                try
                {
                    MailMessage email = new MailMessage();
                    email.From = new MailAddress("iCryptoCriptografia@hotmail.com");
                    email.To.Add(new MailAddress(txtEmail.Text));
                    email.Subject = "iCrypto: Informações da conta e nova senha";
                    email.Body = informacoes;
                    SmtpClient cliente = new SmtpClient("smtp.live.com", 587);
                    using (cliente)
                    {
                        cliente.Credentials = new System.Net.NetworkCredential("iCryptoCriptografia@hotmail.com", "projeto1osemestre2020criptografia");
                        cliente.EnableSsl = true;
                        cliente.Send(email);
                    }
                    MessageBox.ShowMessageBoxOK("warning", "E-mail enviado com sucesso!", "Aviso", DarkTheme);
                    banco.Close();
                    this.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.ShowMessageBoxOK("null", erro.Message, "", DarkTheme);
                }
            }
        }

        private void frmEsqueciSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            banco.Close();
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnEnviar.Focus();
            }
        }

        private void picHelp_MouseEnter(object sender, EventArgs e)
        {
            ttpMensagem.Show(mensagem, picHelp);
        }

        private void picHelp_MouseLeave(object sender, EventArgs e)
        {
            ttpMensagem.Hide(picHelp);
        }

        private void mudarTextBoxes(bool dark)
        {
            temaEscuro.darkTextBox(txtEmail, dark);
            temaEscuro.darkTextBox(txtNome, dark);
        }

        private void cboxDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxDarkTheme.Checked)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                mudarTextBoxes(true);
                temaEscuro.darkLogo(picLogo, true);
                picHelp.Image = Resources.DarkInformation;
                temaEscuro.darkToolTip(ttpMensagem, true);
                DarkTheme = true;
            }
            else
            {
                this.BackColor = SystemColors.ActiveCaption;
                mudarTextBoxes(false);
                temaEscuro.darkLogo(picLogo, false);
                picHelp.Image = Resources.Information;
                temaEscuro.darkToolTip(ttpMensagem, false);
                DarkTheme = false;
            }
        }

        public bool TemaEscuro()
        {
            return DarkTheme;
        }

        private void cboxEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxEmail.Checked)
            {
                lbNome.Enabled = true;
                txtNome.Enabled = true;
            }
            else
            {
                lbNome.Enabled = false;
                txtNome.Enabled = false;
                txtNome.ResetText();
            }
        }
    }
}
