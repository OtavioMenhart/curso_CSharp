using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnInvocarWebService_Click(object sender, EventArgs e)
        {
            var prx = new Prx.WebService();
            txtResult.Text = prx.Somar(10, 20).ToString();
            dataGridView1.DataSource = prx.getClientes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
