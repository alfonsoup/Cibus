//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CibusMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class ComboRestaurante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ComboRestaurante()
        {
            this.DetallePedidoes = new HashSet<DetallePedido>();
        }
    
        public int IdComboRestaurante { get; set; }
        public int IdRestaurante { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string Imagen { get; set; }
        public string Nombre { get; set; }
    
        public virtual Restaurante Restaurante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePedido> DetallePedidoes { get; set; }
    }
}
