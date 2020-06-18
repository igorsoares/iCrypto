using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_Login;

namespace CifraDeCesarProjeto1
{
    public partial class CifraCesar : Form
    {
        Usuario usuario = new Usuario();
        IObjectContainer banco;
        string caminhoBanco = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\database.db";
        int cont;
        bool DarkTheme = false;
        public CifraCesar(Usuario usuarioLogado)
        {
            InitializeComponent();
            tbxChave.Text = "0";
            cbxModo.SelectedIndex = 0;
            rtbxTPuro.Focus();
            usuario= usuarioLogado;
            try
            {
                banco.Close();
            }
            catch
            {

            }
            finally
            {
                banco = Db4oFactory.OpenFile(caminhoBanco);
            }

        }
        
        char[] alpha = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
        'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] num = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] simbolo = { ')', '!', '@', '#', '$', '%', '¨', '&', '*', '(' };
        char[]ALPHA = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q',
        'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        public int ChaveLetra(int x)
        {
            if (x >= 26)
            {
                do
                {
                    x = x % 26;
                } while (x > 26);
            }
         
            return x;
        }
        public int ChaveNum(int x)
        {
            if (x >= 10)
            {
                do
                {
                    x = x % 10;
                } while (x > 10);
            }
            return x; 
        }
        public int DChaveLetra(int x)
        {
            if (x <= 0)
            {

                x = x + 26;

            } 
            return x;
        }
        public int DChaveNum(int x)
        {
            if (x <= 0)
            {
                
                {
                    x = x + 10;
                }
            }
            return x;
        }
    


