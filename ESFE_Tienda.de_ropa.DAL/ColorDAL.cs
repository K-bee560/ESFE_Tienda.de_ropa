using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class ColorDAL
    {
        public static int Insertar(Color entidad)
        {
            using (IDbConnection conn = DBComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_InsertarColor", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Ajusta los parámetros según las propiedades de tu entidad Color
                    cmd.Parameters.AddWithValue("@Nombre", entidad.ColorNombre ?? (object)DBNull.Value);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Color> ObtenerTodos()
        {
            List<Color> lista = new List<Color>();
            using (IDbConnection conn = DBComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerTodosColores", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Color color = new Color();
                            color.Id_Color = reader["Id"] != DBNull.Value ? Convert.ToInt32(reader["Id"]) : 0;
                            color.ColorNombre = reader["Nombre"]?.ToString();

                            lista.Add(color);
                        }
                    }
                }
            }
            return lista;
        }

        public static Color ObtenerPorId(int id)
        {
            Color color = null;
            using (IDbConnection conn = DBComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerColorPorId", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            color = new Color();
                            color.Id_Color = reader["Id"] != DBNull.Value ? Convert.ToInt32(reader["Id"]) : 0;
                            color.ColorNombre = reader["Nombre"]?.ToString();
                        }
                    }
                }
            }
            return color;
        }
    }
}