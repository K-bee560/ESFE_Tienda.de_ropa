using ESFE_Tienda.de_ropa.EN;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ESFE_Tienda.de_ropa.DAL
{
    // Implementación de acceso a datos para Bitacora
    public static class BitacoraDAL
    {
        private static string ConnectionString = "TuCadenaDeConexionAquí";

        public static int Insertar(Bitacora entidad)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertarBitacora", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Accion", entidad.Accion);
                cmd.Parameters.AddWithValue("@Id_Usuario", entidad.Id_Usuario);
                cmd.Parameters.AddWithValue("@Fecha_y_hora", entidad.Fecha_y_hora);

                return cmd.ExecuteNonQuery();
            }
        }

        public static List<Bitacora> ObtenerTodos()
        {
            var lista = new List<Bitacora>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerTodasBitacoras", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var b = new Bitacora
                        {
                            id_actividad = reader["id_actividad"] != DBNull.Value ? Convert.ToInt32(reader["id_actividad"]) : 0,
                            Accion = reader["Accion"]?.ToString(),
                            Id_Usuario = reader["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(reader["Id_Usuario"]) : 0,
                            Fecha_y_hora = reader["Fecha_y_hora"] != DBNull.Value ? Convert.ToDateTime(reader["Fecha_y_hora"]) : DateTime.MinValue
                        };
                        lista.Add(b);
                    }
                }
            }
            return lista;
        }

        public static List<Bitacora> ObtenerPorUsuario(int idUsuario)
        {
            var lista = new List<Bitacora>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerBitacoraPorUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var b = new Bitacora
                        {
                            id_actividad = reader["id_actividad"] != DBNull.Value ? Convert.ToInt32(reader["id_actividad"]) : 0,
                            Accion = reader["Accion"]?.ToString(),
                            Id_Usuario = reader["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(reader["Id_Usuario"]) : 0,
                            Fecha_y_hora = reader["Fecha_y_hora"] != DBNull.Value ? Convert.ToDateTime(reader["Fecha_y_hora"]) : DateTime.MinValue
                        };
                        lista.Add(b);
                    }
                }
            }
            return lista;
        }
    }
}

namespace ESFE_Tienda.de_ropa.LN
{
    public class BitacoraLN
    {
        public int Insertar(Bitacora entidad)
        {
            return ESFE_Tienda.de_ropa.DAL.BitacoraDAL.Insertar(entidad);
        }

        public List<Bitacora> ObtenerTodos()
        {
            return ESFE_Tienda.de_ropa.DAL.BitacoraDAL.ObtenerTodos();
        }

        public List<Bitacora> ObtenerPorUsuario(int idUsuario)
        {
            return ESFE_Tienda.de_ropa.DAL.BitacoraDAL.ObtenerPorUsuario(idUsuario);
        }
    }
}
