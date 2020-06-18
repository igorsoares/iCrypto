using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_Login;
using Teste_Login.Properties;

namespace RSA_versao_final
{
    public partial class frmRSA : Form
    {
        IObjectContainer banco;
        Usuario usuario = new Usuario();
        string chave, chaveExportar, caracteresTxt, modo, caminhoArquivo = "", chaveImpressao, tipoChave;
        int numCaracter = 0;
        bool DarkTheme = false;
        string caminhoBanco = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\database.db";
        metodosDarkTheme temaEscuro = new metodosDarkTheme();
        public frmRSA(Usuario usuarioLogado, bool DarkTheme)
        {
            InitializeComponent();

            if (DarkTheme)
            {
                //Cores de fundo
                this.BackColor = SystemColors.ControlDarkDark;
                temaEscuro.darkTabControl(tcMenuRSA, true);
                //TextBoxes
                txtCaminhoTxt.BackColor = SystemColors.ControlDark;
                txtChave.BackColor = SystemColors.ControlDark;
                txtChavePrivada.BackColor = SystemColors.ControlDark; 
                txtChavePublica.BackColor = SystemColors.ControlDark;
                txtOriginal.BackColor = SystemColors.ControlDark;
                txtTextoFinal.BackColor = SystemColors.ControlDark;
                //ComboBoxes
                cboxExportarChave.BackColor = SystemColors.ScrollBar;
                cboxGerarImportar.BackColor = SystemColors.ScrollBar;
                cboxModo.BackColor = SystemColors.ScrollBar;
                cboxTamanhoChaves.BackColor = SystemColors.ScrollBar;
                cboxTipoChave.BackColor = SystemColors.ScrollBar;
                //Logo e imagens
                picLogo.Image = Resources.logo2;
                picHelpRSA.Image = Resources.iCrypto_HelpRSADark;
                this.DarkTheme = true;
            }

            banco = Db4oFactory.OpenFile(caminhoBanco);
            usuario = usuarioLogado;
        }

