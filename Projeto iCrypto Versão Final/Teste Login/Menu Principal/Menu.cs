using CifraDeCesarProjeto1;
using CodigoMorseProjeto1;
using Db4objects.Db4o;
using Esteganografia_versao_final;
using Projeto_AES;
using RSA_versao_final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_Login;
using Teste_Login.Properties;

namespace Projeto1_semestre
{
    public partial class frmMenu : Form
    {
        Usuario usuario = new Usuario();
        metodosDarkTheme temaEscuro = new metodosDarkTheme();
        ShowMessageBox MessageBox = new ShowMessageBox();
        IObjectContainer banco;
        bool validar, letra, DarkTheme;
        int[] algarismos = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string caracteres, numeros, qualHistorico, testeSenha;
        string caminhoBanco = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\database.db";

        public frmMenu(Usuario usuarioLogado, bool DarkTheme)
        {
            InitializeComponent();

            if (DarkTheme)
            {
                temaEscuroOn_Click(null, null);
            }
            else
            {
                temaEscuroOff_Click(null, null);
            }

            usuario = usuarioLogado;
            hideSenhas();
            tbxNome.Text = usuario.nome;
            tbxEmail.Text = usuario.email;
            tbxUser.Text = usuario.usuario;
            rbAES.Checked = true;
            try
            {
                txtEmailSMTP.Text = usuario.servidorSMTP.emailSMTP;
                txtPorta.Text = usuario.servidorSMTP.portaSMTP.ToString();
                if (usuario.servidorSMTP.portaSMTP == 0)
                {
                    txtPorta.ResetText();
                }
                txtSenhaSMTP.Text = usuario.servidorSMTP.senhaSMTP;
                txtServidor.Text = usuario.servidorSMTP.servidorSMTP;
            }
            catch (Exception)
            {

            }
            banco = Db4oFactory.OpenFile(caminhoBanco);
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult resposta = System.Windows.Forms.MessageBox.Show("Deseja realmente sair ?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta.Equals(DialogResult.Yes))
            {
                banco.Close();
                Application.Exit();
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            banco.Close();
        }

        private void hisóricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banco.Close();
            this.Hide();
            Historico historico = new Historico(usuario, DarkTheme);
            historico.ShowDialog();
            this.Show();
            banco = Db4oFactory.OpenFile(caminhoBanco);
        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banco.Close();
            this.Hide();
            frmRSA formRSA = new frmRSA(usuario, DarkTheme);
            formRSA.ShowDialog();
            this.Show();
            banco = Db4oFactory.OpenFile(caminhoBanco);
        }

        private void códigoMorseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banco.Close();
            this.Hide();
            frmCodigoMorse formCodigoMorse = new frmCodigoMorse(usuario, DarkTheme);
            formCodigoMorse.ShowDialog();
            this.Show();
            banco = Db4oFactory.OpenFile(caminhoBanco);
        }

        private void aESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banco.Close();
            this.Hide();
            SecretPass formAES = new SecretPass(usuario, DarkTheme);
            formAES.ShowDialog();
            this.Show();
            banco = Db4oFactory.OpenFile(caminhoBanco);
        }

