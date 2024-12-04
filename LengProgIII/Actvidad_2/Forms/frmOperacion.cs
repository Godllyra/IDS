using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actvidad_2.Clases;

namespace Actvidad_2.Forms
{
    public partial class frmOperacion : Form
    {
        Clases.clsOperacion operacion = new Clases.clsOperacion();
        public frmOperacion()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado;

            resultado = operacion.Multiplicar(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = resultado.ToString();
        }

        private void frmMulti_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int resultado = operacion.Sumar(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = resultado.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int resultado = operacion.Restar(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = resultado.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            float resultado = operacion.Dividir((int)float.Parse(textBox1.Text), (int)float.Parse(textBox2.Text));
            textBox3.Text = resultado.ToString();
        }
    }
}
