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
    
    public partial class SYS_Forms
    {
        public int Form_Id { get; set; }
        public byte Form_Language { get; set; }
        public string Form_Name { get; set; }
        public string Form_Caption { get; set; }
        public string InsertUser { get; set; }
        public System.DateTime InsertDate { get; set; }
        public string InsertPCName { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdatePCName { get; set; }
        public byte[] wzTimeStamp { get; set; }
    }
}