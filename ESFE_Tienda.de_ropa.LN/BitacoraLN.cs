
using ESFE_Tienda.de_ropa.DAL;
using System;
using System.Data;

namespace ESFE_Tienda.de.ropa.LN
{
    public class BitacoraLN
    {
        private BitacoraDAL dal = new BitacoraDAL();

        public DataTable ObtenerTodos()
        {
            return dal.ObtenerTodos();
        }

        public bool Eliminar(int IDActividad)
        {
            if (IDActividad > 0)
            {
                return dal.Eliminar(IDActividad);
            }

            return false;
        }
    }
}