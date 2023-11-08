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
    public class CD_Afiliados
    {
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NombreConexion"].ToString()))
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "MostrarAfiliados";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(dr);
                conn.Close();
                return tabla;
            }
        }
        public void InsertarAfiliado(int codigoAfiliado, string nombreCompleto, DateTime fechaInicioCobertura, DateTime fechaFinCobertura, decimal montoCobertura, int estado)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NombreConexion"].ToString()))
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "InsertarAfiliado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoAfiliado", codigoAfiliado);
                cmd.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                cmd.Parameters.AddWithValue("@FechaInicioCobertura", fechaInicioCobertura);
                cmd.Parameters.AddWithValue("@FechaFinCobertura", fechaFinCobertura);
                cmd.Parameters.AddWithValue("@MontoCobertura", montoCobertura);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
            }
        }

        public void EditarAfiliado(int codigoAfiliado, string nuevoNombreCompleto, DateTime nuevaFechaInicioCobertura, DateTime nuevaFechaFinCobertura, decimal nuevoMontoCobertura, int nuevoEstado)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NombreConexion"].ToString()))
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "EditarAfiliado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoAfiliado", codigoAfiliado);
                cmd.Parameters.AddWithValue("@NuevoNombreCompleto", nuevoNombreCompleto);
                cmd.Parameters.AddWithValue("@NuevaFechaInicioCobertura", nuevaFechaInicioCobertura);
                cmd.Parameters.AddWithValue("@NuevaFechaFinCobertura", nuevaFechaFinCobertura);
                cmd.Parameters.AddWithValue("@NuevoMontoCobertura", nuevoMontoCobertura);
                cmd.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
            }
        }

        public void EliminarAfiliado(int codigoAfiliado)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NombreConexion"].ToString()))
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "EliminarAfiliado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoAfiliado", codigoAfiliado);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
            }
        }
    }
}
