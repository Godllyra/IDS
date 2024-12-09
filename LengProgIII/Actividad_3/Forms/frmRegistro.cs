using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_3.Forms
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnct = new SqlConnection("Data Source=DESKTOP-GF9TVV9\\SQLEXPRESS;Initial Catalog=Zapateria_Umi;Integrated Security=True;Encrypt=False"))
            {
                if (txtCurp.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtBirthDay.Text == "" || txtNumero.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Todos los campos son necesarios");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Clientes VALUES ('" + txtCurp.Text + "', '" + txtNumero.Text + "', '" + txtApellido.Text + "', '" + txtBirthDay.Text + "', '" + txtNumero.Text + "', '" + txtEmail.Text + "');", cnct);
                    cmd.CommandType = CommandType.Text;
                    cnct.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro completado");
                    txtCurp.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtBirthDay.Clear();
                    txtNumero.Clear();
                    txtEmail.Clear();
                }
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnct = new SqlConnection("Data Source=DESKTOP-GF9TVV9\\SQLEXPRESS;Initial Catalog=Zapateria_Umi;Integrated Security=True;Encrypt=False"))
            {
                if (txtCurp.Text == "")
                {
                    MessageBox.Show("Ingresa la curp del cliente");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Clientes WHERE curp = '" + txtCurp.Text + "';", cnct);
                    cmd.CommandType = CommandType.Text;
                    cnct.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro eliminado");
                    txtCurp.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtBirthDay.Clear();
                    txtNumero.Clear();
                    txtEmail.Clear();
                }
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnct = new SqlConnection("Data Source=DESKTOP-GF9TVV9\\SQLEXPRESS;Initial Catalog=Zapateria_Umi;Integrated Security=True;Encrypt=False"))
            {
                if (txtCurp.Text == "")
                {
                    MessageBox.Show("Ingresa la curp del cliente");
                }
                else
                {
                    if (txtNombre.Text == "" || txtApellido.Text == "" || txtBirthDay.Text == "" || txtNumero.Text == "" || txtEmail.Text == "")
                    {
                        MessageBox.Show("Todos los campos son obligatorios");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Clientes SET nombres = '" + txtNombre.Text + "', apellidos = '" + txtApellido.Text + "', fecha_nacimiento = '" + txtBirthDay.Text + "', telefono = '" + txtNumero.Text + "', email = '" + txtEmail.Text + "' WHERE curp = '" + txtCurp.Text + "';", cnct);
                        cmd.CommandType = CommandType.Text;
                        cnct.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro modificado");
                        txtCurp.Clear();
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtBirthDay.Clear();
                        txtNumero.Clear();
                        txtEmail.Clear();
                    }
                }
                
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DataTable db = new DataTable();
            using (SqlConnection cnct = new SqlConnection("Data Source=DESKTOP-GF9TVV9\\SQLEXPRESS;Initial Catalog=Zapateria_Umi;Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Clientes", cnct);
                data.SelectCommand.CommandType = CommandType.Text;
                cnct.Open();
                data.Fill(db);
                dgvDB.DataSource = db;
            }
        }
    }
}
