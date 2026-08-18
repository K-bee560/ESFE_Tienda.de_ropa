using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class VentasDAL
    {
        private static string ConnectionString = "TuCadenaDeConexionAquí";

        public static int Insertar(Ventas entidad)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertarVenta", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Codigo_de_Venta", entidad.Codigo_de_Venta);
                cmd.Parameters.AddWithValue("@Fecha_y_hora", entidad.Fecha_y_hora);
                cmd.Parameters.AddWithValue("@Cantidad_de_prod", entidad.Cantidad_de_prod);
                cmd.Parameters.AddWithValue("@id_Tipo_Produc", entidad.id_Tipo_Produc);
                cmd.Parameters.AddWithValue("@id_cliente", entidad.id_cliente);

                return cmd.ExecuteNonQuery();
            }
        }

        public static List<Ventas> ObtenerTodos()
        {
            List<Ventas> lista = new List<Ventas>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerTodasVentas", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ventas v = new Ventas();
                    v.Codigo_de_Venta = reader["Codigo_de_Venta"].ToString();
                    v.Fecha_y_hora = Convert.ToDateTime(reader["Fecha_y_hora"]);
                    v.Cantidad_de_prod = Convert.ToInt32(reader["Cantidad_de_prod"]);
                    v.id_Tipo_Produc = Convert.ToInt32(reader["id_Tipo_Produc"]);
                    v.id_cliente = Convert.ToInt32(reader["id_cliente"]);

                    lista.Add(v);
                }
            }
            return lista;
        }

        public static Ventas ObtenerPorCodigo(string codigo)
        {
            Ventas v = null;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerVentaPorCodigo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_de_Venta", codigo);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    v = new Ventas();
                    v.Codigo_de_Venta = reader["Codigo_de_Venta"].ToString();
                    v.Fecha_y_hora = Convert.ToDateTime(reader["Fecha_y_hora"]);
                    v.Cantidad_de_prod = Convert.ToInt32(reader["Cantidad_de_prod"]);
                    v.id_Tipo_Produc = Convert.ToInt32(reader["id_Tipo_Produc"]);
                    v.id_cliente = Convert.ToInt32(reader["id_cliente"]);
                }
            }
            return v;
        }

        public static int Actualizar(Ventas entidad)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ActualizarVenta", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Codigo_de_Venta", entidad.Codigo_de_Venta);
                cmd.Parameters.AddWithValue("@Fecha_y_hora", entidad.Fecha_y_hora);
                cmd.Parameters.AddWithValue("@Cantidad_de_prod", entidad.Cantidad_de_prod);
                cmd.Parameters.AddWithValue("@id_Tipo_Produc", entidad.id_Tipo_Produc);
                cmd.Parameters.AddWithValue("@id_cliente", entidad.id_cliente);

                return cmd.ExecuteNonQuery();
            }
        }

        public static int Eliminar(string codigo)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_EliminarVenta", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_de_Venta", codigo);

                return cmd.ExecuteNonQuery();
            }
        }
    }
}
