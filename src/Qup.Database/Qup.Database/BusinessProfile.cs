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
    
    public partial class BusinessProfile
    {
        public int Id { get; set; }
        public Nullable<int> BusinessId { get; set; }
        public byte[] ProfileImage { get; set; }
    
        public virtual Business Business { get; set; }
    }
}
