using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class UsuarioDAL
    {
        public static int Insertar(Usuario entidad)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("@UsuarioNombre", entidad.UsuarioNombre ?? (object)DBNull.Value)
            };
            return BDComun.ExecuteNonQuery("sp_InsertarUsuario", p);
        }

        public static List<Usuario> ObtenerTodos()
        {
            var lista = new List<Usuario>();
            DataTable dt = BDComun.ExecuteDataTable("sp_ObtenerTodosUsuarios");
            foreach (DataRow row in dt.Rows)
            {
                var u = new Usuario
                {
                    Id_Usuario = row["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(row["Id_Usuario"]) : 0,
                    UsuarioNombre = row["UsuarioNombre"] != DBNull.Value ? row["UsuarioNombre"].ToString() : null
                };
                lista.Add(u);
            }
            return lista;
        }

        public static Usuario ObtenerPorId(int id)
        {
            Usuario u = null;
            var p = new SqlParameter[] { new SqlParameter("@Id_Usuario", id) };
            DataTable dt = BDComun.ExecuteDataTable("sp_ObtenerUsuarioPorId", p);
            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                u = new Usuario
                {
                    Id_Usuario = row["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(row["Id_Usuario"]) : 0,
                    UsuarioNombre = row["UsuarioNombre"] != DBNull.Value ? row["UsuarioNombre"].ToString() : null
                };
            }
            return u;
        }

        public static int Actualizar(Usuario entidad)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("@Id_Usuario", entidad.Id_Usuario),
                new SqlParameter("@UsuarioNombre", entidad.UsuarioNombre ?? (object)DBNull.Value)
            };
            return BDComun.ExecuteNonQuery("sp_ActualizarUsuario", p);
        }

        public static int Eliminar(int id)
        {
            var p = new SqlParameter[] { new SqlParameter("@Id_Usuario", id) };
            return BDComun.ExecuteNonQuery("sp_EliminarUsuario", p);
        }
    }
}
