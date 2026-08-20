using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class TallasDAL
    {
        public static int Insertar(Tallas entidad)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_InsertarTalla", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Talla_Producto", entidad.Talla_Producto ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Tallas> ObtenerTodos()
        {
            var lista = new List<Tallas>();
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerTodasTallas", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var t = new Tallas
                            {
                                id_tallas = reader["id_tallas"] != DBNull.Value ? Convert.ToInt32(reader["id_tallas"]) : 0,
                                Talla_Producto = reader["Talla_Producto"]?.ToString()
                            };
                            lista.Add(t);
                        }
                    }
                }
            }
            return lista;
        }

        public static Tallas ObtenerPorId(int id)
        {
            Tallas talla = null;
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerTallaPorId", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_tallas", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            talla = new Tallas
                            {
                                id_tallas = reader["id_tallas"] != DBNull.Value ? Convert.ToInt32(reader["id_tallas"]) : 0,
                                Talla_Producto = reader["Talla_Producto"]?.ToString()
                            };
                        }
                    }
                }
            }
            return talla;
        }
    }
}
