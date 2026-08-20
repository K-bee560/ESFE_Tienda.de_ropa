using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class TelaDAL
    {
        public static int Insertar(Tela entidad)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("@Tipo_de_tela", entidad.Tipo_de_tela ?? (object)DBNull.Value)
            };
            return BDComun.ExecuteNonQuery("sp_InsertarTela", p);
        }

        public static List<Tela> ObtenerTodos()
        {
            var lista = new List<Tela>();
            DataTable dt = BDComun.ExecuteDataTable("sp_ObtenerTodasTelas");
            foreach (DataRow row in dt.Rows)
            {
                var tela = new Tela
                {
                    Id_Tela = row["Id_Tela"] != DBNull.Value ? Convert.ToInt32(row["Id_Tela"]) : 0,
                    Tipo_de_tela = row["Tipo_de_tela"] != DBNull.Value ? row["Tipo_de_tela"].ToString() : null
                };
                lista.Add(tela);
            }
            return lista;
        }

        public static Tela ObtenerPorId(int id)
        {
            Tela tela = null;
            var p = new SqlParameter[] { new SqlParameter("@Id_Tela", id) };
            DataTable dt = BDComun.ExecuteDataTable("sp_ObtenerTelaPorId", p);
            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                tela = new Tela
                {
                    Id_Tela = row["Id_Tela"] != DBNull.Value ? Convert.ToInt32(row["Id_Tela"]) : 0,
                    Tipo_de_tela = row["Tipo_de_tela"] != DBNull.Value ? row["Tipo_de_tela"].ToString() : null
                };
            }
            return tela;
        }

        public static int Actualizar(Tela entidad)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("@Id_Tela", entidad.Id_Tela),
                new SqlParameter("@Tipo_de_tela", entidad.Tipo_de_tela ?? (object)DBNull.Value)
            };
            return BDComun.ExecuteNonQuery("sp_ActualizarTela", p);
        }

        public static int Eliminar(int id)
        {
            var p = new SqlParameter[] { new SqlParameter("@Id_Tela", id) };
            return BDComun.ExecuteNonQuery("sp_EliminarTela", p);
        }
    }
}
