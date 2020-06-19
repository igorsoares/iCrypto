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
        string gerado, extensao, mensagem;
        IObjectContainer banco;
        ArrayList anexos = new ArrayList();
        Usuario usuario = new Usuario();
        string[] enderecoEmail;
        string servidor, extensaoHide, nomeArqOriginal, nomeArqOculto, nomeArqFinal, nome;
        int porta;
        string caminhoBanco = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\database.db";
        string respostaGmail;
        metodosDarkTheme metodosDarkTheme = new metodosDarkTheme();
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
            else if (anexos.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Nenhum arquivo foi anexado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                System.Windows.Forms.MessageBox.Show("Nenhum arquivo original foi selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnArquivoOriginal.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtFileHide.Text))
            {
                System.Windows.Forms.MessageBox.Show("Nenhum arquivo foi selecionado para ser escondido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnFileHide.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtSalvarArquivo.Text))
            {
                System.Windows.Forms.MessageBox.Show("Nenhuma pasta foi selecionada para salvar o arquivo esteganografado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPasta.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtNomeArquivo.Text))
            {
                System.Windows.Forms.MessageBox.Show("Digite um nome para o arquivo gerado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                System.Windows.Forms.MessageBox.Show("Nenhum arquivo foi selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


                    foreach (string anexo in anexos)
                    {
                        email.Attachments.Add(new Attachment(anexo));
                    }
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
                                    resetarCamposEmail();
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
                                    resetarCamposEmail();
                                    return;
                                }
                                catch (Exception)
                                {
                                    DialogResult google2 = System.Windows.Forms.MessageBox.Show("Certifique-se de que a opção " +
                                        "'Menos Seguro' está ativa em sua conta google", "Falha ao enviar o e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                resetarCamposEmail();
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
                System.Windows.Forms.MessageBox.Show("A linha inteira deve ser selecionada!", "Nenhum arquivo foi selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    System.Windows.Forms.MessageBox.Show("Certifique-se de que você possui um " +
                        "\nservidor SMTP personalizado em seu cadastro", "Um erro inesperado aconteceu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                System.Windows.Forms.MessageBox.Show("O nome do arquivo não pode conter os seguintes caracteres:" +
                    "\n"
                    + "\n" + @"!, ^, *, \, /, (, ), =, ., |, <, >, ?, :, ;, &, {, } e " + '"', "Caracteres inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    System.Windows.Forms.MessageBox.Show(mensagem, "Processo concluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    System.Windows.Forms.MessageBox.Show(erro.Message, "Ocorreu um erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
