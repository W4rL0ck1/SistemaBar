using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bar
{
    public partial class FrmProduto2 : Form
    {
        #region Variaveis

        Principal t2 = new Principal();
        IniFile ini1 = new IniFile();
        //PagInicial pag1 = new PagInicial();
       // string nmProduto = ""; // string StrAux;
        //bool CustomImgVerif = false;
        int NumCategoria; int aux; int NumProduto;
        int Intopcao;
        //int picboxImage;
        public string pasta_imagens1 = ""; public string pasta_imagens2 = "";
        public Image[] IconProdutos = new Image[50];
        bool[] VerifCustomImg = new bool[25]; string[] CarregarCódigo = new string[25]; double[] CarregarPreco = new double[25];
        #endregion

        #region Funcoes
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
        #endregion

        public FrmProduto2()
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
            buttonAlterar.Enabled = false;
            buttonAlterar.Visible = false;
            comboBoxProduto.Visible = false;
            comboBoxCategoria.Visible = false;
            comboBoxOpcoesProduto.Visible = false;
            picBoxImageUp.Visible = false;
            textBoxCodigoBarras.Visible = false;

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
                CarregarCódigo[i] = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + i, "");
                CarregarPreco[i] = double.Parse(ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + i, ""));
                
            }
            switch (comboBoxProduto.SelectedIndex)
            {
                case 0:
                    NumProduto = 1;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto,"");                 
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto,"");
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
                    NumProduto = 2;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
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
                    NumProduto = 3;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[3] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 3", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[3] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 3", ""));
                    }
                    break;

                case 3:
                    NumProduto = 4;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[4] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 4", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[4] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 4", ""));
                    }
                    break;

                case 4:
                    NumProduto = 5;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[5] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 5", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[5] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 5", ""));
                    }
                    break;

                case 5:
                    NumProduto = 6;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[6] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 6", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[6] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 6", ""));
                    }
                    break;

                case 6:
                    NumProduto = 7;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[7] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 7", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[7] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 7", ""));
                    }
                    break;

                case 7:
                    NumProduto = 8;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[8] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 8", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[8] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 8", ""));
                    }
                    break;

                case 8:
                    NumProduto = 9;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[9] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 9", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[9] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 9", ""));
                    }
                    break;

                case 9:
                    NumProduto = 10;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[10] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 10", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[10] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 10", ""));
                    }
                    break;

                case 10:
                    NumProduto = 11;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[11] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 11", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[11] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 11", ""));
                    }
                    break;

                case 11:
                    NumProduto = 12;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[12] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 12", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[12] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 12", ""));
                    }
                    break;

                case 12:
                    NumProduto = 13;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[13] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 13", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[13] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 13", ""));
                    }
                    break;

                case 13:
                    NumProduto = 14;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[14] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 14", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[14] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 14", ""));
                    }
                    break;

                case 14:
                    NumProduto = 15;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[15] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 15", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[15] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 15", ""));
                    }
                    break;

                case 15:
                    NumProduto = 16;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[16] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 16", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[16] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 16", ""));
                    }
                    break;

                case 16:
                    NumProduto = 17;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[17] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 17", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[17] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 17", ""));
                    }
                    break;

                case 17:
                    NumProduto = 18;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[18] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 18", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[18] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 18", ""));
                    }
                    break;

                case 18:
                    NumProduto = 19;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[19] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 19", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[19] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 19", ""));
                    }
                    break;

                case 19:
                    NumProduto = 20;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[20] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 20", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[20] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 20", ""));
                    }
                    break;

                case 20:
                    NumProduto = 21;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[21] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 21", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[21] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 21", ""));
                    }
                    break;

                case 21:
                    NumProduto = 22;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[22] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 22", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[22] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 22", ""));
                    }
                    break;

                case 22:
                    NumProduto = 23;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[23] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 23", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[23] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 23", ""));
                    }
                    break;

                case 23:
                    NumProduto = 24;
                    textBoxCodigoBarras.Text = ini1.IniReadString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, "");
                    textBoxPreco.Text = ini1.IniReadString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, "");
                    if (VerifCustomImg[24] == false)
                    {
                        aux = ini1.IniReadInt("Imagem dos Produtos da Categoria " + NumCategoria, "ImagemDoProduto 24", 0);
                        picBoxImageUp.Image = IconProdutos[aux];
                    }
                    else if (VerifCustomImg[24] == true)
                    {
                        picBoxImageUp.Image = Image.FromFile(ini1.IniReadString("Caminho dos Icones Personalizados da Categoria " + NumCategoria, "Imagem 24", ""));
                    }
                    break;

                                   
           }
       
        }

        private void comboBoxOpcoesCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBoxOpcoesProduto.SelectedIndex)
            {
                case 0:

                    labelProduto1.Text = "Alterar Código Barras do\n Produto Selecionado Para:"; labelProduto1.Visible = true;
                    textBoxCodigoBarras.Visible = true;
                    buttonAlterar.Visible = true;
                    Intopcao = 1;

                    //SETAR AS OUTRAS OPCOES COMO FALSE
                    textBoxPreco.Visible = false;
                    break;
                case 1:
                    labelProduto1.Text = "Alterar Preço do Produto\n Selecionado Para:"; labelProduto1.Visible = true;
                    textBoxPreco.Visible = true;
                    buttonAlterar.Visible = true;
                    Intopcao = 2;

                    //SETAR AS OUTRAS OPCOES COMO FALSE
                    textBoxCodigoBarras.Visible = false;
                    break;

                    
            }
        } 



        private void ButtonAltNmCateg_Click(object sender, EventArgs e)
        {


            if (Intopcao == 1)
            {
                ini1.IniWriteString("Codigo dos Produtos da Categoria " + NumCategoria, "Codigo " + NumProduto, textBoxCodigoBarras.Text.ToString());
                MessageBox.Show("O Produto " + comboBoxProduto.Text.ToUpper() + " \nTeve o Código de Barras alterado Para :\n " + textBoxCodigoBarras.Text.ToUpper() + " !");
            }
            if (Intopcao == 2)
            {
                ini1.IniWriteString("Preco dos Produtos da Categoria " + NumCategoria, "Preco " + NumProduto, textBoxPreco.Text.ToString());
                MessageBox.Show("O Produto " + comboBoxProduto.Text.ToUpper() + " \nTeve seu Preço Para :\n " + textBoxPreco.Text.ToUpper() + " !");
            }
           
        }

        private void textBoxCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCodigoBarras.Text != "")
            {
                buttonAlterar.Enabled = true;
            }
            else
            {
                buttonAlterar.Enabled = false;
            }
        }

        private void textBoxPreco_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCodigoBarras.Text != "")
            {
                buttonAlterar.Enabled = true;
            }
            else
            {
                buttonAlterar.Enabled = false;
            }
        }
    }
}
