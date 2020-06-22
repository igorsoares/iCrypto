using Db4objects.Db4o;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_Login;

namespace Projeto1_semestre
{
    public partial class Historico : Form
    {
        string[] teste = new string[4];
        string[] teste2 = new string[5];
        bool DarkTheme = false;
        string write = "";
        int cont;
        int contador_entra = 0; // "correção de bug ", mensagem de AES aparecendo antes do form
        Usuario usuario = new Usuario();
        IObjectContainer banco;
        string caminhoBanco = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + @"\iCrypto\database.db";
        const char delimitadorFinal = 'ק';
        metodosEDarkTheme temaEscuro = new metodosEDarkTheme();
        ShowMessageBox MessageBox = new ShowMessageBox();
        public Historico(Usuario usuarioLogado, bool DarkTheme)
        {
            InitializeComponent();
            //banco = Db4oFactory.OpenFile(caminhoBanco);

            if (DarkTheme)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                this.DarkTheme = DarkTheme;
                //TabPages
                temaEscuro.darkTabControl(tbcMenuHistorico, true);

                //DataGridAES
                temaEscuro.darkDataGrid(dataGridViewAES);

                //DataGridAESFiles
                temaEscuro.darkDataGrid(dataGridViewAESArquivo);

                //DataGridRSA
                temaEscuro.darkDataGrid(dgvHistoricoRSA);

                //DataGridCesar
                temaEscuro.darkDataGrid(dgvCesar);

                //DataGridMorse
                temaEscuro.darkDataGrid(dgvMorse);

                //DataGridEsteganografia
                temaEscuro.darkDataGrid(dgvHistoricoEsteganografia);
            }

            usuario.nome = usuarioLogado.nome;
            historyAES();
            //banco.Close();
        }

        private void Historico_FormClosing(object sender, FormClosingEventArgs e)
        {
            banco.Close();
        }

        private bool historyAES()
        {
            try
            {
                ArrayList parts = new ArrayList();

                try
                {
                    banco.Close();
                }
                catch (Exception)
                {

                }
                finally
                {
                    banco = Db4oFactory.OpenFile(caminhoBanco);

                }

                dataGridViewAES.Rows.Clear();
                //Usuario new_user = new Usuario();
                //new_user.nome = usuario.nome;

                IObjectSet retorno = banco.QueryByExample(usuario);
                string msg = "";
                bool exists = false;

                if (retorno.HasNext())
                {
                    Usuario tmp = (Usuario)retorno.Next();
                    if (!String.IsNullOrEmpty(tmp.historicoAES))
                    {
                        msg = tmp.historicoAES;
                        exists = true;
                    }

                }

                if (exists == true)
                {
                 
                    foreach (string splitado in msg.Split('ק'))
                    {
                        parts.Add(splitado);

                    }


                    for (int i = 0; i < parts.Count; i++)
                    {
                        dataGridViewAES.Rows.Add(parts[i], parts[i + 1], parts[i + 2], parts[i + 3]);
                        i += 3;

                    }

                    parts.Clear();
                    banco.Close();
                    return true;
                }
                else
                {
                    if (contador_entra == 0)
                    {
                        contador_entra++;
                        banco.Close();
                        return false;

                    }
                    else
                    {
                        banco.Close();
                        MessageBox.ShowMessageBoxOK("warning", "Não há atividades registradas no AES!", "Histórico vazio", DarkTheme);
                        return false;
                    }

                }
            }
            catch (Exception )
            {
                return false;
            }


        }


