using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class UsuarioDAL
    {
        public static int Insertar(Usuario entidad)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_InsertarUsuario", conn as SqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioNombre", entidad.UsuarioNombre ?? (object)DBNull.Value);
                return cmd.ExecuteNonQuery();
            }
        }

        public static List<Usuario> ObtenerTodos()
        {
            var lista = new List<Usuario>();
            using (IDbConnection conn = BDComun.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerTodosUsuarios", conn as SqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var u = new Usuario
                        {
                            Id_Usuario = reader["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(reader["Id_Usuario"]) : 0,
                            UsuarioNombre = reader["UsuarioNombre"] != DBNull.Value ? reader["UsuarioNombre"].ToString() : null
                        };
                        lista.Add(u);
                    }
                }
            }
            return lista;
        }

        public static Usuario ObtenerPorId(int id)
        {
            Usuario u = null;
            using (IDbConnection conn = BDComun.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerUsuarioPorId", conn as SqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Usuario", id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        u = new Usuario
                        {
                            Id_Usuario = reader["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(reader["Id_Usuario"]) : 0,
                            UsuarioNombre = reader["UsuarioNombre"] != DBNull.Value ? reader["UsuarioNombre"].ToString() : null
                        };
                    }
                }
            }
            return u;
        }

        public static int Actualizar(Usuario entidad)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ActualizarUsuario", conn as SqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Usuario", entidad.Id_Usuario);
                cmd.Parameters.AddWithValue("@UsuarioNombre", entidad.UsuarioNombre ?? (object)DBNull.Value);
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Eliminar(int id)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_EliminarUsuario", conn as SqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Usuario", id);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
