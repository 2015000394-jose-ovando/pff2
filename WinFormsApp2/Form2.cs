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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double valor;

            if (!double.TryParse(textBox1.Text, out valor))
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
                return;
            }

            double resultado = valor * 0.0001;

            textBox2.Text = "el resultado es "+resultado+"metros";
        }
    }
    }

