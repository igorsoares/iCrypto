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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente sair ?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta.Equals(DialogResult.Yes))
            {
                banco.Close();
                Application.Exit();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
            frmCodigoMorse formCodigoMorse = new frmCodigoMorse(usuario);
            formCodigoMorse.ShowDialog();
            this.Show();
            banco = Db4oFactory.OpenFile(caminhoBanco);
        }

        private void aESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banco.Close();
            this.Hide();
            SecretPass formAES = new SecretPass(usuario);
            formAES.ShowDialog();
            this.Show();
            banco = Db4oFactory.OpenFile(caminhoBanco);
        }

        private void esteganografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banco.Close();
            this.Hide();
            Esteganografia formEsteganografia = new Esteganografia(usuario);
            formEsteganografia.ShowDialog();
            this.Show();
            banco = Db4oFactory.OpenFile(caminhoBanco);
        }

        private void cifraDeCesarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banco.Close();
            this.Hide();
            CifraCesar frmCifraDeCesar = new CifraCesar(usuario);
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
                MessageBox.Show("A senha deve conter pelo menos 4 caracteres!", "Senha inválida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxNovaSenha.Focus();
                return false;
            }
            else if (caracteres.Length != 4 && caracteres.Length != 9)
            {
                MessageBox.Show("A senha deve conter 4 ou 9 caracteres!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxNovaSenha.Focus();
                return false;
            }
            else if (numeros == null)
            {
                MessageBox.Show("A senha deve conter pelo menos um número!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (DialogResult.Yes.Equals(MessageBox.Show("Deseja realmente excluir sua conta?", "Excluir conta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
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
                        MessageBox.Show("Servidor SMTP cadastrado com sucesso!", "Servidor cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        banco.Close();
                        banco = Db4oFactory.OpenFile(caminhoBanco);
                        MessageBox.Show("Reinicie o iCrypto para que as mudanças tenham efeitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("A porta deve ser um número!", "Formato incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (DialogResult.Yes.Equals(MessageBox.Show("Deseja realmente excluir seus dados do servidor SMTP atual?", "Excluir conta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
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
                        MessageBox.Show("Reinicie o iCrypto para que as mudanças tenham efeitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        MessageBox.Show("Servidor SMTP alterado com sucesso!", "Servidor cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        banco.Close();
                        banco = Db4oFactory.OpenFile(caminhoBanco);
                        MessageBox.Show("Reinicie o iCrypto para que as mudanças tenham efeitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("A porta deve ser um número!", "Formato incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (DialogResult.Yes.Equals(MessageBox.Show("Deseja realmente excluir todos os históricos?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
            {
                Usuario user = new Usuario();
                user.nome = tbxNome.Text;
                IObjectSet pesquisaHistorico = banco.QueryByExample(user);
                if (pesquisaHistorico.HasNext())
                {
                    user = (Usuario)pesquisaHistorico.Next();
                    user.historicoAES = String.Empty;
                    user.historicoAESArquivo = String.Empty;
                    user.historicoRSA = String.Empty;
                    user.historicoCesar = String.Empty;
                    user.historicoMorse = String.Empty;
                    user.historicoEsteganografia = String.Empty;
                    banco.Store(user);
                    MessageBox.Show("Todos os históricos foram excluídos com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void temaEscuroOn_Click(object sender, EventArgs e)
        {
            //MenuDoTema
            temaEscuroOn.Checked = true;
            temaEscuroOn.BackColor = SystemColors.ControlDark;
            temaEscuroOff.Checked = false;
            temaEscuroOff.BackColor = SystemColors.ControlDark;
            this.BackColor = SystemColors.ControlDarkDark;
            //TextBoxes
            tpMinhaConta.BackColor = SystemColors.ControlDarkDark;
            tpServerSMTP.BackColor = SystemColors.ControlDarkDark;
            tpLimparHistorico.BackColor = SystemColors.ControlDarkDark;
            txtEmailSMTP.BackColor = SystemColors.ControlDark;
            txtPorta.BackColor = SystemColors.ControlDark;
            txtSenhaSMTP.BackColor = SystemColors.ControlDark;
            txtServidor.BackColor = SystemColors.ControlDark;
            tbxEmail.BackColor = SystemColors.ControlDark;
            tbxNome.BackColor = SystemColors.ControlDark;
            tbxNovaSenha.BackColor = SystemColors.ControlDark;
            tbxNovaSenhaConfirm.BackColor = SystemColors.ControlDark;
            tbxUser.BackColor = SystemColors.ControlDark;
            //Imagens
            picLogo1.Image = Resources.logo2;
            picLogo2.Image = Resources.logo2;
            //Menus
            menuSuperior.BackColor = Color.Black;
            tsmiCriptografia.ForeColor = SystemColors.AppWorkspace;
            tsmiCriptografia.BackColor = Color.Black;
            tsmiSair.ForeColor = SystemColors.AppWorkspace;
            tsmiSair.BackColor = Color.Black;
            tsmiTema.ForeColor = SystemColors.AppWorkspace;
            tsmiTema.BackColor = Color.Black;
            tsmiOpcoes.ForeColor = SystemColors.AppWorkspace;
            tsmiOpcoes.BackColor = Color.Black;
            aESToolStripMenuItem.BackColor = SystemColors.ControlDark;
            rSAToolStripMenuItem.BackColor = SystemColors.ControlDark;
            esteganografiaToolStripMenuItem.BackColor = SystemColors.ControlDark;
            códigoMorseToolStripMenuItem.BackColor = SystemColors.ControlDark;
            cifraDeCesarToolStripMenuItem.BackColor = SystemColors.ControlDark;
            hisóricoToolStripMenuItem.BackColor = SystemColors.ControlDark;
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
            tpMinhaConta.BackColor = SystemColors.ActiveCaption;
            tpServerSMTP.BackColor = SystemColors.ActiveCaption;
            tpLimparHistorico.BackColor = SystemColors.ActiveCaption;
            txtEmailSMTP.BackColor = SystemColors.Window;
            txtPorta.BackColor = SystemColors.Window;
            txtSenhaSMTP.BackColor = SystemColors.Window;
            txtServidor.BackColor = SystemColors.Window;
            tbxEmail.BackColor = SystemColors.Window;
            tbxNome.BackColor = SystemColors.Window;
            tbxNovaSenha.BackColor = SystemColors.Window;
            tbxNovaSenhaConfirm.BackColor = SystemColors.Window;
            tbxUser.BackColor = SystemColors.Window;
            //Imagens
            picLogo1.Image = Resources.logo1;
            picLogo2.Image = Resources.logo1;
            //Menus
            menuSuperior.BackColor = Color.White;
            tsmiCriptografia.ForeColor = Color.Black;
            tsmiCriptografia.BackColor = Color.White;
            tsmiSair.ForeColor = Color.Black;
            tsmiSair.BackColor = Color.White;
            tsmiTema.ForeColor = Color.Black;
            tsmiTema.BackColor = Color.White;
            tsmiOpcoes.ForeColor = Color.Black;
            tsmiOpcoes.BackColor = Color.White;
            aESToolStripMenuItem.BackColor = Color.White;
            rSAToolStripMenuItem.BackColor = Color.White;
            esteganografiaToolStripMenuItem.BackColor = Color.White;
            códigoMorseToolStripMenuItem.BackColor = Color.White;
            cifraDeCesarToolStripMenuItem.BackColor = Color.White;
            hisóricoToolStripMenuItem.BackColor = Color.White;
            DarkTheme = false;
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
            if (DialogResult.Yes.Equals(MessageBox.Show("Deseja realmente limpar este histórico?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
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
                            user.historicoAES = String.Empty;
                            break;

                        case "FileAES":
                            user.historicoAESArquivo = String.Empty;
                            break;

                        case "RSA":
                            user.historicoRSA = String.Empty;
                            break;

                        case "Cesar":
                            user.historicoCesar = String.Empty;
                            break;

                        case "Esteganografia":
                            user.historicoEsteganografia = String.Empty;
                            break;

                        case "Morse":
                            user.historicoMorse = String.Empty;
                            break;
                    }

                    MessageBox.Show("Histórico excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Nenhuma informação foi selecionada para alterar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                return false;
            }
            else if (!String.IsNullOrEmpty(tbxEmail.Text) && (!tbxEmail.Text.Contains('@') || !tbxEmail.Text.Contains('.')))
            {
                MessageBox.Show("O e-mail digitado é inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                tbxEmail.Focus();
                return false;
            }
            else if (!String.IsNullOrEmpty(tbxUser.Text) && tbxUser.Text.Length < 8)
            {
                MessageBox.Show("O usuário deve conter 8 ou mais caracteres!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxUser.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tbxNovaSenha.Text) && cboxAlterarSenha.Checked)
            {
                MessageBox.Show("Nenhuma nova senha foi digitada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxNovaSenhaConfirm.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tbxNovaSenhaConfirm.Text) && cboxAlterarSenha.Checked)
            {
                MessageBox.Show("A senha deve ser confirmada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxNovaSenhaConfirm.Focus();
                return false;
            }
            else if (tbxNovaSenha.Text != tbxNovaSenhaConfirm.Text && cboxAlterarSenha.Checked)
            {
                MessageBox.Show("As senhas não coincidem", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            MessageBox.Show("O número da sua senha deve ser maior que " + determinante);
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
                            MessageBox.Show("O número da sua senha deve ser maior que " + determinante);
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
                            MessageBox.Show("Nenhuma informação foi alterada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                    MessageBox.Show("Este e-mail já está sendo utilizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                    MessageBox.Show("Este usuário já está sendo utilizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            MessageBox.Show("A senha digitada é a senha atual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        usuario.senha = stringg.ToString();
                    }

                    if (DialogResult.Yes.Equals(MessageBox.Show("Deseja realmente alterar as informações da sua conta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
                    {
                        banco.Store(usuario);

                        MessageBox.Show("Informações alteradas com sucesso!", "Cadastro atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        banco.Close();
                        banco = Db4oFactory.OpenFile(caminhoBanco);
                    }
                }
            }
        }
    }
}
