using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_DelegateMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //btnClick.Click += delegate (object sender, EventArgs e)
            btnClick.Click += delegate
            {
                MessageBox.Show("Olá, fui clicado");
            };
        }
    }
}
