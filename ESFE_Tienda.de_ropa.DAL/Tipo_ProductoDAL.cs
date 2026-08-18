using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class Tipo_ProductoDAL
    {
        private static string ConnectionString = "TuCadenaDeConexionAquí";

        public static int Insertar(Tipo_Producto entidad)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertarTipoProducto", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Tipo_de_producto", entidad.Tipo_de_producto);

                return cmd.ExecuteNonQuery();
            }
        }

        public static List<Tipo_Producto> ObtenerTodos()
        {
            List<Tipo_Producto> lista = new List<Tipo_Producto>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerTodosTipoProductos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Tipo_Producto tp = new Tipo_Producto();
                    tp.id_Tipo_Producto = Convert.ToInt32(reader["id_Tipo_Producto"]);
                    tp.Tipo_de_producto = reader["Tipo_de_producto"].ToString();

                    lista.Add(tp);
                }
            }
            return lista;
        }

        public static Tipo_Producto ObtenerPorId(int id)
        {
            Tipo_Producto tp = null;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerTipoProductoPorId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Tipo_Producto", id);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tp = new Tipo_Producto();
                    tp.id_Tipo_Producto = Convert.ToInt32(reader["id_Tipo_Producto"]);
                    tp.Tipo_de_producto = reader["Tipo_de_producto"].ToString();
                }
            }
            return tp;
        }

        public static int Actualizar(Tipo_Producto entidad)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ActualizarTipoProducto", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_Tipo_Producto", entidad.id_Tipo_Producto);
                cmd.Parameters.AddWithValue("@Tipo_de_producto", entidad.Tipo_de_producto);

                return cmd.ExecuteNonQuery();
            }
        }

        public static int Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_EliminarTipoProducto", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Tipo_Producto", id);

                return cmd.ExecuteNonQuery();
            }
        }
    }
}