        private bool historyAESArquivo()
        {
            try
            {
                try
                {
                    banco.Close();
                }catch(Exception)
                {

                }
                finally
                {
                    banco = Db4oFactory.OpenFile(caminhoBanco);

                }
                
                
                dataGridViewAESArquivo.Rows.Clear();

                IObjectSet retorno = banco.QueryByExample(usuario);
                string msg = "";
                bool exists = false;
                if (retorno.HasNext())
                {
                    Usuario tmp = (Usuario)retorno.Next();
                    if (!String.IsNullOrEmpty(tmp.historicoAESArquivo))
                    {
                        msg = tmp.historicoAESArquivo;
                        exists = true;
                    }

                }

                ArrayList parts = new ArrayList();
                if (exists == true)
                {
                    foreach (string splitado in msg.Split('ק'))
                    {
                        parts.Add(splitado);
                    }

                    if (parts.Count % 2 != 0)
                    {
                        for (int i = 0; i < parts.Count; i++)
                        {
                            dataGridViewAESArquivo.Rows.Add(parts[i], parts[i + 1], parts[i + 2], parts[i + 3]);
                            i += 3;

                        }
                        parts.Clear();
                    }


                    banco.Close();
                    return true;
                }
                else
                {
                    banco.Close();
                    MessageBox.ShowMessageBoxOK("warning", "Não há atividades com arquivos registradas no AES!", "Histórico vazio", DarkTheme);
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }


        }
        private void tbcMenuHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcMenuHistorico.SelectedIndex == 2)
            {
                try
                {
                    banco.Close();
                }
                finally
                {
                    banco = Db4oFactory.OpenFile(caminhoBanco);
                }

                dgvHistoricoRSA.Rows.Clear();
                IObjectSet pesquisar = banco.QueryByExample(usuario);
                if (pesquisar.HasNext())
                {
                    Usuario usuarioRSA = (Usuario)pesquisar.Next();

                    if (String.IsNullOrEmpty(usuarioRSA.historicoRSA))
                    {
                        MessageBox.ShowMessageBoxOK("warning", "Não há atividades registradas no RSA!", "Histórico vazio", DarkTheme);
                        return;
                    }

                    for (int pos = 0; pos < 4; pos++)
                    {
                        teste[pos] = "";
                    }

                    for (int i = 0; i < usuarioRSA.historicoRSA.Length; i++)
                    {
                        if (!usuarioRSA.historicoRSA[i].Equals('ק'))
                        {
                            write += usuarioRSA.historicoRSA[i];
                        }
                        else
                        {
                            
                            for (int index = 0; index < 4; index++)
                            {
                                if (teste[index].Equals(""))
                                {
                                    teste[index] = write;
                                    write = "";
                                }
                            }

                            cont = 0;
                            for (int index = 0; index < 4; index++)
                            {
                                if (!teste[index].Equals(""))
                                {
                                    cont++;
                                }
                            }

                            if (cont == 4)
                            {
                                dgvHistoricoRSA.Rows.Add(teste);
                                for (int pos = 0; pos < 4; pos++)
                                {
                                    teste[pos] = "";
                                }
                                teste[0] = write;
                                write = "";
                            }
                        }
                    }
                    banco.Close();
                }
            }
            if (tbcMenuHistorico.SelectedIndex == 3)
            {
                try
                {
                    banco.Close();
                }
                finally
                {
                    banco = Db4oFactory.OpenFile(caminhoBanco);
                }


                dgvHistoricoEsteganografia.Rows.Clear();
                IObjectSet pesquisar = banco.QueryByExample(usuario);
                if (pesquisar.HasNext())
                {
                    Usuario usuarioEsteganografia = (Usuario)pesquisar.Next();

                    if (String.IsNullOrEmpty(usuarioEsteganografia.historicoEsteganografia))
                    {
                        banco.Close();
                        MessageBox.ShowMessageBoxOK("warning", "Não há atividades registradas na Esteganografia!", "Histórico vazio", DarkTheme);
                        return;
                    }

                    for (int pos = 0; pos < 4; pos++)
                    {
                        teste[pos] = "";
                    }

                    for (int i = 0; i < usuarioEsteganografia.historicoEsteganografia.Length; i++)
                    {
                        if (!usuarioEsteganografia.historicoEsteganografia[i].Equals('ק'))
                        {
                            write += usuarioEsteganografia.historicoEsteganografia[i];
                        }
                        else
                        {
                            
                            for (int index = 0; index < 4; index++)
                            {
                                if (teste[index].Equals(""))
                                {
                                    teste[index] = write;
                                    write = "";
                                }
                            }

                            cont = 0;
                            for (int index = 0; index < 4; index++)
                            {
                                if (!teste[index].Equals(""))
                                {
                                    cont++;
                                }
                            }

                            if (cont == 4)
                            {
                                dgvHistoricoEsteganografia.Rows.Add(teste);
                                for (int pos = 0; pos < 4; pos++)
                                {
                                    teste[pos] = "";
                                }
                                teste[0] = write;
                                write = "";
                            }
                            banco.Close();
                        }
                    }
                }
            }
            if (tbcMenuHistorico.SelectedIndex == 0)
            {
                if (!historyAES())
                    return;

            }

