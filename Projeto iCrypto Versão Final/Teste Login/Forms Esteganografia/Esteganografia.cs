using Db4objects.Db4o;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_Login;

namespace Esteganografia_versao_final
{
    public partial class Esteganografia : Form
    {
        string[] arquivo = new string[3];
        string[] fileAnexo = new string[4];
        string[] tamanhoArquivos;
        string gerado, extensao, mensagem, retornoGmail;
        IObjectContainer banco;
        ArrayList anexos = new ArrayList();
        Usuario usuario = new Usuario();
        string[] enderecoEmail;
        string servidor, extensaoHide, nomeArqOriginal, nomeArqOculto, nomeArqFinal, nome;
        int porta;
        string caminhoBanco = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\database.db";
        long tamanhoAnexos = 0;
        metodosEDarkTheme metodosDarkTheme = new metodosEDarkTheme();
        ShowMessageBox MessageBox = new ShowMessageBox();
        bool DarkTheme;
        Color cor = Color.Blue;

        public Esteganografia(Usuario usuarioLogado, bool DarkTheme)
        {
            InitializeComponent();
            usuario = usuarioLogado;
            banco = Db4oFactory.OpenFile(caminhoBanco);

            if (DarkTheme)
            {
                this.DarkTheme = true;
                this.BackColor = SystemColors.ControlDarkDark;
                //DataGrids
                metodosDarkTheme.darkDataGrid(dgvAnexos);
                metodosDarkTheme.darkDataGrid(dgvArquivoFinal);
                metodosDarkTheme.darkDataGrid(dgvArquivoOriginal);
                metodosDarkTheme.darkDataGrid(dgvFileHide);
                //TextBoxes
                metodosDarkTheme.darkTextBox(txtArquivoOriginal, true);
                metodosDarkTheme.darkTextBox(txtAssunto, true);
                metodosDarkTheme.darkTextBox(txtCaminhoAnexo, true);
                metodosDarkTheme.darkTextBox(txtDestinatario, true);
                metodosDarkTheme.darkTextBox(txtDiretorioFinal, true);
                metodosDarkTheme.darkTextBox(txtEmail, true);
                metodosDarkTheme.darkTextBox(txtFileHide, true);
                metodosDarkTheme.darkTextBox(txtMensagem, true);
                metodosDarkTheme.darkTextBox(txtNomeArquivo, true);
                metodosDarkTheme.darkTextBox(txtSalvarArquivo, true);
                metodosDarkTheme.darkTextBox(txtSenha, true);
                //Botões
                metodosDarkTheme.darkButton(btnPasta);
                metodosDarkTheme.darkButton(btnFileHide);
                metodosDarkTheme.darkButton(btnArquivoOriginal);
                metodosDarkTheme.darkButton(btnSelecionarAnexo);
                cor = SystemColors.ScrollBar;
            }
        }

