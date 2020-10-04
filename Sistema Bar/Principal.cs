using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.IO;

namespace Sistema_Bar
{
    class Principal : IniFile
    {
        public string pasta_imagens1 = ""; public string pasta_imagens2 = ""; public string pasta_imagens3 = "";
        public Image[] Imgs = new Image[20];
        public Image[] IconProdutos = new Image[60];
       


        public void Instaciar_Imagens()
        {
            pasta_imagens1 = Application.StartupPath + @"\images\icones\IconesVariados\";
            pasta_imagens2 = Application.StartupPath + @"\images\icones\IconesProdutos\"; 
            pasta_imagens3 = Application.StartupPath + @"\images\icones\";
            Imgs[1] = Image.FromFile(pasta_imagens1 + "menu1.png"); Imgs[2] = Image.FromFile(pasta_imagens1 + "menu2.png"); Imgs[3] = Image.FromFile(pasta_imagens1 + "carrinho1.png"); Imgs[4] = Image.FromFile(pasta_imagens1 + "carrinho2.png"); Imgs[5] = Image.FromFile(pasta_imagens1 + "caixa1.png");
            Imgs[6] = Image.FromFile(pasta_imagens1 + "caixa2.png");
            IconProdutos[1] = Image.FromFile(pasta_imagens2 + "batatafrita.png"); IconProdutos[2] = Image.FromFile(pasta_imagens2 + "bolo.png"); IconProdutos[3] = Image.FromFile(pasta_imagens2 + "cachorro quente.png"); IconProdutos[4] = Image.FromFile(pasta_imagens2 + "cafe.png"); IconProdutos[5] = Image.FromFile(pasta_imagens2 + "doces.png");
            IconProdutos[6] = Image.FromFile(pasta_imagens2 + "franguinho.png"); IconProdutos[7] = Image.FromFile(pasta_imagens2 + "garfo e colher.png"); IconProdutos[8] = Image.FromFile(pasta_imagens2 + "hamburguer.png"); IconProdutos[9] = Image.FromFile(pasta_imagens2 + "lanche.png"); IconProdutos[10] = Image.FromFile(pasta_imagens2 + "pipoca.png");
            IconProdutos[11] = Image.FromFile(pasta_imagens2 + "pirulito.png"); IconProdutos[12] = Image.FromFile(pasta_imagens2 + "pizza.png"); IconProdutos[13] = Image.FromFile(pasta_imagens2 + "refrigerante.png"); IconProdutos[14] = Image.FromFile(pasta_imagens2 + "refrigerante2.png"); IconProdutos[15] = Image.FromFile(pasta_imagens2 + "sorvete1.png");
            IconProdutos[16] = Image.FromFile(pasta_imagens2 + "sorvete2.png"); IconProdutos[17] = Image.FromFile(pasta_imagens2 + "001-shopping bag.png"); IconProdutos[18] = Image.FromFile(pasta_imagens2 + "002-canned food.png"); IconProdutos[19] = Image.FromFile(pasta_imagens2 + "003-paper bag.png"); IconProdutos[20] = Image.FromFile(pasta_imagens2 + "005-chili sauce.png");
            IconProdutos[21] = Image.FromFile(pasta_imagens2 + "007-eggs.png"); IconProdutos[22] = Image.FromFile(pasta_imagens2 + "008-soda.png"); IconProdutos[23] = Image.FromFile(pasta_imagens2 + "026-toilet paper.png"); IconProdutos[24] = Image.FromFile(pasta_imagens2 + "033-liquid soap.png"); IconProdutos[25] = Image.FromFile(pasta_imagens2 + "037-toothpaste.png");
            IconProdutos[26] = Image.FromFile(pasta_imagens2 + "010-chocolate.png"); IconProdutos[27] = Image.FromFile(pasta_imagens2 + "017-sausages.png"); IconProdutos[28] = Image.FromFile(pasta_imagens2 + "027-olive oil.png"); IconProdutos[29] = Image.FromFile(pasta_imagens2 + "034-fridge.png"); IconProdutos[30] = Image.FromFile(pasta_imagens2 + "038-cereal.png");
            IconProdutos[31] = Image.FromFile(pasta_imagens2 + "011-jam.png"); IconProdutos[32] = Image.FromFile(pasta_imagens2 + "022-meat.png"); IconProdutos[33] = Image.FromFile(pasta_imagens2 + "029-sardines.png"); IconProdutos[34] = Image.FromFile(pasta_imagens2 + "035-milk bottle.png"); IconProdutos[35] = Image.FromFile(pasta_imagens2 + "039-snack.png");
            IconProdutos[36] = Image.FromFile(pasta_imagens2 + "015-avocado.png"); IconProdutos[37] = Image.FromFile(pasta_imagens2 + "023-salami.png"); IconProdutos[38] = Image.FromFile(pasta_imagens2 + "032-ketchup.png"); IconProdutos[39] = Image.FromFile(pasta_imagens2 + "036-bread.png"); IconProdutos[40] = Image.FromFile(pasta_imagens2 + "040-mayonnaise.png");
            IconProdutos[41] = Image.FromFile(pasta_imagens2 + "041-juice.png"); IconProdutos[42] = Image.FromFile(pasta_imagens2 + "042-fish.png"); IconProdutos[43] = Image.FromFile(pasta_imagens2 + "043-cheese.png"); IconProdutos[44] = Image.FromFile(pasta_imagens2 + "045-Butter.png");IconProdutos[45] = Image.FromFile(pasta_imagens2 + "048-yogurt.png");
            IconProdutos[46] = Image.FromFile(pasta_imagens2 + "049-coffee.png"); IconProdutos[47] = Image.FromFile(pasta_imagens2 + "chocolate.png"); IconProdutos[48] = Image.FromFile(pasta_imagens2 + "bolo2.png"); IconProdutos[49] = Image.FromFile(pasta_imagens2 + "taco.png");
        }

