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
    
    public partial class item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public item()
        {
            this.wishlists = new HashSet<wishlist>();
            this.item_header = new HashSet<item_header>();
        }
    
        public string item_id { get; set; }
        public string shop_id { get; set; }
        public string item_name { get; set; }
        public int inventory { get; set; }
        public System.DateTime expiration_date { get; set; }
        public int price { get; set; }
        public string item_image_path { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wishlist> wishlists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<item_header> item_header { get; set; }
        public virtual shop shop { get; set; }
    }
}
