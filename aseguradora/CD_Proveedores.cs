using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace aseguradora
{
    public class CD_Proveedores
    {
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NombreConexion"].ToString()))
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "MostrarProveedores";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(dr);
                conn.Close();
                return tabla;
            }
        }
        public void Insertar(int nit, string nombre, int estado)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NombreConexion"].ToString()))
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "InsertarProveedor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NIT", nit);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();

            }
            
        }
        public void Editar(int nit, string nombre, int estado)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NombreConexion"].ToString()))
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "EditarProveedor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NIT", nit);
                cmd.Parameters.AddWithValue("@NuevoNombre", nombre);
                cmd.Parameters.AddWithValue("@NuevoEstado", estado);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();

            }
        }

        public void Eliminar(int nit)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NombreConexion"].ToString()))
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "EliminarProveedor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NIT", nit);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();

            }
        }
    }
}
