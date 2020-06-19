using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Projeto1_semestre;
using Teste_Login.Properties;

namespace Teste_Login
{
    public partial class frmLogin : Form
    {
        IObjectContainer banco;
        string caminhoBanco =  Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\database.db";
        Color colorIn, colorOut = Color.Black;
        bool DarkTheme;
        metodosDarkTheme darkTheme = new metodosDarkTheme();
        frmMessageBox MessageBox;

        public frmLogin()
        {
            InitializeComponent();

           if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto"))
               Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto");

           if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\DarkTheme"))
           {
                cboxDarkTheme.Checked = true;
           }

            banco = Db4oFactory.OpenFile(caminhoBanco);
            txtUsuario.Focus();
        }

        private bool validarCampos()
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                /*
                MessageBox.Show("O usuário é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                */
                MessageBox = new frmMessageBox("Warning", "O usuário é obrigatório", "Aviso", DarkTheme, false);
                MessageBox.ShowDialog();
                return false;
            }
            if (String.IsNullOrEmpty(txtSenha.Text))
            {
                /*
                MessageBox.Show("A senha é obrigatória", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                */
                MessageBox = new frmMessageBox("Warning", "A senha é obrigatória", "Aviso", DarkTheme, false);
                MessageBox.ShowDialog();
                txtSenha.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void lbEsqueciSenha_MouseEnter(object sender, EventArgs e)
        {
            lbEsqueciSenha.ForeColor = colorIn;
        }

        private void lbEsqueciSenha_MouseLeave(object sender, EventArgs e)
        {
            lbEsqueciSenha.ForeColor = colorOut;
        }

        private void lbEsqueciSenha_Click(object sender, EventArgs e)
        {
            banco.Close();
            this.Hide();
            frmEsqueciSenha recSenha = new frmEsqueciSenha(DarkTheme);
            recSenha.ShowDialog();
            cboxDarkTheme.Checked = recSenha.TemaEscuro();
            this.Show();
            banco = Db4oFactory.OpenFile(caminhoBanco);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Usuario usuario = new Usuario();
                usuario.usuario = txtUsuario.Text;
                
                IObjectSet procurar = banco.QueryByExample(usuario);
                if (procurar.HasNext())
                {
                    usuario = (Usuario)procurar.Next();
                    
                    MD5 md5 = MD5.Create();
                    string senha = txtSenha.Text; //oq o usuario digitou
                    byte[] hasheada = md5.ComputeHash(Encoding.UTF8.GetBytes(senha));
                    StringBuilder stB = new StringBuilder();
                    for(int i=0; i<hasheada.Length; i++)
                    {
                        stB.Append(hasheada[i].ToString("x2")); // hexa
                    }

                    senha = stB.ToString();
                    //MessageBox.Show(senha);

                    if (usuario.senha.Equals(senha))
                    {
                        //Abrir o menu aqui

                        banco.Close();
                        this.Hide();
                        frmMenu formMenu = new frmMenu(usuario, DarkTheme);
                        formMenu.ShowDialog();
                        cboxDarkTheme.Checked = formMenu.TemaEscuro();
                        this.Show();
                        banco = Db4oFactory.OpenFile(caminhoBanco);
                    }
                    else
                    {
                        /*
                        MessageBox.Show("Senha incorreta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        */
                        MessageBox = new frmMessageBox("Warning", "Senha incorreta!", "Aviso", DarkTheme, false);
                        MessageBox.ShowDialog();
                    }
                }
                else
                {
                    /*
                    MessageBox.Show("Usuário não cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    */
                    MessageBox = new frmMessageBox("Warning", "Usuário não cadastrado!", "Aviso", DarkTheme, false);
                    MessageBox.ShowDialog();
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            banco.Close();
            this.Hide();
            frmCadastro cadastro = new frmCadastro(DarkTheme);
            cadastro.ShowDialog();
            cboxDarkTheme.Checked = cadastro.TemaEscuro();
            this.Show();
            banco = Db4oFactory.OpenFile(caminhoBanco);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            banco.Close();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnLogin.Focus();
            }
        }

        private void mudarTextBoxes(bool dark)
        {
            darkTheme.darkTextBox(txtSenha, dark);
            darkTheme.darkTextBox(txtUsuario, dark);
        }

        private void cboxDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxDarkTheme.Checked)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                mudarTextBoxes(true);
                colorIn = SystemColors.ScrollBar;
                darkTheme.darkLogo(picLogo, true);
                DarkTheme = true;
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\DarkTheme"))
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\DarkTheme");
            }
            else
            {
                this.BackColor = SystemColors.ActiveCaption;
                mudarTextBoxes(false);
                colorIn = Color.Blue;
                darkTheme.darkLogo(picLogo, false);
                DarkTheme = false;
                if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\DarkTheme"))
                    Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\DarkTheme");
            }
        }
    }
}
