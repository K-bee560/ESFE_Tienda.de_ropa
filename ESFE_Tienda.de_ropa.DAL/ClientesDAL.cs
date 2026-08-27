using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class ClienteDAL
    {
        // =====================================================
        // AGREGAR CLIENTE
        // =====================================================

        public bool AgregarCliente(
            string nombre,
            string dui,
            string telefono,
            string correo,
            int idRol,
            int idPermiso,
            int idEstado)
        {
            try
            {
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nombre", nombre),
                    new SqlParameter("@DUI", dui),
                    new SqlParameter("@Telefono", telefono),
                    new SqlParameter("@Correo", correo),
                    new SqlParameter("@IDRol", idRol),
                    new SqlParameter("@IDPermiso", idPermiso),
                    new SqlParameter("@IDEstado", idEstado)
                };

                int resultado = BDComun.ExecuteNonQuery(
                    "sp_AgregarCliente",
                    parametros
                );

                return resultado > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }


        // =====================================================
        // BUSCAR CLIENTE
        // =====================================================

        public DataTable BuscarCliente(string busqueda)
        {
            SqlParameter parametro =
                new SqlParameter("@Busqueda", busqueda);

            return BDComun.ExecuteDataTable(
                "sp_BuscarCliente",
                parametro
            );
        }


        // =====================================================
        // MOSTRAR CLIENTES
        // =====================================================

        public DataTable MostrarClientes()
        {
            return BDComun.ExecuteDataTable(
                "sp_MostrarClientes"
            );
        }


        // =====================================================
        // ELIMINAR CLIENTE
        // =====================================================

        public bool EliminarCliente(string busqueda)
        {
            try
            {
                SqlParameter parametro =
                    new SqlParameter("@Busqueda", busqueda);

                int resultado = BDComun.ExecuteNonQuery(
                    "sp_EliminarCliente",
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