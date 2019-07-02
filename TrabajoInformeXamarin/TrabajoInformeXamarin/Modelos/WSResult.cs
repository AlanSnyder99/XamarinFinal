using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoInformeXamarin.Modelos
{
    class WSResult
    {
        public int IdAlumno { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Habilitado { get; set; }
        public long PuntosTotales { get; set; }
        public int CantidadRespuestasCorrectas { get; set; }
        public int CantidadRespuestasRegular { get; set; }
        public int CantidadRespuestasMal { get; set; }
        public int CantidadMejorRespuesta { get; set; }
        public System.DateTime FechaHoraCreacion { get; set; }

    }
}
