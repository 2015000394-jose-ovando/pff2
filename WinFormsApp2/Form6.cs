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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double valor,valor2,valor3;

            if (!double.TryParse(textBox1.Text, out valor))
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
                return;
            }

            if (!double.TryParse(textBox3.Text, out valor2))
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
                return;
            }
            if (!double.TryParse(textBox4.Text, out valor3))
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
                return;
            }

            double resultado = 0.05 * (valor + valor2)*valor3;

            textBox2.Text = "el resultado es " + resultado + "m";
        }
    }
}