        private bool validarCamposEmail()
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.ShowMessageBoxOK("warning", "Nenhum endereço de e-mail foi inserido!", "Aviso", DarkTheme);
                txtEmail.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.ShowMessageBoxOK("warning", "A senha do e-mail é necessária!", "Aviso", DarkTheme);
                txtSenha.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtDestinatario.Text))
            {
                MessageBox.ShowMessageBoxOK("warning", "Nenhum endereço de e-mail destinatário foi inserido!", "Aviso", DarkTheme);
                txtDestinatario.Focus();
                return false;
            }
            else if (anexos.Count == 0)
            {
                MessageBox.ShowMessageBoxOK("warning", "Nenhum arquivo foi anexado!", "Aviso", DarkTheme);
                btnSelecionarAnexo.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool validarCampos()
        {
            if (String.IsNullOrEmpty(txtArquivoOriginal.Text))
            {
                MessageBox.ShowMessageBoxOK("warning", "Nenhum arquivo original foi selecionado!", "Aviso", DarkTheme);
                btnArquivoOriginal.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtFileHide.Text))
            {
                MessageBox.ShowMessageBoxOK("warning", "Nenhum arquivo foi selecionado para ser escondido!", "Aviso", DarkTheme);
                btnFileHide.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtSalvarArquivo.Text))
            {
                MessageBox.ShowMessageBoxOK("warning", "Nenhuma pasta foi selecionada para salvar o arquivo esteganografado!", "Aviso", DarkTheme);
                btnPasta.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtNomeArquivo.Text))
            {
                MessageBox.ShowMessageBoxOK("warning", "Digite um nome para o arquivo gerado!", "Aviso", DarkTheme);
                txtNomeArquivo.Focus();
                return false;
            }
            return true;
        }

        private void btnArquivoOriginal_Click(object sender, EventArgs e)
        {
            if (ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                txtArquivoOriginal.Text = ofdAbrirArquivo.FileName;
                FileInfo arquivoOriginal = new FileInfo(txtArquivoOriginal.Text);
                arquivo[0] = arquivoOriginal.Name;
                nomeArqOriginal = arquivoOriginal.Name;
                arquivo[1] = arquivoOriginal.Length.ToString() + " bytes";
                arquivo[2] = arquivoOriginal.Extension;
                extensao = arquivoOriginal.Extension;
                dgvArquivoOriginal.Rows.Clear();
                dgvArquivoOriginal.Rows.Insert(0, arquivo);
            }
        }

        private void btnFileHide_Click(object sender, EventArgs e)
        {
            if (ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                txtFileHide.Text = ofdAbrirArquivo.FileName;
                FileInfo arquivoOculto = new FileInfo(txtFileHide.Text);
                arquivo[0] = arquivoOculto.Name;
                nomeArqOculto = arquivoOculto.Name;
                arquivo[1] = arquivoOculto.Length.ToString() + " bytes";
                arquivo[2] = arquivoOculto.Extension;
                extensaoHide = arquivoOculto.Extension;
                dgvFileHide.Rows.Clear();
                dgvFileHide.Rows.Insert(0, arquivo);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvArquivoOriginal.Rows.Clear();
            dgvFileHide.Rows.Clear();
            dgvArquivoFinal.Rows.Clear();
            txtArquivoOriginal.ResetText();
            txtDiretorioFinal.ResetText();
            txtFileHide.ResetText();
            txtNomeArquivo.ResetText();
            txtSalvarArquivo.ResetText();
        }

        private void Esteganografia_FormClosing(object sender, FormClosingEventArgs e)
        {
            banco.Close();
        }


        private void Esteganografia_Load(object sender, EventArgs e)
        {
            gboxLoginEmail.Enabled = false;
            gboxConteudoEmail.Enabled = false;
        }

        private void rbConta_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Text = usuario.email;
            txtEmail.ReadOnly = true;
            txtSenha.ResetText();
            gboxLoginEmail.Enabled = true;
            cboxMostrarSenha.Enabled = true;
            gboxConteudoEmail.Enabled = true;
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

        private void rbOutro_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.ResetText();
            txtSenha.ResetText();
            txtEmail.ReadOnly = false;
            gboxLoginEmail.Enabled = true;
            cboxMostrarSenha.Enabled = true;
            gboxConteudoEmail.Enabled = true;
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCaminhoAnexo.Text))
            {
                anexos.Add(txtCaminhoAnexo.Text);
                FileInfo anexo = new FileInfo(txtCaminhoAnexo.Text);
                fileAnexo[0] = anexo.Name;
                fileAnexo[1] = anexo.Length.ToString() + " bytes";
                fileAnexo[2] = anexo.Extension;
                fileAnexo[3] = anexo.FullName;
                dgvAnexos.Rows.Add(fileAnexo);
            }
            else
            {
                MessageBox.ShowMessageBoxOK("warning", "Nenhum arquivo foi selecionado!", "Aviso", DarkTheme);
                btnSelecionarAnexo.Focus();
            }
        }

        private void resetarCamposEmail()
        {
            txtEmail.ResetText();
            txtSenha.ResetText();
            txtDestinatario.ResetText();
            txtAssunto.ResetText();
            txtMensagem.ResetText();
            txtCaminhoAnexo.ResetText();
            dgvAnexos.Rows.Clear();
            anexos.Clear();
            rbConta.Checked = false;
            rbOutro.Checked = false;
            cboxMostrarSenha.Checked = false;
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
                        MessageBox.ShowMessageBoxOK("warning", "Não temos suporte para este tipo de servidor." +
                            "\nTente utilizar um email do google (gmail), hotmail, live.com ou" +
                            "\noutlook e confira se o e-mail está correto", "Servidor sem suporte", DarkTheme);
                        return;
                    }

                enviarEmail:
                    MailMessage email = new MailMessage();
                    email.From = new MailAddress(txtEmail.Text);
                    email.To.Add(new MailAddress(txtDestinatario.Text));
                    email.Subject = txtAssunto.Text;
                    email.Body = txtMensagem.Text;

                    foreach (DataGridViewRow linha in dgvAnexos.Rows)
                    {
                        try
                        {
                            tamanhoArquivos = linha.Cells[1].Value.ToString().Split(' ');
                            tamanhoAnexos += Convert.ToInt64(tamanhoArquivos[0]);
                            if (linha.Cells[2].Value.ToString().Equals(".exe"))
                            {
                                MessageBox.ShowMessageBoxOK("warning", "Arquivos .exe não podem ser enviados por e-mail.", "Arquivo .exe encontrado", DarkTheme);
                                return;
                            }
                        }
                        catch (NullReferenceException)
                        {

                        }
                    }

                    if (tamanhoAnexos > 26214400L)
                    {
                        MessageBox.ShowMessageBoxOK("warning", "O e-mail suporta envios de até 25Mb de arquivos em anexo. Remova alguns anexos.", "Limite de tamanho de anexos", DarkTheme);
                        return;
                    }

                    foreach (string anexo in anexos)
                    {
                        email.Attachments.Add(new Attachment(anexo));
                    }

                    metodosDarkTheme.enviarEmail(servidor, porta, rbSMTP.Checked, usuario.servidorSMTP.SSL, email, txtEmail.Text, txtSenha.Text, DarkTheme);
                    /*
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
                                MessageBox.ShowMessageBoxOK("correct", "E-mail enviado com sucesso!", "Aviso", DarkTheme);
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
                                retornoGmail = MessageBox.ShowMessageBoxYesNo("question", "A opção menos segura foi ativada?", "", DarkTheme);
                                if (retornoGmail.Equals("sim"))
                                {
                                    try
                                    {
                                        cliente.Send(email);
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
                                    cliente.Send(email);
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
                                cliente.Send(email);
                                MessageBox.ShowMessageBoxOK("correct", "E-mail enviado com sucesso!", "Aviso", DarkTheme);
                                return;
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }
                        
                    }
                    */
                }
            }
            catch (Exception)
            {
                MessageBox.ShowMessageBoxOK("error", "O envio falhou!" +
                   "\n" +
                   "\nCertifique que o e-mail está correto e é válido" +
                   "\nCertifique que a senha está correta (Deve ser a senha do e-mail e não do iCrypto)" +
                   "\nCaso seja gmail, certique que a opção 'Acesso a apps menos seguros' está ativada", "Ocorreu um erro", DarkTheme);
            }
        }

        private void lbAjudaWinRAR_Click(object sender, EventArgs e)
        {
            HelpAbrirWinRarEsteganografia frmAjudaWinRar = new HelpAbrirWinRarEsteganografia(DarkTheme);
            frmAjudaWinRar.Show();
        }

        private void lbAjudaWinRAR_MouseEnter(object sender, EventArgs e)
        {
            lbAjudaWinRAR.ForeColor = cor;
        }

        private void lbAjudaWinRAR_MouseLeave(object sender, EventArgs e)
        {
            lbAjudaWinRAR.ForeColor = Color.Black;
        }

        private void lbDownloadWinRar_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.win-rar.com/start.html?&L=9");
        }

        private void lbDownloadWinRar_MouseEnter(object sender, EventArgs e)
        {
            lbDownloadWinRar.ForeColor = cor;
        }

        private void lbDownloadWinRar_MouseLeave(object sender, EventArgs e)
        {
            lbDownloadWinRar.ForeColor = Color.Black;
        }
        private void lbHelpEsteganografia_Click(object sender, EventArgs e)
        {
            frmHelpGeralEsteganografia frmAjudaEsteganografia = new frmHelpGeralEsteganografia(DarkTheme);
            frmAjudaEsteganografia.Show();
        }

        private void lbHelpEsteganografia_MouseEnter(object sender, EventArgs e)
        {
            lbHelpEsteganografia.ForeColor = cor;
        }

        private void lbHelpEsteganografia_MouseLeave(object sender, EventArgs e)
        {
            lbHelpEsteganografia.ForeColor = Color.Black;
        }

        private void btnSelecionarAnexo_Click(object sender, EventArgs e)
        {
            if (ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoAnexo.Text = ofdAbrirArquivo.FileName;
            }
        }

        private void btnRemoverAnexo_Click(object sender, EventArgs e)
        {
            if (dgvAnexos.SelectedRows.Count == 0)
            {
                MessageBox.ShowMessageBoxOK("warning", "A linha inteira deve ser selecionada!", "Nenhum arquivo foi selecionado", DarkTheme);
                return;
            }
            else
            {
                foreach (DataGridViewCell celula in dgvAnexos.SelectedCells)
                {
                    try
                    {
                        if (String.IsNullOrEmpty(celula.Value.ToString()))
                        {
                            return;
                        }
                    }
                    catch (NullReferenceException)
                    {
                        return;
                    }
                }
                foreach (DataGridViewRow linha in dgvAnexos.SelectedRows)
                {
                    dgvAnexos.Rows.Remove(linha);
                    anexos.Remove(linha.Cells[3].Value);
                }
            }
        }

        private void rbSMTP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSMTP.Checked)
            {
                try
                {
                    gboxLoginEmail.Enabled = false;
                    txtEmail.Text = usuario.servidorSMTP.emailSMTP;
                    txtSenha.Text = usuario.servidorSMTP.senhaSMTP;
                    gboxConteudoEmail.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.ShowMessageBoxOK("error", "Certifique-se de que você possui um " +
                        "\nservidor SMTP personalizado em seu cadastro", "Um erro inesperado aconteceu", DarkTheme);
                }
            }
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            if (fbdAbrirPasta.ShowDialog() == DialogResult.OK)
            {
                txtSalvarArquivo.Text = fbdAbrirPasta.SelectedPath;
            }
        }

        private bool validarNomeArquivo()
        {
            if (txtNomeArquivo.Text.Contains("!") || txtNomeArquivo.Text.Contains("^") || txtNomeArquivo.Text.Contains("*") || txtNomeArquivo.Text.Contains("(") || txtNomeArquivo.Text.Contains(")") || txtNomeArquivo.Text.Contains("=") || txtNomeArquivo.Text.Contains(".") || txtNomeArquivo.Text.Contains("|") || txtNomeArquivo.Text.Contains("}") || txtNomeArquivo.Text.Contains("{") || txtNomeArquivo.Text.Contains('"') || txtNomeArquivo.Text.Contains("?") || txtNomeArquivo.Text.Contains(">") || txtNomeArquivo.Text.Contains("<") || txtNomeArquivo.Text.Contains(":") || txtNomeArquivo.Text.Contains(";") || txtNomeArquivo.Text.Contains("&") || txtNomeArquivo.Text.Contains(@"\") || txtNomeArquivo.Text.Contains("/") || txtNomeArquivo.Text.Contains(","))
            {
                MessageBox.ShowMessageBoxOK("warning", "O nome do arquivo não pode conter os seguintes caracteres:" +
                    "\n"
                    + "\n" + @"!, ^, *, \, /, (, ), =, ., |, <, >, ?, :, ;, &, {, } e " + '"', "Caracteres inválidos", DarkTheme);
                return false;
            }
            else
                return true;

        }

        private void btnEsteganografar_Click(object sender, EventArgs e)
        {
            if (validarCampos() && validarNomeArquivo())
            {
                nome = txtNomeArquivo.Text;
                if (nome.Contains(" "))
                {
                    nome = nome.Replace(' ', '_');
                }

                try
                {
                    if (File.Exists(@"C:\iCrypto\Zipado.rar"))
                        File.Delete(@"C:\iCrypto\Zipado.rar");

                    if (!Directory.Exists(@"C:\iCrypto\Esteganografia"))
                        Directory.CreateDirectory(@"C:\iCrypto\Esteganografia");
                    else
                    {
                        Directory.Delete(@"C:\iCrypto\Esteganografia", true);
                        Directory.CreateDirectory(@"C:\iCrypto\Esteganografia");
                    }

                    File.Copy(txtFileHide.Text, @"C:\iCrypto\Esteganografia\ArquivoEsteganografado" + extensaoHide, true);
                    ZipFile.CreateFromDirectory(@"C:\iCrypto\Esteganografia", @"C:\iCrypto\Zipado.rar");

                    gerado = '"' + txtSalvarArquivo.Text + @"\" + '"' + nome + extensao + '"';
                    ProcessStartInfo infos = new ProcessStartInfo();
                    infos.FileName = "cmd.exe";
                    infos.UseShellExecute = true;
                    infos.CreateNoWindow = true;
                    infos.WindowStyle = ProcessWindowStyle.Hidden;
                    infos.Arguments = "/C copy /b " + '"' + txtArquivoOriginal.Text + '"' + "+" + '"' + @"C:\iCrypto\Zipado.rar" + '"' + " " + gerado;
                    Process processo = new Process();
                    processo.StartInfo = infos;
                    processo.Start();

                    gerado = txtSalvarArquivo.Text + @"\" + "" + nome + "" + extensao;
                    mensagem = "Foi criado um novo arquivo esteganografado no seguinte diretório:" +
                        "\n" +
                        "\n" + gerado;

                    MessageBox.ShowMessageBoxOK("correct", mensagem, "Processo concluído!", DarkTheme);

                    timerAntiBug.Start();

                    FileInfo novoArquivo = new FileInfo(gerado);
                    txtDiretorioFinal.Text = gerado;
                    arquivo[0] = novoArquivo.Name;
                    nomeArqFinal = novoArquivo.Name;
                    arquivo[1] = novoArquivo.Length.ToString() + " bytes";
                    arquivo[2] = novoArquivo.Extension;
                    dgvArquivoFinal.Rows.Clear();

                    if (cboxAnexar.Checked)
                    {
                        fileAnexo[0] = arquivo[0];
                        fileAnexo[1] = arquivo[1];
                        fileAnexo[2] = arquivo[2];
                        fileAnexo[3] = gerado;
                        dgvAnexos.Rows.Add(fileAnexo);
                        anexos.Add(gerado);
                    }
                    dgvArquivoFinal.Rows.Insert(0, arquivo);

                    Usuario usuarioPesquisa = new Usuario();
                    usuarioPesquisa.nome = usuario.nome;

                    IObjectSet pesquisarUsuario = banco.QueryByExample(usuarioPesquisa);
                    if (pesquisarUsuario.HasNext())
                    {
                        usuario = (Usuario)pesquisarUsuario.Next();

                        if (String.IsNullOrEmpty(usuario.historicoEsteganografia))
                        {
                            usuario.historicoEsteganografia = nomeArqOriginal + "ק" + nomeArqOculto + "ק" + nomeArqFinal + "ק" + DateTime.Now.ToString("dd /MM/yyyy") + "ק";
                        }
                        else
                        {
                            usuario.historicoEsteganografia += nomeArqOriginal + "ק" + nomeArqOculto + "ק" + nomeArqFinal + "ק" + DateTime.Now.ToString("dd /MM/yyyy") + "ק";
                        }

                        banco.Store(usuario);
                    }


                    File.Delete(@"C:\iCrypto\Zipado.rar");
                    Directory.Delete(@"C:\iCrypto\Esteganografia", true);

                }
                catch (Exception erro)
                {
                    MessageBox.ShowMessageBoxOK("error", erro.Message, "Ocorreu um erro inesperado", DarkTheme);
                }
            }
        }
    }
}
