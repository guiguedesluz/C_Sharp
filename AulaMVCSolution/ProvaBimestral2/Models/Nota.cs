//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProvaBimestral2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nota
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nota()
        {
            this.ItemNota = new HashSet<ItemNota>();
        }
    
        public int ID_Nota { get; set; }
        public Nullable<System.DateTime> DataNota { get; set; }
        public Nullable<int> ID_Cliente { get; set; }
        public Nullable<decimal> ValorNota { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemNota> ItemNota { get; set; }
    }
}
