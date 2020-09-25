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
        public string pasta_imagens1 = ""; public string pasta_imagens2 = "";
        public Image[] Imgs = new Image[7];
        public Image[] IconProdutos = new Image[60];
       


        public void Instaciar_Imagens()
        {
            pasta_imagens1 = Application.StartupPath + @"\images\icones\";
            pasta_imagens2 = Application.StartupPath + @"\images\icones\IconesFeitos\";
            Imgs[1] = Image.FromFile(pasta_imagens1 + "menu1.png"); Imgs[2] = Image.FromFile(pasta_imagens1 + "menu2.png"); Imgs[3] = Image.FromFile(pasta_imagens1 + "carrinho1.png"); Imgs[4] = Image.FromFile(pasta_imagens1 + "carrinho2.png"); Imgs[5] = Image.FromFile(pasta_imagens1 + "caixa1.png"); Imgs[6] = Image.FromFile(pasta_imagens1 + "caixa2.png");
            IconProdutos[1] = Image.FromFile(pasta_imagens2 + "batatafrita.png"); IconProdutos[2] = Image.FromFile(pasta_imagens2 + "bolo.png"); IconProdutos[3] = Image.FromFile(pasta_imagens2 + "cachorro quente.png"); IconProdutos[4] = Image.FromFile(pasta_imagens2 + "cafe.png"); IconProdutos[5] = Image.FromFile(pasta_imagens2 + "chocolate.png"); IconProdutos[6] = Image.FromFile(pasta_imagens2 + "franguinho.png"); IconProdutos[7] = Image.FromFile(pasta_imagens2 + "garfo e colher.png"); IconProdutos[8] = Image.FromFile(pasta_imagens2 + "hamburguer.png"); IconProdutos[9] = Image.FromFile(pasta_imagens2 + "lanche.png"); IconProdutos[10] = Image.FromFile(pasta_imagens2 + "pipoca.png"); IconProdutos[11] = Image.FromFile(pasta_imagens2 + "pirulito.png"); IconProdutos[12] = Image.FromFile(pasta_imagens2 + "pizza.png"); IconProdutos[13] = Image.FromFile(pasta_imagens2 + "refrigerante.png"); IconProdutos[14] = Image.FromFile(pasta_imagens2 + "refrigerante2.png"); IconProdutos[15] = Image.FromFile(pasta_imagens2 + "sorvete1.png"); IconProdutos[16] = Image.FromFile(pasta_imagens2 + "sorvete2.png"); IconProdutos[17] = Image.FromFile(pasta_imagens2 + "taco.png");
            //IconProdutos[41] = Image.FromFile(); //IconProdutos[42] = Image.FromFile(IniReadString("Caminho Dos Icones Personalizados", "Imagem 2", "")); IconProdutos[43] = Image.FromFile(IniReadString("Caminho Dos Icones Personalizados", "Imagem 3", "")); IconProdutos[44] = Image.FromFile(IniReadString("Caminho Dos Icones Personalizados", "Imagem 4", "")); IconProdutos[45] = Image.FromFile(IniReadString("Caminho Dos Icones Personalizados", "Imagem 5", "")); IconProdutos[46]= Image.FromFile(IniReadString("Caminho Dos Icones Personalizados", "Imagem 6", "")); IconProdutos[47] = Image.FromFile(IniReadString("Caminho Dos Icones Personalizados", "Imagem 7", "")); IconProdutos[48] = Image.FromFile(IniReadString("Caminho Dos Icones Personalizados", "Imagem 8", "")); IconProdutos[49] = Image.FromFile(IniReadString("Caminho Dos Icones Personalizados", "Imagem 9", "")); IconProdutos[50] = Image.FromFile(IniReadString("Caminho Dos Icones Personalizados", "Imagem 1", ""));
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
            string Chave = "chave";
            string MinhaString = "Minha String";
            //ID PRODUTOS
            for (int i = 0; i <= 8; i++)
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
            IniWriteString("Nome da Categoria dos Produtos", "NomeProduto 4", "Cafe");
            IniWriteString("Nome da Categoria dos Produtos", "NomeProduto 5", "Doces");
            IniWriteString("Nome da Categoria dos Produtos", "NomeProduto 6", "Carnes");
            IniWriteString("Nome da Categoria dos Produtos", "NomeProduto 7", "Almoços");
            IniWriteString("Nome da Categoria dos Produtos", "NomeProduto 8", "Lanches 2");

            //CARREGAR ICONES CUSTOM
            for (int i = 1; i <= 8; i++)
            {
                Chave = "IconeCustomizado " + i;
                MinhaString = "false";
                IniWriteString("Carregar Icones Customizados", Chave, MinhaString);
            }            

            //CAMINHO DAS IMAGENS PERSONALIZADAS
            for (int i = 1; i <= 10; i++)
            {
                Chave = "Imagem " + i;
                MinhaString = "C:/Windows/WinSxS/x86_netfx4 - aspnet_webadmin_images_b03f5f7f11d50a3a_4.0.15805.0_none_7ab11546ceb3decd/ASPdotNET_logo.jpg";
                IniWriteString("Caminho Dos Icones Personalizados", Chave, MinhaString);
            }           
        }

    }
}