        private bool validarCampos()
        {
            if (String.IsNullOrEmpty(txtOriginal.Text))
            {
                MessageBox.Show("Nenhum texto foi digitado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOriginal.Focus();
                return false;
            }
            else if (cboxModo.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum modo foi selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboxModo.Focus();
                return false;
            }
            return true;
        }

        private void criptografarRSA(string key)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            try
            {
                RSA.FromXmlString(key);

                byte[] textoOriginal = Encoding.Unicode.GetBytes(txtOriginal.Text);
                byte[] textoCifrado = RSA.Encrypt(textoOriginal, false);
                string final = null;
                final = Convert.ToBase64String(textoCifrado);
                txtTextoFinal.Text = final;


                //Joga as informacoes no historico depois de criptografar
                //Padrao: Modo(Criptografar\Decifar) | Mensagem de entrada | Mensagem de saida

                Usuario usuarioTeste = new Usuario();
                usuarioTeste.nome = usuario.nome;

                IObjectSet pesquisa = banco.QueryByExample(usuarioTeste);
                if (pesquisa.HasNext())
                {
                    usuario = (Usuario)pesquisa.Next();
                    if (String.IsNullOrEmpty(usuario.historicoRSA))
                        usuario.historicoRSA = cboxModo.SelectedItem.ToString() + "ק" + txtOriginal.Text + "ק" + txtTextoFinal.Text + "ק" + DateTime.Now.ToString("dd/MM/yyyy") + "ק";
                    else
                        usuario.historicoRSA += cboxModo.SelectedItem.ToString() + "ק" + txtOriginal.Text + "ק" + txtTextoFinal.Text + "ק" + DateTime.Now.ToString("dd/MM/yyyy") + "ק";

                    banco.Store(usuario);
                }
                

                return;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Nenhuma chave foi importada!", "Chave inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tcMenuRSA.SelectedIndex = 1;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("-> Certifique que o processo está correto e as chaves coincidem" +
                    "\n-> Tente cifrar uma quantidade menor de texto" +
                    "\n-> Caso seja necessário cifrar um texto maior, cifre-o em partes", "Um erro inesperado ocorreu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void descriptografarRSA(string key)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            try
            {
                RSA.FromXmlString(key);

                byte[] bytesCifrados = Convert.FromBase64String(txtOriginal.Text);
                byte[] textoDecifrado = RSA.Decrypt(bytesCifrados, false);
                txtTextoFinal.Text = Encoding.Unicode.GetString(textoDecifrado);

                Usuario usuarioTeste = new Usuario();
                usuarioTeste.nome = usuario.nome;

                IObjectSet pesquisa = banco.QueryByExample(usuarioTeste);
                if (pesquisa.HasNext())
                {
                    usuario = (Usuario)pesquisa.Next();
                    if (String.IsNullOrEmpty(usuario.historicoRSA))
                        usuario.historicoRSA = cboxModo.SelectedItem.ToString() + "ק" + txtOriginal.Text + "ק" + txtTextoFinal.Text + "ק" + DateTime.Now.ToString("dd/MM/yyyy") + "ק";
                    else
                        usuario.historicoRSA += cboxModo.SelectedItem.ToString() + "ק" + txtOriginal.Text + "ק" + txtTextoFinal.Text + "ק" + DateTime.Now.ToString("dd/MM/yyyy") + "ק";

                    banco.Store(usuario);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Nenhuma chave foi importada!", "Chave inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tcMenuRSA.SelectedIndex = 1;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("-> Certifique que o processo está correto e as chaves coincidem" +
                    "\n-> Tente cifrar uma quantidade menor de texto" +
                    "\n-> Caso seja necessário cifrar um texto maior, cifre-o em partes", "Um erro inesperado ocorreu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlgoritmo_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                
                if (cboxModo.SelectedItem.Equals("Criptografar"))
                { 
                    criptografarRSA(chave);
                }
                else if (cboxModo.SelectedItem.Equals("Descriptografar"))
                {
                    descriptografarRSA(chave);
                }
            }
        }

        private void frmRSA_Load(object sender, EventArgs e)
        {
            cboxGerarImportar.SelectedIndex = 1;
        }


        private void cboxGerarImportar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxGerarImportar.SelectedIndex == 0)
            {
                btnImportarGerar.Text = "Gerar";
                cboxTipoChave.SelectedIndex = -1;
                btnLimparChave.Enabled = false;
                btnColarChave.Enabled = false;
                cboxTipoChave.Enabled = false;
                txtChave.ResetText();
                txtCaminhoTxt.ResetText();
                caminhoArquivo = "";
                btnSelecionarTxt.Enabled = false;
                cboxTamanhoChaves.Enabled = true;
                btnDigitarChave.Enabled = false;
            }
            else
            {
                btnImportarGerar.Text = "Importar";
                btnColarChave.Enabled = true;
                btnSelecionarTxt.Enabled = true;
                btnLimparChave.Enabled = true;
                cboxTamanhoChaves.SelectedIndex = -1;
                cboxTamanhoChaves.Enabled = false;
                cboxTipoChave.Enabled = true;
                btnDigitarChave.Enabled = true;
            }
        }

        private void frmRSA_FormClosing(object sender, FormClosingEventArgs e)
        {
            banco.Close();
        }

        private bool validarCamposChaves()
        {
            if (cboxGerarImportar.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum modo foi selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public void alterarStatusChave()
        {
            RSACryptoServiceProvider infosChave = new RSACryptoServiceProvider();
            infosChave.FromXmlString(chave);
            lbAtualKeySize.Text = infosChave.KeySize.ToString() + " bytes";

            if (infosChave.PublicOnly)
            {
                if (DarkTheme)
                {
                    lbTipoChaveAtual.ForeColor = Color.DarkGreen;
                }
                else
                {
                    lbTipoChaveAtual.ForeColor = Color.Green;
                }
                lbTipoChaveAtual.Text = "Pública";
            }
            else
            {
                if (DarkTheme)
                {
                    lbTipoChaveAtual.ForeColor = Color.DarkRed;
                }
                else
                {
                    lbTipoChaveAtual.ForeColor = Color.Red;
                }
                lbTipoChaveAtual.Text = "Privada";
            }
        }

        private void btnImportarGerar_Click(object sender, EventArgs e)
        {
            if (validarCamposChaves())
            {
                if (cboxGerarImportar.SelectedIndex == 0 && cboxTamanhoChaves.SelectedIndex != -1)
                {
                    RSACryptoServiceProvider chaveGerada = new RSACryptoServiceProvider(Convert.ToInt32(cboxTamanhoChaves.SelectedItem));
                    txtChavePublica.Text = chaveGerada.ToXmlString(false);
                    txtChavePrivada.Text = chaveGerada.ToXmlString(true);

                    frmGerarEImportarChaveRSA importarChave = new frmGerarEImportarChaveRSA(DarkTheme);
                    importarChave.ShowDialog();
                    tipoChave = importarChave.retornarTipoChave();

                    if (!tipoChave.Equals("nao"))
                    {
                        switch (tipoChave)
                        {
                            case "Privada":
                                chave = txtChavePrivada.Text;
                                alterarStatusChave();
                                break;

                            case "Publica":
                                chave = txtChavePublica.Text;
                                alterarStatusChave();
                                break;

                            default:
                                break;
                        }

                        MessageBox.Show("Chave importada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    MessageBox.Show("Utilize o campo 'Exportar' para guardá-las ou" +
                        "\no modo 'Importar' para utilizá-las", "Chaves geradas com sucesso!", MessageBoxButtons.OK);
                    cboxExportarChave.SelectedIndex = -1;
                    return;
                }
                else if(cboxGerarImportar.SelectedIndex == 0 && cboxTamanhoChaves.SelectedIndex == -1)
                {
                    MessageBox.Show("Nenhum tamanho de chave foi selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (cboxGerarImportar.SelectedIndex == 1 && !String.IsNullOrEmpty(txtChave.Text))
                {
                    chave = txtChave.Text;
                    if (cboxTipoChave.SelectedIndex == 0)
                        modo = "criptografar";
                    else if (cboxTipoChave.SelectedIndex == 1)
                        modo = "decifrar";
                    else
                    {
                        MessageBox.Show("Nenhum tipo de chave foi selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    try
                    {
                        chave = txtChave.Text;
                        alterarStatusChave();
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("O formato da chave está incorreto", "Erro ao importar chave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Acesse a área 'Algoritmo RSA' para " + modo +
                        "\nmensagens com esta chave", "Chave importada com sucesso!", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Nenhuma chave foi digitada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void rbImprimir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbImprimir.Checked)
            {
                btnMetodo.Text = "Imprimir";
            }
        }

        private void rbSalvarTxt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSalvarTxt.Checked)
            {
                btnMetodo.Text = "Salvar";
            }
        }

        private void rbCopiar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCopiar.Checked)
            {
                btnMetodo.Text = "Copiar";
            }
        }

        private void rbEnviarEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEnviarEmail.Checked)
            {
                btnMetodo.Text = "Enviar";
            }
        }

        private void btnSelecionarTxt_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK.Equals(ofdAbrirTxt.ShowDialog()))
            {
                txtChave.ResetText();
                FileInfo arquivo = new FileInfo(ofdAbrirTxt.FileName);
                if (arquivo.Extension.Equals(".txt"))
                {
                    txtCaminhoTxt.Text = ofdAbrirTxt.FileName;
                    caminhoArquivo = txtCaminhoTxt.Text;
                    caracteresTxt = File.ReadAllText(txtCaminhoTxt.Text);
                    foreach (char caracter in caracteresTxt)
                    {
                        txtChave.Text += caracter;
                    }
                }
                else
                {
                    MessageBox.Show("O arquivo deve possuir a extensão .txt", "Extensão inválida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            if (cboxExportarChave.SelectedIndex != -1)
            {
                if (!String.IsNullOrEmpty(txtChavePrivada.Text) || !String.IsNullOrEmpty(txtChavePublica.Text))
                {
                    if (rbImprimir.Checked)
                    {
                        if (pdlogPropriedadesImpressao.ShowDialog().Equals(DialogResult.OK))
                        {
                            pdocImprimirChave.PrinterSettings = pdlogPropriedadesImpressao.PrinterSettings;
                            pdocImprimirChave.Print();
                        }
                    }
                    else if (rbCopiar.Checked)
                    {
                        Clipboard.SetText(chaveExportar);
                        MessageBox.Show("Chave copiada!");
                    }
                    else if (rbSalvarTxt.Checked)
                    {
                        if (cboxExportarChave.SelectedIndex == 0)
                            sfdSalvarTxt.FileName = "Chave Pública RSA";
                        else
                            sfdSalvarTxt.FileName = "Chave Privada RSA";

                        if (sfdSalvarTxt.ShowDialog().Equals(DialogResult.OK))
                        {
                            File.WriteAllText(sfdSalvarTxt.FileName, chaveExportar);
                        }
                    }
                    else if (rbEnviarEmail.Checked)
                    {
                        banco.Close();
                        this.Hide();
                        frmEnviarChaveRSAEmail frmEnviarChaveEmail = new frmEnviarChaveRSAEmail(usuario, chaveExportar, cboxExportarChave.SelectedItem.ToString(), caminhoArquivo, DarkTheme);
                        frmEnviarChaveEmail.ShowDialog();
                        banco = Db4oFactory.OpenFile(caminhoBanco);
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma chave foi gerada ou inserida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione uma chave para exportar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void cboxExportarChave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxExportarChave.SelectedIndex == 0)
                chaveExportar = txtChavePublica.Text;
            else
                chaveExportar = txtChavePrivada.Text;
        }

        private void btnLimparOriginal_Click(object sender, EventArgs e)
        {
            txtOriginal.ResetText();
        }

        private void btnLimparFinal_Click(object sender, EventArgs e)
        {
            txtTextoFinal.ResetText();
        }

        private void btnLimparChave_Click(object sender, EventArgs e)
        {
            txtChave.ResetText();
            txtCaminhoTxt.ResetText();
            caminhoArquivo = "";
        }

        private void btnColarChave_Click(object sender, EventArgs e)
        {
            txtChave.Text = Clipboard.GetText();
            caminhoArquivo = "";
            txtCaminhoTxt.ResetText();
        }

        private void btnEnviarMensagemEmail_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtTextoFinal.Text))
            {
                EnviarMensagem enviarMensagem = new EnviarMensagem(txtTextoFinal.Text, usuario, DarkTheme);
                enviarMensagem.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhuma mensagem de saída foi gerada!", "Não há mensagens para enviar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRetirarChave_Click(object sender, EventArgs e)
        {
            chave = String.Empty;
            lbAtualKeySize.Text = "N/D";
            lbTipoChaveAtual.ForeColor = Color.Black;
            lbTipoChaveAtual.Text = "Sem chave";
        }

        private void btnDigitarChave_Click(object sender, EventArgs e)
        {
            txtChave.ResetText();
            txtCaminhoTxt.ResetText();
            caminhoArquivo = "";
            frmDigitarChave digitarChave = new frmDigitarChave(DarkTheme);
            digitarChave.ShowDialog();
            if (!digitarChave.fechou)
                txtChave.Text = digitarChave.txtChaveDigitada.Text;
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtTextoFinal.Text);
        }

        private void btnImportarToExportar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtChave.Text) && cboxTipoChave.SelectedIndex != -1)
            {
                txtChavePrivada.ResetText();
                txtChavePublica.ResetText();

                if (cboxTipoChave.SelectedIndex == 0)
                    txtChavePublica.Text = txtChave.Text;
                else
                    txtChavePrivada.Text = txtChave.Text;
            }
            else
            {
                MessageBox.Show("Você deve inserir uma chave e selecionar seu tipo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnColarOirginal_Click(object sender, EventArgs e)
        {
            txtOriginal.Text = Clipboard.GetText();
        }

        private void pdocImprimirChave_PrintPage(object sender, PrintPageEventArgs e)
        {
            chaveImpressao = "";

            if (cboxExportarChave.SelectedIndex == 0)
            {
                foreach (char caracter in txtChavePublica.Text)
                {
                    chaveImpressao += caracter;
                    numCaracter++;

                    if (numCaracter == 96)
                    {
                        chaveImpressao += "\n";
                        numCaracter = 0;
                    }
                }
            }
            else
            {
                foreach (char caracter in txtChavePrivada.Text)
                {
                    chaveImpressao += caracter;
                    numCaracter++;

                    if (numCaracter == 96)
                    {
                        chaveImpressao += "\n";
                        numCaracter = 0;
                    }
                }
            }

            e.Graphics.DrawString(chaveImpressao, txtChavePublica.Font, Brushes.Black, 50, 60);
        }
    }
}
