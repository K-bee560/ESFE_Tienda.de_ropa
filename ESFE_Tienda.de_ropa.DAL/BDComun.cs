﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;




namespace ESFE_Tienda.de_ropa.DAL
{
    public class BDComun
    {
        //public const string _stringCnn = EDWIN\SQLEXPRESS;Initial Catalog=BDDesarrollo;Integrated Security=True";
        public const string _stringCnn = @"Server=M20-CIII;Database=ESFE_TiendaRopa;Integrated Security=True;TrustServerCertificate=True;";


        /// <summary>
        /// Metodo para obtener base de datos.
        /// </summary>
        /// <returns>Devuelve la  conexion</returns>
        public static IDbConnection ObtenerConexion()
        {
            return new SqlConnection(_stringCnn);
        }

        public static IDataReader ObtenerCommando(IDbConnection pConexion, string pSql)
        {
            SqlCommand _command = new SqlCommand(pSql, pConexion as SqlConnection);
            return _command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        // Helper: ejecutar un stored procedure que no devuelve filas
        public static int ExecuteNonQuery(string pSp, params SqlParameter[] pParams)
        {
            using (var conn = new SqlConnection(_stringCnn))
            {
                conn.Open();
                using (var cmd = new SqlCommand(pSp, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (pParams != null && pParams.Length > 0) cmd.Parameters.AddRange(pParams);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Helper: ejecutar un stored procedure y obtener un valor escalar
        public static object ExecuteScalar(string pSp, params SqlParameter[] pParams)
        {
            using (var conn = new SqlConnection(_stringCnn))
            {
                conn.Open();
                using (var cmd = new SqlCommand(pSp, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (pParams != null && pParams.Length > 0) cmd.Parameters.AddRange(pParams);
                    return cmd.ExecuteScalar();
                }
            }
        }

        // Helper: ejecutar un stored procedure y devolver un DataTable (no deja conexiones abiertas)
        public static DataTable ExecuteDataTable(string pSp, params SqlParameter[] pParams)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_stringCnn))
            {
                conn.Open();
                using (var cmd = new SqlCommand(pSp, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (pParams != null && pParams.Length > 0) cmd.Parameters.AddRange(pParams);
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }
    }
}