            if (tbcMenuHistorico.SelectedIndex == 1)
            {
                // AES COM ARQUIVO
                if (!historyAESArquivo())
                    return;

            }
            if (tbcMenuHistorico.SelectedIndex == 4)
            {
                try
                {
                    banco.Close();
                }
                finally
                {
                    banco = Db4oFactory.OpenFile(caminhoBanco);
                }

                dgvCesar.Rows.Clear();
                IObjectSet procurar = banco.QueryByExample(usuario);
                if (procurar.HasNext())
                {
                    Usuario usuarioCesar = (Usuario)procurar.Next();

                    if (String.IsNullOrEmpty(usuarioCesar.historicoCesar))
                    {
                        banco.Close();
                        MessageBox.ShowMessageBoxOK("warning", "Não foi salva nenhuma atividade em Cifra de Cesar!!", "Histórico vazio", DarkTheme);
                        return;
                    }
                    for (int pos = 0; pos < 5; pos++)
                    {
                        teste2[pos] = "";
                    }

                    for (int i = 0; i < usuarioCesar.historicoCesar.Length; i++)
                    {
                        if (!usuarioCesar.historicoCesar[i].Equals('ק'))
                        {
                            write += usuarioCesar.historicoCesar[i];
                        }
                        else
                        {

                            for (int index = 0; index < 5; index++)
                            {
                                if (teste2[index].Equals(""))
                                {
                                    teste2[index] = write;
                                    write = "";
                                }
                            }

                            cont = 0;
                            for (int index = 0; index < 5; index++)
                            {
                                if (!teste2[index].Equals(""))
                                {
                                    cont++;
                                }
                            }

                            if (cont == 5)
                            {
                                dgvCesar.Rows.Add(teste2);
                                for (int pos = 0; pos < 5; pos++)
                                {
                                    teste2[pos] = "";
                                }
                                teste2[0] = write;
                                write = "";
                            }
                            banco.Close();
                        }
                    }

                }

            }
            if (tbcMenuHistorico.SelectedIndex == 5)
            {
                try
                {
                    banco.Close();
                }
                finally
                {
                    banco = Db4oFactory.OpenFile(caminhoBanco);
                }

                dgvMorse.Rows.Clear();
                IObjectSet procurar = banco.QueryByExample(usuario);
                if (procurar.HasNext())
                {
                    Usuario usuarioMorse = (Usuario)procurar.Next();

                    if (String.IsNullOrEmpty(usuarioMorse.historicoMorse))
                    {
                        banco.Close();
                        MessageBox.ShowMessageBoxOK("warning", "Não foi salva nenhuma atividade em Código Morse!!", "Histórico vazio", DarkTheme);
                        return;
                    }
                    for (int pos = 0; pos < 4; pos++)
                    {
                        teste[pos] = "";
                    }

                    for (int i = 0; i < usuarioMorse.historicoMorse.Length; i++)
                    {
                        if (!usuarioMorse.historicoMorse[i].Equals('ק'))
                        {
                            write += usuarioMorse.historicoMorse[i];
                        }
                        else
                        {
                            
                            for (int index = 0; index < 4; index++)
                            {
                                if (teste[index].Equals(""))
                                {
                                    teste[index] = write;
                                    write = "";
                                }
                            }

                            cont = 0;
                            for (int index = 0; index < 4; index++)
                            {
                                if (!teste[index].Equals(""))
                                {
                                    cont++;
                                }
                            }

                            if (cont == 4)
                            {
                                dgvMorse.Rows.Add(teste);
                                for (int pos = 0; pos < 4; pos++)
                                {
                                    teste[pos] = "";
                                }
                                teste[0] = write;
                                write = "";
                            }
                            banco.Close();
                        }
                    }

                }
               

            }
        }

        private void Historico_Load(object sender, EventArgs e)
        {

        }

        private void RemoveLinhaUnica(DataGridView datagrid, DataGridViewCellEventArgs e)
        {
            // argumentos: Datagrid a ser manipulado e Eventos da célula (retirada do evento cell content click)
            try
            {

                string msg = "";
                /*
                if (tbcMenuHistorico.SelectedIndex != 2)
                {
                    for (int i = 0; i < 4; i++) //4 colunas p/datagrid
                    {
                        if (i == 3)
                        {
                            msg += datagrid.Rows[e.RowIndex].Cells[i].Value.ToString();
                            continue;
                        }
                        msg += datagrid.Rows[e.RowIndex].Cells[i].Value.ToString() + delimitadorInicial;
                    }
                    msg += delimitadorFinal;
                }
                */
                ///Aqui foi o que deu certo no histórico do RSA, só adaptar pra outras cifras
                ///Não sei qual delimitador utilizaram, mas acho melhor usar um só, o malakoi do hebraico lá 

                for (int i = 0; i < 4; i++) //4 colunas p/datagrid
                {
                    msg += datagrid.Rows[e.RowIndex].Cells[i].Value.ToString() + delimitadorFinal;
                }


                //busca no banco 

                string msgBanco = "";
                banco.Close();
                banco = Db4oFactory.OpenFile(caminhoBanco);

                IObjectSet resultado = banco.QueryByExample(usuario);

                string actualTab = tbcMenuHistorico.SelectedTab.Text;
                switch (actualTab)
                {
                    case "AES":
                        if (resultado.HasNext())
                        {
                            Usuario tmp = (Usuario)resultado.Next();
                            msgBanco = tmp.historicoAES;
                            msgBanco = msgBanco.Replace(msg, "");
                            tmp.historicoAES = msgBanco;
                            banco.Store(tmp);
                        }
                        break;
                    case "AES Arquivos":
                        if (resultado.HasNext())
                        {
                            Usuario tmp = (Usuario)resultado.Next();
                            msgBanco = tmp.historicoAESArquivo;
                            msgBanco = msgBanco.Replace(msg, "");
                            tmp.historicoAESArquivo = msgBanco;
                            banco.Store(tmp);
                        }
                        break;
                    case "RSA":
                        if (resultado.HasNext())
                        {
                            Usuario tmp = (Usuario)resultado.Next();
                            msgBanco = tmp.historicoRSA;
                            msgBanco = msgBanco.Replace(msg, "");
                            tmp.historicoRSA = msgBanco;
                            banco.Store(tmp);
                        }
                        break;
                    case "Esteganografia":
                        if (resultado.HasNext())
                        {
                            Usuario tmp = (Usuario)resultado.Next();
                            msgBanco = tmp.historicoEsteganografia;
                            msgBanco = msgBanco.Replace(msg, "");
                            tmp.historicoEsteganografia = msgBanco;
                            banco.Store(tmp);
                        }
                        break;
                    case "Código Morse":
                        if (resultado.HasNext())
                        {
                            Usuario tmp = (Usuario)resultado.Next();
                            msgBanco = tmp.historicoMorse;
                            msgBanco = msgBanco.Replace(msg, "");
                            tmp.historicoMorse = msgBanco;
                            banco.Store(tmp);
                        }
                        break;
                    case "Cifra de Cesar":
                        if (resultado.HasNext())
                        {
                            msg = "";
                            for (int i = 0; i < 5; i++) 
                            {
                                msg += datagrid.Rows[e.RowIndex].Cells[i].Value.ToString() + delimitadorFinal;
                            }
                            Usuario tmp = (Usuario)resultado.Next();
                            msgBanco = tmp.historicoCesar;
                            msgBanco = msgBanco.Replace(msg, "");
                            tmp.historicoCesar = msgBanco;
                            banco.Store(tmp);
                        }
                        break;
                    default:
                        break;
                }
                banco.Close();
            }
            catch (Exception)
            {
                return;
            }

        }

        private void RemoveLinhaASK(DataGridView datagrid, string nome_coluna, DataGridViewCellEventArgs e, int x)
        {
            try
            {
                
                int contador = 0; // verifica se a linha está totalmente vazia
                if (datagrid.Columns[e.ColumnIndex].Name == nome_coluna)
                {

                    DataGridViewRow obj = datagrid.Rows[e.RowIndex];
                    for (int i = 0; i < x; i++)
                    {
                        if (String.IsNullOrEmpty(obj.Cells[i].Value.ToString()))
                            contador++;
                    }
                    if (contador == x - 1)
                        return;
                    //DialogResult resu = System.Windows.Forms.MessageBox.Show("Deseja realmente excluir ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (MessageBox.ShowMessageBoxYesNo("question", "Deseja realmente excluir ?", "Confirmar exclusão",DarkTheme).Equals("sim"))
                    {
                        RemoveLinhaUnica(datagrid, e);
                        DataGridViewRow linha_select = datagrid.Rows[e.RowIndex];
                        datagrid.Rows.Remove(linha_select);
                    }
                    
                }
            }
            catch (Exception)
            {
                return;
            }
        }



        private void dataGridViewAES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = 4;
            RemoveLinhaASK(dataGridViewAES, "columnDeletar", e, x);
        }

        private void dataGridViewAESArquivo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = 4;
            RemoveLinhaASK(dataGridViewAESArquivo, "columnDeletarAESArq", e, x);
        }

        private void dgvHistoricoRSA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = 4;
            RemoveLinhaASK(dgvHistoricoRSA, "columnRSADeletar", e, x);
        }

        private void dgvHistoricoEsteganografia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = 4;
            RemoveLinhaASK(dgvHistoricoEsteganografia, "columnEstegaDeletar", e, x );
        }

        private void dgvMorse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = 4;
            RemoveLinhaASK(dgvMorse, "columnMorseDeletar", e, x);
        }

        private void dgvCesar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = 5;
            RemoveLinhaASK(dgvCesar, "columnCesarDeletar", e, x);
        }
    }
}
