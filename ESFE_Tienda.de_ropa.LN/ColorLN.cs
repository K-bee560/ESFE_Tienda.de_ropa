using System;
using System.Data;
using ESFE_Tienda.de_ropa.DAL;

namespace ESFE_Tienda.de_ropa.LN
{
    public class ColorLN
    {
        private ColorDAL colorDAL = new ColorDAL();


        // =====================================================
        // AGREGAR COLOR
        // =====================================================

        public bool AgregarColor(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception(
                    "El nombre del color es obligatorio."
                );
            }

            return colorDAL.AgregarColor(
                nombre.Trim()
            );
        }


        // =====================================================
        // BUSCAR COLOR
        // =====================================================

        public DataTable BuscarColor(string busqueda)
        {
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                throw new Exception(
                    "Ingrese el nombre o ID del color."
                );
            }

            return colorDAL.BuscarColor(
                busqueda.Trim()
            );
        }


        // =====================================================
        // ELIMINAR COLOR
        // =====================================================

        public bool EliminarColor(string busqueda)
        {
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                throw new Exception(
                    "Ingrese el nombre o ID del color."
                );
            }

            return colorDAL.EliminarColor(
                busqueda.Trim()
            );
        }
    }
}