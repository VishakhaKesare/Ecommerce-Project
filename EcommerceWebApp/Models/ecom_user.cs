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
    
    public partial class ecom_user
    {
        public int user_id { get; set; }
        public int user_group_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string image { get; set; }
        public string code { get; set; }
        public string ip { get; set; }
        public byte status { get; set; }
        public System.DateTime date_added { get; set; }
    
        public virtual ecom_user_group ecom_user_group { get; set; }
    }
}
