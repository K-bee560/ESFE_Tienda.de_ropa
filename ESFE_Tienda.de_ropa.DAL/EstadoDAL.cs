using ESFE_Tienda.de_ropa.EN;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class EstadoDAL
    {
        private static string ConnectionString = "TuCadenaDeConexionAquí";

        public static int Insertar(Estado entidad)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertarEstado", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Ajusta los parámetros según las propiedades de tu entidad Estado
                cmd.Parameters.AddWithValue("@Nombre", entidad.EstadoNombre);

                return cmd.ExecuteNonQuery();
            }
        }

        public static List<Estado> ObtenerTodos()
        {
            List<Estado> lista = new List<Estado>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerTodosEstados", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Estado estado = new Estado();
                    estado.id_estado = Convert.ToInt32(reader["Id"]);
                    estado.EstadoNombre = reader["Nombre"].ToString();

                    lista.Add(estado);
                }
            }
            return lista;
        }

        public static Estado ObtenerPorId(int id)
        {
            Estado estado = null;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerEstadoPorId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    estado = new Estado();
                    estado.id_estado = Convert.ToInt32(reader["Id"]);
                    estado.EstadoNombre = reader["Nombre"].ToString();
                }
            }
            return estado;
        }
    }
}