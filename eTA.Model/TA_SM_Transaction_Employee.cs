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
    
    public partial class TA_SM_Transaction_Employee
    {
        public long TrxnID { get; set; }
        public string EmployeeID { get; set; }
        public int ShiftID { get; set; }
        public System.DateTime PunchDate { get; set; }
        public byte DayOfWeek { get; set; }
        public string DayCode { get; set; }
        public bool DayRamadan { get; set; }
        public System.TimeSpan Punch1In { get; set; }
        public System.TimeSpan Punch1Out { get; set; }
        public System.TimeSpan Punch2In { get; set; }
        public System.TimeSpan Punch2Out { get; set; }
        public System.TimeSpan Shift1TimeIn { get; set; }
        public System.TimeSpan Shift1TimeOut { get; set; }
        public decimal Shift1WorkHours { get; set; }
        public System.TimeSpan Shift2TimeIn { get; set; }
        public System.TimeSpan Shift2TimeOut { get; set; }
        public decimal Shift2WorkHours { get; set; }
        public int DayWorkTime { get; set; }
        public int DayTimeOff { get; set; }
        public int HolidayID { get; set; }
        public int LeaveID { get; set; }
        public int Ex1_ID_In { get; set; }
        public int Ex1_ID_Out { get; set; }
        public int Ex2_ID_In { get; set; }
        public int Ex2_ID_Out { get; set; }
        public int Shift1AbsentIn { get; set; }
        public int Shift1AbsentOut { get; set; }
        public int Shift2AbsentIn { get; set; }
        public int Shift2AbsentOut { get; set; }
        public int Shift1DelayIn { get; set; }
        public int Shift1EarlyExit { get; set; }
        public int Shift2DelayIn { get; set; }
        public int Shift2EarlyExit { get; set; }
        public int DayOverTime { get; set; }
    }
}
