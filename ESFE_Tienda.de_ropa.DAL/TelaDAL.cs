using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class TelaDAL
    {
        private static string ConnectionString = "TuCadenaDeConexionAquí";

        public static int Insertar(Tela entidad)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertarTela", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Tipo_de_tela", entidad.Tipo_de_tela ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery();
            }
        }

        public static List<Tela> ObtenerTodos()
        {
            List<Tela> lista = new List<Tela>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerTodasTelas", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tela tela = new Tela();
                        tela.Id_Tela = reader["Id_Tela"] != DBNull.Value ? Convert.ToInt32(reader["Id_Tela"]) : 0;
                        tela.Tipo_de_tela = reader["Tipo_de_tela"] != DBNull.Value ? reader["Tipo_de_tela"].ToString() : null;

                        lista.Add(tela);
                    }
                }
            }
            return lista;
        }

        public static Tela ObtenerPorId(int id)
        {
            Tela tela = null;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerTelaPorId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Tela", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tela = new Tela();
                        tela.Id_Tela = reader["Id_Tela"] != DBNull.Value ? Convert.ToInt32(reader["Id_Tela"]) : 0;
                        tela.Tipo_de_tela = reader["Tipo_de_tela"] != DBNull.Value ? reader["Tipo_de_tela"].ToString() : null;
                    }
                }
            }
            return tela;
        }

        public static int Actualizar(Tela entidad)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ActualizarTela", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Tela", entidad.Id_Tela);
                cmd.Parameters.AddWithValue("@Tipo_de_tela", entidad.Tipo_de_tela ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery();
            }
        }

        public static int Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_EliminarTela", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Tela", id);

                return cmd.ExecuteNonQuery();
            }
        }
    }
}
