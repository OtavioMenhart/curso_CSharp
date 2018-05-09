using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;

namespace System.XML_Example
{
    public partial class Form3 : Form
    {

        Contatos contatos = null;

        public Form3()
        {
            InitializeComponent();
            contatos = SContatos.Read();
            
        }

        private void ReadAgenda()
        {
            lblContatos.Text = string.Empty;

            foreach (Contato c in contatos.Contato)
            {
                lblContatos.Text += "Nome: " + c.Nome + "\nTelefone: " + c.Telefone + "\n\n";
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ReadAgenda();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato c = new Contato();
            c.Id = this.NextId();
            c.Nome = txtNome.Text;
            c.Telefone = txtTelefone.Text;

            contatos.Contato.Add(c);

            SContatos.Write(contatos);

            ReadAgenda();

        }

        private int NextId() {
            int next = contatos.Contato[contatos.Contato.Count - 1].Id + 1;
            return next;
        }


    }
}