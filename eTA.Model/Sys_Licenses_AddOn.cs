//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eTA.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sys_Licenses_AddOn
    {
        public int AppId { get; set; }
        public string Application { get; set; }
        public string CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string LIC_ID { get; set; }
        public string LIC_Decription { get; set; }
        public string LIC_Code { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string InsertUser { get; set; }
        public System.DateTime InsertDate { get; set; }
        public string InsertPCName { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdatePCName { get; set; }
        public byte[] wzTimeStamp { get; set; }
    }
}
