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
    
    public partial class Sys_Sec_PermissionsGranted
    {
        public int PGrantedId { get; set; }
        public int PId { get; set; }
        public int AppUserID { get; set; }
        public string PermissionInheritedFrom { get; set; }
        public Nullable<bool> IsInheritedFromGroup { get; set; }
        public string InsertUser { get; set; }
        public System.DateTime InsertDate { get; set; }
        public string InsertPCName { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdatePCName { get; set; }
        public byte[] wzTimeStamp { get; set; }
    
        public virtual Sys_Sec_Permissions Sys_Sec_Permissions { get; set; }
        public virtual Sys_Sec_User Sys_Sec_User { get; set; }
    }
}
