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
            var p = new SqlParameter[]
            {
                new SqlParameter("@Codigo_de_Venta", entidad.Codigo_de_Venta ?? (object)DBNull.Value),
                new SqlParameter("@Fecha_y_hora", entidad.Fecha_y_hora),
                new SqlParameter("@Cantidad_de_prod", entidad.Cantidad_de_prod),
                new SqlParameter("@id_Tipo_Produc", entidad.id_Tipo_Produc),
                new SqlParameter("@id_cliente", entidad.id_cliente)
            };
            return BDComun.ExecuteNonQuery("sp_InsertarVenta", p);
        }

        public static List<Ventas> ObtenerTodos()
        {
            var lista = new List<Ventas>();
            DataTable dt = BDComun.ExecuteDataTable("sp_ObtenerTodasVentas");
            foreach (DataRow row in dt.Rows)
            {
                var v = new Ventas
                {
                    Codigo_de_Venta = row["Codigo_de_Venta"] != DBNull.Value ? row["Codigo_de_Venta"].ToString() : null,
                    Fecha_y_hora = row["Fecha_y_hora"] != DBNull.Value ? Convert.ToDateTime(row["Fecha_y_hora"]) : DateTime.MinValue,
                    Cantidad_de_prod = row["Cantidad_de_prod"] != DBNull.Value ? Convert.ToInt32(row["Cantidad_de_prod"]) : 0,
                    id_Tipo_Produc = row["id_Tipo_Produc"] != DBNull.Value ? Convert.ToInt32(row["id_Tipo_Produc"]) : 0,
                    id_cliente = row["id_cliente"] != DBNull.Value ? Convert.ToInt32(row["id_cliente"]) : 0
                };
                lista.Add(v);
            }
            return lista;
        }

        public static Ventas ObtenerPorCodigo(string codigo)
        {
            Ventas v = null;
            var p = new SqlParameter[] { new SqlParameter("@Codigo_de_Venta", codigo ?? (object)DBNull.Value) };
            DataTable dt = BDComun.ExecuteDataTable("sp_ObtenerVentaPorCodigo", p);
            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                v = new Ventas
                {
                    Codigo_de_Venta = row["Codigo_de_Venta"] != DBNull.Value ? row["Codigo_de_Venta"].ToString() : null,
                    Fecha_y_hora = row["Fecha_y_hora"] != DBNull.Value ? Convert.ToDateTime(row["Fecha_y_hora"]) : DateTime.MinValue,
                    Cantidad_de_prod = row["Cantidad_de_prod"] != DBNull.Value ? Convert.ToInt32(row["Cantidad_de_prod"]) : 0,
                    id_Tipo_Produc = row["id_Tipo_Produc"] != DBNull.Value ? Convert.ToInt32(row["id_Tipo_Produc"]) : 0,
                    id_cliente = row["id_cliente"] != DBNull.Value ? Convert.ToInt32(row["id_cliente"]) : 0
                };
            }
            return v;
        }

        public static int Actualizar(Ventas entidad)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("@Codigo_de_Venta", entidad.Codigo_de_Venta ?? (object)DBNull.Value),
                new SqlParameter("@Fecha_y_hora", entidad.Fecha_y_hora),
                new SqlParameter("@Cantidad_de_prod", entidad.Cantidad_de_prod),
                new SqlParameter("@id_Tipo_Produc", entidad.id_Tipo_Produc),
                new SqlParameter("@id_cliente", entidad.id_cliente)
            };
            return BDComun.ExecuteNonQuery("sp_ActualizarVenta", p);
        }

        public static int Eliminar(string codigo)
        {
            var p = new SqlParameter[] { new SqlParameter("@Codigo_de_Venta", codigo ?? (object)DBNull.Value) };
            return BDComun.ExecuteNonQuery("sp_EliminarVenta", p);
        }
    }
}
