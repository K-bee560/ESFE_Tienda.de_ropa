using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class RolesDAL
    {
        public static int Insertar(Roles entidad)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_InsertarRol", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Descripcion_Rol", entidad.Descripcion_Rol ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Roles> ObtenerTodos()
        {
            var lista = new List<Roles>();
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerTodosRoles", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var r = new Roles
                            {
                                id_rol = reader["id_rol"] != DBNull.Value ? Convert.ToInt32(reader["id_rol"]) : 0,
                                Descripcion_Rol = reader["Descripcion_Rol"]?.ToString()
                            };
                            lista.Add(r);
                        }
                    }
                }
            }
            return lista;
        }

        public static Roles ObtenerPorId(int id)
        {
            Roles rol = null;
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerRolPorId", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_rol", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rol = new Roles
                            {
                                id_rol = reader["id_rol"] != DBNull.Value ? Convert.ToInt32(reader["id_rol"]) : 0,
                                Descripcion_Rol = reader["Descripcion_Rol"]?.ToString()
                            };
                        }
                    }
                }
            }
            return rol;
        }
    }
}
