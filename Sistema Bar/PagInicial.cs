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
        FrmCnfrm conf = new FrmCnfrm(); 
        int[] picboxImage = new int[11];
        bool[] VerifCustomImg =  new bool[11];


        void  CarregarImgCustom(int categoria)
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

        void CarregarCategorias()
        {
            VerifCustomImg[1] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 1", false);
            VerifCustomImg[2] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 2", false); ;
            VerifCustomImg[3] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 3", false);
            VerifCustomImg[4] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 4", false);
            VerifCustomImg[5] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 5", false);
            VerifCustomImg[6] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 6", false);
            VerifCustomImg[7] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 7", false);
            VerifCustomImg[8] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 8", false);


            if (VerifCustomImg[1] == false)
            {
                picboxImage[1] = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 1", 0);
                picBoxOpcao1.Image = t1.IconProdutos[picboxImage[1]];
            }
            else if (VerifCustomImg[1] == true)
            {
                picBoxOpcao1.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 1", ""));
            }

            if (VerifCustomImg[2] == false)
            {
                picboxImage[2] = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 2", 0);
                picBoxOpcao2.Image = t1.IconProdutos[picboxImage[2]];
            }
            else if (VerifCustomImg[2] == true)
            {
                picBoxOpcao2.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 2", ""));
            }

            if (VerifCustomImg[3] == false)
            {
                picboxImage[3] = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 3", 0);
                picBoxOpcao3.Image = t1.IconProdutos[picboxImage[3]];
            }
            else if (VerifCustomImg[3] == true)
            {
                picBoxOpcao3.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 3", ""));
            }

            if (VerifCustomImg[4] == false)
            {
                picboxImage[4] = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 4", 0);
                picBoxOpcao4.Image = t1.IconProdutos[picboxImage[4]];
            }
            else if (VerifCustomImg[4] == true)
            {
                picBoxOpcao4.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 4", ""));
            }

            if (VerifCustomImg[5] == false)
            {
                picboxImage[5] = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 5", 0);
                picBoxOpcao5.Image = t1.IconProdutos[picboxImage[5]];
            }
            else if (VerifCustomImg[5] == true)
            {
                picBoxOpcao1.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 5", ""));
            }

            if (VerifCustomImg[6] == false)
            {
                picboxImage[6] = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 6", 0);
                picBoxOpcao6.Image = t1.IconProdutos[picboxImage[6]];
            }
            else if (VerifCustomImg[6] == true)
            {
                picBoxOpcao6.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 6", ""));
            }

            if (VerifCustomImg[7] == false)
            {
                picboxImage[7] = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 7", 0);
                picBoxOpcao7.Image = t1.IconProdutos[picboxImage[7]];
            }
            else if (VerifCustomImg[7] == true)
            {
                picBoxOpcao7.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 7", ""));
            }
            if (VerifCustomImg[8] == false)
            {
                picboxImage[8] = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 8", 0);
                picBoxOpcao8.Image = t1.IconProdutos[picboxImage[8]];
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

        public PagInicial()
        {
            InitializeComponent();
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {                   
            //hover troca imagens
            t1.Instaciar_Imagens();
            CarregarCategorias();
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
            MessageBox.Show("Arquivo Ini gerado! Seus produtos e categorias foram retornados aos \n valores originais do programa");
            t1.GerarIni();
            CarregarCategorias();
        }


        private void AlterarIconeDasCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conf.Show();
            CarregarFrmCnfrmCategorias();
        }



        private void BtnOpcao1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("testeadndoidoad");
        }


        private void PictureBoxHome_Click(object sender, EventArgs e)
        {           
            CarregarCategorias();
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

        private void picBoxOpcao1_Click(object sender, EventArgs e)
        {          

        }

        private void toolStripMenuCat1_Click(object sender, EventArgs e)
        {
            CarregarImgCustom(1);           
        }

        private void toolStripMenuCat2_Click(object sender, EventArgs e)
        {
            CarregarImgCustom(2);
        }

        private void toolStripMenuCat3_Click(object sender, EventArgs e)
        {
            CarregarImgCustom(3);
        }

        private void toolStripMenuCat4_Click(object sender, EventArgs e)
        {
            CarregarImgCustom(4);
        }

        private void toolStripMenuCat5_Click(object sender, EventArgs e)
        {
            CarregarImgCustom(5);
        }

        private void toolStripMenuCat6_Click(object sender, EventArgs e)
        {
            CarregarImgCustom(6);
        }

        private void toolStripMenuCat7_Click(object sender, EventArgs e)
        {
            CarregarImgCustom(7);
        }

        private void toolStripMenuCat8_Click(object sender, EventArgs e)
        {
            CarregarImgCustom(8);
        }
    }
}
