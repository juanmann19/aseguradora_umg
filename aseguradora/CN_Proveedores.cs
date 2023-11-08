using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aseguradora
{
    public class CN_Proveedores
    {
        CD_Proveedores proveedor = new CD_Proveedores();
        public DataTable MostrarProv()
        {
            DataTable tabla = new DataTable();
            tabla = proveedor.Mostrar();
            return tabla;
        }

        public void InsertarProv(string nit, string nombre, string estado)
        {
            proveedor.Insertar(Convert.ToInt32(nit),nombre, Convert.ToInt32(estado));

        }

        public void EditarProv(string nit, string nombre, string estado)
        {
            proveedor.Editar(Convert.ToInt32(nit), nombre, Convert.ToInt32(estado));

        }

        public void EliminarProv(string nit)
        {
            proveedor.Eliminar(Convert.ToInt32(nit));
        }
    }


}
