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
    
    public partial class Adm_Cfg_Signatories
    {
        public int SignId { get; set; }
        public string PropertyID { get; set; }
        public string FormName { get; set; }
        public string EmployeeName { get; set; }
        public string SignatoryLabel { get; set; }
        public string JobDescriptionE { get; set; }
        public Nullable<byte> SequenceID { get; set; }
        public string PrintType { get; set; }
        public bool Active { get; set; }
        public byte[] wzTimeStamp { get; set; }
        public string InsertUser { get; set; }
        public System.DateTime InsertDate { get; set; }
        public string InsertPCName { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdatePCName { get; set; }
    }
}