        /*public void Alterar_Opcoes(int categoria)
        {
            switch (categoria)
            {
                case 1:
                    Console.WriteLine("Case 2");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 2");
                    break;
                case 4:
                    Console.WriteLine("Case 1");
                    break;
                case 5:
                    Console.WriteLine("Case 2");
                    break;
                case 6:
                    Console.WriteLine("Case 2");
                    break;
                case 7:
                    Console.WriteLine("Case 1");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }*/

        public void GerarIni()
        {
            //CATEGORIAS

            string Chave = "chave";
            string MinhaString = "Minha String";
            //ID PRODUTOS
            for (int i = 1; i <= 8; i++)
            {
                Chave = "NomedoProduto " + i;
                MinhaString = "Produto " + i;
                IniWriteString("ID da Categoria dos Produtos", Chave, MinhaString);
            }
            // IMAGEM DOS PRODUTOS
            for (int i = 1; i <= 8; i++)
            {
                Chave = "ImagemDoProduto " + i;
                MinhaString = i.ToString();
                IniWriteString("Imagem Da Categoria dos Produtos", Chave, MinhaString);
            }

            //NOME DA CATEGORIA DOS PRODUTOS
            IniWriteString("Nome da Categoria dos Produtos", "NomeProduto 1", "Fritas");
            IniWriteString("Nome da Categoria dos Produtos", "NomeProduto 2", "Bolos");
            IniWriteString("Nome da Categoria dos Produtos", "NomeProduto 3", "Lanches");
            IniWriteString("Nome da Categoria dos Produtos", "NomeProduto 4", "Bebidas e Cafe");
            IniWriteString("Nome da Categoria dos Produtos", "NomeProduto 5", "Doces");
            IniWriteString("Nome da Categoria dos Produtos", "NomeProduto 6", "Carnes");
            IniWriteString("Nome da Categoria dos Produtos", "NomeProduto 7", "Almoços");
            IniWriteString("Nome da Categoria dos Produtos", "NomeProduto 8", "Lanches 2");

            //CARREGAR ICONES CUSTOM
            for (int i = 1; i <= 8; i++)
            {
                Chave = "IconeCustomizado " + i;
                MinhaString = "False";
                IniWriteString("Carregar Icones Customizados", Chave, MinhaString);
            }            

            //CAMINHO DAS IMAGENS PERSONALIZADAS
            for (int i = 1; i <= 8; i++)
            {
                Chave = "Imagem " + i;
                MinhaString = "nULL";
                IniWriteString("Caminho Dos Icones Personalizados", Chave, MinhaString);
            }

            //SETAR QUANTOS PRODUTOS DE CADA CATEGORIA ESTAO ATIVADOS
            for (int i = 1; i <= 8; i++)
            {
                for (int y = 1; y <= 24; y++)
                {
                    Chave = "Ativado Item " + y;
                    MinhaString = "False";
                    IniWriteString("Produtos Ativados da Categoria " + i, Chave, MinhaString);
                }
            }





            //PRODUTOS
            // IMAGEM DOS PRODUTOS DAS CATEGORIAS
            for (int i = 1; i <= 8; i++)
            {
                for (int y = 1; y <= 24; y++)
                {
                    Chave = "ImagemDoProduto " + y;
                    MinhaString = y.ToString();
                    IniWriteString("Imagem dos Produtos da Categoria " + i, Chave, MinhaString);
                }
            }        


            //NOME DOS PRODUTOS DAS CATEGORIAS
            for (int i = 1; i <= 8; i++)
            {
                for (int y = 1; y <= 24; y++)
                {
                    Chave = "Nome do Produto " + y;
                    MinhaString = "NulL";
                    IniWriteString("Nome dos Produtos da Categoria " + i, Chave, MinhaString);
                }
            }


            //CARREGAR ICONES CUSTOM
            for (int i = 1; i <= 8; i++)
            {
                for (int y = 1; y <= 24; y++)
                {
                    Chave = "IconeCustomizado " + y;
                    MinhaString = "False";
                    IniWriteString("Carregar Icones Customizados Produtos Categoria " + i, Chave, MinhaString);
                }
            }

            //CAMINHO DAS IMAGENS PERSONALIZADAS
            for (int i = 1; i <= 8; i++)
            {
                for (int y = 1; y <= 24; y++)
                {
                    Chave = "Imagem " + y;
                    MinhaString = "nulL";
                    IniWriteString("Caminho dos Icones Personalizados da Categoria " + i, Chave, MinhaString);
                }
            }

            //GERAR PRODUTOS PADRÃO DO PROGRAMA
            for (int i = 1;i <=1;i++)
            {
                //Produtos Categoria 1
                IniWriteString("Produtos Ativados da Categoria 1", "Ativado Item 1", "true");
                IniWriteString("Produtos Ativados da Categoria 1", "Ativado Item 2", "true");

                IniWriteString("Imagem dos Produtos da Categoria 1", "ImagemDoProduto 1", "9");
                IniWriteString("Imagem dos Produtos da Categoria 1", "ImagemDoProduto 2", "1");

                IniWriteString("Nome dos Produtos da Categoria 1", "Nome do Produto 1", "Pastel");
                IniWriteString("Nome dos Produtos da Categoria 1", "Nome do Produto 2", "Batata Frita");

                //Produtos Categoria 2
                IniWriteString("Produtos Ativados da Categoria 2", "Ativado Item 1", "true");
                IniWriteString("Produtos Ativados da Categoria 2", "Ativado Item 2", "true");


                IniWriteString("Imagem dos Produtos da Categoria 2", "ImagemDoProduto 1", "48");
                IniWriteString("Imagem dos Produtos da Categoria 2", "ImagemDoProduto 2", "2");


                IniWriteString("Nome dos Produtos da Categoria 2", "Nome do Produto 1", "Bolo Avelã");
                IniWriteString("Nome dos Produtos da Categoria 2", "Nome do Produto 2", "Bolo Laranja");



                //Produtos Categoria 3
                IniWriteString("Produtos Ativados da Categoria 3", "Ativado Item 1", "true");
                IniWriteString("Produtos Ativados da Categoria 3", "Ativado Item 2", "true");
                IniWriteString("Produtos Ativados da Categoria 3", "Ativado Item 3", "true");
                IniWriteString("Produtos Ativados da Categoria 3", "Ativado Item 4", "true");
                IniWriteString("Produtos Ativados da Categoria 3", "Ativado Item 5", "true");
                IniWriteString("Produtos Ativados da Categoria 3", "Ativado Item 6", "true");

                IniWriteString("Imagem dos Produtos da Categoria 3", "ImagemDoProduto 1", "3");
                IniWriteString("Imagem dos Produtos da Categoria 3", "ImagemDoProduto 2", "8");
                IniWriteString("Imagem dos Produtos da Categoria 3", "ImagemDoProduto 3", "9");
                IniWriteString("Imagem dos Produtos da Categoria 3", "ImagemDoProduto 4", "12");
                IniWriteString("Imagem dos Produtos da Categoria 3", "ImagemDoProduto 5", "49");
                IniWriteString("Imagem dos Produtos da Categoria 3", "ImagemDoProduto 6", "15");

                IniWriteString("Nome dos Produtos da Categoria 3", "Nome do Produto 1", "Cachorro Quente");
                IniWriteString("Nome dos Produtos da Categoria 3", "Nome do Produto 2", "X-Salada");
                IniWriteString("Nome dos Produtos da Categoria 3", "Nome do Produto 3", "Pastel");
                IniWriteString("Nome dos Produtos da Categoria 3", "Nome do Produto 4", "Pizza");
                IniWriteString("Nome dos Produtos da Categoria 3", "Nome do Produto 5", "Taco");
                IniWriteString("Nome dos Produtos da Categoria 3", "Nome do Produto 6", "Sorvete");



                //Produtos Categoria 4
                IniWriteString("Produtos Ativados da Categoria 4", "Ativado Item 1", "true");
                IniWriteString("Produtos Ativados da Categoria 4", "Ativado Item 2", "true");
                IniWriteString("Produtos Ativados da Categoria 4", "Ativado Item 3", "true");
                IniWriteString("Produtos Ativados da Categoria 4", "Ativado Item 4", "true");
                IniWriteString("Produtos Ativados da Categoria 4", "Ativado Item 5", "true");
                IniWriteString("Produtos Ativados da Categoria 4", "Ativado Item 6", "true");

                IniWriteString("Imagem dos Produtos da Categoria 4", "ImagemDoProduto 1", "4");
                IniWriteString("Imagem dos Produtos da Categoria 4", "ImagemDoProduto 2", "13");
                IniWriteString("Imagem dos Produtos da Categoria 4", "ImagemDoProduto 3", "14");
                IniWriteString("Imagem dos Produtos da Categoria 4", "ImagemDoProduto 4", "40");
                IniWriteString("Imagem dos Produtos da Categoria 4", "ImagemDoProduto 5", "41");
                IniWriteString("Imagem dos Produtos da Categoria 4", "ImagemDoProduto 6", "34");

                IniWriteString("Nome dos Produtos da Categoria 4", "Nome do Produto 1", "Café");
                IniWriteString("Nome dos Produtos da Categoria 4", "Nome do Produto 2", "Coca- Cola");
                IniWriteString("Nome dos Produtos da Categoria 4", "Nome do Produto 3", "Pepsi");
                IniWriteString("Nome dos Produtos da Categoria 4", "Nome do Produto 4", "Dolly");
                IniWriteString("Nome dos Produtos da Categoria 4", "Nome do Produto 5", "Suco Camp");
                IniWriteString("Nome dos Produtos da Categoria 4", "Nome do Produto 6", "Leite Itambé");

                //Produtos Categoria 5
                IniWriteString("Produtos Ativados da Categoria 5", "Ativado Item 1", "true");
                IniWriteString("Produtos Ativados da Categoria 5", "Ativado Item 2", "true");
                IniWriteString("Produtos Ativados da Categoria 5", "Ativado Item 3", "true");
                IniWriteString("Produtos Ativados da Categoria 5", "Ativado Item 4", "true");
                IniWriteString("Produtos Ativados da Categoria 5", "Ativado Item 5", "true");
                IniWriteString("Produtos Ativados da Categoria 5", "Ativado Item 6", "true");

                IniWriteString("Imagem dos Produtos da Categoria 5", "ImagemDoProduto 1", "2");
                IniWriteString("Imagem dos Produtos da Categoria 5", "ImagemDoProduto 2", "5");
                IniWriteString("Imagem dos Produtos da Categoria 5", "ImagemDoProduto 3", "11");
                IniWriteString("Imagem dos Produtos da Categoria 5", "ImagemDoProduto 4", "26");
                IniWriteString("Imagem dos Produtos da Categoria 5", "ImagemDoProduto 5", "15");
                IniWriteString("Imagem dos Produtos da Categoria 5", "ImagemDoProduto 6", "34");

                IniWriteString("Nome dos Produtos da Categoria 5", "Nome do Produto 1", "Bolo Avelã");
                IniWriteString("Nome dos Produtos da Categoria 5", "Nome do Produto 2", "Choco. Suffler");
                IniWriteString("Nome dos Produtos da Categoria 5", "Nome do Produto 3", "Bala Halls");
                IniWriteString("Nome dos Produtos da Categoria 5", "Nome do Produto 4", "Choco. Nestlé");
                IniWriteString("Nome dos Produtos da Categoria 5", "Nome do Produto 5", "Sorvete1");
                IniWriteString("Nome dos Produtos da Categoria 5", "Nome do Produto 6", "Leite Itambé");


                //Produtos Categoria 6
                IniWriteString("Produtos Ativados da Categoria 6", "Ativado Item 1", "true");
                IniWriteString("Produtos Ativados da Categoria 6", "Ativado Item 2", "true");


                IniWriteString("Imagem dos Produtos da Categoria 6", "ImagemDoProduto 1", "6");
                IniWriteString("Imagem dos Produtos da Categoria 6", "ImagemDoProduto 2", "33");

                IniWriteString("Nome dos Produtos da Categoria 6", "Nome do Produto 1", "Asa Frango 2kg");
                IniWriteString("Nome dos Produtos da Categoria 6", "Nome do Produto 2", "Sardinha Lata");
            }
            













        }


    }
}