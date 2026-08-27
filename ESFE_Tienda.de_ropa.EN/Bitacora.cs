using System;

namespace ESFE_Tienda.de_ropa.EN
{
    public class BitacoraEN
    {
        public int IDActividad { get; set; }
        public string Accion { get; set; }
        public int IDUsuario { get; set; }
        public DateTime FechaHora { get; set; }

        public BitacoraEN()
        {
        }

        public BitacoraEN(int idActividad, string accion, int idUsuario, DateTime fechaHora)
        {
            IDActividad = idActividad;
            Accion = accion;
            IDUsuario = idUsuario;
            FechaHora = fechaHora;
        }
    }
}