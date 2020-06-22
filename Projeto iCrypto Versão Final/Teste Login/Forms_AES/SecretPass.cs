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
using Db4objects.Db4o;
using Teste_Login;

namespace Projeto_AES
{
    public partial class SecretPass : Form
    {
        Usuario usuario = new Usuario();
        bool DarkTheme = false;
        metodosEDarkTheme temaEscuro = new metodosEDarkTheme();

        ShowMessageBox MessageBox = new ShowMessageBox();
        public SecretPass(Usuario usuarioLogado, bool DarkTheme)
        {
            InitializeComponent();
            usuario = usuarioLogado;
            if (DarkTheme)
            {
                this.DarkTheme = true;
                this.BackColor = SystemColors.ControlDarkDark;
                temaEscuro.darkTextBox(tbSenha, true);
                temaEscuro.darkComboBox(cmbTamanhoChave);
                temaEscuro.darkLogo(picLogo, true);
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSenha.Text))
            {
                MessageBox.ShowMessageBoxOK("error", "Insira uma senha secreta", "Erro", DarkTheme);
                return;
            }
            else
            {
                while(progressBar1.Value < 100)
                {
                    if(progressBar1.Value == 80)
                    {
                        System.Threading.Thread.Sleep(500);
                    }
                    System.Threading.Thread.Sleep(50);
                    progressBar1.Value = progressBar1.Value + 10;
                }
                if (cmbTamanhoChave.SelectedIndex == 0) { // 128 bits
                    MD5 md5 = MD5.Create();
                    byte[] md5128 = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(tbSenha.Text));
                    frmAES obj = new frmAES(md5128, "128", usuario, DarkTheme);
                    this.Hide();
                    obj.ShowDialog();
                    this.Close();

                }
                else
                {
                    // Obtém a hash SHA 256 da chave e joga como argumento no form
                    //  logo sendo convertida para uma chave secreta AES
                    SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
                    byte[] hash = sha256.ComputeHash(ASCIIEncoding.ASCII.GetBytes(tbSenha.Text));
                    frmAES obj = new frmAES(hash,"256", usuario, DarkTheme);
                    this.Hide();
                    obj.ShowDialog();
                    this.Close();
                }



            }
        }

        private void cbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrar.Checked)
            {
                string senha = tbSenha.Text;
                tbSenha.PasswordChar = '\0'; //NADA
                tbSenha.Text = senha;
                cbMostrar.Text = "Ocultar";
            }
            else
            {
                string senha = tbSenha.Text;
                tbSenha.PasswordChar = '*';
                tbSenha.Text = senha;
                cbMostrar.Text = "Mostrar";
            }
        }

        private void cmbTamanhoChave_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SecretPass_Load(object sender, EventArgs e)
        {
            cmbTamanhoChave.SelectedIndex = 1;

        }
    }
}
