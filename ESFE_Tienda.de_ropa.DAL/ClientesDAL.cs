using ESFE_Tienda.de_ropa.EN;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ESFE_Tienda.de_ropa.DAL
{
    public class ClientesDAL
    {
        public static int Insertar(Clientes entidad)
        {
            using (IDbConnection conn = DBComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_InsertarCliente", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Ajusta los parámetros según las propiedades de tu clase Clientes
                    cmd.Parameters.AddWithValue("@Nombre", entidad.Nombre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DUI", entidad.DUI ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telefono", entidad.Telefono ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Correo", entidad.Correo ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@id_rol", entidad.id_rol);
                    cmd.Parameters.AddWithValue("@id_permiso", entidad.id_permiso);
                    cmd.Parameters.AddWithValue("@id_estado", entidad.id_estado);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Clientes> ObtenerTodos()
        {
            List<Clientes> lista = new List<Clientes>();
            using (IDbConnection conn = DBComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerTodosClientes", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Clientes cliente = new Clientes();
                            cliente.id_cliente = reader["id_cliente"] != DBNull.Value ? Convert.ToInt32(reader["id_cliente"]) : 0;
                            cliente.Nombre = reader["Nombre"]?.ToString();
                            cliente.DUI = reader["DUI"]?.ToString();
                            cliente.Telefono = reader["Telefono"]?.ToString();
                            cliente.Correo = reader["Correo"]?.ToString();
                            cliente.id_rol = reader["id_rol"] != DBNull.Value ? Convert.ToInt32(reader["id_rol"]) : 0;
                            cliente.id_permiso = reader["id_permiso"] != DBNull.Value ? Convert.ToInt32(reader["id_permiso"]) : 0;
                            cliente.id_estado = reader["id_estado"] != DBNull.Value ? Convert.ToInt32(reader["id_estado"]) : 0;

                            lista.Add(cliente);
                        }
                    }
                }
            }
            return lista;
        }

        public static Clientes ObtenerPorId(int id)
        {
            Clientes cliente = null;
            using (IDbConnection conn = DBComun.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerClientePorId", conn as SqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cliente", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new Clientes();
                            cliente.id_cliente = reader["id_cliente"] != DBNull.Value ? Convert.ToInt32(reader["id_cliente"]) : 0;
                            cliente.Nombre = reader["Nombre"]?.ToString();
                            cliente.DUI = reader["DUI"]?.ToString();
                            cliente.Telefono = reader["Telefono"]?.ToString();
                            cliente.Correo = reader["Correo"]?.ToString();
                            cliente.id_rol = reader["id_rol"] != DBNull.Value ? Convert.ToInt32(reader["id_rol"]) : 0;
                            cliente.id_permiso = reader["id_permiso"] != DBNull.Value ? Convert.ToInt32(reader["id_permiso"]) : 0;
                            cliente.id_estado = reader["id_estado"] != DBNull.Value ? Convert.ToInt32(reader["id_estado"]) : 0;
                        }
                    }
                }
            }
            return cliente;
        }
    }
}
