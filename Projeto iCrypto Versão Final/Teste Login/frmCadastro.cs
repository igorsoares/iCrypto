using Db4objects.Db4o;
using Db4objects.Db4o.Internal.Marshall;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Teste_Login.Properties;

namespace Teste_Login
{
    public partial class frmCadastro : Form
    {
        IObjectContainer banco;
        string caracteres, numeros;
        bool letra, validar, DarkTheme;
        int[] algarismos = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string mensagemSenha = "** A senha deve conter 4 ou 9 letras/símbolos" +
            "\n** A senha deve conter ao menos um algarismo qualquer" +
            "\n** Na validação, sua senha será dividida entre seus caracteres e números, " +
            "\nde forma que o módulo do número resultante dos caracteres seja menor que" +
            "\nos números digitados" +
            "\n" +
            "\n Exemplo:" +
            "\n Senha: A1B2C3D4" +
            "\n ABCD = |-2| = 2" +
            "\n 1234 > 2, Logo a senha é válida";
        string mensagemSMTP = "Este software possui a funcionalidade de enviar e-mails diretamente pelo sistema." +
                            "\nPara isso é necessário utilizar um servidor SMTP. Selecione esta caixa somente se" +
                            "\nvocê já utiliza um servidor SMTP próprio e preencha o campo ao lado para configurá-lo." +
                            "\n" +
                            "\nCaso não utilize nenhum servidor SMTP pessoal, nosso sistema lhe oferecerá mecanismos" +
                            "\nautomáticos para que você também possa utilizar esta função.";

        string caminhoBanco = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\database.db";
        public frmCadastro(bool DarkTheme)
        {
            InitializeComponent();
            cboxDarkTheme.Checked = DarkTheme;
            this.DarkTheme = DarkTheme;
            gboxSMTP.Enabled = false;
            txtNome.Focus();
            banco = Db4oFactory.OpenFile(caminhoBanco);
        }

