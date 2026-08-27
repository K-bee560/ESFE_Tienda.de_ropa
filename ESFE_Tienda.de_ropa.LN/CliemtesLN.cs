using System;
using System.Data;
using ESFE_Tienda.de_ropa.DAL;

namespace ESFE_Tienda.de_ropa.LN
{
    public class ClienteLN
    {
        private ClienteDAL clienteDAL = new ClienteDAL();


        // =====================================================
        // AGREGAR CLIENTE
        // =====================================================

        public bool AgregarCliente(
            string nombre,
            string dui,
            string telefono,
            string correo,
            int idRol,
            int idPermiso,
            int idEstado)
        {
            // Validar nombre
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception(
                    "El nombre del cliente es obligatorio.");
            }

            // Validar DUI
            if (string.IsNullOrWhiteSpace(dui))
            {
                throw new Exception(
                    "El DUI del cliente es obligatorio.");
            }

            // Validar rol
            if (idRol <= 0)
            {
                throw new Exception(
                    "El ID del rol no es válido.");
            }

            // Validar permiso
            if (idPermiso <= 0)
            {
                throw new Exception(
                    "El ID del permiso no es válido.");
            }

            // Validar estado
            if (idEstado <= 0)
            {
                throw new Exception(
                    "El ID del estado no es válido.");
            }

            return clienteDAL.AgregarCliente(
                nombre.Trim(),
                dui.Trim(),
                telefono.Trim(),
                correo.Trim(),
                idRol,
                idPermiso,
                idEstado
            );
        }


        // =====================================================
        // BUSCAR CLIENTE
        // =====================================================

        public DataTable BuscarCliente(string busqueda)
        {
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                throw new Exception(
                    "Ingrese un ID, DUI o teléfono.");
            }

            return clienteDAL.BuscarCliente(
                busqueda.Trim()
            );
        }


        // =====================================================
        // MOSTRAR CLIENTES
        // =====================================================

        public DataTable MostrarClientes()
        {
            return clienteDAL.MostrarClientes();
        }


        // =====================================================
        // ELIMINAR CLIENTE
        // =====================================================

        public bool EliminarCliente(string busqueda)
        {
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                throw new Exception(
                    "Ingrese el ID, DUI o teléfono del cliente.");
            }

            return clienteDAL.EliminarCliente(
                busqueda.Trim()
            );
        }
    }
}