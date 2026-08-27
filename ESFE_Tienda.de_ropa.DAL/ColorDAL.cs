using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class ColorDAL
    {
        // =====================================================
        // AGREGAR COLOR
        // =====================================================

        public bool AgregarColor(string nombre)
        {
            try
            {
                SqlParameter parametro =
                    new SqlParameter("@Nombre", nombre);

                int resultado = BDComun.ExecuteNonQuery(
                    "sp_AgregarColor",
                    parametro
                );

                return resultado > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }


        // =====================================================
        // BUSCAR COLOR
        // =====================================================

        public DataTable BuscarColor(string busqueda)
        {
            SqlParameter parametro =
                new SqlParameter("@Busqueda", busqueda);

            return BDComun.ExecuteDataTable(
                "sp_BuscarColor",
                parametro
            );
        }


        // =====================================================
        // ELIMINAR COLOR
        // =====================================================

        public bool EliminarColor(string busqueda)
        {
            try
            {
                SqlParameter parametro =
                    new SqlParameter("@Busqueda", busqueda);

                int resultado = BDComun.ExecuteNonQuery(
                    "sp_EliminarColor",
                    parametro
                );

                return resultado > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}