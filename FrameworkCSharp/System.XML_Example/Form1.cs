using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace System.XML_Example
{
    public partial class Form1 : Form
    {
        string arquivo = @"D:\devmedia\NETFwk\XML\Agenda.xml";
        XmlDocument xmlDoc = new XmlDocument();

        public Form1()
        {
            InitializeComponent();

            if (!File.Exists(arquivo))
            {
                XmlNode nodeRoot = xmlDoc.CreateElement("Contatos");
                xmlDoc.AppendChild(nodeRoot);
                xmlDoc.Save(arquivo);
            }

            ReadAgenda();

        }
        //Schema
        private void button1_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(arquivo);
            
            XmlNode nodeNome = xmlDoc.CreateElement("Nome");
            XmlNode nodeTelefone = xmlDoc.CreateElement("Telefone");
            nodeNome.InnerText = txtNome.Text;
            nodeTelefone.InnerText = txtTelefone.Text;

            XmlNode nodeContato = xmlDoc.CreateElement("Contato");
            xmlDoc.SelectSingleNode("/Contatos").PrependChild(nodeContato);
                        
            xmlDoc.SelectSingleNode("/Contatos/Contato").AppendChild(nodeNome);
            xmlDoc.SelectSingleNode("/Contatos/Contato").AppendChild(nodeTelefone);
            xmlDoc.Save(arquivo);

            ReadAgenda();
            
        }

        private void ReadAgenda() {
            xmlDoc.Load(arquivo);
            lblAgenda.Text = "Contatos: \n\n";
            foreach (XmlNode node in xmlDoc.GetElementsByTagName("Contato")) {
                lblAgenda.Text += node.ChildNodes[0].InnerText + ": " + node.ChildNodes[1].InnerText + "\n";
            }
        
        }
    }
}
