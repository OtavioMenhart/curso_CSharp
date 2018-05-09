using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class FormCadastroClientes : Form
    {
        public FormCadastroClientes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //cria dataset q pode ser uma colecao de tabelas
            DataSet dataset = new DataSet("Dados");
            DataTable tabela = CriarEstruturaTabela();

            //adiciona tabela ao dataset
            dataset.Tables.Add(tabela);
            DataRow registro = CriaRegistro(tabela);
            tabela.Rows.Add(registro);
            //salvando o cliente em um arquivo xml
            dataset.WriteXml(@".\cliente_" + txtCodigo.Text + ".xml");
            MessageBox.Show("Cadastrado com sucesso");
            Limpar();
        }

        private DataRow CriaRegistro(DataTable tabela)
        {
            //adicionar os registros na tabela
            //cria os registros
            DataRow registro = tabela.NewRow();
            registro["Codigo"] = txtCodigo.Text;
            registro["Nome"] = txtNome.Text;
            registro["Telefone"] = txtTelefone.Text;
            registro["Email"] = txtEmail.Text;
            return registro;
        }

        private static DataTable CriarEstruturaTabela()
        {
            //cria a tabela
            DataTable tabela = new DataTable("Clientes");
            //crio colunas
            tabela.Columns.Add(new DataColumn("Codigo"));
            tabela.Columns.Add(new DataColumn("Nome"));
            tabela.Columns.Add(new DataColumn("Telefone"));
            tabela.Columns.Add(new DataColumn("Email"));
            return tabela;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //cria dataset
            DataSet dataset = new DataSet();
            //le o dataset do disco
            dataset.ReadXml(@".\cliente_" + txtCodigo.Text + ".xml");
            //tabela é o primeiro datatable da coleção
            DataTable tabela = dataset.Tables[0];
            //considero o primeiro registro da tabela
            DataRow registro = tabela.Rows[0];
            MostrarDadosTela(registro);
        }

        private void MostrarDadosTela(DataRow registro)
        {
            //mostro dados
            txtNome.Text = registro["Nome"].ToString();
            txtTelefone.Text = registro["Telefone"].ToString();
            txtEmail.Text = registro["Email"].ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            //percorrer todos os controles de tela para limpar
            foreach (Control txt in Controls)
            {
                if (txt is TextBox)
                {
                    (txt as TextBox).Clear();
                }
            }
        }
    }
}
