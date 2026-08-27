
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class BitacoraDAL
    {
        private string conexion = "TU_CADENA_DE_CONEXION";

        // AGREGAR REGISTRO
        public bool Agregar(BitacoraEN bitacora)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = @"INSERT INTO Bitacora
                               (IDActividad, Accion, IDUsuario, FechaHora)
                               VALUES
                               (@IDActividad, @Accion, @IDUsuario, @FechaHora)";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@IDActividad", bitacora.IDActividad);
                    cmd.Parameters.AddWithValue("@Accion", bitacora.Accion);
                    cmd.Parameters.AddWithValue("@IDUsuario", bitacora.IDUsuario);
                    cmd.Parameters.AddWithValue("@FechaHora", bitacora.FechaHora);

                    cn.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // BUSCAR REGISTRO
        public BitacoraEN Buscar(int idActividad)
        {
            BitacoraEN bitacora = null;

            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = @"SELECT IDActividad,
                                      Accion,
                                      IDUsuario,
                                      FechaHora
                               FROM Bitacora
                               WHERE IDActividad = @IDActividad";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@IDActividad", idActividad);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            bitacora = new BitacoraEN();

                            bitacora.IDActividad =
                                Convert.ToInt32(dr["IDActividad"]);

                            bitacora.Accion =
                                dr["Accion"].ToString();

                            bitacora.IDUsuario =
                                Convert.ToInt32(dr["IDUsuario"]);

                            bitacora.FechaHora =
                                Convert.ToDateTime(dr["FechaHora"]);
                        }
                    }
                }
            }

            return bitacora;
        }

        // LISTAR REGISTROS
        public DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = @"SELECT IDActividad,
                                      Accion,
                                      IDUsuario,
                                      FechaHora
                               FROM Bitacora
                               ORDER BY FechaHora DESC";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                {
                    da.Fill(tabla);
                }
            }

            return tabla;
        }

        // ELIMINAR REGISTRO
        public bool Eliminar(int idActividad)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = @"DELETE FROM Bitacora
                               WHERE IDActividad = @IDActividad";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@IDActividad", idActividad);

                    cn.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
