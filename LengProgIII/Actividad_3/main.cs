using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad_3.Forms;

namespace Actividad_3
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menùToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bienvenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a Zapaterias UMI\nFeliz navidad!!");
        }

        private void quienesSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Quienes somos?\nSomos una empresa urgullosamente mexicana distribuidora de calzado com mas de 20 años de experiencia en el sector");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void misiònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.");
        }

        private void visiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum");
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();
;        }
    }
}
