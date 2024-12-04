using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actvidad_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saludoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saludoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmSaludo frmSaludo = new Forms.frmSaludo();
            frmSaludo.Show();

        }

        private void operacionesBàsicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmOperacion operaciones = new Forms.frmOperacion();
            operaciones.Show();
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmInformacionPersonal informacionPersonal = new Forms.frmInformacionPersonal();
            informacionPersonal.Show();
        }
    }
}