        private void esteganografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banco.Close();
            this.Hide();
            Esteganografia formEsteganografia = new Esteganografia(usuario, DarkTheme);
            formEsteganografia.ShowDialog();
            this.Show();
            banco = Db4oFactory.OpenFile(caminhoBanco);
        }

        private void cifraDeCesarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banco.Close();
            this.Hide();
            CifraCesar frmCifraDeCesar = new CifraCesar(usuario, DarkTheme);
            frmCifraDeCesar.ShowDialog();
            this.Show();
            banco = Db4oFactory.OpenFile(caminhoBanco);
        }

        private bool validarTamanhoSenha()
        {
            caracteres = null;
            numeros = null;

            for (int posicao = 0; posicao < tbxNovaSenha.Text.Length; posicao++)
            {
                letra = true;
                foreach (int algarismo in algarismos)
                {
                    if (algarismo.ToString().Equals(tbxNovaSenha.Text[posicao].ToString()))
                    {
                        numeros += tbxNovaSenha.Text[posicao];
                        letra = false;
                    }
                }

                if (letra)
                    caracteres += tbxNovaSenha.Text[posicao];
            }

            if (String.IsNullOrEmpty(caracteres))
            {
                MessageBox.ShowMessageBoxOK("warning", "A senha deve conter pelo menos 4 caracteres!", "Senha inválida!", DarkTheme);
                tbxNovaSenha.Focus();
                return false;
            }
            else if (caracteres.Length != 4 && caracteres.Length != 9)
            {
                MessageBox.ShowMessageBoxOK("warning", "A senha deve conter 4 ou 9 caracteres!", "Aviso", DarkTheme);
                tbxNovaSenha.Focus();
                return false;
            }
            else if (numeros == null)
            {
                MessageBox.ShowMessageBoxOK("warning", "A senha deve conter pelo menos um número!", "Aviso", DarkTheme);
                tbxNovaSenha.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cboxAlterarInfos_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxAlterarInfos.Checked)
            {
                tbxEmail.ReadOnly = false;
                tbxUser.ReadOnly = false;
            }
            else
            {
                tbxEmail.ReadOnly = true;
                tbxUser.ReadOnly = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.ShowMessageBoxYesNo("question", "Deseja realmente excluir sua conta?", "Excluir conta", DarkTheme).Equals("sim"))
            {
                Usuario user = new Usuario();
                user.nome = tbxNome.Text;

                IObjectSet pesquisarExcluir = banco.QueryByExample(user);
                if (pesquisarExcluir.HasNext())
                {
                    user = (Usuario)pesquisarExcluir.Next();
                    banco.Delete(user);
                }
                banco.Close();
                this.Close();
            }
        }

        private bool validarSMTP()
        {
            if (String.IsNullOrEmpty(txtEmailSMTP.Text))
            {
                MessageBox.ShowMessageBoxOK("warning", "O e-mail do SMTP é obrigatório", "Aviso", DarkTheme);
                txtEmailSMTP.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtSenhaSMTP.Text))
            {
                MessageBox.ShowMessageBoxOK("warning", "A senha do e-mail SMTP é obrigatória", "Aviso", DarkTheme);
                txtSenhaSMTP.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtServidor.Text))
            {
                MessageBox.ShowMessageBoxOK("warning", "O servidor SMTP é obrigatório", "Aviso", DarkTheme);
                txtServidor.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtPorta.Text))
            {
                MessageBox.ShowMessageBoxOK("warning", "A porta do servidor SMTP é obrigatória", "Aviso", DarkTheme);
                txtPorta.Focus();
                return false;
            }
            else
                return true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (validarSMTP())
            {
                Usuario usuario = new Usuario();
                usuario.nome = tbxNome.Text;

                IObjectSet pesquisaSMTP = banco.QueryByExample(usuario);
                if (pesquisaSMTP.HasNext())
                {
                    usuario = (Usuario)pesquisaSMTP.Next();
                    try
                    {
                        ServidorSMTP smtp = new ServidorSMTP();
                        smtp.emailSMTP = txtEmailSMTP.Text;
                        smtp.senhaSMTP = txtSenhaSMTP.Text;
                        smtp.servidorSMTP = txtServidor.Text;
                        smtp.portaSMTP = Convert.ToInt32(txtPorta.Text);
                        usuario.servidorSMTP = smtp;
                        banco.Store(usuario);
                        MessageBox.ShowMessageBoxOK("correct", "Servidor SMTP cadastrado com sucesso!", "Servidor cadastrado", DarkTheme);
                        banco.Close();
                        banco = Db4oFactory.OpenFile(caminhoBanco);
                        MessageBox.ShowMessageBoxOK("information", "Reinicie o iCrypto para que as mudanças tenham efeitos.", "Aviso", DarkTheme);

                    }
                    catch (FormatException)
                    {
                        MessageBox.ShowMessageBoxOK("error", "A porta deve ser um número!", "Formato incorreto", DarkTheme);
                        txtPorta.Focus();
                        return;
                    }
                }
            }
        }

        private void btnExcluirSMTP_Click(object sender, EventArgs e)
        {
            if (validarSMTP())
            {
                if (MessageBox.ShowMessageBoxYesNo("question", "Deseja realmente excluir seus dados do servidor SMTP atual?", "Excluir conta", DarkTheme).Equals("sim"))
                {
                    Usuario user = new Usuario();
                    user.nome = tbxNome.Text;

                    IObjectSet pesquisarExcluir = banco.QueryByExample(user);
                    if (pesquisarExcluir.HasNext())
                    {
                        user = (Usuario)pesquisarExcluir.Next();
                        ServidorSMTP newServer = new ServidorSMTP();
                        user.servidorSMTP = newServer;
                        banco.Store(user);
                        MessageBox.ShowMessageBoxOK("information", "Reinicie o iCrypto para que as mudanças tenham efeitos.", "Reinicialização necessária", DarkTheme);

                    }
                    banco.Close();
                    banco = Db4oFactory.OpenFile(caminhoBanco);
                }
            }
            
        }

        private void btnAlterarSMTP_Click(object sender, EventArgs e)
        {
            if (validarSMTP())
            {
                Usuario usuario = new Usuario();
                usuario.nome = tbxNome.Text;

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

                IObjectSet pesquisaSMTP = banco.QueryByExample(usuario);
                if (pesquisaSMTP.HasNext())
                {
                    usuario = (Usuario)pesquisaSMTP.Next();
                    try
                    {
                        ServidorSMTP smtp = new ServidorSMTP();
                        smtp.emailSMTP = txtEmailSMTP.Text;
                        smtp.senhaSMTP = txtSenhaSMTP.Text;
                        smtp.servidorSMTP = txtServidor.Text;
                        smtp.portaSMTP = Convert.ToInt32(txtPorta.Text);
                        usuario.servidorSMTP = smtp;
                        banco.Store(usuario);
                        MessageBox.ShowMessageBoxOK("information", "Servidor SMTP alterado com sucesso!", "Servidor cadastrado", DarkTheme);
                        banco.Close();
                        banco = Db4oFactory.OpenFile(caminhoBanco);
                        MessageBox.ShowMessageBoxOK("information", "Reinicie o iCrypto para que as mudanças tenham efeitos.", "Reinicialização necessária", DarkTheme);

                    }
                    catch (FormatException)
                    {
                        MessageBox.ShowMessageBoxOK("error", "A porta deve ser um número!", "Formato incorreto", DarkTheme);
                        txtPorta.Focus();
                        return;
                    }
                }
            }
        }

        private void cboxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxMostrarSenha.Checked)
            {
                txtSenhaSMTP.PasswordChar = char.MinValue;
                cboxMostrarSenha.Text = "Ocultar";
            }
            else
            {
                txtSenhaSMTP.PasswordChar = '*';
                cboxMostrarSenha.Text = "Mostrar";
            }
        }

        private void rbAES_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAES.Checked)
            {
                btnLimparEspecifico.Text = "Limpar histórico (AES)";
                qualHistorico = "AES";
            }
        }

        private void rbFileAES_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFileAES.Checked)
            {
                btnLimparEspecifico.Text = "Limpar histórico (AES - Arquivos)";
                qualHistorico = "FileAES";
            }
        }

        private void rbRSA_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRSA.Checked)
            {
                btnLimparEspecifico.Text = "Limpar histórico (RSA)";
                qualHistorico = "RSA";
            }
        }

        private void rbCifra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCifra.Checked)
            {
                btnLimparEspecifico.Text = "Limpar histórico (Cifra de Cesar)";
                qualHistorico = "Cesar";
            }
        }

        private void rbMorse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMorse.Checked)
            {
                btnLimparEspecifico.Text = "Limpar histórico (Código Morse)";
                qualHistorico = "Morse";
            }
        }

        private void btnLimparTodosHistoricos_Click(object sender, EventArgs e)
        {
            if (MessageBox.ShowMessageBoxYesNo("question", "Deseja realmente excluir todos os históricos?", "Confirmar exclusão", DarkTheme).Equals("sim"))
            {
                Usuario user = new Usuario();
                user.nome = tbxNome.Text;
                IObjectSet pesquisaHistorico = banco.QueryByExample(user);
                if (pesquisaHistorico.HasNext())
                {
                    user = (Usuario)pesquisaHistorico.Next();
                    user.historicoAES = string.Empty;
                    user.historicoAESArquivo = string.Empty;
                    user.historicoRSA = string.Empty;
                    user.historicoCesar = string.Empty;
                    user.historicoMorse = string.Empty;
                    user.historicoEsteganografia = string.Empty;
                    banco.Store(user);
                    MessageBox.ShowMessageBoxOK("information", "Todos os históricos foram excluídos com sucesso!", "Históricos excluídos!", DarkTheme);
                }
                banco.Close();
                banco = Db4oFactory.OpenFile(caminhoBanco);
            }
        }

        private void hideSenhas()
        {
            tbxNovaSenha.Hide();
            tbxNovaSenha.ResetText();
            tbxNovaSenhaConfirm.Hide();
            tbxNovaSenhaConfirm.ResetText();
            lbSenha.Hide();
            lbConfirmarSenha.Hide();
        }

        private void rbEsteganografia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEsteganografia.Checked)
            {
                btnLimparEspecifico.Text = "Limpar histórico (Esteganografia)";
                qualHistorico = "Esteganografia";
            }
        }

        private void mudarTextBoxes(bool dark)
        {
            temaEscuro.darkTextBox(txtEmailSMTP, dark);
            temaEscuro.darkTextBox(txtPorta, dark);
            temaEscuro.darkTextBox(txtSenhaSMTP, dark);
            temaEscuro.darkTextBox(txtServidor, dark);
            temaEscuro.darkTextBox(tbxEmail, dark);
            temaEscuro.darkTextBox(tbxNome, dark);
            temaEscuro.darkTextBox(tbxNovaSenha, dark);
            temaEscuro.darkTextBox(tbxNovaSenhaConfirm, dark);
            temaEscuro.darkTextBox(tbxUser, dark);
        }

        private void temaEscuroOn_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\DarkTheme"))
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\DarkTheme");
            //MenuDoTema
            temaEscuroOn.Checked = true;
            temaEscuroOn.BackColor = SystemColors.ControlDark;
            temaEscuroOff.Checked = false;
            temaEscuroOff.BackColor = SystemColors.ControlDark;
            this.BackColor = SystemColors.ControlDarkDark;
            //TextBoxes
            mudarTextBoxes(true);
            //TabControl
            temaEscuro.darkTabControl(tbcInfosConta, true);
            //Imagens
            temaEscuro.darkLogo(picLogo1, true);
            temaEscuro.darkLogo(picLogo2, true);
            //Menus
            temaEscuro.darkMenuStrip(menuSuperior, true);
            DarkTheme = true;
        }

        private void temaEscuroOff_Click(object sender, EventArgs e)
        {
            //MenuDoTema
            temaEscuroOn.Checked = false;
            temaEscuroOn.BackColor = Color.White;
            temaEscuroOff.Checked = true;
            temaEscuroOff.BackColor = Color.White;
            this.BackColor = SystemColors.ActiveCaption;
            //TextBoxes
            mudarTextBoxes(false);
            //TabControl
            temaEscuro.darkTabControl(tbcInfosConta, false);
            //Imagens
            temaEscuro.darkLogo(picLogo1, false);
            temaEscuro.darkLogo(picLogo2, false);
            //Menus
            temaEscuro.darkMenuStrip(menuSuperior, false);
            DarkTheme = false;
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\DarkTheme"))
                Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\DarkTheme");
        }

        public bool TemaEscuro()
        {
            return DarkTheme;
        }

        private void cboxAlterarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxAlterarSenha.Checked)
            {
                tbxNovaSenha.Show();
                tbxNovaSenhaConfirm.Show();
                lbSenha.Show();
                lbConfirmarSenha.Show();
            }
            else
            {
                hideSenhas();
            }
        }

        private void btnLimparEspecifico_Click(object sender, EventArgs e)
        {
            if (MessageBox.ShowMessageBoxYesNo("question", "Deseja realmente limpar este histórico?", "Confirmar exclusão", DarkTheme).Equals("sim"))
            {
                Usuario user = new Usuario();
                user.nome = tbxNome.Text;
                IObjectSet pesquisaHistorico = banco.QueryByExample(user);
                if (pesquisaHistorico.HasNext())
                {
                    user = (Usuario)pesquisaHistorico.Next();
                    switch (qualHistorico)
                    {
                        case "AES":
                            user.historicoAES = string.Empty;
                            break;

                        case "FileAES":
                            user.historicoAESArquivo = string.Empty;
                            break;

                        case "RSA":
                            user.historicoRSA = string.Empty;
                            break;

                        case "Cesar":
                            user.historicoCesar = string.Empty;
                            break;

                        case "Esteganografia":
                            user.historicoEsteganografia = string.Empty;
                            break;

                        case "Morse":
                            user.historicoMorse = string.Empty;
                            break;
                    }

                    MessageBox.ShowMessageBoxOK("correct", "Histórico excluído com sucesso!", "", DarkTheme);
                    banco.Store(user);
                }
                banco.Close();
                banco = Db4oFactory.OpenFile(caminhoBanco);
            }
        }

        private bool validarCampos()
        {
            if (!cboxAlterarInfos.Checked && !cboxAlterarSenha.Checked)
            {
                MessageBox.ShowMessageBoxOK("warning", "Nenhuma informação foi selecionada para alterar!", "Aviso", DarkTheme); 
                return false;
            }
            else if (!String.IsNullOrEmpty(tbxEmail.Text) && (!tbxEmail.Text.Contains('@') || !tbxEmail.Text.Contains('.')))
            {
                MessageBox.ShowMessageBoxOK("warning", "O e-mail digitado é inválido", "Aviso", DarkTheme); 
                tbxEmail.Focus();
                return false;
            }
            else if (!String.IsNullOrEmpty(tbxUser.Text) && tbxUser.Text.Length < 8)
            {
                MessageBox.ShowMessageBoxOK("warning", "O usuário deve conter 8 ou mais caracteres!", "Aviso", DarkTheme);
                tbxUser.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tbxNovaSenha.Text) && cboxAlterarSenha.Checked)
            {
                MessageBox.ShowMessageBoxOK("warning", "Nenhuma nova senha foi digitada!", "Aviso", DarkTheme);
                tbxNovaSenhaConfirm.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tbxNovaSenhaConfirm.Text) && cboxAlterarSenha.Checked)
            {
                MessageBox.ShowMessageBoxOK("warning", "A senha deve ser confirmada", "Aviso", DarkTheme);
                tbxNovaSenhaConfirm.Focus();
                return false;
            }
            else if (tbxNovaSenha.Text != tbxNovaSenhaConfirm.Text && cboxAlterarSenha.Checked)
            {
                MessageBox.ShowMessageBoxOK("warning", "As senhas não coincidem", "Aviso", DarkTheme);
                tbxNovaSenhaConfirm.Focus();
                return false;
            }
            else if (!String.IsNullOrEmpty(tbxNovaSenha.Text))
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
                            MessageBox.ShowMessageBoxOK("warning", "O número da sua senha deve ser maior que " + determinante, "Senha inválida", DarkTheme);
                            tbxNovaSenha.Focus();
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
                            MessageBox.ShowMessageBoxOK("warning", "O número da sua senha deve ser maior que " + determinante, "Senha inválida", DarkTheme);
                            tbxNovaSenha.Focus();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Usuario usuario = new Usuario();
                usuario.nome = tbxNome.Text;

                IObjectSet pesquisarUsuario = banco.QueryByExample(usuario);
                if (pesquisarUsuario.HasNext())
                {
                    usuario = (Usuario)pesquisarUsuario.Next();

                    if (cboxAlterarInfos.Checked)
                    {
                        if (tbxEmail.Text.Equals(usuario.email) && tbxUser.Text.Equals(usuario.usuario))
                        {
                            MessageBox.ShowMessageBoxOK("warning", "Nenhuma informação foi alterada!", "Aviso", DarkTheme);
                            return;
                        }

                        if (!tbxEmail.Text.Equals(usuario.email) && !String.IsNullOrEmpty(tbxEmail.Text))
                        {
                            Usuario u2 = new Usuario();
                            u2.email = tbxEmail.Text;
                            IObjectSet p2 = banco.QueryByExample(u2);
                            if (p2.HasNext())
                            {
                                Usuario u = (Usuario)p2.Next();
                                if (u.email.Equals(tbxEmail.Text))
                                {
                                    MessageBox.ShowMessageBoxOK("warning", "Este e-mail já está sendo utilizado", "Aviso", DarkTheme);
                                    tbxEmail.Focus();
                                    return;
                                }
                            }
                            usuario.email = tbxEmail.Text;
                        }

                        if (!tbxUser.Text.Equals(usuario.usuario) && !String.IsNullOrEmpty(tbxUser.Text))
                        {
                            Usuario u1 = new Usuario();
                            u1.usuario = tbxUser.Text;
                            IObjectSet p1 = banco.QueryByExample(u1);
                            if (p1.HasNext())
                            {
                                Usuario u = (Usuario)p1.Next();
                                if (u.usuario.Equals(tbxUser.Text))
                                {
                                    MessageBox.ShowMessageBoxOK("warning", "Este usuário já está sendo utilizado", "Aviso", DarkTheme);
                                    tbxUser.Focus();
                                    return;
                                }
                            }
                            usuario.usuario = tbxUser.Text;
                        }
                    }

                    if (cboxAlterarSenha.Checked)
                    {
                        MD5 md5 = MD5.Create();
                        byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(tbxNovaSenha.Text));
                        StringBuilder stringg = new StringBuilder();
                        for (int i = 0; i < hash.Length; i++)
                        {
                            stringg.Append(hash[i].ToString("x2")); // hexa
                        }

                        testeSenha = stringg.ToString();
                        if (testeSenha.Equals(usuario.senha))
                        {
                            MessageBox.ShowMessageBoxOK("warning", "A senha digitada é a senha atual", "Aviso", DarkTheme);
                            return;
                        }
                        usuario.senha = stringg.ToString();
                    }

                    if (MessageBox.ShowMessageBoxYesNo("question", "Deseja realmente alterar as informações da sua conta?", "Confirmar exclusão de conta", DarkTheme).Equals("sim"))
                    {
                        banco.Store(usuario);

                        MessageBox.ShowMessageBoxOK("information", "Informações alteradas com sucesso!", "Cadastro atualizado", DarkTheme);
                        banco.Close();
                        banco = Db4oFactory.OpenFile(caminhoBanco);
                    }
                }
            }
        }
    }
}
