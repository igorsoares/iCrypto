using Db4objects.Db4o;
using Db4objects.Db4o.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_Login;

namespace CodigoMorseProjeto1
{
    public partial class frmCodigoMorse : Form
    {
     
        Usuario usuario = new Usuario();
        IObjectContainer banco;
        string caminhoBanco = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\database.db";
        int cont;
        bool DarkTheme = false;
        metodosDarkTheme temaEscuro = new metodosDarkTheme();

        static Dictionary<char, string> chaveTexto = new Dictionary<char, string>()
        {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."},
            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {' ', "/" },
            {'.',".-.-.-" },
            {',',"--..--" },
            {'?',"..--.." },
            {'\'',".----." },
            {'!',"-.-.--" },
            {'(',"-.--." },
            {')',"-.--.-" },
            {'&',".-..." },
            {':',"---..." },
            {';',"-.-.-." },
            {'=',"-...-" },
            {'-',"-....-" },
            {'_',"..--.-" },
            {'"',".-..-." },
            {'$',"...-..-" },
            {'@',".--.-." }
        };
        private Dictionary<string, string> chaveMorse = new Dictionary<string, string>()
        {
            { ".-", "a" },
            { "-...", "b" },
            { "-.-.", "c" },
            { "-..", "d" },
            { ".", "e" },
            { "..-.", "f" },
            { "--.", "g" },
            { "....", "h" },
            { "..", "i" },
            { ".---", "j" },
            { "-.-", "k" },
            { ".-..", "l" },
            { "--", "m" },
            { "-.", "n" },
            { "---", "o" },
            { ".--.", "p" },
            { "--.-", "q" },
            { ".-.", "r" },
            { "...", "s" },
            { "-", "t" },
            { "..-", "u" },
            { "...-", "v" },
            { ".--", "w" },
            { "-..-", "x" },
            { "-.--", "y" },
            { "--..", "z" },
            {"/", " " },
            {".-.-.-", "." },
            {"--..--","," },
            {"..--..","?" },
            {".----.","'" },
            {"-.-.--","!" },
            {"-.--.","("},
            {"-.--.-",")" },
            {".-...","&" },
            {"---...",":" },
            {"-.-.-.",";" },
            {"-...-","=" },
            {"-....-","-" },
            {"..--.-","_" },
            {".-..-.","\"" },
            {"...-..-","$" },
            {".--.-.","@" },
            {"-----", "0"},
            {".----", "1"},
            {"..---", "2"},
            {"...--", "3"},
            {"....-","4"},
            {".....","5"},
            {"-....","6"},
            {"--...","7"},
            {"---..","8"},
            {"----.","9"},


        };

        public frmCodigoMorse(Usuario usuarioLogado, bool DarkTheme)
        {
            InitializeComponent();
            cbxModo.SelectedIndex = 0;
            usuario = usuarioLogado;

            if (DarkTheme)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                temaEscuro.darkRichTextBox(rtbxCripto);
                temaEscuro.darkRichTextBox(rtbxTPuro);
                temaEscuro.darkComboBox(cbxModo);
                this.DarkTheme = true;
            }

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
        string texto;
        private void rtbxTPuro_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
        
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

                rtbxCripto.Clear();

                texto = rtbxTPuro.Text.ToLower();
                if (cbxModo.SelectedIndex == 0)
                {
                    foreach (Char c in texto)
                    {
                        if (chaveTexto.ContainsKey(c))
                        {
                            rtbxCripto.Text += chaveTexto[c] + " ";
                        }

                    }

                }
                else
                {
                    string[] Texto = texto.Split(' ');

                    foreach (String c in Texto)
                    {
                        if (chaveMorse.ContainsKey(c))
                        {
                            rtbxCripto.Text += chaveMorse[c].ToUpper();

                        }

                    }


                }
                if (String.IsNullOrEmpty(rtbxCripto.Text) || rtbxCripto.Text == " ")
                {
                    btnSave.Enabled = false;
                    btnEnviar.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                    btnEnviar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void cbxModo_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (cbxModo.SelectedIndex == 0)
            {
                gbxTPuro.Text = "Texto Puro";
                gbxCripto.Text = "Texto Morse";
                rtbxTPuro.Clear();
                rtbxTPuro.Focus();
                toolTip1.SetToolTip(cbxModo, "Converte o Texto Puro em Código Morse");
                toolTip1.SetToolTip(rtbxTPuro, "Insira seu texto Puro Aqui.\nDeterminados tipos de caracteres não possuem conversão em morse...\n" +
                    "nesse caso não serão codificados. ");
                toolTip1.SetToolTip(rtbxCripto, "Texto em código Morse.\nDeterminados tipos de caracteres não possuem conversão em morse...\n" +
                    "nesse caso não foram codificados.");
                
            }
            else
            {
                toolTip1.SetToolTip(cbxModo, "Converte o Código Morse em Texto Puro");
                toolTip1.SetToolTip(rtbxTPuro, "Insira seu texto em Código Morse aqui./n Digite '/' para representar espaços entre as palavras\n" +
                    "Pressione a tecla ESPAÇO para determinar o código referente a cada letra." +
                    "\nDeterminados tipos de caracteres não possuem conversão em morse...\n" +
                   "nesse caso não serão decodificados. ");
                toolTip1.SetToolTip(rtbxCripto, "Texto em Formato Puro.\nDeterminados tipos de caracteres não possuem conversão em morse...\n" +
                   "nesse caso não foram codificados.\nO '/' Representa os espaços entre as palavras!!!");
                gbxTPuro.Text = "Texto Morse";
                gbxCripto.Text = "Texto Puro";
                rtbxTPuro.Clear();
                rtbxTPuro.Focus();
            }
            rtbxTPuro_TextChanged(null, null);
        }

        private void btnCopiar1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(rtbxTPuro.Text))
            Clipboard.SetText(rtbxTPuro.Text);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

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
                        if (!String.IsNullOrEmpty(usuario.historicoMorse))
                        {
                            usuario.historicoMorse += cbxModo.SelectedItem.ToString() + "ק" + rtbxTPuro.Text + "ק" + rtbxCripto.Text + "ק" + DateTime.Now.ToString("dd/MM/yyyy") + "ק";
                        }
                        else
                        {
                            usuario.historicoMorse = cbxModo.SelectedItem.ToString() + "ק" + rtbxTPuro.Text + "ק" + rtbxCripto.Text + "ק" + DateTime.Now.ToString("dd/MM/yyyy") + "ק";
                        }
                        banco.Store(usuario);

                    System.Windows.Forms.MessageBox.Show("Informações salvas com sucesso!!", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                

                }
                catch (Exception ex)
                {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                }
          
        }

        private void frmCodigoMorse_FormClosing(object sender, FormClosingEventArgs e)
        {
            banco.Close();
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rtbxTPuro.Clear();
        }

        private void btnCopiar2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(rtbxCripto.Text))
                Clipboard.SetText(rtbxCripto.Text);
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            cbxModo.SelectedIndex = 0;
            rtbxTPuro.Clear();
            rtbxTPuro.Focus();
            cbxAutoSalvar.Checked = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnviarMensagem enviar = new EnviarMensagem(rtbxCripto.Text, usuario, DarkTheme);
            enviar.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rtbxCripto.Text) || rtbxCripto.Text == " ")
            {
                return;
            }
            cont -= 1;
            if(cont == 0)
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

        private void btnColar_Click(object sender, EventArgs e)
        {
            rtbxTPuro.Text = Clipboard.GetText();
        }
    }
}
