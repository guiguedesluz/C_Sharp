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
    
    public partial class ItemNota
    {
        public int ID_ItemNota { get; set; }
        public Nullable<int> ID_Nota { get; set; }
        public Nullable<int> ID_Produto { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<decimal> ValorTotal { get; set; }
    
        public virtual Nota Nota { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
