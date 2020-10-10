using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.IO;
using System.Xml;

namespace Sistema_Bar
{
    class XmlFile
    {
        public string fileName { set; get; }

        // Define section e key default para os casos em que não se define
        public string section = Path.GetFileNameWithoutExtension(Application.ExecutablePath);


        // Declara dll para trabalhar com arquivos ini
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
                 string key, string def, StringBuilder retVal,
            int size, string filePath);

        #region Construtor

        /// <summary>
        /// Metodo Construtor onde se informa o Path (Caminho) e o Nome do Arquivo
        /// </summary>
        /// <param name="path">Path (Caminho) onde sera gravado o arquivo</param>
        /// <param name="fileName">Nome do arquivo</param>
        /// <example>Inifile("C:\dados\exemplos","Configuracoes")</example>
        public XmlFile(string path, string fileName)
        {
            if (path.Substring(path.Length - 1, 1) != @"\\")
            {
                path += "\\";
            }
            this.fileName = path + corrigeFileName(fileName);
        }

        /// <summary>
        /// Metodo Construtor onde se informa o Nome do Arquivo com ou sem Path (Caminho)
        /// Se o Path (Caminho) não for informado será definido o Path (Caminho) da aplicação
        /// </summary>
        /// <param name="fileName">[Path]+Nome do arquivo</param>
        /// <example>Inifile("Configuracoes") , Inifile("c:\dados\exemplos\Configuracoes")</example>
        public XmlFile(string fileName)
        {
            if (fileName.IndexOf("\\") > -1)
            {
                this.fileName = fileName;
            }
            else
            {
                String strAppDir = Application.StartupPath;
                this.fileName = strAppDir + "\\" + corrigeFileName(fileName);
            }
        }

        /// <summary>
        /// Metodo Construtor sem parametros
        /// O Path (Caminho) do arquivo será definido como o path (Caminho) da aplicacao
        /// O Nome do arquivo sera definido com o mesmo nome da aplicacao com a extensao '.ini'
        /// </summary>
        /// <example>Inifile()</example>
        public XmlFile()
        {
            String strAppDir = Application.ExecutablePath;
            strAppDir = strAppDir.ToLower().Replace(".exe", ".xml");
            this.fileName = strAppDir;
        }

        #region outros metodos

        /// <summary>
        /// Corrige o nome do arquivo caso seja informado sem a extensão
        /// </summary>
        /// <param name="fileName">string com o Nome do arquivo</param>
        /// <returns>string com o Nome do arquivo corrigido</returns>
        private string corrigeFileName(string fileName)
        {
            fileName = fileName.ToLower();
            if (fileName.IndexOf(".xml") == -1)
            {
                fileName += ".xml";
            }
            return fileName;
        }


        #region Metodos 

        /// <summary>
        /// Grava string no arquivo ini
        /// </summary>
        /// <PARAM name="Section">Informe o nome sessão</PARAM>
        /// <PARAM name="Key">Informe o nome da chave</PARAM>
        /// <PARAM name="Valor">Informe a string a ser gravada</PARAM>
        public void IniWriteString(string Section, string Key, string Valor)
        {
            WritePrivateProfileString(Section, Key, Valor, this.fileName);
        }

        /// <summary>
        /// Grava string no arquivo ini
        /// </summary>
        /// <PARAM name="Key">Informe o nome da chave</PARAM>
        /// <PARAM name="Valor">Informe a string a ser gravada</PARAM>
        public void GerarXml()
        {
            XmlWriter xmlWriter = XmlWriter.Create(this.section + ".Xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Produtos");

            /* xmlWriter.WriteStartElement("produto");
             xmlWriter.WriteElementString("Código","00004550401");
             xmlWriter.WriteElementString("Descrição","Biscoito sei la cara");
             xmlWriter.WriteElementString("Quant");
             xmlWriter.WriteElementString("Valor Unit.");
             xmlWriter.WriteElementString("Total");
             xmlWriter.WriteEndElement(); */

              xmlWriter.WriteStartElement("prod");
              xmlWriter.WriteStartElement("Código");
              xmlWriter.WriteValue(45584477174741);
              xmlWriter.WriteEndElement();
              xmlWriter.WriteStartElement("Descrição");
              xmlWriter.WriteString("Biscoito bolado de 1 real ");
              xmlWriter.WriteEndElement();
              xmlWriter.WriteStartElement("Quant");
              xmlWriter.WriteValue(5);
              xmlWriter.WriteEndElement();
              xmlWriter.WriteStartElement("ValorUnit");
              xmlWriter.WriteValue(0.99);
              xmlWriter.WriteEndElement();
              xmlWriter.WriteStartElement("Total");
              xmlWriter.WriteValue(5);
              xmlWriter.WriteEndElement();
              xmlWriter.WriteEndElement();


              xmlWriter.WriteStartElement("prod");
              xmlWriter.WriteStartElement("Código");
              xmlWriter.WriteValue(457674577174);
              xmlWriter.WriteEndElement();
              xmlWriter.WriteStartElement("Descrição");
              xmlWriter.WriteString("Biscoito Trakinas ");
              xmlWriter.WriteEndElement();
              xmlWriter.WriteStartElement("Quant");
              xmlWriter.WriteValue(2);
              xmlWriter.WriteEndElement();
              xmlWriter.WriteStartElement("ValorUnit");
              xmlWriter.WriteValue(2.50);
              xmlWriter.WriteEndElement();
              xmlWriter.WriteStartElement("Total");
              xmlWriter.WriteValue(5);
              xmlWriter.WriteEndElement();
              xmlWriter.WriteEndElement();




            xmlWriter.WriteEndElement();
            /* xmlWriter.WriteStartElement("produto");
             xmlWriter.WriteString("");
             xmlWriter.WriteString("Biscoito de 1 conto brabo ");
             xmlWriter.WriteString("");
             xmlWriter.WriteString("");
             xmlWriter.WriteString("");
             xmlWriter.WriteEndElement(); */

            /* xmlWriter.WriteStartElement("user");
             xmlWriter.WriteAttributeString("age", "39");
             xmlWriter.WriteString("Jane Doe"); */

            xmlWriter.Close();

            //WritePrivateProfileString(this.section, Key, Valor, this.fileName);
        }

        public void GerarXml2()
        {
            XmlWriter xmlWriter = XmlWriter.Create(this.section + ".Xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Produtos");

            /* xmlWriter.WriteStartElement("produto");
             xmlWriter.WriteElementString("Código","00004550401");
             xmlWriter.WriteElementString("Descrição","Biscoito sei la cara");
             xmlWriter.WriteElementString("Quant");
             xmlWriter.WriteElementString("Valor Unit.");
             xmlWriter.WriteElementString("Total");
             xmlWriter.WriteEndElement(); */

            xmlWriter.WriteStartElement("prod");
            xmlWriter.WriteStartElement("Código");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Descrição");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Quant");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("ValorUnit");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Total");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();


            xmlWriter.WriteEndElement();
            /* xmlWriter.WriteStartElement("produto");
             xmlWriter.WriteString("");
             xmlWriter.WriteString("Biscoito de 1 conto brabo ");
             xmlWriter.WriteString("");
             xmlWriter.WriteString("");
             xmlWriter.WriteString("");
             xmlWriter.WriteEndElement(); */

            /* xmlWriter.WriteStartElement("user");
             xmlWriter.WriteAttributeString("age", "39");
             xmlWriter.WriteString("Jane Doe"); */

            xmlWriter.Close();

            //WritePrivateProfileString(this.section, Key, Valor, this.fileName);
        }
       
        #endregion

        #endregion

    }
}
#endregion