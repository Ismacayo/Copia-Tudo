using System;
using System.Windows.Forms;

namespace CopiaTudo
{
    public partial class ListaArquivos : Form
    {
        private bool fechar = false;

        public ListaArquivos()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }

            #region Catch
            catch (ObjectDisposedException x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }

            catch (InvalidOperationException x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }

            catch (Exception x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }
            #endregion
        }

        private void ListaArquivos_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (fechar == false)
                {
                    if (MessageBox.Show("Deseja Realmente Fechar o Programa sem Dado Nenhum?",
                                "Confirmação", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        GlobalMessage.fechou = true;
                    }
                }

                else
                {
                    int i = 0;

                    GlobalMessage.InstaciaArray(ListaArquivosText.Lines.Length);

                    foreach (string listaArray in ListaArquivosText.Lines)
                    {
                        GlobalMessage.SetListadeArquivos(listaArray, i);
                        i++;
                    }

                }
            }

            #region Catch
            catch (InvalidOperationException x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }

            catch (Exception x)
            {
                MessageBox.Show("Erro: " + x.Message);
            }
            #endregion
        }

        private void ListaArquivosText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ListaArquivosText.Text != "") fechar = true;
            }

            catch(Exception x)
            {
                MessageBox.Show("Erro: " + x.Message); 
            }
        }
    }
}
