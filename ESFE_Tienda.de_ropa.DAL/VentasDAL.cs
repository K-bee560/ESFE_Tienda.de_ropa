using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class VentasDAL
    {
        public static int Insertar(Ventas entidad)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_InsertarVenta", conn as SqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_de_Venta", entidad.Codigo_de_Venta ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Fecha_y_hora", entidad.Fecha_y_hora);
                cmd.Parameters.AddWithValue("@Cantidad_de_prod", entidad.Cantidad_de_prod);
                cmd.Parameters.AddWithValue("@id_Tipo_Produc", entidad.id_Tipo_Produc);
                cmd.Parameters.AddWithValue("@id_cliente", entidad.id_cliente);
                return cmd.ExecuteNonQuery();
            }
        }

        public static List<Ventas> ObtenerTodos()
        {
            var lista = new List<Ventas>();
            using (IDbConnection conn = BDComun.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerTodasVentas", conn as SqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var v = new Ventas
                        {
                            Codigo_de_Venta = reader["Codigo_de_Venta"] != DBNull.Value ? reader["Codigo_de_Venta"].ToString() : null,
                            Fecha_y_hora = reader["Fecha_y_hora"] != DBNull.Value ? Convert.ToDateTime(reader["Fecha_y_hora"]) : DateTime.MinValue,
                            Cantidad_de_prod = reader["Cantidad_de_prod"] != DBNull.Value ? Convert.ToInt32(reader["Cantidad_de_prod"]) : 0,
                            id_Tipo_Produc = reader["id_Tipo_Produc"] != DBNull.Value ? Convert.ToInt32(reader["id_Tipo_Produc"]) : 0,
                            id_cliente = reader["id_cliente"] != DBNull.Value ? Convert.ToInt32(reader["id_cliente"]) : 0
                        };
                        lista.Add(v);
                    }
                }
            }
            return lista;
        }

        public static Ventas ObtenerPorCodigo(string codigo)
        {
            Ventas v = null;
            using (IDbConnection conn = BDComun.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerVentaPorCodigo", conn as SqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_de_Venta", codigo ?? (object)DBNull.Value);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        v = new Ventas
                        {
                            Codigo_de_Venta = reader["Codigo_de_Venta"] != DBNull.Value ? reader["Codigo_de_Venta"].ToString() : null,
                            Fecha_y_hora = reader["Fecha_y_hora"] != DBNull.Value ? Convert.ToDateTime(reader["Fecha_y_hora"]) : DateTime.MinValue,
                            Cantidad_de_prod = reader["Cantidad_de_prod"] != DBNull.Value ? Convert.ToInt32(reader["Cantidad_de_prod"]) : 0,
                            id_Tipo_Produc = reader["id_Tipo_Produc"] != DBNull.Value ? Convert.ToInt32(reader["id_Tipo_Produc"]) : 0,
                            id_cliente = reader["id_cliente"] != DBNull.Value ? Convert.ToInt32(reader["id_cliente"]) : 0
                        };
                    }
                }
            }
            return v;
        }

        public static int Actualizar(Ventas entidad)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ActualizarVenta", conn as SqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_de_Venta", entidad.Codigo_de_Venta ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Fecha_y_hora", entidad.Fecha_y_hora);
                cmd.Parameters.AddWithValue("@Cantidad_de_prod", entidad.Cantidad_de_prod);
                cmd.Parameters.AddWithValue("@id_Tipo_Produc", entidad.id_Tipo_Produc);
                cmd.Parameters.AddWithValue("@id_cliente", entidad.id_cliente);
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Eliminar(string codigo)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_EliminarVenta", conn as SqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_de_Venta", codigo ?? (object)DBNull.Value);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
