using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class ProductoDAL
    {
        public static int Insertar(Productos entidad)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_InsertarProducto", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo_Product", entidad.Codigo_Product ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nombre_Product", entidad.Nombre_Product ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Precio", entidad.Precio);
                    cmd.Parameters.AddWithValue("@id_Tipo_Product", entidad.id_Tipo_Product);
                    cmd.Parameters.AddWithValue("@id_tallas", entidad.id_tallas);
                    cmd.Parameters.AddWithValue("@id_Tela", entidad.id_Tela);
                    cmd.Parameters.AddWithValue("@id_Color", entidad.id_Color);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Productos> ObtenerTodos()
        {
            var lista = new List<Productos>();
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerTodosProductos", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var p = new Productos
                            {
                                Codigo_Product = reader["Codigo_Product"]?.ToString(),
                                Nombre_Product = reader["Nombre_Product"]?.ToString(),
                                Precio = reader["Precio"] != DBNull.Value ? Convert.ToDecimal(reader["Precio"]) : 0m,
                                id_Tipo_Product = reader["id_Tipo_Product"] != DBNull.Value ? Convert.ToInt32(reader["id_Tipo_Product"]) : 0,
                                id_tallas = reader["id_tallas"] != DBNull.Value ? Convert.ToInt32(reader["id_tallas"]) : 0,
                                id_Tela = reader["id_Tela"] != DBNull.Value ? Convert.ToInt32(reader["id_Tela"]) : 0,
                                id_Color = reader["id_Color"] != DBNull.Value ? Convert.ToInt32(reader["id_Color"]) : 0
                            };
                            lista.Add(p);
                        }
                    }
                }
            }
            return lista;
        }

        public static Productos ObtenerPorCodigo(string codigo)
        {
            Productos producto = null;
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerProductoPorCodigo", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo_Product", codigo ?? (object)DBNull.Value);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            producto = new Productos
                            {
                                Codigo_Product = reader["Codigo_Product"]?.ToString(),
                                Nombre_Product = reader["Nombre_Product"]?.ToString(),
                                Precio = reader["Precio"] != DBNull.Value ? Convert.ToDecimal(reader["Precio"]) : 0m,
                                id_Tipo_Product = reader["id_Tipo_Product"] != DBNull.Value ? Convert.ToInt32(reader["id_Tipo_Product"]) : 0,
                                id_tallas = reader["id_tallas"] != DBNull.Value ? Convert.ToInt32(reader["id_tallas"]) : 0,
                                id_Tela = reader["id_Tela"] != DBNull.Value ? Convert.ToInt32(reader["id_Tela"]) : 0,
                                id_Color = reader["id_Color"] != DBNull.Value ? Convert.ToInt32(reader["id_Color"]) : 0
                            };
                        }
                    }
                }
            }
            return producto;
        }
    }
}
