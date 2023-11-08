using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aseguradora
{
    public class CN_Afiliados
    {
        CD_Afiliados afiliado = new CD_Afiliados();

        public DataTable MostrarAfiliados()
        {
            DataTable tabla = new DataTable();
            tabla = afiliado.Mostrar();
            return tabla;
        }

        public void InsertarAfiliado(int codigoAfiliado, string nombreCompleto, DateTime fechaInicioCobertura, DateTime fechaFinCobertura, decimal montoCobertura, int estado)
        {
            afiliado.InsertarAfiliado(codigoAfiliado, nombreCompleto, fechaInicioCobertura, fechaFinCobertura, montoCobertura, estado);
        }

        public void EditarAfiliado(int codigoAfiliado, string nuevoNombreCompleto, DateTime nuevaFechaInicioCobertura, DateTime nuevaFechaFinCobertura, decimal nuevoMontoCobertura, int nuevoEstado)
        {
            afiliado.EditarAfiliado(codigoAfiliado, nuevoNombreCompleto, nuevaFechaInicioCobertura, nuevaFechaFinCobertura, nuevoMontoCobertura, nuevoEstado);
        }

        public void EliminarAfiliado(int codigoAfiliado)
        {
            afiliado.EliminarAfiliado(codigoAfiliado);
        }


    }


}
