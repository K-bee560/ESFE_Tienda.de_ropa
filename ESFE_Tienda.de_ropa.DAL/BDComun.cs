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
        public const string _stringCnn = @"Server=DESKTOP-9JI9BTT\MSSQLSERVER01;Database=BDDesarrollo;Integrated Security=True;TrustServerCertificate=True;";


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
    }
}