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
    public partial class FrmProduto : Form
    {
        Principal t2 = new Principal();
        IniFile ini1 = new IniFile();
        //PagInicial pag1 = new PagInicial();
        string NmImgCateg = ""; string nmProduto = ""; // string StrAux;
        //bool CustomImgVerif = false;
        int NovoItemImgCateg; int NumCategoria; int aux; int NumProduto;
        //int picboxImage;
        public string pasta_imagens1 = ""; public string pasta_imagens2 = "";
        public Image[] IconProdutos = new Image[50];
        bool[] VerifCustomImg = new bool[25]; bool[] VerifAtivado = new bool[25];
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


        public FrmProduto()
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
            labelNomeProduto1.Visible = false;
            labelProduto1.Visible = false;
            buttonAltNmProduto.Enabled = false;
            buttonAltNmProduto.Visible = false;
            comboBoxProduto.Visible = false;
            comboBoxCategoria.Visible = false;
            comboBoxOpcoesProduto.Visible = false;
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
            comboBoxProduto.Visible = true;

            comboBoxProduto.Items.Clear();
            comboBoxProduto.Text = "---Selecionar!---";

            switch (comboBoxCategoria.SelectedIndex)
            {
                case 0:
                    NumCategoria = 1;
                    comboBoxProduto.Items.AddRange(new object[] { ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 1", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 2", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 3", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 4", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 5", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 6", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 7", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 8", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 9", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 10", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 11", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 12", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 13", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 14", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 15", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 16", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 17", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 18", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 19", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 20", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 21", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 22", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 23", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 24", ""), });
                    break;
                case 1:
                    NumCategoria = 2;
                    comboBoxProduto.Items.AddRange(new object[] { ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 1", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 2", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 3", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 4", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 5", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 6", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 7", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 8", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 9", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 10", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 11", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 12", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 13", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 14", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 15", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 16", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 17", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 18", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 19", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 20", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 21", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 22", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 23", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 24", ""), });
                    break;
                case 2:
                    NumCategoria = 3;
                    comboBoxProduto.Items.AddRange(new object[] { ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 1", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 2", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 3", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 4", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 5", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 6", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 7", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 8", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 9", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 10", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 11", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 12", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 13", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 14", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 15", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 16", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 17", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 18", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 19", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 20", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 21", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 22", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 23", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 24", ""), });
                    break;
                case 3:
                    NumCategoria = 4;
                    comboBoxProduto.Items.AddRange(new object[] { ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 1", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 2", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 3", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 4", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 5", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 6", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 7", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 8", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 9", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 10", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 11", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 12", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 13", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 14", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 15", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 16", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 17", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 18", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 19", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 20", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 21", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 22", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 23", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 24", ""), });
                    break;
                case 4:
                    NumCategoria = 5;
                    comboBoxProduto.Items.AddRange(new object[] { ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 1", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 2", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 3", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 4", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 5", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 6", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 7", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 8", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 9", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 10", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 11", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 12", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 13", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 14", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 15", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 16", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 17", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 18", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 19", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 20", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 21", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 22", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 23", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 24", ""), });
                    break;
                case 5:
                    NumCategoria = 6;
                    comboBoxProduto.Items.AddRange(new object[] { ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 1", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 2", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 3", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 4", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 5", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 6", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 7", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 8", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 9", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 10", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 11", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 12", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 13", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 14", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 15", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 16", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 17", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 18", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 19", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 20", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 21", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 22", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 23", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 24", ""), });
                    break;
                case 6:
                    NumCategoria = 7;
                    comboBoxProduto.Items.AddRange(new object[] { ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 1", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 2", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 3", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 4", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 5", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 6", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 7", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 8", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 9", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 10", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 11", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 12", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 13", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 14", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 15", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 16", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 17", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 18", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 19", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 20", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 21", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 22", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 23", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 24", ""), });
                    break;
                case 7:
                    NumCategoria = 8;
                    comboBoxProduto.Items.AddRange(new object[] { ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 1", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 2", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 3", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 4", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 5", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 6", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 7", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 8", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 9", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 10", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 11", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 12", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 13", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 14", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 15", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 16", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 17", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 18", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 19", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 20", ""),
                    ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 21", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 22", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 23", ""), ini1.IniReadString("Nome dos Produtos da Categoria " + NumCategoria, "Nome do Produto 24", ""), });
                    break;
            }
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxOpcoesProduto.Visible = true;

            for (int i = 1; i <= 24; i++)
            {
                VerifCustomImg[i] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + NumCategoria, "IconeCustomizado " + i, false);
                VerifAtivado[i] = ini1.IniReadBool("Produtos Ativados da Categoria " + NumCategoria, "Ativado Item " + i, false);                       
            }


            switch (comboBoxProduto.SelectedIndex)
            {
                case 0:
                    if (VerifAtivado[1] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[1] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 1:
                    if (VerifAtivado[2] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[2] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 2:
                    if (VerifAtivado[3] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[3] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;                   

                case 3:
                    if (VerifAtivado[4] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[4] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 4:
                    if (VerifAtivado[5] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[5] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 5:
                    if (VerifAtivado[6] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[6] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 6:
                    if (VerifAtivado[7] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[7] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 7:
                    if (VerifAtivado[8] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[8] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                   

                case 8:
                    if (VerifAtivado[9] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[9] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 9:
                    if (VerifAtivado[10] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[10] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 10:
                    if (VerifAtivado[11] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[11] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 11:
                    if (VerifAtivado[12] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[12] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 12:
                    if (VerifAtivado[13] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[13] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 13:
                    if (VerifAtivado[14] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[14] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 14:
                    if (VerifAtivado[15] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[15] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 15:
                    if (VerifAtivado[16] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[16] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 16:
                    if (VerifAtivado[17] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[17] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 17:
                    if (VerifAtivado[18] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[18] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 18:
                    if (VerifAtivado[19] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[19] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
                
                case 19:
                    if (VerifAtivado[20] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[20] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 20:
                    if (VerifAtivado[21] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[21] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 21:
                    if (VerifAtivado[22] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[22] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 22:
                    if (VerifAtivado[23] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[23] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 23:
                    if (VerifAtivado[24] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[24] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;
            }

            switch (comboBoxProduto.SelectedIndex)
            {
                case 0:
                    nmProduto = "Nome do Produto 1";
                    NumProduto = 1;
                    if (VerifCustomImg[1] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 1", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[1] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 1", ""));
                    }
                    break;

                case 1:
                    nmProduto = "Nome do Produto 2";
                    NumProduto = 2;
                    if (VerifCustomImg[2] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 2", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[2] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 2", ""));
                    }
                    break;
                  

                case 2:
                    nmProduto = "Nome do Produto 3";
                    NumProduto = 3;
                    if (VerifCustomImg[3] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 3", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[3] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 3", ""));
                    }
                    if (VerifAtivado[3] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[3] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 3:
                    nmProduto = "Nome do Produto 4";
                    NumProduto = 4;
                    if (VerifCustomImg[4] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 4", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[4] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 4", ""));
                    }
                    if (VerifAtivado[4] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[4] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 4:
                    nmProduto = "Nome do Produto 5";
                    NumProduto = 5;
                    if (VerifCustomImg[5] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 5", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[5] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 5", ""));
                    }
                    if (VerifAtivado[5] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[5] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 5:
                    nmProduto = "Nome do Produto 6";
                    NumProduto = 6;
                    if (VerifCustomImg[6] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 6", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[6] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 6", ""));
                    }
                    if (VerifAtivado[6] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[6] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 6:
                    nmProduto = "Nome do Produto 7";
                    NumProduto = 7;
                    if (VerifCustomImg[7] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 7", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[7] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 7", ""));
                    }
                    if (VerifAtivado[7] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[7] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 7:
                    nmProduto = "Nome do Produto 8";
                    NumProduto = 8;
                    if (VerifCustomImg[8] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 8", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[8] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 8", ""));
                    }
                    if (VerifAtivado[8] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[8] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 8:
                    nmProduto = "Nome do Produto 9";
                    NumProduto = 9;
                    if (VerifCustomImg[9] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 9", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[9] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 9", ""));
                    }
                    if (VerifAtivado[9] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[9] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 9:
                    nmProduto = "Nome do Produto 10";
                    NumProduto = 10;
                    if (VerifCustomImg[10] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 10", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[10] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 10", ""));
                    }
                    if (VerifAtivado[10] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[10] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 10:
                    nmProduto = "Nome do Produto 11";
                    NumProduto = 11;
                    if (VerifCustomImg[11] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 11", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[11] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 11", ""));
                    }
                    if (VerifAtivado[11] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[11] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 11:
                    nmProduto = "Nome do Produto 12";
                    NumProduto = 12;
                    if (VerifCustomImg[12] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 12", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[12] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 12", ""));
                    }
                    if (VerifAtivado[12] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[12] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 12:
                    nmProduto = "Nome do Produto 13";
                    NumProduto = 13;
                    if (VerifCustomImg[13] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 13", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[13] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 13", ""));
                    }
                    if (VerifAtivado[13] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[13] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 13:
                    nmProduto = "Nome do Produto 14";
                    NumProduto = 14;
                    if (VerifCustomImg[14] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 14", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[14] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 14", ""));
                    }
                    if (VerifAtivado[14] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[14] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 14:
                    nmProduto = "Nome do Produto 15";
                    NumProduto = 15;
                    if (VerifCustomImg[15] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 15", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[15] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 15", ""));
                    }
                    if (VerifAtivado[15] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[15] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 15:
                    nmProduto = "Nome do Produto 16";
                    NumProduto = 16;
                    if (VerifCustomImg[16] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 16", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[16] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 16", ""));
                    }
                    if (VerifAtivado[16] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[16] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 16:
                    nmProduto = "Nome do Produto 17";
                    NumProduto = 17;
                    if (VerifCustomImg[17] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 17", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[17] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 17", ""));
                    }
                    if (VerifAtivado[17] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[17] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 17:
                    nmProduto = "Nome do Produto 18";
                    NumProduto = 18;
                    if (VerifCustomImg[18] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 18", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[18] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 18", ""));
                    }
                    if (VerifAtivado[18] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[18] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 18:
                    nmProduto = "Nome do Produto 19";
                    NumProduto = 19;
                    if (VerifCustomImg[19] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 19", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[19] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 19", ""));
                    }
                    if (VerifAtivado[19] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[19] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 19:
                    nmProduto = "Nome do Produto 20";
                    NumProduto = 20;
                    if (VerifCustomImg[20] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 20", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[20] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 20", ""));
                    }
                    if (VerifAtivado[20] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[20] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 20:
                    nmProduto = "Nome do Produto 21";
                    NumProduto = 21;
                    if (VerifCustomImg[21] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 21", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[21] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 21", ""));
                    }
                    if (VerifAtivado[21] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[21] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 21:
                    nmProduto = "Nome do Produto 22";
                    NumProduto = 22;
                    if (VerifCustomImg[22] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 22", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[22] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 22", ""));
                    }
                    if (VerifAtivado[22] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[22] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 22:
                    nmProduto = "Nome do Produto 23";
                    NumProduto = 23;
                    if (VerifCustomImg[23] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 23", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[23] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 23", ""));
                    }
                    if (VerifAtivado[23] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[23] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

                case 23:
                    nmProduto = "Nome do Produto 24";
                    NumProduto = 24;
                    if (VerifCustomImg[24] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 24", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[24] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 24", ""));
                    }
                    if (VerifAtivado[24] == false)
                    {
                        buttonAtivarProduto.Enabled = true;
                        buttonDesativarProduto.Enabled = false;
                    }
                    else if (VerifAtivado[24] == true)
                    {
                        buttonAtivarProduto.Enabled = false;
                        buttonDesativarProduto.Enabled = true;
                    }
                    break;

            }
       
        }

        private void comboBoxOpcoesCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxOpcoesProduto.SelectedIndex)
            {
                case 0:

                    labelProduto1.Text = "Alterar Nome do Produto\n Selecionado Para:"; labelProduto1.Visible = true;
                    textBoxResultado.Visible = true;
                    buttonAltNmProduto.Visible = true;
                    buttonAtivarProduto.Visible = true;
                    buttonDesativarProduto.Visible = true;
                    //buttonCancelar.Location = new System.Drawing.Point(57, 296);
                    buttonCancelar.Location = new System.Drawing.Point(57, 421);

                    //SETAR AS OUTRAS OPCOES COMO FALSE
                    comboBoxSelecionarImg.Visible = false;
                    picBoxTrocarImagem.Visible = false;
                    buttonSubstituirImg.Visible = false;
                    break;
                case 1:
                    labelProduto1.Text = "Alterar Imagem do Produto Selecionado Para:"; labelProduto1.Visible = true;
                    comboBoxSelecionarImg.Visible = true;
                    picBoxTrocarImagem.Visible = true;
                    buttonSubstituirImg.Visible = true;
                    buttonCancelar.Location = new System.Drawing.Point(57, 421);

                    //SETAR AS OUTRAS OPCOES COMO FALSE
                    textBoxResultado.Visible = false;
                    buttonAltNmProduto.Visible = false;
                    buttonAtivarProduto.Visible = false;
                    buttonDesativarProduto.Visible = false;
                    break;


            }
        }

        private void buttonAtivarProduto_Click(object sender, EventArgs e)
        {
            ini1.IniWriteBool("Produtos Ativados da Categoria " + NumCategoria, "Ativado Item " + NumProduto, true);
            buttonAtivarProduto.Enabled = false;
            buttonDesativarProduto.Enabled = true;
            MessageBox.Show("O Produto Selecionado Foi Ativado!");
        }

        private void buttonDesativarProduto_Click(object sender, EventArgs e)
        {
            ini1.IniWriteBool("Produtos Ativados da Categoria " + NumCategoria, "Ativado Item " + NumProduto, false);
            buttonAtivarProduto.Enabled = true;
            buttonDesativarProduto.Enabled = false;
            MessageBox.Show("O Produto Selecionado Foi Desativado!");
        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                buttonAltNmProduto.Enabled = true;
            }
            else
            {
                buttonAltNmProduto.Enabled = false;
            }
        }

        private void ButtonAltNmCateg_Click(object sender, EventArgs e)
        {         
            ini1.IniWriteString("Nome dos Produtos da Categoria " + NumCategoria, nmProduto, textBoxResultado.Text);

            MessageBox.Show("O Produto " + comboBoxProduto.Text.ToUpper() + " \nFoi Alterado para: " + textBoxResultado.Text.ToUpper() + "!");
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

            for (int i = 1; i <= 24; i++)
            {
                VerifCustomImg[i] = ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + NumCategoria, "IconeCustomizado " + i, false);
            }


            switch (comboBoxProduto.SelectedIndex)
            {
                case 0:
                    if (VerifCustomImg[1] == true)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 1", NovoItemImgCateg);
                        ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + NumCategoria, "IconeCustomizado " + 1, false);
                    }
                    else if (VerifCustomImg[1] == false)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 1", NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone do Produto selecionado\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;
                case 1:
                    if (VerifCustomImg[2] == true)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto " + 2, NovoItemImgCateg);
                        ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + NumCategoria, "IconeCustomizado " + 2, false);
                    }
                    else if (VerifCustomImg[2] == false)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto " + 2, NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;

                case 2:
                    if (VerifCustomImg[3] == true)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto " + 3, NovoItemImgCateg);
                        ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + NumCategoria, "IconeCustomizado " + 3, false);
                    }

                    else if (VerifCustomImg[3] == false)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto " + 3, NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;
                case 3:
                    if (VerifCustomImg[4] == true)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto " + 4, NovoItemImgCateg);
                        ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + NumCategoria, "IconeCustomizado " + 4, false);
                    }
                    else if (VerifCustomImg[4] == false)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto " + 4, NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;
                case 4:
                    if (VerifCustomImg[5] == true)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto " + 5, NovoItemImgCateg);
                        ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + NumCategoria, "IconeCustomizado " + 5, false);
                    }
                    else if (VerifCustomImg[5] == false)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto " + 5, NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;
                case 5:
                    if (VerifCustomImg[6] == true)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto " + 6, NovoItemImgCateg);
                        ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + NumCategoria, "IconeCustomizado " + 6, false);
                    }
                    else if (VerifCustomImg[6] == false)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto " + 6, NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;
                case 6:
                    if (VerifCustomImg[7] == true)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto " + 7, NovoItemImgCateg);
                        ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + NumCategoria, "IconeCustomizado " + 7, false);
                    }
                    else if (VerifCustomImg[8] == false)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto " + 7, NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;
                case 7:
                    if (VerifCustomImg[8] == true)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto " + 8, NovoItemImgCateg);
                        ini1.IniReadBool("Carregar Icones Customizados Produtos Categoria " + NumCategoria, "IconeCustomizado " + 8, false);
                    }
                    else if (VerifCustomImg[8] == false)
                    {
                        ini1.IniWriteInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto " + 8, NovoItemImgCateg);
                    }
                    MessageBox.Show("O icone da Categoria selecionada\n Foi Alterado com Sucesso!\n Atualize a Página!");
                    break;

            }
        }

       

        private void buttonSaveImg_Click(object sender, EventArgs e)
        {
           /* ini1.IniWriteString("Caminho Dos Icones Personalizados", PosIni, imageLocation);
            //IconProdutos[NmSalvarImg] = Image.FromFile(ini1.IniReadString("Caminho Dos Icones Personalizados", PosIni, ""));
            t2.IconProdutos[NmSalvarImg] = Image.FromFile(imageLocation);
            MessageBox.Show(imageLocation); */
        }

      
    }
}
