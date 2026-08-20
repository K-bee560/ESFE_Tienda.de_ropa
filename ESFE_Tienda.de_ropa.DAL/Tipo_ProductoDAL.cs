using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class Tipo_ProductoDAL
    {
        public static int Insertar(Tipo_Producto entidad)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_InsertarTipoProducto", conn as SqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Tipo_de_producto", entidad.Tipo_de_producto ?? (object)DBNull.Value);
                return cmd.ExecuteNonQuery();
            }
        }

        public static List<Tipo_Producto> ObtenerTodos()
        {
            var lista = new List<Tipo_Producto>();
            DataTable dt = BDComun.ExecuteDataTable("sp_ObtenerTodosTipoProductos");
            foreach (DataRow row in dt.Rows)
            {
                var tp = new Tipo_Producto
                {
                    id_Tipo_Producto = row["id_Tipo_Producto"] != DBNull.Value ? Convert.ToInt32(row["id_Tipo_Producto"]) : 0,
                    Tipo_de_producto = row["Tipo_de_producto"] != DBNull.Value ? row["Tipo_de_producto"].ToString() : null
                };
                lista.Add(tp);
            }
            return lista;
        }

        public static Tipo_Producto ObtenerPorId(int id)
        {
            Tipo_Producto tp = null;
            var p = new SqlParameter[] { new SqlParameter("@id_Tipo_Producto", id) };
            DataTable dt = BDComun.ExecuteDataTable("sp_ObtenerTipoProductoPorId", p);
            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                tp = new Tipo_Producto
                {
                    id_Tipo_Producto = row["id_Tipo_Producto"] != DBNull.Value ? Convert.ToInt32(row["id_Tipo_Producto"]) : 0,
                    Tipo_de_producto = row["Tipo_de_producto"] != DBNull.Value ? row["Tipo_de_producto"].ToString() : null
                };
            }
            return tp;
        }

        public static int Actualizar(Tipo_Producto entidad)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("@id_Tipo_Producto", entidad.id_Tipo_Producto),
                new SqlParameter("@Tipo_de_producto", entidad.Tipo_de_producto ?? (object)DBNull.Value)
            };
            return BDComun.ExecuteNonQuery("sp_ActualizarTipoProducto", p);
        }

        public static int Eliminar(int id)
        {
            var p = new SqlParameter[] { new SqlParameter("@id_Tipo_Producto", id) };
            return BDComun.ExecuteNonQuery("sp_EliminarTipoProducto", p);
        }
    }
}
