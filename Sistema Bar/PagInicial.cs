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
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Runtime.ExceptionServices;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Drawing.Printing;

namespace Sistema_Bar
{
    public partial class PagInicial : Form
    {
        #region Variaveis

        Principal t1 = new Principal();
        IniFile ini1 = new IniFile();
        XmlFile xml = new XmlFile();
        FrmCategoria conf = new FrmCategoria();
        FrmProduto prod = new FrmProduto();
        FrmProduto2 prod2 = new FrmProduto2();
        bool[] VerifCustomImg = new bool[25]; bool[] VerifAtivado = new bool[25];
        int aux; int quant = 0; int categoria; int posicaotabela = 0; int QuantProdutos = 0;
        string StrAux;
        double soma;
        string teste = "";
        //double ValorUnitario; double auxiliar;

        #endregion

        #region Funções Void da Aplicação

        //FUNÇÕES 
        void CarregarImgCustomCategoria(int categoria)
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

        void CarregarImgCustomProdutos(int categoria, int produto)
        {
            String imageLocation = "";

            {
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All files(*.*)|*.*";

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = dialog.FileName;

                        ini1.IniWriteBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado " + produto, true);
                        ini1.IniWriteString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem " + produto, imageLocation);

                        CarregarProdutos(categoria);
                        MessageBox.Show("O icone do Produto foi alterado com sucesso!");
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        void CarregarProdutos(int categoria)
        {
            /*CARREGANDO OS VALORES E JOGANDO PARA VARIAVEIS,DOS QUAIS:
             * O PRIMEIRO VERIFICA SE HÁ ARQUIVOS DE IMAGENS EXTERNAS USADAS COMO ICONES
             * E O SEGUNDO VERIFICA SE O PRODUTO ESTÁ ATVIVADO
            */
            for (int i = 1; i <= 24; i++)
            {
                VerifCustomImg[i] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + categoria, "IconeCustomizado " + i, false);
                VerifAtivado[i] = ini1.IniReadBool("Produtos Ativados da Categoria " + categoria, "Ativado Item " + i, false);
            }

            /* OS LAÇOS ABAIXO VERIFICAM SE O .INI TEM ALGUM ARQUIVO PERSONALIZADO OU DO PRÓPRIO PROGRAMA
             * SE HOUVER UM ARQUIVO EXTERNO SENDO USADO COMO ICONE O PROGRAMA CARREGA SEU CAMINHO 
             * CASO CONTRARIO INSTANCIA O ICONE DO PROPRIO PROGRAMA 
            */

            #region Verificar se o usuario adicionou um icone personalizado ao produto e carrega-lo

            try
            {
                if (VerifCustomImg[1] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 1", 0);
                    pictureBoxProduto1.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[1] == true)
                {
                    pictureBoxProduto1.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 1", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[2] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 2", 0);
                    pictureBoxProduto2.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[2] == true)
                {
                    pictureBoxProduto2.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 2", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[3] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 3", 0);
                    pictureBoxProduto3.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[3] == true)
                {
                    pictureBoxProduto3.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 3", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[4] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 4", 0);
                    pictureBoxProduto4.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[4] == true)
                {
                    pictureBoxProduto4.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 4", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[5] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 5", 0);
                    pictureBoxProduto5.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[5] == true)
                {
                    pictureBoxProduto5.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 5", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (VerifCustomImg[6] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 6", 0);
                    pictureBoxProduto6.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[6] == true)
                {
                    pictureBoxProduto6.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 5", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[7] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 7", 0);
                    pictureBoxProduto7.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[7] == true)
                {
                    pictureBoxProduto7.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 6", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[8] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 8", 0);
                    pictureBoxProduto8.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[8] == true)
                {
                    pictureBoxProduto8.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 7", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[9] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 9", 0);
                    pictureBoxProduto9.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[9] == true)
                {
                    pictureBoxProduto9.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 9", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[10] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 10", 0);
                    pictureBoxProduto10.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[10] == true)
                {
                    pictureBoxProduto10.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 10", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[11] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 11", 0);
                    pictureBoxProduto11.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[11] == true)
                {
                    pictureBoxProduto11.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 11", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[12] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 12", 0);
                    pictureBoxProduto12.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[12] == true)
                {
                    pictureBoxProduto12.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 12", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[13] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 13", 0);
                    pictureBoxProduto13.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[13] == true)
                {
                    pictureBoxProduto13.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 13", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[14] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 14", 0);
                    pictureBoxProduto14.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[14] == true)
                {
                    pictureBoxProduto14.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 14", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[15] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 15", 0);
                    pictureBoxProduto15.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[15] == true)
                {
                    pictureBoxProduto15.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 15", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[16] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 16", 0);
                    pictureBoxProduto16.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[16] == true)
                {
                    pictureBoxProduto16.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 16", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[17] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 17", 0);
                    pictureBoxProduto17.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[17] == true)
                {
                    pictureBoxProduto17.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 17", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[18] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 18", 0);
                    pictureBoxProduto18.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[18] == true)
                {
                    pictureBoxProduto18.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 18", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[19] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 19", 0);
                    pictureBoxProduto19.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[19] == true)
                {
                    pictureBoxProduto19.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 19", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[20] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 20", 0);
                    pictureBoxProduto20.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[20] == true)
                {
                    pictureBoxProduto20.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 20", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {

                if (VerifCustomImg[21] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 21", 0);
                    pictureBoxProduto21.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[21] == true)
                {
                    pictureBoxProduto21.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 21", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[22] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 22", 0);
                    pictureBoxProduto22.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[22] == true)
                {
                    pictureBoxProduto22.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 22", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[23] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 23", 0);
                    pictureBoxProduto23.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[23] == true)
                {
                    pictureBoxProduto23.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 23", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[24] == false)
                {
                    aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + categoria, "ImagemDoProduto 24", 0);
                    pictureBoxProduto24.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[24] == true)
                {
                    pictureBoxProduto24.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + categoria, "Imagem 24", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            #endregion

            #region carregar nome dos produtos

            //CARREGAR NOME DOS PRODUTOS

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

            #endregion

            #region ativar os produtos se o arquivo ini retornar true

            //ATIVAR OS PRODUTOS SE O ARQUIVO INI RETORNAR TRUE

            labelProduto1.Visible = VerifAtivado[1];
            pictureBoxProduto1.Visible = VerifAtivado[1];
            panelProduto1.Visible = VerifAtivado[1];
            labelProduto2.Visible = VerifAtivado[2];
            pictureBoxProduto2.Visible = VerifAtivado[2];
            panelProduto2.Visible = VerifAtivado[2];
            labelProduto3.Visible = VerifAtivado[3];
            pictureBoxProduto3.Visible = VerifAtivado[3];
            panelProduto3.Visible = VerifAtivado[3];
            labelProduto4.Visible = VerifAtivado[4];
            pictureBoxProduto4.Visible = VerifAtivado[4];
            panelProduto4.Visible = VerifAtivado[4];
            labelProduto5.Visible = VerifAtivado[5];
            pictureBoxProduto5.Visible = VerifAtivado[5];
            panelProduto5.Visible = VerifAtivado[5];
            labelProduto6.Visible = VerifAtivado[6];
            pictureBoxProduto6.Visible = VerifAtivado[6];
            panelProduto6.Visible = VerifAtivado[6];
            labelProduto7.Visible = VerifAtivado[7];
            pictureBoxProduto7.Visible = VerifAtivado[7];
            panelProduto7.Visible = VerifAtivado[7];
            labelProduto8.Visible = VerifAtivado[8];
            pictureBoxProduto8.Visible = VerifAtivado[8];
            panelProduto8.Visible = VerifAtivado[8];
            labelProduto9.Visible = VerifAtivado[9];
            pictureBoxProduto9.Visible = VerifAtivado[9];
            panelProduto9.Visible = VerifAtivado[9];
            labelProduto10.Visible = VerifAtivado[10];
            pictureBoxProduto10.Visible = VerifAtivado[10];
            panelProduto10.Visible = VerifAtivado[10];
            labelProduto11.Visible = VerifAtivado[11];
            pictureBoxProduto11.Visible = VerifAtivado[11];
            panelProduto11.Visible = VerifAtivado[11];
            labelProduto12.Visible = VerifAtivado[12];
            pictureBoxProduto12.Visible = VerifAtivado[12];
            panelProduto12.Visible = VerifAtivado[12];
            labelProduto13.Visible = VerifAtivado[13];
            pictureBoxProduto13.Visible = VerifAtivado[13];
            panelProduto13.Visible = VerifAtivado[13];
            labelProduto14.Visible = VerifAtivado[14];
            pictureBoxProduto14.Visible = VerifAtivado[14];
            panelProduto14.Visible = VerifAtivado[14];
            labelProduto15.Visible = VerifAtivado[15];
            pictureBoxProduto15.Visible = VerifAtivado[15];
            panelProduto15.Visible = VerifAtivado[15];
            labelProduto16.Visible = VerifAtivado[16];
            pictureBoxProduto16.Visible = VerifAtivado[16];
            panelProduto16.Visible = VerifAtivado[16];
            labelProduto17.Visible = VerifAtivado[17];
            pictureBoxProduto17.Visible = VerifAtivado[17];
            panelProduto17.Visible = VerifAtivado[17];
            labelProduto18.Visible = VerifAtivado[18];
            pictureBoxProduto18.Visible = VerifAtivado[18];
            panelProduto18.Visible = VerifAtivado[18];
            labelProduto19.Visible = VerifAtivado[19];
            pictureBoxProduto19.Visible = VerifAtivado[19];
            panelProduto19.Visible = VerifAtivado[19];
            labelProduto20.Visible = VerifAtivado[20];
            pictureBoxProduto20.Visible = VerifAtivado[20];
            panelProduto20.Visible = VerifAtivado[20];
            labelProduto21.Visible = VerifAtivado[21];
            pictureBoxProduto21.Visible = VerifAtivado[21];
            panelProduto21.Visible = VerifAtivado[21];
            labelProduto22.Visible = VerifAtivado[22];
            pictureBoxProduto22.Visible = VerifAtivado[22];
            panelProduto22.Visible = VerifAtivado[22];
            labelProduto23.Visible = VerifAtivado[23];
            pictureBoxProduto23.Visible = VerifAtivado[23];
            panelProduto23.Visible = VerifAtivado[23];
            labelProduto24.Visible = VerifAtivado[24];
            pictureBoxProduto24.Visible = VerifAtivado[24];
            panelProduto24.Visible = VerifAtivado[24];

            #endregion
        }


        public void CarregarCategorias()
        {
            /* VerifCustomImg[1] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 1", false);
             VerifCustomImg[2] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 2", false);
             VerifCustomImg[3] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 3", false);
             VerifCustomImg[4] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 4", false);
             VerifCustomImg[5] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 5", false);
             VerifCustomImg[6] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 6", false);
             VerifCustomImg[7] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 7", false);
             VerifCustomImg[8] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 8", false);
            */

            for (int i = 1; i <= 8; i++)
            {
                VerifCustomImg[i] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado " + i, false);
            }



            try
            {
                if (VerifCustomImg[1] == false)
                {
                    aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 1", 0);
                    picBoxOpcao1.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[1] == true)
                {
                    picBoxOpcao1.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 1", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[2] == false)
                {
                    aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 2", 0);
                    picBoxOpcao2.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[2] == true)
                {
                    picBoxOpcao2.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 2", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[3] == false)
                {
                    aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 3", 0);
                    picBoxOpcao3.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[3] == true)
                {
                    picBoxOpcao3.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 3", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            try
            {
                if (VerifCustomImg[4] == false)
                {
                    aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 4", 0);
                    picBoxOpcao4.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[4] == true)
                {
                    picBoxOpcao4.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 4", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[5] == false)
                {
                    aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 5", 0);
                    picBoxOpcao5.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[5] == true)
                {
                    picBoxOpcao1.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 5", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            try
            {
                if (VerifCustomImg[6] == false)
                {
                    aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 6", 0);
                    picBoxOpcao6.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[6] == true)
                {
                    picBoxOpcao6.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 6", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            try
            {
                if (VerifCustomImg[7] == false)
                {
                    aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 7", 0);
                    picBoxOpcao7.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[7] == true)
                {
                    picBoxOpcao7.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 7", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (VerifCustomImg[8] == false)
                {
                    aux = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 8", 0);
                    picBoxOpcao8.Image = t1.IconProdutos[aux];
                }
                else if (VerifCustomImg[8] == true)
                {
                    picBoxOpcao8.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 8", ""));
                }
            }
            catch (Exception)
            {
                StrAux = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                MessageBox.Show("A imagem Personalizada inserida na categoria " + StrAux.ToUpper() + " não foi encontrada!\n" +
                    "Favor Selecionar um Icone na lista do programa ou Carregar novamente o icone\n" +
                    "Caso o erro persista carregar outro icone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #region carregar nome dos produtos
            {

                labalCateg1.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", "");
                labalCateg2.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 2", "");
                labalCateg3.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 3", "");
                labalCateg4.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 4", "");
                labalCateg5.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 5", "");
                labalCateg6.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 6", "");
                labalCateg7.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 7", "");
                labalCateg8.Text = ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 8", "");
            }
            #endregion
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
            conf.comboBoxSelecionarImg.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49 });
            conf.comboBoxOpcoesCategoria.Items.AddRange(new object[] { "Alterar Nome das Categorias", "Alterar Imagem das Categorias" });
            conf.MaximumSize = new System.Drawing.Size(202, 463);
            conf.Size = new System.Drawing.Size(202, 463);
            conf.buttonCancelar.Location = new System.Drawing.Point(57, 421);
            conf.picBoxImageUp.Location = new System.Drawing.Point(26, 52);
            this.Hide();
        }

        void CarregarFrmCnfrmProdutos()
        {
            prod.labelNomeProduto1.Visible = true;
            prod.buttonCancelar.Visible = true;
            prod.buttonAtivarProduto.Enabled = false;
            prod.buttonDesativarProduto.Enabled = false;
            prod.comboBoxCategoria.Visible = true;
            prod.comboBoxCategoria.Visible = true;
            prod.picBoxImageUp.Visible = true;
            prod.labelProduto1.Text = "Alterar o nome do Produto: ";
            prod.textBoxResultado.Text = "";
            prod.comboBoxCategoria.Text = "";
            prod.comboBoxCategoria.Items.Clear();
            prod.comboBoxSelecionarImg.Items.Clear();
            prod.comboBoxOpcoesProduto.Items.Clear();
            prod.comboBoxProduto.Items.Clear();
            prod.comboBoxCategoria.Items.AddRange(new object[] { ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 2", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 3", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 4", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 5", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 6", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 7", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 8", "") });
            //prod.comboBoxProduto.Items.AddRange(new object[] {ini1.IniReadString("Nome dos Produtos da Categoria 1", "Nome do Produto 1", ""), });
            prod.comboBoxSelecionarImg.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49 });
            prod.comboBoxOpcoesProduto.Items.AddRange(new object[] { "Alterar Nome/Visibilidade dos Produtos", "Alterar Imagem dos Produtos" });
            prod.MaximumSize = new System.Drawing.Size(202, 463);
            prod.Size = new System.Drawing.Size(202, 463);
            prod.buttonCancelar.Location = new System.Drawing.Point(57, 421);
            prod.picBoxImageUp.Location = new System.Drawing.Point(26, 79);
            this.Hide();
        }

        void CarregarFrmAlterarProdutos()
        {
            prod2.labelNomeProduto1.Visible = true;
            prod2.buttonCancelar.Visible = true;
            prod2.comboBoxCategoria.Visible = true;
            prod2.comboBoxCategoria.Visible = true;
            prod2.picBoxImageUp.Visible = true;
            prod2.labelProduto1.Text = "Alterar o nome do Produto: ";
            prod2.textBoxCodigoBarras.Text = "";
            prod2.textBoxPreco.Text = "";
            prod2.comboBoxCategoria.Text = "";
            prod2.comboBoxCategoria.Items.Clear();
            prod2.comboBoxOpcoesProduto.Items.Clear();
            prod2.comboBoxProduto.Items.Clear();
            prod2.comboBoxCategoria.Items.AddRange(new object[] { ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 2", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 3", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 4", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 5", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 6", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 7", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 8", "") });
            //prod.comboBoxProduto.Items.AddRange(new object[] {ini1.IniReadString("Nome dos Produtos da Categoria 1", "Nome do Produto 1", ""), });
            prod2.comboBoxOpcoesProduto.Items.AddRange(new object[] { "Alterar Código de Barras", "Alterar Preço" });
            prod2.MaximumSize = new System.Drawing.Size(202, 352);
            prod2.Size = new System.Drawing.Size(202, 463);
            prod2.buttonCancelar.Location = new System.Drawing.Point(57, 309);
            prod2.picBoxImageUp.Location = new System.Drawing.Point(26, 79);
            this.Hide();
            prod2.Show();
        }

        void LoadProdCombobox()
        {
            try
            {
                toolStripComboBoxCategoria.Items.AddRange(new object[] { ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 2", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 3", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 4", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 5", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 6", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 7", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 8", "") });
                toolStripComboBoxTrocarCategoria.Items.AddRange(new object[] { ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 1", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 2", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 3", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 4", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 5", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 6", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 7", ""), ini1.IniReadString("Nome da Categoria dos Produtos", "NomeProduto 8", "") });
            }
            catch (Exception)
            {
                toolStripComboBoxCategoria.Items.AddRange(new object[] { "Categoria 1", "Categoria 2", "Categoria 3 ", "Categoria 4 ", "Cateogira 5 ", "Categoria 6 ", "Categoria 7", "Categoria 8" });
                toolStripComboBoxTrocarCategoria.Items.AddRange(new object[] { "Categoria 1", "Categoria 2", "Categoria 3 ", "Categoria 4 ", "Cateogira 5 ", "Categoria 6 ", "Categoria 7", "Categoria 8" });
            }
        }

        void LoadXml(int categoria, int produto)
        {

            string descricao;
            descricao = ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto " + produto, "");

            long codigo;
            codigo = long.Parse(ini1.IniReadString("Codigo dos Produtos da Categoria " + categoria, "Codigo " + produto, ""));

            double valorunit;
            valorunit = double.Parse(ini1.IniReadString("Preco dos Produtos da Categoria " + categoria, "Preco " + produto, ""));


            if (quant > 0)
            {
                dataGridProdutos.Rows.Add(codigo, descricao, quant, valorunit, quant * valorunit);
                QuantProdutos++;
            }



            textBoxCodigoProduto.Text = codigo.ToString();
            textBoxPrecoProduto.Text = valorunit.ToString();
            soma += quant * valorunit;
            //Itens[id] = quant * valorunit;
            //id++;
            labelValorTotal.Text = soma.ToString("N2");
        }

        #endregion

        #region Load e Inicio do Programa

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
            LoadProdCombobox();

           
        }

        #endregion

        #region Clique e Hover de Imagens Botões Superiores

        //hover de imagem 

        private void pictureBoxHome_MouseHover_1(object sender, EventArgs e)
        {
            pictureBoxHome.BackgroundImage = t1.Imgs[2];
        }

        private void pictureBoxHome_MouseLeave_1(object sender, EventArgs e)
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
        private void pictureBoxHome_Click_1(object sender, EventArgs e)
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

        #endregion

        #region Botoes Parte Superior

        private void RetornarProdutosPadrãoDoProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gerando...");
            t1.GerarIni();
            xml.GerarXml();
            CarregarCategorias();
            MessageBox.Show("Arquivo Ini gerado! Seus produtos e categorias foram retornados aos \n valores originais do programa");

            /*  DataSet ds = new DataSet();
             ds.ReadXml(Application.ExecutablePath + Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".xml");
             dataGridViewProdutos.DataSource = ds.Tables[0]; */
        }

        private void AlterarIconeDasCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conf.Show();
            CarregarFrmCnfrmCategorias();
        }

        private void alterarIconeDosProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prod.Show();
            CarregarFrmCnfrmProdutos();
        }

        private void atualizarArqIniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarCategorias();
        }

        private void toolStripComboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Switch categoria
            switch (toolStripComboBoxCategoria.SelectedIndex)
            {
                case 0:
                    categoria = 1;
                    toolStripComboBoxProduto.Enabled = true;
                    toolStripComboBoxProduto.Items.Clear();
                    for (int i = 1; i <= 24; i++)
                    {
                        toolStripComboBoxProduto.Items.Add(ini1.IniReadString("Nome dos Produtos da Categoria 1", "Nome do Produto " + i, ""));
                    }
                    break;
                case 1:
                    categoria = 2;
                    toolStripComboBoxProduto.Enabled = true;
                    toolStripComboBoxProduto.Items.Clear();
                    for (int i = 1; i <= 24; i++)
                    {
                        toolStripComboBoxProduto.Items.Add(ini1.IniReadString("Nome dos Produtos da Categoria 2", "Nome do Produto " + i, ""));
                    }
                    break;
                case 2:
                    categoria = 3;
                    toolStripComboBoxProduto.Enabled = true;
                    toolStripComboBoxProduto.Items.Clear();
                    for (int i = 1; i <= 24; i++)
                    {
                        toolStripComboBoxProduto.Items.Add(ini1.IniReadString("Nome dos Produtos da Categoria 3", "Nome do Produto " + i, ""));
                    }
                    break;
                case 3:
                    categoria = 4;
                    toolStripComboBoxProduto.Enabled = true;
                    toolStripComboBoxProduto.Items.Clear();
                    for (int i = 1; i <= 24; i++)
                    {
                        toolStripComboBoxProduto.Items.Add(ini1.IniReadString("Nome dos Produtos da Categoria 4", "Nome do Produto " + i, ""));
                    }
                    break;
                case 4:
                    categoria = 5;
                    toolStripComboBoxProduto.Enabled = true;
                    toolStripComboBoxProduto.Items.Clear();
                    for (int i = 1; i <= 24; i++)
                    {
                        toolStripComboBoxProduto.Items.Add(ini1.IniReadString("Nome dos Produtos da Categoria 5", "Nome do Produto " + i, ""));
                    }
                    break;
                case 5:
                    categoria = 6;
                    toolStripComboBoxProduto.Enabled = true;
                    toolStripComboBoxProduto.Items.Clear();
                    for (int i = 1; i <= 24; i++)
                    {
                        toolStripComboBoxProduto.Items.Add(ini1.IniReadString("Nome dos Produtos da Categoria 6", "Nome do Produto " + i, ""));
                    }
                    break;
                case 6:
                    categoria = 7;
                    toolStripComboBoxProduto.Enabled = true;
                    toolStripComboBoxProduto.Items.Clear();
                    for (int i = 1; i <= 24; i++)
                    {
                        toolStripComboBoxProduto.Items.Add(ini1.IniReadString("Nome dos Produtos da Categoria 7", "Nome do Produto " + i, ""));
                    }
                    break;
                case 7:
                    categoria = 8;
                    toolStripComboBoxProduto.Enabled = true;
                    toolStripComboBoxProduto.Items.Clear();
                    for (int i = 1; i <= 24; i++)
                    {
                        toolStripComboBoxProduto.Items.Add(ini1.IniReadString("Nome dos Produtos da Categoria 8", "Nome do Produto " + i, ""));
                    }
                    break;
            }
            #endregion
        }

        private void toolStripComboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region switch produto
            switch (toolStripComboBoxProduto.SelectedIndex)
            {
                case 0:
                    CarregarImgCustomProdutos(categoria, 1);
                    break;
                case 1:
                    CarregarImgCustomProdutos(categoria, 2);

                    break;
                case 2:
                    CarregarImgCustomProdutos(categoria, 3);
                    break;
                case 3:
                    CarregarImgCustomProdutos(categoria, 4);
                    break;
                case 4:
                    CarregarImgCustomProdutos(categoria, 5);
                    break;
                case 5:
                    CarregarImgCustomProdutos(categoria, 6);
                    break;
                case 6:
                    CarregarImgCustomProdutos(categoria, 7);
                    break;
                case 7:
                    CarregarImgCustomProdutos(categoria, 8);
                    break;
                case 8:
                    CarregarImgCustomProdutos(categoria, 9);
                    break;
                case 9:
                    CarregarImgCustomProdutos(categoria, 10);
                    break;
                case 10:
                    CarregarImgCustomProdutos(categoria, 11);
                    break;
                case 11:
                    CarregarImgCustomProdutos(categoria, 12);
                    break;
                case 12:
                    CarregarImgCustomProdutos(categoria, 13);
                    break;
                case 13:
                    CarregarImgCustomProdutos(categoria, 14);
                    break;
                case 14:
                    CarregarImgCustomProdutos(categoria, 15);
                    break;
                case 15:
                    CarregarImgCustomProdutos(categoria, 16);
                    break;
                case 16:
                    CarregarImgCustomProdutos(categoria, 17);
                    break;
                case 17:
                    CarregarImgCustomProdutos(categoria, 18);
                    break;
                case 18:
                    CarregarImgCustomProdutos(categoria, 19);
                    break;
                case 19:
                    CarregarImgCustomProdutos(categoria, 20);
                    break;
                case 20:
                    CarregarImgCustomProdutos(categoria, 21);
                    break;
                case 21:
                    CarregarImgCustomProdutos(categoria, 22);
                    break;
                case 22:
                    CarregarImgCustomProdutos(categoria, 23);
                    break;
                case 23:
                    CarregarImgCustomProdutos(categoria, 24);
                    break;
            }
            #endregion
        }

        private void toolStripComboBoxTrocarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region switch produto
            switch (toolStripComboBoxTrocarCategoria.SelectedIndex)
            {
                case 0:
                    CarregarImgCustomCategoria(1);
                    break;
                case 1:
                    CarregarImgCustomCategoria(2);
                    break;
                case 2:
                    CarregarImgCustomCategoria(3);
                    break;
                case 3:
                    CarregarImgCustomCategoria(4);
                    break;
                case 4:
                    CarregarImgCustomCategoria(5);
                    break;
                case 5:
                    CarregarImgCustomCategoria(6);
                    break;
                case 6:
                    CarregarImgCustomCategoria(7);
                    break;
                case 7:
                    CarregarImgCustomCategoria(8);
                    break;
                case 8:
                    CarregarImgCustomCategoria(9);
                    break;
                    #endregion
            }
        }

        private void alterarCódigoDeBarrasDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarFrmAlterarProdutos();
        }


        #endregion

        #region Carregar Imagens Personalizadas Categorias

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

        #endregion

        #region Opções Categorias

        //OPÇÕES CATEGORIAS 

        private void picBoxOpcao1_Click(object sender, EventArgs e)
        {
            CarregarProdutos(1);
            categoria = 1;
        }

        private void picBoxOpcao2_Click(object sender, EventArgs e)
        {
            CarregarProdutos(2);
            categoria = 2;
        }

        private void picBoxOpcao3_Click(object sender, EventArgs e)
        {
            CarregarProdutos(3);
            categoria = 3;
        }

        private void picBoxOpcao4_Click(object sender, EventArgs e)
        {
            CarregarProdutos(4);
            categoria = 4;
        }

        private void picBoxOpcao5_Click(object sender, EventArgs e)
        {
            CarregarProdutos(5);
            categoria = 5;
        }

        private void picBoxOpcao6_Click(object sender, EventArgs e)
        {
            CarregarProdutos(6);
            categoria = 6;
        }

        private void picBoxOpcao7_Click(object sender, EventArgs e)
        {
            CarregarProdutos(7);
            categoria = 7;
        }

        private void picBoxOpcao8_Click(object sender, EventArgs e)
        {
            CarregarProdutos(8);
            categoria = 8;
        }

        #endregion

        #region Hover de Opcoes das categorias

        //HOVER DE OPCOES

        private void picBoxOpcao1_MouseHover(object sender, EventArgs e)
        {
            panel.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void picBoxOpcao1_MouseLeave(object sender, EventArgs e)
        {
            panel.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
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

        #endregion

        #region Hover dos produtos

        //HOVER PRODUTOS

        private void pictureBoxProduto1_MouseHover(object sender, EventArgs e)
        {
            panelProduto1.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto1_MouseLeave(object sender, EventArgs e)
        {
            panelProduto1.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto2_MouseHover(object sender, EventArgs e)
        {
            panelProduto2.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto2_MouseLeave(object sender, EventArgs e)
        {
            panelProduto2.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto3_MouseHover(object sender, EventArgs e)
        {
            panelProduto3.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto3_MouseLeave(object sender, EventArgs e)
        {
            panelProduto3.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto4_MouseHover(object sender, EventArgs e)
        {
            panelProduto4.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto4_MouseLeave(object sender, EventArgs e)
        {
            panelProduto4.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto5_MouseHover(object sender, EventArgs e)
        {
            panelProduto5.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto5_MouseLeave(object sender, EventArgs e)
        {
            panelProduto5.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto6_MouseHover(object sender, EventArgs e)
        {
            panelProduto6.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto6_MouseLeave(object sender, EventArgs e)
        {
            panelProduto6.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto7_MouseHover(object sender, EventArgs e)
        {
            panelProduto7.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto7_MouseLeave(object sender, EventArgs e)
        {
            panelProduto7.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto8_MouseHover(object sender, EventArgs e)
        {
            panelProduto8.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto8_MouseLeave(object sender, EventArgs e)
        {
            panelProduto8.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto9_MouseHover(object sender, EventArgs e)
        {
            panelProduto9.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto9_MouseLeave(object sender, EventArgs e)
        {
            panelProduto9.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto10_MouseHover(object sender, EventArgs e)
        {
            panelProduto10.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto10_MouseLeave(object sender, EventArgs e)
        {
            panelProduto10.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto11_MouseHover(object sender, EventArgs e)
        {
            panelProduto11.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto11_MouseLeave(object sender, EventArgs e)
        {
            panelProduto11.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto12_MouseHover(object sender, EventArgs e)
        {
            panelProduto12.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto12_MouseLeave(object sender, EventArgs e)
        {
            panelProduto12.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto13_MouseHover(object sender, EventArgs e)
        {
            panelProduto13.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto13_MouseLeave(object sender, EventArgs e)
        {
            panelProduto13.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto14_MouseHover(object sender, EventArgs e)
        {
            panelProduto14.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto14_MouseLeave(object sender, EventArgs e)
        {
            panelProduto14.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto15_MouseHover(object sender, EventArgs e)
        {
            panelProduto15.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto15_MouseLeave(object sender, EventArgs e)
        {
            panelProduto15.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto16_MouseHover(object sender, EventArgs e)
        {
            panelProduto16.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto16_MouseLeave(object sender, EventArgs e)
        {
            panelProduto16.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto17_MouseHover(object sender, EventArgs e)
        {
            panelProduto17.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto17_MouseLeave(object sender, EventArgs e)
        {
            panelProduto17.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto18_MouseHover(object sender, EventArgs e)
        {
            panelProduto18.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto18_MouseLeave(object sender, EventArgs e)
        {
            panelProduto18.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto19_MouseHover(object sender, EventArgs e)
        {
            panelProduto19.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto19_MouseLeave(object sender, EventArgs e)
        {
            panelProduto19.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto20_MouseHover(object sender, EventArgs e)
        {
            panelProduto20.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto20_MouseLeave(object sender, EventArgs e)
        {
            panelProduto20.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto21_MouseHover(object sender, EventArgs e)
        {
            panelProduto21.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto21_MouseLeave(object sender, EventArgs e)
        {
            panelProduto21.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto22_MouseHover(object sender, EventArgs e)
        {
            panelProduto22.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto22_MouseLeave(object sender, EventArgs e)
        {
            panelProduto22.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto23_MouseHover(object sender, EventArgs e)
        {
            panelProduto23.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto23_MouseLeave(object sender, EventArgs e)
        {
            panelProduto23.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        private void pictureBoxProduto24_MouseHover(object sender, EventArgs e)
        {
            panelProduto24.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");
        }

        private void pictureBoxProduto24_MouseLeave(object sender, EventArgs e)
        {
            panelProduto24.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png");
        }

        #endregion

        #region Clique dos PRODUTOS

        private void pictureBoxProduto1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add();
            LoadXml(categoria, 1);
            //MessageBox.Show(categoria + "  " + ini1.IniReadString("Nome dos Produtos da Categoria " + categoria, "Nome do Produto 1", "") + "  " + quant);
        }

        private void pictureBoxProduto2_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 2);
        }

        private void pictureBoxProduto3_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 3);
        }

        private void pictureBoxProduto4_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 4);
        }

        private void pictureBoxProduto5_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 5);
        }

        private void pictureBoxProduto6_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 6);
        }

        private void pictureBoxProduto7_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 7);
        }

        private void pictureBoxProduto8_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 8);
        }

        private void pictureBoxProduto9_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 9);
        }

        private void pictureBoxProduto10_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 10);
        }

        private void pictureBoxProduto11_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 11);
        }

        private void pictureBoxProduto12_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 12);
        }

        private void pictureBoxProduto13_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 13);
        }

        private void pictureBoxProduto14_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 14);
        }

        private void pictureBoxProduto15_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 15);
        }

        private void pictureBoxProduto16_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 16);
        }

        private void pictureBoxProduto17_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 17);
        }

        private void pictureBoxProduto18_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 18);
        }

        private void pictureBoxProduto19_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 19);
        }

        private void pictureBoxProduto20_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 20);
        }

        private void pictureBoxProduto21_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 21);
        }

        private void pictureBoxProduto22_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 22);
        }

        private void pictureBoxProduto23_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 23);
        }

        private void pictureBoxProduto24_Click(object sender, EventArgs e)
        {
            LoadXml(categoria, 24);
        }

        #endregion

        #region Confirmacao de fechamento do programa
        //CONFIRMAÇAO DE FECHAMENTO DO PROGRAMA!

        private void PagInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // confirma que ao ser clicado o botao de sair pelo usuario toda a aplicacao sera encerrada!            
        }

        #endregion

        #region Alterações Datagrid

        /*Deduzir da Soma o valor inserido caso o usuario apague uma celula do datagrid
         * ou faça alguma alteração na quantidade de produtos
         * em ambos casos o valor total será corrigido!
         */


        private void dataGridProdutos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            soma -= double.Parse(dataGridProdutos.Rows[posicaotabela].Cells[4].Value.ToString());
            labelValorTotal.Text = soma.ToString();
            QuantProdutos = dataGridProdutos.Rows.Count;
        }

        private void dataGridProdutos_SelectionChanged_1(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridProdutos.Rows[0].Cells[4].Value.ToString());  
            // MessageBox.Show(posicaotabela.ToString());
            posicaotabela = dataGridProdutos.CurrentRow.Index;
        }

        private void dataGridProdutos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridProdutos.Rows[posicaotabela].Cells[2].Value != null)
                {
                    soma -= double.Parse(dataGridProdutos.Rows[dataGridProdutos.CurrentRow.Index].Cells[4].Value.ToString());
                    dataGridProdutos.Rows[dataGridProdutos.CurrentRow.Index].Cells[4].Value = int.Parse(dataGridProdutos.Rows[dataGridProdutos.CurrentRow.Index].Cells[2].Value.ToString()) * double.Parse(dataGridProdutos.Rows[dataGridProdutos.CurrentRow.Index].Cells[3].Value.ToString());
                    soma += double.Parse(dataGridProdutos.Rows[dataGridProdutos.CurrentRow.Index].Cells[4].Value.ToString());

                    labelValorTotal.Text = soma.ToString();

                }

            }
            catch (Exception)
            {

            }
        }


        #endregion

        #region Opcoes e sets dos campos do canto superior direito

        private void pictureBoxAumentarQuant_Click(object sender, EventArgs e)
        {
            if (textBoxQuantidade.Text == "")
            {
                quant = 0;
            }

            textBoxQuantidade.Text = (quant + 1).ToString();
            quant = int.Parse(textBoxQuantidade.Text);

            if (quant > 0)
            {
                pictureBoxDiminuirQuant.Enabled = true;
            }
        }

        private void pictureBoxDiminuirQuant_Click(object sender, EventArgs e)
        {
            if (textBoxQuantidade.Text == "")
            {
                quant = 0;
            }

            textBoxQuantidade.Text = (quant - 1).ToString();
            quant = int.Parse(textBoxQuantidade.Text);

            if (quant <= 0)
            {
                pictureBoxDiminuirQuant.Enabled = false;
            }
        }

        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                quant = int.Parse(textBoxQuantidade.Text);
                if (quant > 0 || quant < 99)
                {
                    quant = int.Parse(textBoxQuantidade.Text);
                }
                if (textBoxQuantidade.Text == "")
                {
                    quant = 0;
                    textBoxQuantidade.Text = quant.ToString();
                    pictureBoxDiminuirQuant.Enabled = false;
                }

            }
            catch (Exception)
            {
                quant = 0;
            }

        }

        #endregion

        #region Opcoes e sets do canto inferior direito 

        private void pictureBoxCancelarCompra_Click(object sender, EventArgs e)
        {
            dataGridProdutos.Rows.Clear();
            soma = 0;
            labelValorTotal.Text = soma.ToString();
        }

        private void pictureBoxFinalizarCompra_Click(object sender, EventArgs e)
        {

        }

        //Hover

        private void pictureBoxCancelarCompra_MouseHover(object sender, EventArgs e)
        {
            pictureBoxCancelarCompra.BackgroundImage = Image.FromFile(t1.pasta_imagens1 + "ButtonCancelar2.png");
        }

        private void pictureBoxCancelarCompra_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCancelarCompra.BackgroundImage = Image.FromFile(t1.pasta_imagens1 + "btn.png");
        }

        private void pictureBoxFinalizarCompra_MouseHover(object sender, EventArgs e)
        {
            pictureBoxFinalizarCompra.BackgroundImage = Image.FromFile(t1.pasta_imagens1 + "ButtonFinalizar2.png");
        }

        private void pictureBoxFinalizarCompra_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxFinalizarCompra.BackgroundImage = Image.FromFile(t1.pasta_imagens1 + "ButtonFinalizar.png");


        }

        #endregion



 

        private void sairEFecharCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();

            printDoc.Print();
         
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            
        }
    }
}


/* for (int i = 0; i <= (QuantProdutos - 1); i++)
{
    for (int y = 0; y <= 4; y++)
    {
        teste += dataGridProdutos.Rows[i].Cells[y].Value.ToString() + "  //  ";
    }

    teste += "\n";

} 

MessageBox.Show(teste); */

/* picBoxOpcao1.BackColor = Color.Transparent;
 picBoxOpcao1.BackColor = Color.DarkGray; */

/* panel1.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2-1.png");

panel1.BackgroundImage = Image.FromFile(t1.pasta_imagens3 + "botao2.png"); */
