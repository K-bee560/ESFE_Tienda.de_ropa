using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE_Tienda.de_ropa.EN
{
    public class Ventas
    {
        public string Codigo_de_Venta { get; set; }
        public DateTime Fecha_y_hora { get; set; }
        public int Cantidad_de_prod { get; set; }
        public int id_Tipo_Produc { get; set; }
        public int id_cliente { get; set; }

    }
}
