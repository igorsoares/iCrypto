using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using Db4objects.Db4o;
using System.Collections;
using System.IO.Compression;
using Teste_Login;
using Teste_Login.Forms_AES;

namespace Projeto_AES
{
    public partial class frmAES : Form
    {
        byte[] chave;
        byte[] new_IV;
        byte[] hash;
        string pathOrigem = "";
        string pathDestino = "";
        string arquivo_original = "";
        string senhaAES = ""; // SENHA DIGITADO PELO USUARIO NO FORM ANTERIOR
        int contadorIndex = 0; // usado para não dar "Pau" ao iniciar o form com a chamada da função do combobox
        int linha_selecionada = 0; // linha selecionada no datagrid 
        int error = 0;
        AesCryptoServiceProvider aes;
        string tamanho_chave = "";
        string caminhoBanco = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\database.db";
        IObjectContainer banco;
        Usuario usuario = new Usuario();
        metodosDarkTheme temaEscuro = new metodosDarkTheme();
        bool DarkTheme = false;
        
        public frmAES(byte[] hashTamanho,string tamanho_chave, Usuario usuarioLogado, bool DarkTheme)
        {
            InitializeComponent();

            if (DarkTheme)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                temaEscuro.darkMenuStrip(menuSuperior, true);
                temaEscuro.darkTabControl(menuPaginas, true);
                temaEscuro.darkDataGrid(dgvAESFiles);
                temaEscuro.darkTextBox(tbArquivo, true);
                temaEscuro.darkComboBox(cmbModo);
                temaEscuro.darkContextMenuStrip(contextMenuDataGrid);
                temaEscuro.darkContextMenuStrip(contextMenuStrip1);
                temaEscuro.darkRichTextBox(richTexto1);
                temaEscuro.darkRichTextBox(richTexto2);
                this.DarkTheme = true;
            }

            this.hash = hashTamanho;
            this.tamanho_chave = tamanho_chave;
            usuario = usuarioLogado;
        }

        private void frmAES_Load(object sender, EventArgs e)
        {
            richTexto1.Focus();

            contadorIndex++;
            cmbModo.SelectedIndex = 0;
            aes = new AesCryptoServiceProvider();
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.ISO10126;
            //PaddingMode.ISO10126
            aes.KeySize = Convert.ToInt32(this.tamanho_chave);
            aes.Key = hash;
            byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            aes.IV = IV;
            chave = aes.Key;
            new_IV = aes.IV;

        }
        private byte[] Encripta(byte[] mensagem)
        {

            MemoryStream memoria = new MemoryStream();
            CryptoStream cripto = new CryptoStream(memoria, aes.CreateEncryptor(), CryptoStreamMode.Write);
            cripto.Write(mensagem, 0, mensagem.Length);
            cripto.FlushFinalBlock();

            byte[] encriptado= memoria.ToArray();

            return encriptado;
            
        }

        private string Desencriptar(string linha, bool base_64)
        {
            string plaintext = "";
            byte[] linha_byte = Convert.FromBase64String(linha);
            Aes myAes = Aes.Create();
            myAes.Mode = CipherMode.CBC;
            myAes.Padding = PaddingMode.ISO10126;
 
            myAes.KeySize = Convert.ToInt32(this.tamanho_chave);
            myAes.Key = chave;
            myAes.IV = new_IV;
            
            //myAes.Padding = PaddingMode.PKCS7;

            MemoryStream memoria = new MemoryStream(linha_byte);
            CryptoStream cripto = new CryptoStream(memoria, myAes.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader leitor = new StreamReader(cripto);
            
            plaintext = leitor.ReadToEnd();
            leitor.Close();
            

            return plaintext;
        }

        // MÉTODOS CLICK -------------------------------------------
        private void CifraTexto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cifra");
        }

