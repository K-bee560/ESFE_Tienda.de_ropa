using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class ColorDAL
    {
        private static string ConnectionString = "TuCadenaDeConexionAquí";

        public static int Insertar(Color entidad)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertarColor", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Ajusta los parámetros según las propiedades de tu entidad Color
                cmd.Parameters.AddWithValue("@Nombre", entidad.ColorNombre);

                return cmd.ExecuteNonQuery();
            }
        }

        public static List<Color> ObtenerTodos()
        {
            List<Color> lista = new List<Color>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerTodosColores", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Color color = new Color();
                    color.Id_Color = Convert.ToInt32(reader["Id"]);
                    color.ColorNombre = reader["Nombre"].ToString();

                    lista.Add(color);
                }
            }
            return lista;
        }

        public static Color ObtenerPorId(int id)
        {
            Color color = null;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerColorPorId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    color = new Color();
                    color.Id_Color = Convert.ToInt32(reader["Id"]);
                    color.ColorNombre = reader["Nombre"].ToString();
                }
            }
            return color;
        }
    }
}