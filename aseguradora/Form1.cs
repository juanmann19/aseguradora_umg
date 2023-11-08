using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Xml.Serialization;

namespace aseguradora
{
    public partial class Form1 : Form
    {
        private bool Editar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void MostrarProveedores()
        {
            CN_Proveedores cN_Proveedores = new CN_Proveedores();
            dataGridView1.DataSource = cN_Proveedores.MostrarProv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NombreConexion"].ToString()))
                {
                    try
                    {
                        CN_Proveedores cN_Proveedores = new CN_Proveedores();
                        cN_Proveedores.InsertarProv(txtNIT.Text, txtNombre.Text, txtEstado.Text);
                        MessageBox.Show("Se inserto correctamente");
                        MostrarProveedores();
                        limpiarDatos();
                        //limpiar form
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            if (Editar == true)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NombreConexion"].ToString()))
                {
                    try
                    {
                        CN_Proveedores cN_Proveedores = new CN_Proveedores();
                        cN_Proveedores.EditarProv(txtNIT.Text, txtNombre.Text, txtEstado.Text);
                        MessageBox.Show("Se inserto correctamente");
                        Editar = false;
                        MostrarProveedores();
                        limpiarDatos();
                        //limpiar form
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNIT.Text = dataGridView1.CurrentRow.Cells["Nit"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtEstado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione una columna por favor.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string NIT = dataGridView1.CurrentRow.Cells["Nit"].Value.ToString();
                CN_Proveedores cN_Proveedores = new CN_Proveedores();
                cN_Proveedores.EliminarProv(NIT);
                MessageBox.Show("Eliminado correctamente");
                MostrarProveedores();
                limpiarDatos();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void limpiarDatos()
        {
            txtNIT.Text = "";
            txtNombre.Text = "";
            txtEstado.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}