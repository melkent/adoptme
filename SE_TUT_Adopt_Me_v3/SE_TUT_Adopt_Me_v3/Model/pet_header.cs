//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SE_TUT_Adopt_Me_v3.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class pet_header
    {
        public string pet_header_id { get; set; }
        public string cart_id { get; set; }
        public string pet_id { get; set; }
        public int quantity { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual pet pet { get; set; }
    }
}
