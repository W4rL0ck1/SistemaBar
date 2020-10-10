using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bar
{
    public partial class FrmCategoria : Form
    {
        Principal t2 = new Principal();
        IniFile ini1 = new IniFile();
        //PagInicial pag1 = new PagInicial();
        string NovoItemNmCateg; string NmImgCateg;
        //bool CustomImgVerif = false;
        int NovoItemImgCateg; //int NmSalvarImg; 
        int picboxImage;
        public string pasta_imagens1 = ""; public string pasta_imagens2 = "";
        public Image[] IconProdutos = new Image[50];
        bool[] VerifCustomImg = new bool[11];
        Image ImgAux;
        


        public void Instaciar_Imagens()
        {
            pasta_imagens2 = Application.StartupPath + @"\images\icones\IconesProdutos\";
            IconProdutos[1] = Image.FromFile(pasta_imagens2 + "batatafrita.png"); IconProdutos[2] = Image.FromFile(pasta_imagens2 + "bolo.png"); IconProdutos[3] = Image.FromFile(pasta_imagens2 + "cachorro quente.png"); IconProdutos[4] = Image.FromFile(pasta_imagens2 + "cafe.png"); IconProdutos[5] = Image.FromFile(pasta_imagens2 + "chocolate.png");
            IconProdutos[6] = Image.FromFile(pasta_imagens2 + "franguinho.png"); IconProdutos[7] = Image.FromFile(pasta_imagens2 + "garfo e colher.png"); IconProdutos[8] = Image.FromFile(pasta_imagens2 + "hamburguer.png"); IconProdutos[9] = Image.FromFile(pasta_imagens2 + "lanche.png"); IconProdutos[10] = Image.FromFile(pasta_imagens2 + "pipoca.png");
            IconProdutos[11] = Image.FromFile(pasta_imagens2 + "pirulito.png"); IconProdutos[12] = Image.FromFile(pasta_imagens2 + "pizza.png"); IconProdutos[13] = Image.FromFile(pasta_imagens2 + "refrigerante.png"); IconProdutos[14] = Image.FromFile(pasta_imagens2 + "refrigerante2.png"); IconProdutos[15] = Image.FromFile(pasta_imagens2 + "sorvete1.png");
            IconProdutos[16] = Image.FromFile(pasta_imagens2 + "sorvete2.png"); IconProdutos[17] = Image.FromFile(pasta_imagens2 + "001-shopping bag.png"); IconProdutos[18] = Image.FromFile(pasta_imagens2 + "002-canned food.png"); IconProdutos[19] = Image.FromFile(pasta_imagens2 + "003-paper bag.png"); IconProdutos[20] = Image.FromFile(pasta_imagens2 + "005-chili sauce.png");
            IconProdutos[21] = Image.FromFile(pasta_imagens2 + "007-eggs.png"); IconProdutos[22] = Image.FromFile(pasta_imagens2 + "008-soda.png"); IconProdutos[23] = Image.FromFile(pasta_imagens2 + "026-toilet paper.png"); IconProdutos[24] = Image.FromFile(pasta_imagens2 + "033-liquid soap.png"); IconProdutos[25] = Image.FromFile(pasta_imagens2 + "037-toothpaste.png");
            IconProdutos[26] = Image.FromFile(pasta_imagens2 + "010-chocolate.png"); IconProdutos[27] = Image.FromFile(pasta_imagens2 + "017-sausages.png"); IconProdutos[28] = Image.FromFile(pasta_imagens2 + "027-olive oil.png"); IconProdutos[29] = Image.FromFile(pasta_imagens2 + "034-fridge.png"); IconProdutos[30] = Image.FromFile(pasta_imagens2 + "038-cereal.png");
            IconProdutos[31] = Image.FromFile(pasta_imagens2 + "011-jam.png"); IconProdutos[32] = Image.FromFile(pasta_imagens2 + "022-meat.png"); IconProdutos[33] = Image.FromFile(pasta_imagens2 + "029-sardines.png"); IconProdutos[34] = Image.FromFile(pasta_imagens2 + "035-milk bottle.png"); IconProdutos[35] = Image.FromFile(pasta_imagens2 + "039-snack.png");
            IconProdutos[36] = Image.FromFile(pasta_imagens2 + "015-avocado.png"); IconProdutos[37] = Image.FromFile(pasta_imagens2 + "023-salami.png"); IconProdutos[38] = Image.FromFile(pasta_imagens2 + "032-ketchup.png"); IconProdutos[39] = Image.FromFile(pasta_imagens2 + "036-bread.png"); IconProdutos[40] = Image.FromFile(pasta_imagens2 + "040-mayonnaise.png");
            IconProdutos[41] = Image.FromFile(pasta_imagens2 + "041-juice.png"); IconProdutos[42] = Image.FromFile(pasta_imagens2 + "042-fish.png"); IconProdutos[43] = Image.FromFile(pasta_imagens2 + "043-cheese.png"); IconProdutos[44] = Image.FromFile(pasta_imagens2 + "045-Butter.png"); IconProdutos[45] = Image.FromFile(pasta_imagens2 + "048-yogurt.png");
            IconProdutos[46] = Image.FromFile(pasta_imagens2 + "049-coffee.png"); IconProdutos[47] = Image.FromFile(pasta_imagens2 + "chocolate.png"); IconProdutos[48] = Image.FromFile(pasta_imagens2 + "bolo2.png"); IconProdutos[49] = Image.FromFile(pasta_imagens2 + "taco.png");
        } 


        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FormConfirm_Load(object sender, EventArgs e)
        {

            //NovoItem = ((ComboBox)sender).SelectedItem.ToString();
            Instaciar_Imagens();           
        }     

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            PagInicial pag1 = new PagInicial();
            labelNomeCategoria1.Visible = false;
            labelCategoria1.Visible = false;
            buttonAltNmCateg.Enabled = false;
            buttonAltNmCateg.Visible = false;           
            comboBoxCateg.Visible = false;
            comboBoxOpcoesCategoria.Visible = false;
            comboBoxSlotImg.Visible = false;
            comboBoxSelecionarImg.Visible = false;
            picBoxImageUp.Visible = false;
            picBoxTrocarImagem.Visible = false;
            textBoxResultado.Visible = false;

            picBoxImageUp.Image = null;
            MaximumSize = new System.Drawing.Size(202, 463);           
            this.DialogResult = DialogResult.OK;
            this.Hide();
            pag1.Show();
        }

        private void ComboBoxCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxOpcoesCategoria.Visible = true;

            VerifCustomImg[1] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 1", false);
            VerifCustomImg[2] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 2", false); 
            VerifCustomImg[3] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 3", false);
            VerifCustomImg[4] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 4", false);
            VerifCustomImg[5] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 5", false);
            VerifCustomImg[6] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 6", false);
            VerifCustomImg[7] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 7", false);
            VerifCustomImg[8] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 8", false);

            switch (comboBoxCateg.SelectedIndex)
            {
                case 0:
                    NovoItemNmCateg = "NomeProduto 1";
                    NmImgCateg = "ImagemDoProduto 1";

                    if (VerifCustomImg[1] == false)
                    {
                        picboxImage = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 1", 0);
                        picBoxImageUp.Image = IconProdutos[picboxImage];
                    }
                    else if (VerifCustomImg[1] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 1", ""));
                    }                 
                    break;
                case 1:
                    NovoItemNmCateg = "NomeProduto 2";
                    NmImgCateg = "ImagemDoProduto 2";
                    if (VerifCustomImg[2] == false)
                    {
                        picboxImage = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 2", 0);
                        picBoxImageUp.Image = IconProdutos[picboxImage];
                    }
                    else if (VerifCustomImg[2] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 2", ""));
                    }
                    break;
                case 2:
                    NovoItemNmCateg = "NomeProduto 3";
                    NmImgCateg = "ImagemDoProduto 3";
                    if (VerifCustomImg[3] == false)
                    {
                        picboxImage = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 3", 0);
                        picBoxImageUp.Image = IconProdutos[picboxImage];
                    }
                    else if (VerifCustomImg[3] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 3", ""));
                    }
                    break;
                case 3:
                    NovoItemNmCateg = "NomeProduto 4";
                    NmImgCateg = "ImagemDoProduto 4";
                    if (VerifCustomImg[4] == false)
                    {
                        picboxImage = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 4", 0);
                        picBoxImageUp.Image = IconProdutos[picboxImage];
                    }
                    else if (VerifCustomImg[4] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 4", ""));
                    }
                    break;
                case 4:
                    NovoItemNmCateg = "NomeProduto 5";
                    NmImgCateg = "ImagemDoProduto 5";
                    if (VerifCustomImg[5] == false)
                    {
                        picboxImage = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 5", 0);
                        picBoxImageUp.Image = IconProdutos[picboxImage];
                    }
                    else if (VerifCustomImg[5] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 5", ""));
                    }
                    break;
                case 5:
                    NovoItemNmCateg = "NomeProduto 6";
                    NmImgCateg = "ImagemDoProduto 6";
                    if (VerifCustomImg[6] == false)
                    {
                        picboxImage = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 6", 0);
                        picBoxImageUp.Image = IconProdutos[picboxImage];
                    }
                    else if (VerifCustomImg[6] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 6", ""));
                    }
                    break;
                case 6:
                    NovoItemNmCateg = "NomeProduto 7";
                    NmImgCateg = "ImagemDoProduto 7";
                    if (VerifCustomImg[7] == false)
                    {
                        picboxImage = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 7", 0);
                        picBoxImageUp.Image = IconProdutos[picboxImage];
                    }
                    else if (VerifCustomImg[7] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 7", ""));
                    }
                    break;
                case 7:
                    NovoItemNmCateg = "NomeProduto 8";
                    NmImgCateg = "ImagemDoProduto 8";
                    if (VerifCustomImg[8] == false)
                    {
                        picboxImage = ini1.IniReadInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 8", 0);
                        picBoxImageUp.Image = IconProdutos[picboxImage];
                    }
                    else if (VerifCustomImg[8] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", "Imagem 8", ""));
                    }
                    break;
            }


        }

        private void ButtonAltNmCateg_Click(object sender, EventArgs e)
        {
            if (NovoItemNmCateg == "NomeProduto 1")
            {
                ini1.IniWriteString("Nome da Categoria dos Produtos", NovoItemNmCateg, textBoxResultado.Text);
            }
            if (NovoItemNmCateg == "NomeProduto 2")
            {
                ini1.IniWriteString("Nome da Categoria dos Produtos", NovoItemNmCateg, textBoxResultado.Text);
            }
            if (NovoItemNmCateg == "NomeProduto 3")
            {
                ini1.IniWriteString("Nome da Categoria dos Produtos", NovoItemNmCateg, textBoxResultado.Text);
            }
            if (NovoItemNmCateg == "NomeProduto 4")
            {
                ini1.IniWriteString("Nome da Categoria dos Produtos", NovoItemNmCateg, textBoxResultado.Text);
            }
            if (NovoItemNmCateg == "NomeProduto 5")
            {
                ini1.IniWriteString("Nome da Categoria dos Produtos", NovoItemNmCateg, textBoxResultado.Text);
            }
            if (NovoItemNmCateg == "NomeProduto 6")
            {
                ini1.IniWriteString("Nome da Categoria dos Produtos", NovoItemNmCateg, textBoxResultado.Text);
            }
            if (NovoItemNmCateg == "NomeProduto 7")
            {
                ini1.IniWriteString("Nome da Categoria dos Produtos", NovoItemNmCateg, textBoxResultado.Text);
            }
            if (NovoItemNmCateg == "NomeProduto 8")
            {
                ini1.IniWriteString("Nome da Categoria dos Produtos", NovoItemNmCateg, textBoxResultado.Text);
            }

            MessageBox.Show("A Categoria " + comboBoxCateg.Text.ToUpper() + " \nFoi Alterado para: " + textBoxResultado.Text.ToUpper() + "!");
        }

        private void comboBoxOpcoesCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxOpcoesCategoria.SelectedIndex)
            {
                case 0:

                    labelCategoria1.Text = "Alterar Nome da Categoria\n Seleciona Para:"; labelCategoria1.Visible = true;
                    textBoxResultado.Visible = true;
                    buttonAltNmCateg.Visible = true;
                    buttonCancelar.Location = new System.Drawing.Point(57, 296);

                    //SETAR AS OUTRAS OPCOES COMO FALSE
                    comboBoxSelecionarImg.Visible = false;
                    picBoxTrocarImagem.Visible = false;
                    buttonSubstituirImg.Visible = false;
                    break;
                case 1:
                    labelCategoria1.Text = "Alterar Imagem da Categoria Selecionada Para:"; labelCategoria1.Visible = true;
                    comboBoxSelecionarImg.Visible = true;
                    picBoxTrocarImagem.Visible = true;
                    buttonSubstituirImg.Visible = true;
                    buttonCancelar.Location = new System.Drawing.Point(57, 421);

                    //SETAR AS OUTRAS OPCOES COMO FALSE
                    textBoxResultado.Visible = false;
                    buttonAltNmCateg.Visible = false;
                    break;


            }
        }

        private void comboBoxSelecionarImg_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBoxSelecionarImg.SelectedIndex)
            {
                case 0:
                    picBoxTrocarImagem.Image = IconProdutos[1];
                    NovoItemImgCateg = 1;
                    break;
                case 1:
                    picBoxTrocarImagem.Image = IconProdutos[2];
                    NovoItemImgCateg = 2;
                    break;
                case 2:
                    picBoxTrocarImagem.Image = IconProdutos[3];
                    NovoItemImgCateg = 3;
                    break;
                case 3:
                    picBoxTrocarImagem.Image = IconProdutos[4];
                    NovoItemImgCateg = 4;
                    break;
                case 4:
                    picBoxTrocarImagem.Image = IconProdutos[5];
                    NovoItemImgCateg = 5;
                    break;
                case 5:
                    picBoxTrocarImagem.Image = IconProdutos[6];
                    NovoItemImgCateg = 6;
                    break;
                case 6:
                    picBoxTrocarImagem.Image = IconProdutos[7];
                    NovoItemImgCateg = 7;
                    break;
                case 7:
                    picBoxTrocarImagem.Image = IconProdutos[8];
                    NovoItemImgCateg = 8;
                    break;
                case 8:
                    picBoxTrocarImagem.Image = IconProdutos[9];
                    NovoItemImgCateg = 9;
                    break;
                case 9:
                    picBoxTrocarImagem.Image = IconProdutos[10];
                    NovoItemImgCateg = 10;
                    break;
                case 10:
                    picBoxTrocarImagem.Image = IconProdutos[11];
                    NovoItemImgCateg = 11;
                    break;
                case 11:
                    picBoxTrocarImagem.Image = IconProdutos[12];
                    NovoItemImgCateg = 12;
                    break;
                case 12:
                    picBoxTrocarImagem.Image = IconProdutos[13];
                    NovoItemImgCateg = 13;
                    break;
                case 13:
                    picBoxTrocarImagem.Image = IconProdutos[14];
                    NovoItemImgCateg = 14;
                    break;
                case 14:
                    picBoxTrocarImagem.Image = IconProdutos[15];
                    NovoItemImgCateg = 15;
                    break;
                case 15:
                    picBoxTrocarImagem.Image = IconProdutos[16];
                    NovoItemImgCateg = 16;
                    break;
                case 16:
                    picBoxTrocarImagem.Image = IconProdutos[17];
                    NovoItemImgCateg = 17;
                    break;
                case 17:
                    picBoxTrocarImagem.Image = IconProdutos[18];
                    NovoItemImgCateg = 18;
                    break;
                case 18:
                    picBoxTrocarImagem.Image = IconProdutos[19];
                    NovoItemImgCateg = 19;
                    break;
                case 19:
                    picBoxTrocarImagem.Image = IconProdutos[20];
                    NovoItemImgCateg = 20;
                    break;
                case 20:
                    picBoxTrocarImagem.Image = IconProdutos[21];
                    NovoItemImgCateg = 21;
                    break;
                case 21:
                    picBoxTrocarImagem.Image = IconProdutos[22];
                    NovoItemImgCateg = 22;
                    break;
                case 22:
                    picBoxTrocarImagem.Image = IconProdutos[23];
                    NovoItemImgCateg = 23;
                    break;
                case 23:
                    picBoxTrocarImagem.Image = IconProdutos[24];
                    NovoItemImgCateg = 24;
                    break;
                case 24:
                    picBoxTrocarImagem.Image = IconProdutos[25];
                    NovoItemImgCateg = 25;
                    break;
                case 25:
                    picBoxTrocarImagem.Image = IconProdutos[26];
                    NovoItemImgCateg = 26;
                    break;
                case 26:
                    picBoxTrocarImagem.Image = IconProdutos[27];
                    NovoItemImgCateg = 27;
                    break;
                case 27:
                    picBoxTrocarImagem.Image = IconProdutos[28];
                    NovoItemImgCateg = 28;
                    break;
                case 28:
                    picBoxTrocarImagem.Image = IconProdutos[29];
                    NovoItemImgCateg = 29;
                    break;
                case 29:
                    picBoxTrocarImagem.Image = IconProdutos[30];
                    NovoItemImgCateg = 30;
                    break;
                case 30:
                    picBoxTrocarImagem.Image = IconProdutos[31];
                    NovoItemImgCateg = 31;
                    break;
                case 31:
                    picBoxTrocarImagem.Image = IconProdutos[32];
                    NovoItemImgCateg = 32;
                    break;
                case 32:
                    picBoxTrocarImagem.Image = IconProdutos[33];
                    NovoItemImgCateg = 33;
                    break;
                case 33:
                    picBoxTrocarImagem.Image = IconProdutos[34];
                    NovoItemImgCateg = 34;
                    break;
                case 34:
                    picBoxTrocarImagem.Image = IconProdutos[35];
                    NovoItemImgCateg = 35;
                    break;
                case 35:
                    picBoxTrocarImagem.Image = IconProdutos[36];
                    NovoItemImgCateg = 36;
                    break;
                case 36:
                    picBoxTrocarImagem.Image = IconProdutos[37];
                    NovoItemImgCateg = 37;
                    break;
                case 37:
                    picBoxTrocarImagem.Image = IconProdutos[38];
                    NovoItemImgCateg = 38;
                    break;
                case 38:
                    picBoxTrocarImagem.Image = IconProdutos[39];
                    NovoItemImgCateg = 39;
                    break;
                case 39:
                    picBoxTrocarImagem.Image = IconProdutos[40];
                    NovoItemImgCateg = 40;
                    break;
                case 40:
                    picBoxTrocarImagem.Image = IconProdutos[41];
                    NovoItemImgCateg = 41;
                    break;
                case 41:
                    picBoxTrocarImagem.Image = IconProdutos[42];
                    NovoItemImgCateg = 42;
                    break;
                case 42:
                    picBoxTrocarImagem.Image = IconProdutos[43];
                    NovoItemImgCateg = 43;
                    break;
                case 43:
                    picBoxTrocarImagem.Image = IconProdutos[44];
                    NovoItemImgCateg = 44;
                    break;
                case 44:
                    picBoxTrocarImagem.Image = IconProdutos[45];
                    NovoItemImgCateg = 45;
                    break;
                case 45:
                    picBoxTrocarImagem.Image = IconProdutos[46];
                    NovoItemImgCateg = 46;
                    break;
                case 46:
                    picBoxTrocarImagem.Image = IconProdutos[47];
                    NovoItemImgCateg = 47;
                    break;
                case 47:
                    picBoxTrocarImagem.Image = IconProdutos[48];
                    NovoItemImgCateg = 48;
                    break;
                case 48:
                    picBoxTrocarImagem.Image = IconProdutos[49];
                    NovoItemImgCateg = 49;
                    break;                           
            }
        }

        private void buttonSubstituirImg_Click_1(object sender, EventArgs e)
        {
            ImgAux = picBoxTrocarImagem.Image;
            ini1.IniWriteInt("Imagem Da Categoria dos Produtos", NmImgCateg, NovoItemImgCateg);

            VerifCustomImg[1] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 1", false);
            VerifCustomImg[2] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 2", false);
            VerifCustomImg[3] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 3", false);
            VerifCustomImg[4] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 4", false);
            VerifCustomImg[5] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 5", false);
            VerifCustomImg[6] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 6", false);
            VerifCustomImg[7] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 7", false);
            VerifCustomImg[8] = ini1.IniReadBool("Carregar Icones Customizados", "IconeCustomizado 8", false);

            switch (comboBoxCateg.SelectedIndex)
            {
                case 0:
                    if (VerifCustomImg[1] == true)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 1", NovoItemImgCateg);
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 1", false);
                    }
                    else if (VerifCustomImg[1] == false)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 1", NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;
                case 1:
                    if (VerifCustomImg[2] == true)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 2", NovoItemImgCateg);
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 2", false);
                    }
                    else if (VerifCustomImg[2] == false)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 2", NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;

                case 2:
                    if (VerifCustomImg[3] == true)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 3", NovoItemImgCateg);
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 3", false);
                    }

                    else if (VerifCustomImg[3] == false)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 3", NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;
                case 3:
                    if (VerifCustomImg[4] == true)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 4", NovoItemImgCateg);
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 4", false);
                    }
                    else if (VerifCustomImg[4] == false)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 4", NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;
                case 4:
                    if (VerifCustomImg[5] == true)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 5", NovoItemImgCateg);
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 5", false);
                    }
                    else if (VerifCustomImg[5] == false)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 5", NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;
                case 5:
                    if (VerifCustomImg[6] == true)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 6", NovoItemImgCateg);
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 6", false);
                    }
                    else if (VerifCustomImg[6] == false)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 6", NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;
                case 6:
                    if (VerifCustomImg[7] == true)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 7", NovoItemImgCateg);
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 7", false);
                    }
                    else if (VerifCustomImg[8] == false)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 8", NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;
                case 7:
                    if (VerifCustomImg[8] == true)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 8", NovoItemImgCateg);
                        ini1.IniWriteBool("Carregar Icones Customizados", "IconeCustomizado 8", false);
                    }
                    else if (VerifCustomImg[8] == false)
                    {
                        ini1.IniWriteInt("Imagem Da Categoria dos Produtos", "ImagemDoProduto 8", NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;

            }
        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                buttonAltNmCateg.Enabled = true;
            }
            else
            {
                buttonAltNmCateg.Enabled = false;
            }
        }

        private void buttonSaveImg_Click(object sender, EventArgs e)
        {
           /*  ini1.IniWriteString("Caminho Dos Icones Personalizados", PosIni, imageLocation);
            //IconProdutos[NmSalvarImg] = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", PosIni, ""));
            t2.IconProdutos[NmSalvarImg] = Image.FromFile(imageLocation);
            MessageBox.Show(imageLocation); */
        }
    
    }
}
