//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParqueoUPC.DL.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Piso
    {
        public Piso()
        {
            this.Espacio = new HashSet<Espacio>();
        }
    
        public int PisoId { get; set; }
        public int NroPiso { get; set; }
    
        public virtual ICollection<Espacio> Espacio { get; set; }
    }
}
