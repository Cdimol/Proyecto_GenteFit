//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenteFit.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserva
    {
        public int ReservaID { get; set; }
        public System.DateTime FechaReserva { get; set; }
        public string EstadoReserva { get; set; }
        public Nullable<int> ClienteID { get; set; }
        public Nullable<int> ActividadID { get; set; }
    
        public virtual Actividad Actividad { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
