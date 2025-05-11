using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double valor;

            if (!double.TryParse(textBox1.Text, out valor))
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
                return;
            }

            double resultado = valor * 6.452;

            textBox2.Text = "el resultado es " + resultado + "cm";
        }
    }
}
