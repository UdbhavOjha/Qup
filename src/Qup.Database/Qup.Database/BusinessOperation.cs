//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Qup.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class BusinessOperation
    {
        public int Id { get; set; }
        public Nullable<int> BusinessId { get; set; }
        public string Day { get; set; }
        public System.DateTime OpenTime { get; set; }
        public System.DateTime CloseTime { get; set; }
    
        public virtual Business Business { get; set; }
    }
}