        private bool validarSMTP()
        {
            if (cboxSMTP.Checked)
            {
                if (String.IsNullOrEmpty(txtEmailSMTP.Text))
                {
                    MessageBox.Show("O e-mail do SMTP é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                    txtEmailSMTP.Focus();
                    return false;
                }
                else if (String.IsNullOrEmpty(txtSenhaSMTP.Text))
                {
                    MessageBox.Show("A senha do e-mail SMTP é obrigatória", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                    txtSenhaSMTP.Focus();
                    return false;
                }
                else if (String.IsNullOrEmpty(txtServidor.Text))
                {
                    MessageBox.Show("O servidor SMTP é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                    txtServidor.Focus();
                    return false;
                }
                else if (String.IsNullOrEmpty(txtPorta.Text))
                {
                    MessageBox.Show("A porta do servidor SMTP é obrigatória", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                    txtPorta.Focus();
                    return false;
                }
                else
                    return true;
            }
            else
                return true;
        }

        private bool validarTamanhoSenha()
        {
            caracteres = null;
            numeros = null;

            for (int posicao = 0; posicao < txtSenha.Text.Length; posicao++)
            {
                letra = true;
                foreach (int algarismo in algarismos)
                {
                    if (algarismo.ToString().Equals(txtSenha.Text[posicao].ToString()))
                    {
                        numeros += txtSenha.Text[posicao];
                        letra = false;
                    }
                }

                if (letra)
                    caracteres += txtSenha.Text[posicao];
            }

            if (String.IsNullOrEmpty(caracteres))
            {
                MessageBox.Show("A senha deve conter pelo menos 4 caracteres!", "Senha inválida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }
            else if (caracteres.Length != 4 && caracteres.Length != 9)
            {
                MessageBox.Show("A senha deve conter 4 ou 9 caracteres!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }
            else if (numeros == null)
            {
                MessageBox.Show("A senha deve conter pelo menos um número!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validarCampos()
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("O nome é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("O e-mail é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                txtEmail.Focus();
                return false;
            }
            else if (!txtEmail.Text.Contains('@') || !txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("O e-mail digitado é inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                txtEmail.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("O usuário é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }
            else if (txtUsuario.Text.Length < 8)
            {
                MessageBox.Show("O usuário deve conter 8 ou mais caracteres!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("A senha é obrigatória", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtConfirmarSenha.Text))
            {
                MessageBox.Show("A senha deve ser confirmada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarSenha.Focus();
                return false;
            }
            else if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarSenha.Focus();
                return false;
            }
            else if (!String.IsNullOrEmpty(txtSenha.Text))
            {
                validar = validarTamanhoSenha();
                if (validar == true)
                {
                    if (caracteres.Length == 4)
                    {
                        int[,] matriz = new int[2, 2];
                        int posicao = 0, determinante;
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                matriz[i, j] = Convert.ToInt32(caracteres[posicao++]);
                            }
                        }
                        determinante = matriz[0, 0] * matriz[1, 1] - matriz[0, 1] * matriz[1, 0];
                        if (determinante < 0)
                        {
                            determinante = determinante * -1;
                        }

                        if (determinante > Convert.ToInt32(numeros))
                        {
                            MessageBox.Show("O número da sua senha deve ser maior que " + determinante);
                            txtSenha.Focus();
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        int[,] matriz = new int[3, 5];
                        int posicao = 0, determinante, Dpos = 0, Dneg = 0, ci, cf, cont = 0, multiplicar = 1;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                matriz[i, j] = Convert.ToInt32(caracteres[posicao++]);
                            }
                        }

                        posicao = 0;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 3; j < 5; j++)
                            {
                                if (i == 1 && j == 3)
                                    posicao = 3;
                                if (i == 2 & j == 3)
                                    posicao = 6;

                                matriz[i, j] = Convert.ToInt32(caracteres[posicao++]);
                            }
                        }

                        ci = 0; cf = 3;

                    diagonais:

                        for (int i = 0; i < 3; i++)
                        {
                            if (cont < 3)
                            {
                                for (int j = ci; j < cf;)
                                {
                                    multiplicar *= matriz[i, j]; ci++;
                                    if (j == cf - 1)
                                        Dpos += multiplicar;
                                    break;
                                }
                            }
                            if (cont >= 3)
                            {
                                for (int j = ci; j >= cf;)
                                {
                                    multiplicar *= matriz[i, j]; ci--;
                                    if (j == cf)
                                        Dneg += multiplicar;
                                    break;
                                }
                            }
                        }

                        cont++;

                        if (cont == 1)
                        {
                            multiplicar = 1; ci = 1; cf = 4;
                        }
                        if (cont == 2)
                        {
                            multiplicar = 1; ci = 2; cf = 5;
                        }
                        if (cont == 3)
                        {
                            multiplicar = 1; ci = 4; cf = 2;
                        }
                        if (cont == 4)
                        {
                            multiplicar = 1; ci = 3; cf = 1;
                        }
                        if (cont == 5)
                        {
                            multiplicar = 1; ci = 2; cf = 0;
                        }
                        if (cont < 6)
                            goto diagonais;

                        determinante = Dpos - (Dneg);

                        if (determinante < 0)
                        {
                            determinante = determinante * -1;
                        }

                        if (determinante > Convert.ToInt32(numeros))
                        {
                            MessageBox.Show("O número da sua senha deve ser maior que " + determinante);
                            txtSenha.Focus();
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            else
                return true;
            
        }
       

        private void cboxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxSenha.Checked)
            {
                txtSenha.PasswordChar = char.MinValue;
                cboxSenha.Text = "Ocultar";
            }
            else 
            {
                txtSenha.PasswordChar = '*';
                cboxSenha.Text = "Mostrar";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (validarCampos() && validarSMTP())
            {
                Usuario usuario = new Usuario();
                if (cboxSMTP.Checked)
                {
                    try
                    {
                        ServidorSMTP smtp = new ServidorSMTP();
                        smtp.emailSMTP = txtEmailSMTP.Text;
                        smtp.senhaSMTP = txtSenhaSMTP.Text;
                        smtp.servidorSMTP = txtServidor.Text;
                        smtp.portaSMTP = Convert.ToInt32(txtPorta.Text);
                        usuario.servidorSMTP = smtp;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("A porta deve ser um número!", "Formato incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPorta.Focus();
                        return;
                    }
                }

                usuario.nome = txtNome.Text;
                IObjectSet procurar = banco.QueryByExample(usuario);
                if (procurar.HasNext())
                {
                    usuario = (Usuario)procurar.Next();
                    if (usuario.nome.Equals(txtNome.Text))
                    {
                        MessageBox.Show("Este nome já está sendo utilizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                        return;
                    }
                }

                usuario.email = txtEmail.Text;
                Usuario u2 = new Usuario();
                u2.email = txtEmail.Text;
                IObjectSet p2 = banco.QueryByExample(u2);
                if (p2.HasNext())
                {
                    Usuario u = (Usuario)p2.Next();
                    if (u.email.Equals(txtEmail.Text))
                    {
                        MessageBox.Show("Este e-mail já está sendo utilizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();
                        return;
                    }
                }

                usuario.usuario = txtUsuario.Text;
                Usuario u3 = new Usuario();
                u3.usuario = txtUsuario.Text;
                IObjectSet p3 = banco.QueryByExample(u3);
                if (p3.HasNext())
                {
                    Usuario u = (Usuario)p3.Next();
                    if (u.usuario.Equals(txtUsuario.Text))
                    {
                        MessageBox.Show("Este usuário já está sendo utilizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();
                        return;
                    }
                }

                
                Usuario u4 = new Usuario();

                // hash da senha
                MD5 md5 = MD5.Create();
                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(txtSenha.Text));
                StringBuilder stringg = new StringBuilder();
                for(int i=0; i<hash.Length; i++)
                {
                    stringg.Append(hash[i].ToString("x2")); // hexa
                }


                usuario.senha = stringg.ToString();
                u4.senha = txtSenha.Text;
                


                banco.Store(usuario);
                MessageBox.Show("Cadastro realizado com sucesso!");
                banco.Close();
                this.Close();
            }
        }

        private void frmCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            banco.Close();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                txtUsuario.Focus();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                txtSenha.Focus();
            }
        }

        private void picAjudaSenha_MouseEnter(object sender, EventArgs e)
        {
            ttpMensagem.ToolTipTitle = "Parâmetros da senha";
            ttpMensagem.Show(mensagemSenha, picAjudaSenha);
        }

        private void picAjudaSenha_MouseLeave(object sender, EventArgs e)
        {
            ttpMensagem.Hide(picAjudaSenha);
        }

        private void picHelpSMTP_MouseEnter(object sender, EventArgs e)
        {
            ttpMensagem.ToolTipTitle = "Sobre o SMTP";
            ttpMensagem.Show(mensagemSMTP, picHelpSMTP);
        }

        private void picHelpSMTP_MouseLeave(object sender, EventArgs e)
        {
            ttpMensagem.Hide(picHelpSMTP);
        }

        private void cboxSMTP_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxSMTP.Checked)
            {
                gboxSMTP.Enabled = true;
            }
            else
            {
                gboxSMTP.Enabled = false;
            }
        }

        private void cboxDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxDarkTheme.Checked)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                txtConfirmarSenha.BackColor = SystemColors.ControlDark;
                txtEmail.BackColor = SystemColors.ControlDark;
                txtEmailSMTP.BackColor = SystemColors.ControlDark;
                txtNome.BackColor = SystemColors.ControlDark;
                txtPorta.BackColor = SystemColors.ControlDark;
                txtSenha.BackColor = SystemColors.ControlDark;
                txtSenhaSMTP.BackColor = SystemColors.ControlDark;
                txtServidor.BackColor = SystemColors.ControlDark;
                txtUsuario.BackColor = SystemColors.ControlDark;
                picLogo.Image = Resources.logo2;
                DarkTheme = true;
            }
            else
            {
                this.BackColor = SystemColors.ActiveCaption;
                txtConfirmarSenha.BackColor = SystemColors.Window;
                txtEmail.BackColor = SystemColors.Window;
                txtEmailSMTP.BackColor = SystemColors.Window;
                txtNome.BackColor = SystemColors.Window;
                txtPorta.BackColor = SystemColors.Window;
                txtSenha.BackColor = SystemColors.Window;
                txtSenhaSMTP.BackColor = SystemColors.Window;
                txtServidor.BackColor = SystemColors.Window;
                txtUsuario.BackColor = SystemColors.Window;
                picLogo.Image = Resources.logo1;
                DarkTheme = false;
            }
        }

        public bool TemaEscuro()
        {
            return DarkTheme;
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                txtConfirmarSenha.Focus();
            }
        }

        private void txtConfirmarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnCadastrar.Focus();
            }
        }

    }
}
