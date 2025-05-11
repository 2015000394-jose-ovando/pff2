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
    public partial class Form9 : Form
    {
        public Form9()
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

            double resultado = valor / 10000;

            textBox2.Text = "el resultado es " + resultado + "m";
        }
    }
}
