using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class PermisoDAL
    {
        public static int Insertar(Permiso entidad)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_InsertarPermiso", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nivel_permiso", entidad.Nivel_permiso ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Permiso> ObtenerTodos()
        {
            var lista = new List<Permiso>();
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerTodosPermisos", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var p = new Permiso
                            {
                                id_permiso = reader["id_permiso"] != DBNull.Value ? Convert.ToInt32(reader["id_permiso"]) : 0,
                                Nivel_permiso = reader["Nivel_permiso"]?.ToString()
                            };
                            lista.Add(p);
                        }
                    }
                }
            }
            return lista;
        }

        public static Permiso ObtenerPorId(int id)
        {
            Permiso permiso = null;
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerPermisoPorId", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_permiso", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            permiso = new Permiso
                            {
                                id_permiso = reader["id_permiso"] != DBNull.Value ? Convert.ToInt32(reader["id_permiso"]) : 0,
                                Nivel_permiso = reader["Nivel_permiso"]?.ToString()
                            };
                        }
                    }
                }
            }
            return permiso;
        }
    }
}
