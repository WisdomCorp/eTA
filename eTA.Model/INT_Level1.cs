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
    
    public partial class INT_Level1
    {
        public INT_Level1()
        {
            this.INT_Employee = new HashSet<INT_Employee>();
        }
    
        public string Level1 { get; set; }
        public string DescriptionE { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public byte[] WzTimeStamp { get; set; }
        public string InsertUser { get; set; }
        public System.DateTime InsertDate { get; set; }
        public string InsertPCName { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdatePCName { get; set; }
    
        public virtual ICollection<INT_Employee> INT_Employee { get; set; }
    }
}
