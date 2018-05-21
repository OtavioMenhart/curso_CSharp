using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract
{
    public partial class FormMain : Form
    {
        //abstração
        private FormaEnvio _forma;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this._forma = Fabrica.CriarEnvio((TipoEnvio)cmbTipo.SelectedIndex);
            _forma.Enviar(txtAviso.Text);
        }
    }
}