        private void rtbxTPuro_TextChanged(object sender, EventArgs e)
        {
            try
            {
          

                if (String.IsNullOrEmpty(tbxChave.Text)|| tbxChave.Text.Contains('-'))
                tbxChave.Text = "0";

                rtbxTextoCifrado.Clear();
                timer1.Start();
                cont = 5;

                if (cbxAutoSalvar.Checked == true)
                {
                    timer1.Enabled = true;
         
                }
                else
                {
                    timer1.Enabled = false;
                }

                if (cbxModo.SelectedIndex == 0)
                {


                    int chave;
                    try
                    {
                        int Chave = Convert.ToInt32(tbxChave.Text);
                        chave = Chave;
                    }
                    catch
                    {
                        tbxChave.Text = 0.ToString();
                        rtbxTextoCifrado.Clear();
                        int Chave = Convert.ToInt32(tbxChave.Text);
                        chave = Chave;
                    }

                    char[] vetor = rtbxTPuro.Text.ToCharArray();

                    for (int i = 0; i < vetor.Count(); i++)
                    {

                        if (alpha.Contains(vetor[i]))
                        {
                            for (int cont = 0; cont <= 25; cont++)
                            {
                                int key = ChaveLetra(chave);


                                if (vetor[i] == alpha[cont])
                                {
                                    key = key + cont;
                                    key = ChaveLetra(key);

                                    vetor[i] = alpha[key];
                                    rtbxTextoCifrado.Text += vetor[i];
                                    break;
                                }

                            }
                        }
                        if(vetor[i].Equals(' '))
                        {
                            rtbxTextoCifrado.Text += " ";
                        }


                        if (ALPHA.Contains(vetor[i]))
                        {
                            for (int cont = 0; cont <= 25; cont++)
                            {
                                int key = ChaveLetra(chave);


                                if (vetor[i] == ALPHA[cont])
                                {
                                    key = key + cont;
                                    key = ChaveLetra(key);

                                    vetor[i] = ALPHA[key];
                                    rtbxTextoCifrado.Text += vetor[i];
                                    break;
                                }

                            }
                        }

                    
                        if (num.Contains(vetor[i]))
                        {

                            for (int cont = 0; cont <= 9; cont++)
                            {
                                int key = ChaveNum(chave);

                                if (vetor[i] == num[cont])
                                {
                                    key = key + cont;
                                    key = ChaveNum(key);

                                    vetor[i] = num[key];
                                    rtbxTextoCifrado.Text += vetor[i];
                                    break;
                                }
                            }
                        }
                        if (simbolo.Contains(vetor[i]))
                        {

                            for (int cont = 0; cont <= 9; cont++)
                            {
                                int key = ChaveNum(chave);

                                if (vetor[i] == simbolo[cont])
                                {
                                    key = key + cont;
                                    key = ChaveNum(key);

                                    vetor[i] = simbolo[key];
                                    rtbxTextoCifrado.Text += vetor[i];
                                    break;
                                }
                            }
                        }
                        
                        if (!alpha.Contains(vetor[i]) && !num.Contains(vetor[i]) && !simbolo.Contains(vetor[i]) &&!ALPHA.Contains(vetor[i]) && vetor[i] != ' ')
                        {
                            rtbxTextoCifrado.Text += vetor[i];
                        }

                    }
                }
                else
                {
                    int chave;
                    try
                    {
                        int Chave = Convert.ToInt32(tbxChave.Text);
                        chave = Chave;
                    }
                    catch
                    {
                        tbxChave.Text = 0.ToString();
                        rtbxTextoCifrado.Clear();
                        int Chave = Convert.ToInt32(tbxChave.Text);
                        chave = Chave;
                    }
                    char[] vetor = rtbxTPuro.Text.ToCharArray();

                    for (int i = 0; i < vetor.Count(); i++)
                    {

                        if (alpha.Contains(vetor[i]))
                        {
                            for (int cont = 0; cont <= 25; cont++)
                            {
                                int key = ChaveLetra(chave);


                                if (vetor[i] == alpha[cont])
                                {
                                    key = cont - key;
                                    key = ChaveLetra(key);
                                    key = DChaveLetra(key);
                                    key = ChaveLetra(key);

                                    vetor[i] = alpha[key];
                                    rtbxTextoCifrado.Text += vetor[i];
                                    break;
                                }

                            }
                        }
                        if (vetor[i].Equals(' '))
                        {
                            rtbxTextoCifrado.Text += " ";
                        }


                        if (ALPHA.Contains(vetor[i]))
                        {
                            for (int cont = 0; cont <= 25; cont++)
                            {
                                int key = ChaveLetra(chave);


                                if (vetor[i] == ALPHA[cont])
                                {
                                    key = cont - key;
                                    key = ChaveLetra(key);
                                    key = DChaveLetra(key);
                                    key = ChaveLetra(key);

                                    vetor[i] = ALPHA[key];
                                    rtbxTextoCifrado.Text += vetor[i];
                                    break;
                                }

                            }
                        }


                        if (num.Contains(vetor[i]))
                        {

                            for (int cont = 0; cont <= 9; cont++)
                            {
                                int key = ChaveNum(chave);

                                if (vetor[i] == num[cont])
                                {
                                    key = cont - key;
                                    key = ChaveNum(key);
                                    key = DChaveNum(key);
                                    key = ChaveNum(key);

                                    vetor[i] = num[key];
                                    rtbxTextoCifrado.Text += vetor[i];
                                    break;
                                }
                            }
                        }
                        if (simbolo.Contains(vetor[i]))
                        {

                            for (int cont = 0; cont <= 9; cont++)
                            {
                                int key = ChaveNum(chave);

                                if (vetor[i] == simbolo[cont])
                                {
                                    key = cont - key;
                                    key = ChaveNum(key);
                                    key = DChaveNum(key);
                                    key = ChaveNum(key);

                                    vetor[i] = simbolo[key];
                                    rtbxTextoCifrado.Text += vetor[i];
                                    break;
                                }
                            }
                        }

                        if (!alpha.Contains(vetor[i]) && !num.Contains(vetor[i]) && !simbolo.Contains(vetor[i]) && !ALPHA.Contains(vetor[i]) && vetor[i] != ' ')
                        {
                            rtbxTextoCifrado.Text += vetor[i];
                        }

                    }
                }
                if (String.IsNullOrEmpty(rtbxTextoCifrado.Text) || rtbxTextoCifrado.Text == " ")
                {
                    btnSave.Enabled = false;
                    btnEnviarEmail.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                    btnEnviarEmail.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void tbxChave_TextChanged(object sender, EventArgs e)
        {
            try
            {
                banco.Close();
            }
            catch
            {

            }
            finally
            {
                banco = Db4oFactory.OpenFile(caminhoBanco);
            }

            rtbxTPuro_TextChanged(null,null);
        }

        private void tbxChave_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbxChave.Text == 0.ToString())
            {
                tbxChave.SelectAll();
            }
        }

        private void cbxModo_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbxTPuro_TextChanged(null, null);
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(rtbxTextoCifrado.Text))
            Clipboard.SetText(rtbxTextoCifrado.Text);
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rtbxTPuro.Clear();
        }

        private void btnCopiar1_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(rtbxTPuro.Text))
                Clipboard.SetText(rtbxTPuro.Text);
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            rtbxTPuro.Clear();
            cbxModo.SelectedIndex = 0;
            tbxChave.Text = 0.ToString();
            rtbxTPuro.Focus();
        }

        private void btnSalvar(object sender, EventArgs e)
        {
            
                try
                {
                    try
                    {
                        banco.Close();
                    }
                    catch
                    {

                    }
                    finally
                    {
                        banco = Db4oFactory.OpenFile(caminhoBanco);
                    }
                    Usuario user = new Usuario();
                    user.nome = usuario.nome;

                    IObjectSet pesquisa = banco.QueryByExample(user);
                    if (pesquisa.HasNext())
                    {
                        usuario = (Usuario)pesquisa.Next();
                        if (!String.IsNullOrEmpty(usuario.historicoCesar))
                        {
                            usuario.historicoCesar += cbxModo.SelectedItem.ToString() + "ק" + rtbxTPuro.Text + "ק" + tbxChave.Text
                                + "ק" + rtbxTextoCifrado.Text + "ק" + DateTime.Now.ToString("dd/MM/yyyy") + "ק";
                        }
                        else
                        {
                            usuario.historicoCesar = cbxModo.SelectedItem.ToString() + "ק" + rtbxTPuro.Text + "ק" + tbxChave.Text
                                + "ק" + rtbxTextoCifrado.Text + "ק" + DateTime.Now.ToString("dd/MM/yyyy") + "ק";
                        }
                        banco.Store(usuario);

                        MessageBox.Show("Informações salvas com sucesso!!", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           
        }

        private void CifraCesar_FormClosing(object sender, FormClosingEventArgs e)
        {
            banco.Close();
        }

        private void CifraCesar_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            EnviarMensagem enviar = new EnviarMensagem(rtbxTextoCifrado.Text, usuario, DarkTheme);
            enviar.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rtbxTextoCifrado.Text) || rtbxTextoCifrado.Text == " ")
            {
                return;
            }
            cont -= 1;
            if (cont == 0)
            {
                btnSalvar(null, null);
                timer1.Stop();
            }
        }

        private void cbxAutoSalvar_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxAutoSalvar.Checked == true)
            {
                timer1.Enabled = true;
                rtbxTPuro_TextChanged(null, null);
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void btnMaisChave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbxChave.Text) >= 25)
                tbxChave.Text = 0.ToString();
            else
                tbxChave.Text = (Convert.ToInt32(tbxChave.Text) + 1).ToString();
              
        }

        private void btnMenosChave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbxChave.Text) <= 0)
                tbxChave.Text = 25.ToString();
            else
                tbxChave.Text = (Convert.ToInt32(tbxChave.Text) - 1).ToString();
        }

        private void btnColar_Click(object sender, EventArgs e)
        {
           rtbxTPuro.Text = Clipboard.GetText();
        }
    }
}
