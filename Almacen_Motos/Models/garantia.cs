//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Almacen_Motos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class garantia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public garantia()
        {
            this.respuestos = new HashSet<respuestos>();
            this.servicio_mecanica = new HashSet<servicio_mecanica>();
        }
    
        public int codigo { get; set; }
        public Nullable<int> periodo_garantia { get; set; }
        public Nullable<System.DateTime> dia_garantia { get; set; }
        public string tipo { get; set; }
        public Nullable<int> C_Servicio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<respuestos> respuestos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<servicio_mecanica> servicio_mecanica { get; set; }
    }
}
