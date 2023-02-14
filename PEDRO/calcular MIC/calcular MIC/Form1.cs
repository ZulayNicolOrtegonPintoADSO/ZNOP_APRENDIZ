using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcular_MIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtpeso = textBox1.Text;
            double peso = Double.Parse(txtpeso);

            string txtaltura = textBox2.Text;
            double altura = Double.Parse(txtaltura);

            double imc = peso / (altura * altura);

            MessageBox.Show("EL indice de masa corporal es: " + imc);
        }
    }
}
