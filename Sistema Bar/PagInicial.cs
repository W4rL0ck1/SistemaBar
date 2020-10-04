using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Collections;


namespace Sistema_Bar
{
    public partial class PagInicial : Form
    {
        Principal t1 = new Principal();
        IniFile ini1 = new IniFile();       
        FrmCategoria conf = new FrmCategoria(); 
        bool[] VerifCustomImg =  new bool[25];
        bool[] VerifAtivado = new bool[25];
        int aux;

        //FUNÇÕES 
        void  CarregarImgCustomCategoria(int categoria)
        {
            String imageLocation = "";

            if (categoria == 1)
            {
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All files(*.*)|*.*";

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = dialog.FileName;

                        picBoxOpcao1.ImageLocation = imageLocation;
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 1", true);
                        ini1.IniWriteString("Caminho Dos Icones Personalizados", "Imagem 1", imageLocation);
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (categoria == 2)
            {
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All files(*.*)|*.*";

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = dialog.FileName;

                        picBoxOpcao2.ImageLocation = imageLocation;
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 2", true);
                        ini1.IniWriteString("Caminho Dos Icones Personalizados", "Imagem 2", imageLocation);
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (categoria == 3)
            {
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All files(*.*)|*.*";

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = dialog.FileName;

                        picBoxOpcao3.ImageLocation = imageLocation;
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 3", true);
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 3", true);
                        ini1.IniWriteString("Caminho Dos Icones Personalizados", "Imagem 3", imageLocation);
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (categoria == 4)
            {
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All files(*.*)|*.*";

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = dialog.FileName;

                        picBoxOpcao4.ImageLocation = imageLocation;
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 4", true);
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 4", true);
                        ini1.IniWriteString("Caminho Dos Icones Personalizados", "Imagem 4", imageLocation);
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (categoria == 5)
            {
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All files(*.*)|*.*";

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = dialog.FileName;

                        picBoxOpcao5.ImageLocation = imageLocation;
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 5", true);
                        ini1.IniWriteString("Caminho Dos Icones Personalizados", "Imagem 5", imageLocation);
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (categoria == 6)
            {
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All files(*.*)|*.*";

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = dialog.FileName;

                        picBoxOpcao6.ImageLocation = imageLocation;
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 6", true);
                        ini1.IniWriteString("Caminho Dos Icones Personalizados", "Imagem 6", imageLocation);
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (categoria == 7)
            {
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All files(*.*)|*.*";

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = dialog.FileName;

                        picBoxOpcao7.ImageLocation = imageLocation;
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 7", true);
                        ini1.IniWriteString("Caminho Dos Icones Personalizados", "Imagem 7", imageLocation);
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (categoria == 8)
            {
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All files(*.*)|*.*";

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = dialog.FileName;

                        picBoxOpcao8.ImageLocation = imageLocation;
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 8", true);
                        ini1.IniWriteString("Caminho Dos Icones Personalizados", "Imagem 8", imageLocation);
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }          

        }

        void CarregarImgCustomProdutos()
        { 
        
        }

        void CarregarProdutos(int categoria)
        {
            VerifCustomImg[1] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 1", false);
            VerifCustomImg[2] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 2", false);
            VerifCustomImg[3] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 3", false);
            VerifCustomImg[4] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 4", false);
            VerifCustomImg[5] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 5", false);
            VerifCustomImg[6] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 6", false);
            VerifCustomImg[7] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 7", false);
            VerifCustomImg[8] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 8", false);
            VerifCustomImg[9] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 9", false);
            VerifCustomImg[10] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 10", false);
            VerifCustomImg[11] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 11", false);
            VerifCustomImg[12] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 12", false);
            VerifCustomImg[13] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 13", false);
            VerifCustomImg[14] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 14", false);
            VerifCustomImg[15] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 15", false);
            VerifCustomImg[16] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 16", false);
            VerifCustomImg[17] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 17", false);
            VerifCustomImg[18] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 18", false);
            VerifCustomImg[19] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 19", false);
            VerifCustomImg[20] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 20", false);
            VerifCustomImg[21] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 21", false);
            VerifCustomImg[22] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 22", false);
            VerifCustomImg[23] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 23", false);
            VerifCustomImg[24] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado 24", false);


            VerifAtivado[1] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 1", false);
            VerifAtivado[2] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 2", false);
            VerifAtivado[3] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 3", false);
            VerifAtivado[4] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 4", false);
            VerifAtivado[5] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 5", false);
            VerifAtivado[6] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 6", false);
            VerifAtivado[7] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 7", false);
            VerifAtivado[8] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 8", false);
            VerifAtivado[9] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 9", false);
            VerifAtivado[10] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 10", false);
            VerifAtivado[11] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 11", false);
            VerifAtivado[12] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 12", false);
            VerifAtivado[13] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 13", false);
            VerifAtivado[14] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 14", false);
            VerifAtivado[15] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 15", false);
            VerifAtivado[16] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 16", false);
            VerifAtivado[17] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 17", false);
            VerifAtivado[18] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 18", false);
            VerifAtivado[19] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 19", false);
            VerifAtivado[20] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 20", false);
            VerifAtivado[21] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 21", false);
            VerifAtivado[22] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 22", false);
            VerifAtivado[23] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 23", false);
            VerifAtivado[24] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item 24", false);


            if (VerifCustomImg[1] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 1", 0);
                pictureBoxProduto1.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[1] == true)
            {
                pictureBoxProduto1.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 1", ""));
            }

            if (VerifCustomImg[2] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 2", 0);
                pictureBoxProduto2.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[2] == true)
            {
                pictureBoxProduto2.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 2", ""));
            }

            if (VerifCustomImg[3] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 3", 0);
                pictureBoxProduto3.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[3] == true)
            {
                pictureBoxProduto3.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 3", ""));
            }

            if (VerifCustomImg[4] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 4", 0);
                pictureBoxProduto4.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[4] == true)
            {
                pictureBoxProduto4.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 4", ""));
            }

            if (VerifCustomImg[5] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 5", 0);
                pictureBoxProduto5.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[5] == true)
            {
                pictureBoxProduto5.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 5", ""));
            }

            if (VerifCustomImg[6] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 6", 0);
                pictureBoxProduto6.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[6] == true)
            {
                pictureBoxProduto6.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 6", ""));
            }

            if (VerifCustomImg[7] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 7", 0);
                pictureBoxProduto7.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[7] == true)
            {
                pictureBoxProduto7.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 7", ""));
            }
            if (VerifCustomImg[8] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 8", 0);
                pictureBoxProduto8.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[8] == true)
            {
                pictureBoxProduto8.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 8", ""));
            }
            if (VerifCustomImg[9] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 9", 0);
                pictureBoxProduto9.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[9] == true)
            {
                pictureBoxProduto9.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 9", ""));
            }
            if (VerifCustomImg[10] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 10", 0);
                pictureBoxProduto10.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[10] == true)
            {
                pictureBoxProduto10.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 10", ""));
            }
            if (VerifCustomImg[11] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 11", 0);
                pictureBoxProduto11.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[11] == true)
            {
                pictureBoxProduto11.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 11", ""));
            }
            if (VerifCustomImg[12] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 12", 0);
                pictureBoxProduto12.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[12] == true)
            {
                pictureBoxProduto12.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 12", ""));
            }
            if (VerifCustomImg[13] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 13", 0);
                pictureBoxProduto13.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[13] == true)
            {
                pictureBoxProduto13.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 13", ""));
            }
            if (VerifCustomImg[14] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 14", 0);
                pictureBoxProduto14.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[14] == true)
            {
                pictureBoxProduto14.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 14", ""));
            }
            if (VerifCustomImg[15] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 15", 0);
                pictureBoxProduto15.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[15] == true)
            {
                pictureBoxProduto15.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 15", ""));
            }
            if (VerifCustomImg[16] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 16", 0);
                pictureBoxProduto16.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[16] == true)
            {
                pictureBoxProduto16.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 16", ""));
            }
            if (VerifCustomImg[17] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 17", 0);
                pictureBoxProduto17.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[17] == true)
            {
                pictureBoxProduto17.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 17", ""));
            }
            if (VerifCustomImg[18] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 18", 0);
                pictureBoxProduto18.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[18] == true)
            {
                pictureBoxProduto18.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 18", ""));
            }
            if (VerifCustomImg[19] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 19", 0);
                pictureBoxProduto19.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[19] == true)
            {
                pictureBoxProduto19.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 19", ""));
            }
            if (VerifCustomImg[20] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 20", 0);
                pictureBoxProduto20.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[20] == true)
            {
                pictureBoxProduto20.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 20", ""));
            }
            if (VerifCustomImg[21] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 21", 0);
                pictureBoxProduto21.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[21] == true)
            {
                pictureBoxProduto21.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 21", ""));
            }
            if (VerifCustomImg[22] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 22", 0);
                pictureBoxProduto22.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[22] == true)
            {
                pictureBoxProduto22.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 22", ""));
            }
            if (VerifCustomImg[23] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 23", 0);
                pictureBoxProduto23.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[23] == true)
            {
                pictureBoxProduto23.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 23", ""));
            }
            if (VerifCustomImg[24] == false)
            {
                aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 24", 0);
                pictureBoxProduto24.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[24] == true)
            {
                pictureBoxProduto24.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 24", ""));
            }

            labelProduto1.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 1", "");
            labelProduto2.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 2", "");
            labelProduto3.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 3", "");
            labelProduto4.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 4", "");
            labelProduto5.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 5", "");
            labelProduto6.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 6", "");
            labelProduto7.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 7", "");
            labelProduto8.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 8", "");
            labelProduto9.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 9", "");
            labelProduto10.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 10", "");
            labelProduto11.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 11", "");
            labelProduto12.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 12", "");
            labelProduto13.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 13", "");
            labelProduto14.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 14", "");
            labelProduto15.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 15", "");
            labelProduto16.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 16", "");
            labelProduto17.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 17", "");
            labelProduto18.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 18", "");
            labelProduto19.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 19", "");
            labelProduto20.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 20", "");
            labelProduto21.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 21", "");
            labelProduto22.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 22", "");
            labelProduto23.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 23", "");
            labelProduto24.Text = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 24", "");

            /* labelProduto.Visible = VerifAtivado[];
             pictureBoxProduto.Visible = VerifAtivado[]; */

            labelProduto1.Visible = VerifAtivado[1];
            pictureBoxProduto1.Visible = VerifAtivado[1];
            labelProduto2.Visible = VerifAtivado[2];
            pictureBoxProduto2.Visible = VerifAtivado[2];
            labelProduto3.Visible = VerifAtivado[3];
            pictureBoxProduto3.Visible = VerifAtivado[3];
            labelProduto4.Visible = VerifAtivado[4];
            pictureBoxProduto4.Visible = VerifAtivado[4];
            labelProduto5.Visible = VerifAtivado[5];
            pictureBoxProduto5.Visible = VerifAtivado[5];
            labelProduto6.Visible = VerifAtivado[6];
            pictureBoxProduto6.Visible = VerifAtivado[6];
            labelProduto7.Visible = VerifAtivado[7];
            pictureBoxProduto7.Visible = VerifAtivado[7];
            labelProduto8.Visible = VerifAtivado[8];
            pictureBoxProduto8.Visible = VerifAtivado[8];
            labelProduto9.Visible = VerifAtivado[9];
            pictureBoxProduto9.Visible = VerifAtivado[9];
            labelProduto10.Visible = VerifAtivado[10];
            pictureBoxProduto10.Visible = VerifAtivado[10];
            labelProduto11.Visible = VerifAtivado[11];
            pictureBoxProduto11.Visible = VerifAtivado[11];
            labelProduto12.Visible = VerifAtivado[12];
            pictureBoxProduto12.Visible = VerifAtivado[12];
            labelProduto13.Visible = VerifAtivado[13];
            pictureBoxProduto13.Visible = VerifAtivado[13];
            labelProduto14.Visible = VerifAtivado[14];
            pictureBoxProduto14.Visible = VerifAtivado[14];
            labelProduto15.Visible = VerifAtivado[15];
            pictureBoxProduto15.Visible = VerifAtivado[15];
            labelProduto16.Visible = VerifAtivado[16];
            pictureBoxProduto16.Visible = VerifAtivado[16];
            labelProduto17.Visible = VerifAtivado[17];
            pictureBoxProduto17.Visible = VerifAtivado[17];
            labelProduto18.Visible = VerifAtivado[18];
            pictureBoxProduto18.Visible = VerifAtivado[18];
            labelProduto19.Visible = VerifAtivado[19];
            pictureBoxProduto19.Visible = VerifAtivado[19];
            labelProduto20.Visible = VerifAtivado[20];
            pictureBoxProduto20.Visible = VerifAtivado[20];
            labelProduto21.Visible = VerifAtivado[21];
            pictureBoxProduto21.Visible = VerifAtivado[21];
            labelProduto22.Visible = VerifAtivado[22];
            pictureBoxProduto22.Visible = VerifAtivado[22];
            labelProduto23.Visible = VerifAtivado[23];
            pictureBoxProduto23.Visible = VerifAtivado[23];
            labelProduto24.Visible = VerifAtivado[24];
            pictureBoxProduto24.Visible = VerifAtivado[24];

        }


        public void CarregarCategorias()
        {
            VerifCustomImg[1] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 1", false);
            VerifCustomImg[2] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 2", false);
            VerifCustomImg[3] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 3", false);
            VerifCustomImg[4] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 4", false);
            VerifCustomImg[5] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 5", false);
            VerifCustomImg[6] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 6", false);
            VerifCustomImg[7] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 7", false);
            VerifCustomImg[8] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 8", false);


            if (VerifCustomImg[1] == false)
            {
                aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 1", 0);
                picBoxOpcao1.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[1] == true)
            {
                picBoxOpcao1.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 1", ""));
            }

            if (VerifCustomImg[2] == false)
            {
                aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 2", 0);
                picBoxOpcao2.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[2] == true)
            {
                picBoxOpcao2.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 2", ""));
            }

            if (VerifCustomImg[3] == false)
            {
                aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 3", 0);
                picBoxOpcao3.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[3] == true)
            {
                picBoxOpcao3.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 3", ""));
            }

            if (VerifCustomImg[4] == false)
            {
                aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 4", 0);
                picBoxOpcao4.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[4] == true)
            {
                picBoxOpcao4.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 4", ""));
            }

            if (VerifCustomImg[5] == false)
            {
                aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 5", 0);
                picBoxOpcao5.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[5] == true)
            {
                picBoxOpcao1.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 5", ""));
            }

            if (VerifCustomImg[6] == false)
            {
                aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 6", 0);
                picBoxOpcao6.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[6] == true)
            {
                picBoxOpcao6.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 6", ""));
            }

            if (VerifCustomImg[7] == false)
            {
                aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 7", 0);
                picBoxOpcao7.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[7] == true)
            {
                picBoxOpcao7.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 7", ""));
            }
            if (VerifCustomImg[8] == false)
            {
                aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 8", 0);
                picBoxOpcao8.Image = t1.IconProdutos[aux];
            }
            else if (VerifCustomImg[8] == true)
            {
                picBoxOpcao8.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 8", ""));
            }

            labalCateg1.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
            labalCateg2.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 2", "");
            labalCateg3.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 3", "");
            labalCateg4.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 4", "");
            labalCateg5.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 5", "");
            labalCateg6.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 6", "");
            labalCateg7.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 7", "");
            labalCateg8.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 8", "");
           
        }

        void CarregarFrmCnfrmCategorias()
        {
            conf.labelNomeCategoria1.Visible = true;
            conf.buttonCancelar.Visible = true;
            conf.comboBoxCateg.Visible = true;
            conf.comboBoxCateg.Visible = true;
            conf.picBoxImageUp.Visible = true;
            conf.labelNomeCategoria1.Text = "Alterar o nome da categoria: ";
            conf.textBoxResultado.Text = "";
            conf.comboBoxCateg.Text = "";
            conf.comboBoxCateg.Items.Clear();
            conf.comboBoxSelecionarImg.Items.Clear();
            conf.comboBoxOpcoesCategoria.Items.Clear();
            conf.comboBoxCateg.Items.AddRange(new object[] { ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 2", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 3", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 4", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 5", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 6", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 7", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 8", "") });
            conf.comboBoxSelecionarImg.Items.AddRange(new object[] { 1,2,3,4,5,6,7,8,9,10, 11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49 });
            conf.comboBoxOpcoesCategoria.Items.AddRange(new object[] { "Alterar Nome das Categorias", "Alterar Imagem das Categorias" });           
            conf.MaximumSize = new System.Drawing.Size(202, 463);
            conf.Size = new System.Drawing.Size(202, 463);
            conf.buttonCancelar.Location = new System.Drawing.Point(57, 421);
            conf.picBoxImageUp.Location = new System.Drawing.Point( 26, 52);
        }

        void CarregarFrmCnfrmImgCustom()
        {
            conf.labelNomeCategoria1.Text = "Carregar Icone Customizada:"; conf.labelCategoria1.Visible = true;
            conf.labelCategoria1.Text = "Salvar Icone no Slot:"; conf.labelCategoria1.Visible = true;
            conf.comboBoxSlotImg.Text = "Selecionar Slot:"; conf.comboBoxSlotImg.Visible = true;
            conf.MaximumSize = new System.Drawing.Size(202, 463);
            conf.picBoxImageUp.Visible = true;
            conf.buttonCancelar.Visible = true;           
            conf.comboBoxSlotImg.Items.Clear();
            conf.comboBoxSlotImg.Items.AddRange(new object[] {41,42,43,44,45,46,47,48,49});
            conf.buttonCancelar.Location = new System.Drawing.Point(57, 307);
            conf.picBoxImageUp.Location = new System.Drawing.Point(26, 25);
            conf.MaximumSize = new System.Drawing.Size(202, 348);
        }


        //LOAD

        public PagInicial()
        {
            InitializeComponent();
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {                   
            //hover troca imagens
            t1.Instaciar_Imagens();
            CarregarCategorias();

            // this.pictureBoxHome.MouseHover += new System.EventHandler(this.PictureBoxHome_MouseHover);

            //conf.MouseLeave += new System.EventHandler(this.CarregarFrmCnfrmCategorias);
        }



        //hover de imagem 

        private void PictureBoxHome_MouseHover(object sender, EventArgs e)
        {
            pictureBoxHome.BackgroundImage = t1.Imgs[2];
        }

        private void PictureBoxHome_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxHome.BackgroundImage = t1.Imgs[1];
        }

        private void PictureBoxCarrinho_MouseHover(object sender, EventArgs e)
        {
            pictureBoxCarrinho.BackgroundImage = t1.Imgs[4];
        }

        private void PictureBoxCarrinho_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCarrinho.BackgroundImage = t1.Imgs[3];
        }

        private void PictureBoxCaixa_MouseHover(object sender, EventArgs e)
        {
            pictureBoxCaixa.BackgroundImage = t1.Imgs[6];
        }

        private void PictureBoxCaixa_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCaixa.BackgroundImage = t1.Imgs[5];
        }


    
        private void RetornarProdutosPadrãoDoProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gerando...");
            t1.GerarIni();
            CarregarCategorias();
            MessageBox.Show("Arquivo Ini gerado! Seus produtos e categorias foram retornados aos \n valores originais do programa");
        }


        private void AlterarIconeDasCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conf.Show();
            CarregarFrmCnfrmCategorias();
        }

        private void PictureBoxHome_Click(object sender, EventArgs e)
        {           
            
        }

        private void PictureBoxCarrinho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carrinho");
        }

        private void PictureBoxCaixa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caixa");
        }        

        private void atualizarArqIniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarCategorias();
        }


        private void toolStripMenuCat1_Click(object sender, EventArgs e)
        {
            CarregarImgCustomCategoria(1);           
        }

        private void toolStripMenuCat2_Click(object sender, EventArgs e)
        {
            CarregarImgCustomCategoria(2);
        }

        private void toolStripMenuCat3_Click(object sender, EventArgs e)
        {
            CarregarImgCustomCategoria(3);
        }

        private void toolStripMenuCat4_Click(object sender, EventArgs e)
        {
            CarregarImgCustomCategoria(4);
        }

        private void toolStripMenuCat5_Click(object sender, EventArgs e)
        {
            CarregarImgCustomCategoria(5);
        }

        private void toolStripMenuCat6_Click(object sender, EventArgs e)
        {
            CarregarImgCustomCategoria(6);
        }

        private void toolStripMenuCat7_Click(object sender, EventArgs e)
        {
            CarregarImgCustomCategoria(7);
        }

        private void toolStripMenuCat8_Click(object sender, EventArgs e)
        {
            CarregarImgCustomCategoria(8);
        }

        private void picBoxOpcao1_Click(object sender, EventArgs e)
        {
            CarregarProdutos(1);
        }

        private void picBoxOpcao2_Click(object sender, EventArgs e)
        {
            CarregarProdutos(2);
        }

        private void picBoxOpcao3_Click(object sender, EventArgs e)
        {
            CarregarProdutos(3);
        }

        private void picBoxOpcao4_Click(object sender, EventArgs e)
        {
            CarregarProdutos(4);
        }

        private void picBoxOpcao5_Click(object sender, EventArgs e)
        {
            CarregarProdutos(5);
        }

        private void picBoxOpcao6_Click(object sender, EventArgs e)
        {
            CarregarProdutos(6);
        }

        private void picBoxOpcao7_Click(object sender, EventArgs e)
        {
            CarregarProdutos(7);
        }

        private void picBoxOpcao8_Click(object sender, EventArgs e)
        {
            CarregarProdutos(8);
        }






        private void picBoxOpcao1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void picBoxOpcao1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void picBoxOpcao2_MouseHover(object sender, EventArgs e)
        {
            panel2.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");           
        }

        private void picBoxOpcao2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void picBoxOpcao3_MouseHover(object sender, EventArgs e)
        {
            panel3.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void picBoxOpcao3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void picBoxOpcao4_MouseHover(object sender, EventArgs e)
        {
            panel4.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void picBoxOpcao4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void picBoxOpcao5_MouseHover(object sender, EventArgs e)
        {
            panel5.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void picBoxOpcao5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void picBoxOpcao6_MouseHover(object sender, EventArgs e)
        {
            panel6.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void picBoxOpcao6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void picBoxOpcao7_MouseHover(object sender, EventArgs e)
        {
            panel7.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void picBoxOpcao7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void picBoxOpcao8_MouseHover(object sender, EventArgs e)
        {
            panel8.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void picBoxOpcao8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }
    }
}

/* picBoxOpcao1.BackColor = Color.Transparent;
 picBoxOpcao1.BackColor = Color.DarkGray; */

/* panel1.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");

panel1.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png"); */
