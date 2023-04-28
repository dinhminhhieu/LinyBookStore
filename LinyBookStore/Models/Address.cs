//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinyBookStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public int address_id { get; set; }
        public int account_id { get; set; }
        public int province_id { get; set; }
        public int district_id { get; set; }
        public int ward_id { get; set; }
        public string accountPhoneNumber { get; set; }
        public string accountUserName { get; set; }
        public string content { get; set; }
        public bool isDefault { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual District District { get; set; }
        public virtual Province Province { get; set; }
        public virtual Ward Ward { get; set; }
    }
}
