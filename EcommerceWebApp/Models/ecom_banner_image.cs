//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcommerceWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ecom_banner_image
    {
        public int banner_image_id { get; set; }
        public int banner_id { get; set; }
        public int language_id { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public string image { get; set; }
        public int sort_order { get; set; }
    
        public virtual ecom_banner ecom_banner { get; set; }
    }
}
