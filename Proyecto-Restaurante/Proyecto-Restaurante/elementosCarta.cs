//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Restaurante
{
    using System;
    using System.Collections.Generic;
    
    public partial class elementosCarta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public elementosCarta()
        {
            this.Pedidos = new HashSet<Pedidos>();
        }
    
        public int idElemento { get; set; }
        public string nombreElemento { get; set; }
        public int idCategoria { get; set; }
        public double precio { get; set; }
        public string imagen { get; set; }
        public string descripcion { get; set; }
    
        public virtual Categorias Categorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedidos> Pedidos { get; set; }
    }
}
