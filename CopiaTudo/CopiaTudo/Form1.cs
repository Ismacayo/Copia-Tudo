using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CopiaTudo
{
    public partial class FormPrincipal : Form
    {
        private List<string> extenssao = new List<string>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirJanelaText1_Click(object sender, EventArgs e)
        {
            try
            {
                CaminhoBrowser.ShowDialog();

                if (CaminhoBrowser.SelectedPath != "")
                {
                    CaminhoRaizText.Text = CaminhoBrowser.SelectedPath;
                }

                else
                {
                    MessageBox.Show("Por Favor Selecione um Caminho:");
                }
            }

            catch(Exception x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }
        }

        private void AbrirJanelaText2_Click(object sender, EventArgs e)
        {
            try
            {
                CaminhoBrowser.ShowDialog();

                if (CaminhoBrowser.SelectedPath != "")
                {
                    CaminhoCopiarText.Text = CaminhoBrowser.SelectedPath;
                }

                else
                {
                    MessageBox.Show("Por Favor Selecione um Caminho:");
                }
            }

            catch (Exception x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }
        }

        private void ExtensoesText_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (ExtensoesText.Text.Length == 1 && e.KeyChar == (char)8)
                {
                    e.Handled = true;
                }

                else if (e.KeyChar == (char)8)
                {
                    int tamanho = ExtensoesText.Text.Length;

                    if (ExtensoesText.Text[tamanho - 1] == '.')
                    {
                        ExtensoesText.Text = ExtensoesText.Text.Remove(tamanho - 2, 1);
                    }
                }

                if (e.KeyChar == ';')
                {
                    ExtensoesText.Text = string.Concat(ExtensoesText.Text, ";.");
                    ExtensoesText.Select(ExtensoesText.Text.Length, 0);
                    e.Handled = true;
                }
            }
            
            catch (ArgumentOutOfRangeException x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }

            catch (Exception x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }
        }

        private void ExtensoesText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ExtensoesText.Text = Regex.Replace(ExtensoesText.Text, "[^a-zA-Z-.;]+", "");
                ExtensoesText.Select(ExtensoesText.Text.Length, 0);
            }

            catch (ArgumentOutOfRangeException x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }

            catch (Exception x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }
        }

        private void CopiarButoon_Click(object sender, EventArgs e)
        {
            try
            {
                PegaExtensao(ExtensoesText.Text, ';');

                if (VerificarText()) CopiarTudo(CheckALL.Checked, extenssao);
                else MessageBox.Show("Por favor selecione dois caminhos validos!");
            }

            catch (ArgumentOutOfRangeException x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }

            catch (Exception x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }
        }

        private void NomeArquivos_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VerificarText())
                {
                    MessageBox.Show("Por Favor Escreva um Caminho Raiz e Caminho pra Copiar: ");
                }

                else
                {
                    Form ListaArquivos = new ListaArquivos();
                    GlobalMessage.fechou = false;
                    ListaArquivos.ShowDialog();
                    if (!GlobalMessage.fechou) CopiarTudo(CheckALL.Checked);
                }
            }

            catch (InvalidOperationException x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }

            catch (Exception x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }
        }

        /// <summary>
        /// Pega a string e joga numa lista usando o limitador como parametro
        /// </summary>
        /// <param name="texto">String completa pra extração</param>
        /// <param name="limitador">limitador pra pular pro proximo indice</param>
        /// <exception cref="ArgumentNullException"></exception>
        void PegaExtensao(string texto, char limitador)
        {
            try
            {
                string retiraText = "";
                int ultposi = 0;

                for (var i = 0; i < texto.Length; i++)
                {
                    if (texto[i] == limitador)
                    {
                        for (var j = ultposi; j < i; j++)
                        {
                            retiraText = String.Concat(retiraText, texto[j]);
                        }
                        ultposi = i + 1;
                        extenssao.Add(retiraText);
                        retiraText = "";
                    }
                }

                for (var j = ultposi; j < texto.Length; j++)
                {
                    retiraText = String.Concat(retiraText, texto[j]);
                }
                extenssao.Add(retiraText);
            }

            catch(ArgumentNullException e)
            {
                throw e;
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Busca na pasta raiz os arquivos com a extenssão selecionada e copia pro destino
        /// </summary>
        /// <param name="extenssao">List da extenssão selecionada</param>
        /// <param name="ALL">Se é pra ir nas subpastas ou não</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="SecurityException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        void CopiarTudo(bool ALL, List<string> extenssao)
        {
            try
            {
                bool encontrou = true;
                DirectoryInfo dir = new DirectoryInfo(CaminhoRaizText.Text);
                progressBar.Maximum = 0;

                if (ALL)
                {
                    IEnumerable<FileInfo> listDeArquivos = dir.GetFiles("*.*", SearchOption.AllDirectories).Where
                                                                      (s => extenssao.Contains(s.Extension));
                    progressBar.Maximum = listDeArquivos.Count();

                    if (listDeArquivos.Count() != 0)
                    {
                        foreach (var arquivosCopiar in listDeArquivos)
                        {
                            if (!File.Exists(CaminhoCopiarText.Text + "\\" + arquivosCopiar.Name))
                            {
                                File.Copy(arquivosCopiar.FullName, CaminhoCopiarText.Text + "\\" + arquivosCopiar.Name);
                            }
                            progressBar.Value++;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Não foram encontrados nenhum arquivo");
                        encontrou = false;
                    }
                }

                else
                {
                    IEnumerable<FileInfo> listDeArquivos = dir.GetFiles("*.*", SearchOption.TopDirectoryOnly).Where
                                                                      (s => extenssao.Contains(s.Extension));
                    progressBar.Maximum = listDeArquivos.Count();

                    if (listDeArquivos.Count() != 0)
                    {
                        foreach (var arquivosCopiar in listDeArquivos)
                        {
                            if (!File.Exists(CaminhoCopiarText.Text + "\\" + arquivosCopiar.Name))
                            {
                                File.Copy(arquivosCopiar.FullName, CaminhoCopiarText.Text + "\\" + arquivosCopiar.Name);
                            }
                            progressBar.Value++;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Não foram encontrados nenhum arquivo");
                        encontrou = false;
                    }
                }

                if (encontrou) MessageBox.Show("              Pronto");
            }

            #region Catch
            catch (ArgumentNullException e)
            {
                throw e;
            }

            catch (ArgumentOutOfRangeException e)
            {
                throw e;
            }

            catch (ArgumentException e)
            {
                throw e;
            }

            catch (DirectoryNotFoundException e)
            {
                throw e;
            }

            catch (FileNotFoundException e)
            {
                throw e;
            }

            catch (NotSupportedException e)
            {
                throw e;
            }

            catch (PathTooLongException e)
            {
                throw e;
            }

            catch (IOException e)
            {
                throw e;
            }

            catch (SecurityException e)
            {
                throw e;
            }

            catch (UnauthorizedAccessException e)
            {
                throw e;
            }

            catch (Exception e)
            {
                throw e;
            }
            #endregion
        }

        /// <summary>
        /// Busca na pasta raiz os arquivos selecionados e copia pro destino
        /// </summary>
        /// <param name="ALL">Se é pra ir nas subpastas ou não</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="SecurityException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        void CopiarTudo(bool ALL)
        {
            try
            {
                bool encontrou = false;
                DirectoryInfo dir = new DirectoryInfo(CaminhoRaizText.Text);
                progressBar.Maximum = 0;
                
                if (ALL)
                {
                    IEnumerable<FileInfo> listDeArquivos = dir.GetFiles("*.*", SearchOption.AllDirectories);
                    progressBar.Maximum = GlobalMessage.listadeArquivos.Count();

                    foreach (var arquivosCopiar in listDeArquivos)
                    {
                        foreach(var arquivosVerificar in GlobalMessage.listadeArquivos)
                        {
                            if(arquivosCopiar.Name == arquivosVerificar)
                            {
                                encontrou = true;
                                if (!File.Exists(CaminhoCopiarText.Text + "\\" + arquivosCopiar.Name))
                                {
                                    File.Copy(arquivosCopiar.FullName, CaminhoCopiarText.Text + "\\" + arquivosCopiar.Name);
                                }
                                progressBar.Value++;
                            }
                        }
                    }
                }

                else
                {
                    IEnumerable<FileInfo> listDeArquivos = dir.GetFiles("*.*", SearchOption.TopDirectoryOnly);
                    progressBar.Maximum = GlobalMessage.listadeArquivos.Count();

                    foreach (var arquivosCopiar in listDeArquivos)
                    {
                        foreach (var arquivosVerificar in GlobalMessage.listadeArquivos)
                        {
                            if (arquivosCopiar.Name == arquivosVerificar)
                            {
                                encontrou = true;
                                if (!File.Exists(CaminhoCopiarText.Text + "\\" + arquivosCopiar.Name))
                                {
                                    File.Copy(arquivosCopiar.FullName, CaminhoCopiarText.Text + "\\" + arquivosCopiar.Name);
                                }
                                progressBar.Value++;
                            }
                        }
                    }
                }

               if(encontrou) MessageBox.Show("              Pronto");
               else MessageBox.Show("Não foram encontrados nenhum arquivo");
            }

            #region Catch
            catch (ArgumentNullException e)
            {
                throw e;
            }

            catch (ArgumentOutOfRangeException e)
            {
                throw e;
            }

            catch (ArgumentException e)
            {
                throw e;
            }

            catch (DirectoryNotFoundException e)
            {
                throw e;
            }

            catch (FileNotFoundException e)
            {
                throw e;
            }

            catch (NotSupportedException e)
            {
                throw e;
            }

            catch (PathTooLongException e)
            {
                throw e;
            }

            catch (IOException e)
            {
                throw e;
            }

            catch (SecurityException e)
            {
                throw e;
            }

            catch (UnauthorizedAccessException e)
            {
                throw e;
            }

            catch (Exception e)
            {
                throw e;
            }
            #endregion
        }

        /// <summary>
        /// Verifica se os textbox estão preenchidos
        /// </summary>
        /// <returns>bolleano com o resulado</returns>
        private bool VerificarText()
        {
            try
            {
                if (CaminhoRaizText.Text == "" && CaminhoCopiarText.Text == "")
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }

            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
