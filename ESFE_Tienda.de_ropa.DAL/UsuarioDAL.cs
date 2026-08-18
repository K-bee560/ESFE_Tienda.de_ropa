using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class UsuarioDAL
    {
        private static string ConnectionString = "TuCadenaDeConexionAquí";

        public static int Insertar(Usuario entidad)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioNombre", entidad.UsuarioNombre);

                return cmd.ExecuteNonQuery();
            }
        }

        public static List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerTodosUsuarios", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Usuario u = new Usuario();
                    u.Id_Usuario = Convert.ToInt32(reader["Id_Usuario"]);
                    u.UsuarioNombre = reader["UsuarioNombre"].ToString();

                    lista.Add(u);
                }
            }
            return lista;
        }

        public static Usuario ObtenerPorId(int id)
        {
            Usuario u = null;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerUsuarioPorId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Usuario", id);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    u = new Usuario();
                    u.Id_Usuario = Convert.ToInt32(reader["Id_Usuario"]);
                    u.UsuarioNombre = reader["UsuarioNombre"].ToString();
                }
            }
            return u;
        }

        public static int Actualizar(Usuario entidad)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ActualizarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Usuario", entidad.Id_Usuario);
                cmd.Parameters.AddWithValue("@UsuarioNombre", entidad.UsuarioNombre);

                return cmd.ExecuteNonQuery();
            }
        }

        public static int Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_EliminarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Usuario", id);

                return cmd.ExecuteNonQuery();
            }
        }
    }
}
