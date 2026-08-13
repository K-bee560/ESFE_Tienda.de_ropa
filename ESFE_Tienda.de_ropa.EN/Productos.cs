using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE_Tienda.de_ropa.EN
{
    public class Productos
    {
        public string Codigo_Product { get; set; }
        public string Nombre_Product { get; set; }
        public decimal Precio { get; set; }
        public int id_Tipo_Product { get; set; }
        public int id_tallas { get; set; }
        public int id_Tela { get; set; }
        public int id_Color { get; set; }

    }
}
