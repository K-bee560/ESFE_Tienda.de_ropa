using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;
using System.Data;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class TelaDAL
    {
        // =====================================================
        // BUSCAR TELA POR CÓDIGO
        // =====================================================

        public Tela BuscarPorCodigo(string codigoTela)
        {
            Tela tela = null;

            using (IDbConnection conexion = BDComun.ObtenerConexion())
            {
                string sql = @"SELECT 
                                    id_tela,
                                    codigo_tela,
                                    tipo_tela,
                                    color,
                                    precio_metro,
                                    stock_metros,
                                    estado,
                                    descripcion
                               FROM Tela
                               WHERE codigo_tela = @codigo_tela";

                using (SqlCommand comando =
                    new SqlCommand(sql, (SqlConnection)conexion))
                {
                    comando.Parameters.Add(
                        "@codigo_tela",
                        SqlDbType.VarChar,
                        20).Value = codigoTela;

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tela = new Tela
                            {
                                IdTela = Convert.ToInt32(
                                    reader["id_tela"]),

                                CodigoTela = reader["codigo_tela"]
                                    .ToString(),

                                TipoTela = reader["tipo_tela"]
                                    .ToString(),

                                Color = reader["color"]
                                    .ToString(),

                                PrecioMetro = Convert.ToDecimal(
                                    reader["precio_metro"]),

                                StockMetros = Convert.ToDecimal(
                                    reader["stock_metros"]),

                                Estado = reader["estado"]
                                    .ToString(),

                                Descripcion = reader["descripcion"]
                                    .ToString()
                            };
                        }
                    }
                }
            }

            return tela;
        }
    }
}