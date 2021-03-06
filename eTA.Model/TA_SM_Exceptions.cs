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
    
    public partial class TA_SM_Exceptions
    {
        public int ExID { get; set; }
        public System.DateTime ExTrxDate { get; set; }
        public int ExTypeID { get; set; }
        public byte ExPeriod { get; set; }
        public System.DateTime ExDateFrom { get; set; }
        public System.DateTime ExDateTo { get; set; }
        public Nullable<System.TimeSpan> Shift1EntryTime { get; set; }
        public Nullable<System.TimeSpan> Shift1ExitTime { get; set; }
        public Nullable<System.TimeSpan> Shift2EntryTime { get; set; }
        public Nullable<System.TimeSpan> Shift2ExitTime { get; set; }
        public Nullable<bool> ExDay1 { get; set; }
        public Nullable<bool> ExDay2 { get; set; }
        public Nullable<bool> ExDay3 { get; set; }
        public Nullable<bool> ExDay4 { get; set; }
        public Nullable<bool> ExDay5 { get; set; }
        public Nullable<bool> ExDay6 { get; set; }
        public Nullable<bool> ExDay7 { get; set; }
        public string EmployeeID { get; set; }
        public int ShiftID { get; set; }
        public Nullable<int> TaTypeId { get; set; }
        public string ExNotes { get; set; }
        public string ApprovedBY { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string InsertUser { get; set; }
        public System.DateTime InsertDate { get; set; }
        public string InsertPCName { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdatePCName { get; set; }
        public byte[] wzTimeStamp { get; set; }
    
        public virtual TA_SM_Cfg_ExceptionTypes TA_SM_Cfg_ExceptionTypes { get; set; }
    }
}
