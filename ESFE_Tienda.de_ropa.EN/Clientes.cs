using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE_Tienda.de_ropa.EN
{
    public class Clientes
    {
        public int id_cliente { get; set; }
        public string Nombre { get; set; }
        public string DUI { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int id_rol { get; set; }
        public int id_permiso { get; set; }
        public int id_estado { get; set; }

    }
}
