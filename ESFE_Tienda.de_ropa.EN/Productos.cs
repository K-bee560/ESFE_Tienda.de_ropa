// using directives removed because were not used

namespace ESFE_Tienda.de_ropa.EN
{
    /// <summary>
    /// Clase Entidad que representa la estructura de un Producto en la base de datos.
    /// </summary>
    public class Productos
    {
        /// <summary>
        /// Código único de identificación del producto.
        /// </summary>
        public string Codigo_Product { get; set; }

        /// <summary>
        /// Nombre o descripción comercial de la prenda.
        /// </summary>
        public string Nombre_Product { get; set; }

        /// <summary>
        /// Precio unitario de venta de la prenda.
        /// </summary>
        public decimal Precio { get; set; }

        /// <summary>
        /// Identificador del tipo o categoría del producto.
        /// </summary>
        public int id_Tipo_Product { get; set; }

        /// <summary>
        /// Identificador de la talla asignada.
        /// </summary>
        public int id_tallas { get; set; }

        /// <summary>
        /// Identificador del tipo de tela o material.
        /// </summary>
        public int id_Tela { get; set; }

        /// <summary>
        /// Identificador del color principal del producto.
        /// </summary>
        public int id_Color { get; set; }
    }
}



