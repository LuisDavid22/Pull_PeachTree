//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pull_PeachTree
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asiento()
        {
            this.Asiento_Detalle = new HashSet<Asiento_Detalle>();
        }
    
        public int numeroAsiento { get; set; }
        public string detalleAsiento { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<decimal> totalDebito { get; set; }
        public Nullable<decimal> totalCredito { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asiento_Detalle> Asiento_Detalle { get; set; }
    }
}