        private void DecifraTexto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Decifra");
        }

        private void btFileDialog_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog obj = new OpenFileDialog();
                obj.Title = "Selecione um arquivo";
                obj.Filter = "Todos |*.*|Arquivos encriptados|*.aes";
                obj.ShowDialog();
                string arquivo = obj.FileName;
                tbArquivo.Text = arquivo;
                // Verifica se o arquivo ja está no dataGrid
                if (dgvAESFiles.Rows.Count >= 1)
                {
                    //MessageBox.Show(dataGridView["colunaArquivo", 0].Value.ToString());
                    if (!VerificaAmbiguidade(arquivo)) { return; } // se é ambiguo, saia..
                }
                    
                


                // Pega as infos do arquivo
                FileInfo infos = new FileInfo(arquivo);
                dgvAESFiles.Rows.Add(infos.Name, infos.Length.ToString(),infos.Extension, infos.DirectoryName);


            }catch(System.ArgumentException ex)
            {
                //Caso entre aqui, é pq o usuario fechou o filedialog sem selecionar..
                //Só saia..
                return;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void arquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecretPass password = new SecretPass(usuario, DarkTheme);
            this.Hide();
            password.ShowDialog();
            
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            ///MessageBox.Show(tabControl1.SelectedTab.Text.ToString());
        }

        private void cmbModo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(contadorIndex == 0)
            {
                // faça nada
                contadorIndex++;
            }
            else
            {
                if(cmbModo.SelectedItem == "Descriptografar")
                {
                    lblTexto1.Text = "Conteúdo cifrado";
                    btAcao.Text = "Descriptografar";
                    richTexto2.Clear();
                    btEnviaEmail.Enabled = false;
                }
                else
                {
                    lblTexto1.Text = "Texto puro";
                    btAcao.Text = "Criptografar";

                    btEnviaEmail.Enabled = true;
                }
            }
        }

        private void JogaemBanco(string metodo,string textoSrc,string textoDst)
        {
            // textos
            try
            {
                
                banco = Db4oFactory.OpenFile(caminhoBanco);
                Usuario nw_user = new Usuario();
                nw_user.usuario = usuario.usuario;
                IObjectSet resultados = banco.QueryByExample(nw_user);
                string ultimo_historico = "";
                string msg = metodo + "ק" + textoSrc + "ק" + textoDst + "ק" + DateTime.Now.ToString("dd/MM/yyyy") + "ק";

                //System.Threading.Thread.Sleep(100);
                if (resultados.HasNext())
                {
                    Usuario tmp = (Usuario)resultados.Next();
                    tmp.historicoAES = tmp.historicoAES + msg;
                    banco.Store(tmp);
                }
                else
                {
                    //Usuario tmp = (Usuario)resultados.Next();
                    // SÓ ENTRA AQUI NA PRIMEIRA VEZ QUE FOR CIFRAR
                    nw_user.historicoAES = msg;
                    banco.Store(nw_user);
                }
                
                //MessageBox.Show(usuario.historicoAES);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro");
                return;
            }
            

        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            ///              TEXTOS    
            try
            {

                if (richTexto1.Text.Length == 0)
                {
                    MessageBox.Show("Digite algum texto", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (btAcao.Text == "Criptografar")
                {
                    byte[] encripted=Encripta(ASCIIEncoding.UTF8.GetBytes(richTexto1.Text));
                    richTexto2.Text = Convert.ToBase64String(encripted);
                    JogaemBanco("Criptografar", richTexto1.Text, richTexto2.Text);
                    banco.Close();
                }
                else
                {
                    // Descriptografar


                    string retorno=Desencriptar(richTexto1.Text,true);
                    richTexto2.Text = retorno;
                    JogaemBanco("Descriptografar", richTexto1.Text, retorno);
                    banco.Close();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao processar. Chave pode estar incorreta.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void copiarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTexto2.SelectAll();
            richTexto2.Copy();
        }

        private string EncriptaArquivo(string arquivo,string diretorio)
        {
            string encriptedFile = "";
            try
            {
                encriptedFile = diretorio + @"\" + arquivo + ".aes";
                string fullPath = diretorio + @"\" + arquivo;
                var criaArquivo = File.Open(encriptedFile, FileMode.Create);

                // Pega todo o conteudo do arquivo , junta tudo e joga em bytes
                byte[] allContent = File.ReadAllBytes(fullPath);

                byte[] encriptado = Encripta(allContent);
                criaArquivo.Close();
                File.WriteAllBytes(encriptedFile, encriptado);
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                
            }
            return encriptedFile;

        }

        private void IncrementaProgressBar()
        {
            progressBarFile.Value = 0;
            for (int contador = 0; contador <= 100; contador += 10)
            {
                if (progressBarFile.Value == 90)
                {
                    progressBarFile.Value += contador;
                    System.Threading.Thread.Sleep(500);
                    continue;
                }
                if (progressBarFile.Value >= 100)
                    break;
                progressBarFile.Value += contador;
                System.Threading.Thread.Sleep(100);
            }
        }

        private bool VerificaAmbiguidade(string filename)
        {
            int nlinhas = dgvAESFiles.Rows.Count;
            // pegue a ultima ocorrencia do split do filename
            string nome_arquivo= filename.Split('\\')[filename.Split('\\').Length-1];

            for (int i=0; i<nlinhas; i++)
            {
                if (dgvAESFiles["colunaArquivo", i].Value.ToString().Equals(nome_arquivo))
                    return false;

            }
            return true;
        }

        private bool VerificaMBArquivos(ArrayList arquivos_email)
        {
            try
            {
                error = 0;
                long espaco = 0;
                long maximo = 26214400; // 25MB


                foreach (string arquivo in arquivos_email)
                {
                    if (arquivo.EndsWith(".exe"))
                    {
                        MessageBox.Show("Ocorreu um erro. Arquivos executáveis não podem ser enviados por email.",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        arquivos_email.Remove(arquivo);
                        error = 1;
                        return false;
                    }
                    FileInfo informacoes = new FileInfo(arquivo);
                    espaco += informacoes.Length;
                }
                if (espaco > maximo)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                // o erro que dará é no foreach, caso encontre algum executavel..
                return false;
            }
            
        }

        private void JogaemBancoArquivo(string metodo, string arquivoSrc, string arquivoDst)
        {
            
            try
            {
                banco = Db4oFactory.OpenFile(caminhoBanco);

                Usuario nw_user = new Usuario();
                nw_user.usuario = usuario.usuario;
                IObjectSet resultados = banco.QueryByExample(nw_user);
                string ultimo_historico = "";
                string msg = metodo + "ק" + arquivoSrc + "ק" + arquivoDst + "ק" + DateTime.Now.ToString("dd/MM/yyyy") + "ק";

                if (resultados.HasNext())
                {
                    Usuario tmp = (Usuario)resultados.Next();
                    tmp.historicoAESArquivo = tmp.historicoAESArquivo + msg;
                    banco.Store(tmp);
                }
                else
                {
                    //Usuario tmp = (Usuario)resultados.Next();
                    //tmp.historicoAESArquivo = tmp.historicoAESArquivo + msg;
                    //banco.Store(tmp);

                    nw_user.historicoAES = msg;
                    banco.Store(nw_user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }

        private void btEncripta_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\iCrypto\" + "ZipadoAES.rar"))
                File.Delete(@"C:\iCrypto\" + "ZipadoAES.rar");


            ArrayList apagar_linha = new ArrayList();
            ArrayList arquivos_email = new ArrayList();
            int nlinhas = dgvAESFiles.Rows.Count;
            for (int i = 0; i < nlinhas; i++)
            {
                // Encripta o arquivo com nomearquivo.extensao.aes
                string fileName = dgvAESFiles.Rows[i].Cells[0].Value.ToString();

                // VERIFICA SE O ARQUIVO EXISTE, SE NÃO EXISTIR, TIRE DA LISTA
                // Por que? R: O usuario pode ter excluido o arquivo.  
                if (!File.Exists(dgvAESFiles.Rows[i].Cells[3].Value.ToString() + @"\" + fileName))
                {
                    apagar_linha.Add(fileName);
                    continue;
                }

                // PROCESSO DE ENCRIPTAR O ARQUIVO
                if (fileName.Contains(".aes"))
                {
                    lblStatus.Text = "Ambíguo";
                    DataGridViewRow linha = dgvAESFiles.Rows[i];
                    dgvAESFiles.Rows.Remove(linha);
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    nlinhas -= 1;
                    i -= 1;
                    
                    continue;
                }
                string arquivo_en = EncriptaArquivo(fileName, dgvAESFiles.Rows[i].Cells[3].Value.ToString());

                // JOGA O NOME DO ARQUIVO NO BANCO
                JogaemBancoArquivo("Criptografar", fileName, arquivo_en.Split('\\')[arquivo_en.Split('\\').Length-1]);
                banco.Close();

                // verifica se a checkbox está ativa, se estiver, add na arraylist para enviar o email posteriormente
                if (chkEnviaArquivo.Checked)
                {
                    arquivos_email.Add(arquivo_en);
                }

                // Apagar arquivos do datagrid
                arquivo_original = fileName;
                for (int y = 0; y < dgvAESFiles.Rows.Count; y++)
                {
                    if (dgvAESFiles["colunaArquivo", y].Value == arquivo_original)
                    {
                        apagar_linha.Add(arquivo_original); //linha x coluna 1
                    }
                }

                FileInfo infos = new FileInfo(arquivo_en);
                dgvAESFiles.Rows.Add(infos.Name, infos.Length.ToString(), infos.Extension, infos.DirectoryName);
                dgvAESFiles.Refresh();

                IncrementaProgressBar();

                // Reseta Progressbar e mostra o "LOG"
                progressBarFile.Value = 0;
                lblStatus.Text = "Encriptado";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            // apagar todos encriptados (do arraylist que deve ser apagado)
            foreach (string arquivos in apagar_linha)
            {
                // busca pela linha
                for (int i = 0; i < dgvAESFiles.Rows.Count; i++)
                {
                    if (dgvAESFiles["colunaArquivo", i].Value.ToString().Equals(arquivos))
                    {
                        DataGridViewRow obj = dgvAESFiles.Rows[i];
                        dgvAESFiles.Rows.Remove(obj);
                    }

                }

            }


            tbArquivo.Clear();
            // ‭26214400‬bytes = 25MB (MAXIMO)
            if (chkEnviaArquivo.Checked)
            {
                // necessário calcular o espaço de todos arquivos no array, para ver se 
                // passa de 25MB

                if (VerificaMBArquivos(arquivos_email))
                {
                    SMTPEnvioTexto envioEmail = new SMTPEnvioTexto("",arquivos_email,usuario, DarkTheme);
                    envioEmail.ShowDialog();
                }
                else
                {
                    if (error == 1)
                        return;
                    // comprime o arquivo
                    DialogResult retorno = MessageBox.Show("Arquivos resultam em um espaço maior que 25MB.. Deseja " +
                        "comprimir esses arquivos ? ", "Aviso", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    string defaultDirectory= @"C:\iCrypto\AESFile\";

                    if (retorno.Equals(DialogResult.Yes))
                    {
                        if (File.Exists(@"C:\iCrypto\"+"ZipadoAES.rar"))
                            File.Delete(@"C:\iCrypto\" + "ZipadoAES.rar");


                        if (!Directory.Exists(defaultDirectory))
                            Directory.CreateDirectory(defaultDirectory);
                        else
                        {
                            Directory.Delete(defaultDirectory, true);
                            Directory.CreateDirectory(defaultDirectory);
                        }
                        System.Threading.Thread.Sleep(900);
                        foreach (string complete_file in arquivos_email)
                        {
                            string only_Name = complete_file.Split('\\')[complete_file.Split('\\').Length-1];//Somente o nome do arquivo
                            File.Copy(complete_file, defaultDirectory + only_Name, true);
 
                        }
                        System.Threading.Thread.Sleep(900);
                        ZipFile.CreateFromDirectory(defaultDirectory, @"C:\iCrypto\"+"ZipadoAES.rar");
                        ArrayList tmp = new ArrayList() { @"C:\iCrypto\ZipadoAES.rar" };
                        if (!VerificaMBArquivos(tmp))
                        {
                            MessageBox.Show("Arquivo comprimido maior que 25MB, impossível ser enviado.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            SMTPEnvioTexto envioEmail = new SMTPEnvioTexto("", tmp,usuario, DarkTheme);
                            envioEmail.ShowDialog();
                        }
                        // APAGA O ZIPADO (QUE É UM ARQUIVO TEMPORARIO)
                        File.Delete(@"C:\iCrypto\ZipadoAES.rar");
                    }
                    else
                    {
                        MessageBox.Show("Impossível de ser anexado.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

                
            }
        
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SecretPass obj = new SecretPass(usuario, DarkTheme);
            this.Hide();
            obj.ShowDialog();
            
        }

        private void btEnviaEmail_Click(object sender, EventArgs e)
        {
            string conteudo = richTexto2.Text;
            if (conteudo.Length > 0)
            {
                ArrayList trash = new ArrayList(); //nao é usada, criada somente para passagem de argumento obrigatoria
                SMTPEnvioTexto obj = new SMTPEnvioTexto(conteudo,trash,usuario, DarkTheme);
                obj.ShowDialog();

            }
            else
            {
                MessageBox.Show("Cifre algo primeiro ..","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            

        }

        private void btPuroLimpa_Click(object sender, EventArgs e)
        {
            richTexto1.Clear();
        }

        private void btPuroCopia_Click(object sender, EventArgs e)
        {
            richTexto1.SelectAll();
            richTexto1.Copy();
        }

        private void btSaidaCopia_Click(object sender, EventArgs e)
        {
            copiarTextoToolStripMenuItem_Click(null, null);
        }

        private void btSaidaLimpa_Click(object sender, EventArgs e)
        {
            richTexto2.Clear();
        }

        private byte[] DescriptaArquivo(string caminho_inteiro)
        {
            try
            {
                
                FileStream abreLeitura = File.OpenRead(caminho_inteiro); //encriptado
                FileStream output = File.Open(caminho_inteiro.Replace(".aes", ""),
                    FileMode.Create); //encriptado

                byte[] buffer = File.ReadAllBytes(caminho_inteiro);
                MemoryStream mem = new MemoryStream();
                CryptoStream decriptar = new CryptoStream(mem, aes.CreateDecryptor(),
                    CryptoStreamMode.Write);
                decriptar.Write(buffer, 0, buffer.Length);
                decriptar.FlushFinalBlock();

                abreLeitura.Close();
                output.Close();
                return mem.ToArray();
            }catch(System.Security.Cryptography.CryptographicException ex)
            {
                throw;
                
            }
            catch(System.UnauthorizedAccessException ex)
            {
                
                throw;
            }
            byte[] trash = new byte[20];
            return trash;
        }

        private void btDescripta_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(@"C:\iCrypto\" + "ZipadoAES.rar"))
                    File.Delete(@"C:\iCrypto\" + "ZipadoAES.rar");



                int nlinhas = dgvAESFiles.Rows.Count;
                ArrayList apagar_linha = new ArrayList();
                ArrayList arquivos_email = new ArrayList();
                for (int i = 0; i < nlinhas; i++)
                {
                    lblStatus.Text = "";
                    // Encripta o arquivo com nomearquivo.extensao.aes
                    string fileName = dgvAESFiles.Rows[i].Cells[0].Value.ToString();
                    if (!fileName.Contains(".aes"))
                    {
                        MessageBox.Show("Arquivo "+fileName+" sem extensão .aes. Impossível de descriptografar.",
                            "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        DataGridViewRow obj = dgvAESFiles.Rows[i];

                        dgvAESFiles.Rows.Remove(obj);
                        dgvAESFiles.Refresh();

                        nlinhas -= 1;
                        i -= 1;

                        lblStatus.Text = "Sem .aes";
                        lblStatus.ForeColor = System.Drawing.Color.Red;
                        continue;
                    }

                    if (!File.Exists(dgvAESFiles.Rows[i].Cells[3].Value.ToString() + @"\" + fileName))
                    {
                        apagar_linha.Add(fileName);
                        continue;
                    }

                    arquivo_original = fileName;

                    //DECRIPTA O ARQUIVO
                    string caminho_inteiro = dgvAESFiles.Rows[i].Cells[3].Value.ToString() + @"\" + arquivo_original;
                    // VOLTAR ARQUI DEPOIS... PRECISO FAZER COM QUE NAO SEJA OBRIGATORIAMENTE
                    JogaemBancoArquivo("Descriptografar", fileName, fileName.Replace(".aes", "")); 
                    
                    banco.Close();

                    // verifica se a checkbox está ativa, se estiver, add na arraylist para enviar o email posteriormente
                    if (chkEnviaArquivo.Checked) { arquivos_email.Add(caminho_inteiro.Replace(".aes","")); }
                    // VAI RODAR O DATAGRID INTEIRO, VERIFICANDO CADA ARQUIVO DO ARRAYLIST A SER APAGADO, E APAGA.
                    for (int y = 0; y < dgvAESFiles.Rows.Count; y++)
                    {
                        if (dgvAESFiles["colunaArquivo", y].Value == arquivo_original)
                        {
                            apagar_linha.Add(arquivo_original); //linha x coluna 1
                        }
                    }
                    try
                    {
                        byte[] memoryReturn = DescriptaArquivo(caminho_inteiro);
                        File.WriteAllBytes(caminho_inteiro.Replace(".aes", ""), memoryReturn.ToArray()); // joga o conteudo descriptografado no arquivo original
                    }
                    catch (System.UnauthorizedAccessException ex)
                    {
                        MessageBox.Show("Erro. Verifique se o arquivo " + caminho_inteiro + " está funcional.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DataGridViewRow linha = dgvAESFiles.Rows[i];
                        dgvAESFiles.Rows.Remove(linha);
                        return;
                    }


                    FileInfo infos = new FileInfo(caminho_inteiro);
                    dgvAESFiles.Rows.Add(infos.Name.Replace(".aes",""), infos.Length.ToString(), infos.Extension, infos.DirectoryName);
                    dgvAESFiles.Refresh();

                    IncrementaProgressBar();
                    progressBarFile.Value = 0;
                    lblStatus.Text = "Descriptografado";
                    lblStatus.ForeColor = System.Drawing.Color.Green;


                }
                tbArquivo.Clear();
                // DELEÇÃO
                foreach (string arquivos in apagar_linha)
                {
                    // busca pela linha
                    for (int i = 0; i < dgvAESFiles.Rows.Count; i++)
                    {
                        if (dgvAESFiles["colunaArquivo", i].Value.ToString().Equals(arquivos))
                        {
                            DataGridViewRow obj = dgvAESFiles.Rows[i];
                            dgvAESFiles.Rows.Remove(obj);
                        }

                    }

                }


                // ‭26214400‬bytes = 25MB (MAXIMO)
                if (chkEnviaArquivo.Checked)
                {
                    // necessário calcular o espaço de todos arquivos no array, para ver se 
                    // passa de 25MB

                    if (VerificaMBArquivos(arquivos_email) && error == 0)
                    {
                        SMTPEnvioTexto envioEmail = new SMTPEnvioTexto("", arquivos_email,usuario, DarkTheme);
                        envioEmail.ShowDialog();
                    }
                    else
                    {
                        if (error == 1)
                            return;
                        // comprime o arquivo
                        DialogResult retorno = MessageBox.Show("Arquivos resultam em um espaço maior que 25MB.. Deseja " +
                            "comprimir esses arquivos ? ", "Aviso", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        string defaultDirectory = @"C:\iCrypto\AESFile\";

                        if (retorno.Equals(DialogResult.Yes))
                        {
                            if (File.Exists(defaultDirectory + "ZipadoAES.rar"))
                                File.Delete(defaultDirectory + "ZipadoAES.rar");

                            if (!Directory.Exists(defaultDirectory))
                                Directory.CreateDirectory(defaultDirectory);
                            else
                            {
                                Directory.Delete(defaultDirectory, true);
                                Directory.CreateDirectory(defaultDirectory);
                            }
                            foreach (string complete_file in arquivos_email)
                            {
                                string only_Name = complete_file.Split('\\')[complete_file.Split('\\').Length - 1];//Somente o nome do arquivo
                                File.Copy(complete_file, defaultDirectory + only_Name, true);

                            }
                            
                            File.Delete(defaultDirectory + "ZipadoAES.rar");
                            ZipFile.CreateFromDirectory(defaultDirectory, @"C:\iCrypto\" + "ZipadoAES.rar");
                            
                            ArrayList tmp = new ArrayList() { @"C:\iCrypto\ZipadoAES.rar" };
                            if (!VerificaMBArquivos(tmp))
                            {
                                MessageBox.Show("Arquivo comprimido maior que 25MB, impossível ser enviado.",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                SMTPEnvioTexto envioEmail = new SMTPEnvioTexto("", tmp,usuario, DarkTheme);
                                envioEmail.ShowDialog();
                            }
                            // APAGA O ZIPADO (QUE É UM ARQUIVO TEMPORARIO)
                            File.Delete(@"C:\iCrypto\ZipadoAES.rar");
                        }
                        else
                        {
                            return;
                        }

                    }




                }
            }
            catch (System.Security.SecurityException ex)
            {
                
                lblStatus.Text = "Erro em descriptografar";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }catch(System.Security.Cryptography.CryptographicException ex)
            {
                MessageBox.Show("Erro ao descriptografar. Chave pode estar errada.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridView.HitTestInfo infos = dgvAESFiles.HitTest(e.X, e.Y);
                    dgvAESFiles.Rows[infos.RowIndex].Selected = true; //seleciona a linha inteira
                    linha_selecionada = infos.RowIndex;
                }

                if(e.Button == MouseButtons.Left)
                {
                    DataGridView.HitTestInfo infos = dgvAESFiles.HitTest(e.X, e.Y);
                    dgvAESFiles.Rows[infos.RowIndex].Selected = true;
                    // joga as infos da linha clicada no textbox
                    //string diretorio = ;
                    tbArquivo.Text = dgvAESFiles[3, infos.RowIndex].Value.ToString() + @"\" +dgvAESFiles[0,infos.RowIndex].Value.ToString(); //coluna,linha

                }

            }
            catch (Exception ex)
            {
                // se o usuario clicar com o botao esquerdo em qualquer lugar
                // fora das linhas dentro do datagrid
                return;
            }


        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(linha_selecionada > -1)
                {
                    DataGridCell celula;
                    DataGridViewRow linha = dgvAESFiles.Rows[linha_selecionada];
                    dgvAESFiles.Rows.Remove(linha);
                    tbArquivo.Clear(); // Limpa textbox do caminho de arquivo
                }
                lblStatus.Text="";
            }catch(Exception ex)
            {
                return;
            }
        }

        private void deletarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int quantidade = dgvAESFiles.Rows.Count;

                for (int i = 0; i < quantidade; i++)
                {

                    DataGridViewRow linha = dgvAESFiles.Rows[0];
                    dgvAESFiles.Rows.Remove(linha);

                }




            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }

        private void btSalvarEm_Click(object sender, EventArgs e)
        {
            

            if (richTexto2.Text.Length > 0)
            {
                try
                {
                    DateTime agora = DateTime.Now;
                    string configsAgora = agora.Year + @"/" + agora.Month + @"/" +
                        agora.Day + " " + agora.Hour + ":" + agora.Minute;
                    string texto = new string('=',15);
                    texto += "\n" + configsAgora + "\n";
                    texto+= new string('=', 15);
                    texto += "\n"+richTexto2.Text;

                    SaveFileDialog openDialog = new SaveFileDialog();
                    openDialog.Title = "Salvar em ";
                    openDialog.Filter = "Arquivo txt|*.txt|Arquivo .doc|*.doc|Arquivo .docx|*.docx|Todos|*.*";
                    openDialog.ShowDialog();
                    string arquivo_destino = openDialog.FileName;
                    StreamWriter salva = new StreamWriter(File.Open(arquivo_destino,
                        FileMode.Create));
                    salva.Write(texto);
                    salva.Close();

                    MessageBox.Show("Salvamento realizado com sucesso.", "Aviso");
                }catch(Exception ex)
                {
                    // unica excessao : quando fecha sem selecionar.. Só saia.
                    return;
                }


            }
            else
            {
                return;
            }
        }

        private void btDeDiretorio_Click(object sender, EventArgs e)
        {
            // SE O USUARIO SELECIONAR UMA PASTA VAZIA?
            // R: o programa não faz nada.
            try
            {
                FolderBrowserDialog folderBrowsing = new FolderBrowserDialog();
                folderBrowsing.Description = "Selecione uma pasta ";
                folderBrowsing.ShowDialog();
                string diretorio = folderBrowsing.SelectedPath;

                //Recebe uma coleção enumerável de nomes do arquivo

                var numeracao = Directory.EnumerateFiles(diretorio);
                //Pega a coleção (IEnumerable) e joga em uma array de string.
                string[] arquivos_inside_diretorio = numeracao.ToArray();

                foreach (string arquivo in arquivos_inside_diretorio)
                {
                    try
                    {
                        FileInfo infos = new FileInfo(arquivo);
                        if (!VerificaAmbiguidade(arquivo)) { continue; } // se é ambiguo, saia..

                        dgvAESFiles.Rows.Add(infos.Name, infos.Length.ToString(),
                            infos.Extension, infos.DirectoryName);
                        tbArquivo.Text = arquivo;
                    }
                    catch (Exception )
                    {
                        return; // unica exception: caso ele feche a folderBrowsing. Faça nada.
                    }

                }
            }
            catch(Exception )
            {
                return; // se chegar aqui, é pq fechou a janela do FolderBrowsing
            }
            
        }

        private void btColar_Click(object sender, EventArgs e)
        {
            richTexto1.Text = Clipboard.GetText();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobreAES obj = new SobreAES(DarkTheme);
            obj.Show();

        }

        private void frmAES_FormClosed(object sender, FormClosedEventArgs e)
        {
            SecretPass password = new SecretPass(usuario, DarkTheme);
            this.Hide();
            password.ShowDialog();
        }
    }
}
