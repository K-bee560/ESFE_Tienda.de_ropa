using ESFE_Tienda.de_ropa.EN;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class EstadoDAL
    {
        public static int Insertar(Estado entidad)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_InsertarEstado", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Ajusta los parámetros según las propiedades de tu entidad Estado
                    cmd.Parameters.AddWithValue("@Nombre", entidad.EstadoNombre ?? (object)DBNull.Value);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Estado> ObtenerTodos()
        {
            List<Estado> lista = new List<Estado>();
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerTodosEstados", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Estado estado = new Estado();
                            estado.id_estado = reader["Id"] != DBNull.Value ? Convert.ToInt32(reader["Id"]) : 0;
                            estado.EstadoNombre = reader["Nombre"]?.ToString();

                            lista.Add(estado);
                        }
                    }
                }
            }
            return lista;
        }

        public static Estado ObtenerPorId(int id)
        {
            Estado estado = null;
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerEstadoPorId", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            estado = new Estado();
                            estado.id_estado = reader["Id"] != DBNull.Value ? Convert.ToInt32(reader["Id"]) : 0;
                            estado.EstadoNombre = reader["Nombre"]?.ToString();
                        }
                    }
                }
            }
            return estado;
        }
    }
}