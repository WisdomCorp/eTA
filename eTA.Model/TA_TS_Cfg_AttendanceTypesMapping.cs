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
    
    public partial class TA_TS_Cfg_AttendanceTypesMapping
    {
        public int TaTypeMapID { get; set; }
        public int TaTypeId { get; set; }
        public int MappedTaTypeId { get; set; }
        public string PropertyID { get; set; }
        public bool IsActive { get; set; }
        public string InsertUser { get; set; }
        public System.DateTime InsertDate { get; set; }
        public string InsertPCName { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdatePCName { get; set; }
        public byte[] wzTimeStamp { get; set; }
    
        public virtual TA_TS_Cfg_AttendanceTypes TA_TS_Cfg_AttendanceTypes { get; set; }
    }
}
