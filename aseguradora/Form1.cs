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
        private bool EditarAfiliado = false;
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            MostrarProveedores();
        }

        private void button1_Click(object sender, EventArgs e)//boton insertar proveedor
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
            if (Editar == true)//Actualiza los registros una vez puestos en los txtbox mediante el boton editar
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

        private void button2_Click(object sender, EventArgs e)//boton editar
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //retorna los valores seleccionados del datagrid a los txtbox para edicion
                Editar = true;
                txtNIT.Text = dataGridView1.CurrentRow.Cells["Nit"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtEstado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor.");
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


        //Afiliados

        private void btn_mostrarAfiliados_Click(object sender, EventArgs e)
        {
            CN_Afiliados cN_Afiliados = new CN_Afiliados();
            dataGridView1.DataSource = cN_Afiliados.MostrarAfiliados();
        }

        private void MostrarAfiliados()
        {
            CN_Afiliados cN_Afiliados = new CN_Afiliados();
            dataGridView1.DataSource = cN_Afiliados.MostrarAfiliados();
        }
        private void LimpiarDatosAfiliado()
        {
            txtCodAfiliado.Text = "";
            txtnombreafiliado.Text = "";
            txtiniciocobertura.Value = DateTime.Now;
            txtfincobertura.Value = DateTime.Now;
            txtmontocobertura.Text = "";
            txtestadoafiliado.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)//insertar afiliados
        {
            if (EditarAfiliado == false)
            {
                try
                {
                    CN_Afiliados cN_Afiliados = new CN_Afiliados();
                    cN_Afiliados.InsertarAfiliado(Convert.ToInt32(txtCodAfiliado.Text), txtnombreafiliado.Text, txtiniciocobertura.Value, txtfincobertura.Value, Convert.ToDecimal(txtmontocobertura.Text), Convert.ToInt32(txtestadoafiliado.Text));
                    MessageBox.Show("Afiliado insertado correctamente");
                    MostrarAfiliados();
                    LimpiarDatosAfiliado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar afiliado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (EditarAfiliado == true)
            {
                try
                {
                    CN_Afiliados cN_Afiliados = new CN_Afiliados();
                    cN_Afiliados.EditarAfiliado(Convert.ToInt32(txtCodAfiliado.Text), txtnombreafiliado.Text, txtiniciocobertura.Value, txtfincobertura.Value, Convert.ToDecimal(txtmontocobertura.Text), Convert.ToInt32(txtestadoafiliado.Text));
                    MessageBox.Show("Afiliado actualizado correctamente");
                    EditarAfiliado = false;
                    MostrarAfiliados();
                    LimpiarDatosAfiliado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar afiliado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarAfiliado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Retornar los valores seleccionados del DataGridView a los TextBox para edición
                EditarAfiliado = true;
                txtCodAfiliado.Text = dataGridView1.CurrentRow.Cells["Codigo_Afiliado"].Value.ToString();
                txtnombreafiliado.Text = dataGridView1.CurrentRow.Cells["Nombre_Completo"].Value.ToString();
                txtiniciocobertura.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["Fecha_Inicio_Cobertura"].Value.ToString());
                txtfincobertura.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["Fecha_Fin_Cobertura"].Value.ToString());
                txtmontocobertura.Text = dataGridView1.CurrentRow.Cells["Monto_Cobertura"].Value.ToString();
                txtestadoafiliado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor.");
            }
        }

        private void btnEliminarAfiliado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int codigoAfiliado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Codigo_Afiliado"].Value);
                CN_Afiliados cN_Afiliados = new CN_Afiliados();
                cN_Afiliados.EliminarAfiliado(codigoAfiliado);
                MessageBox.Show("Afiliado eliminado correctamente");
                MostrarAfiliados();
                LimpiarDatosAfiliado();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor.");
            }
        }
    }
}