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
    
    public partial class Sys_Msg_Error
    {
        public int ErrMsgId { get; set; }
        public Nullable<short> Category { get; set; }
        public string Header { get; set; }
        public string HeaderA { get; set; }
        public string Text { get; set; }
        public string TextA { get; set; }
        public string Solution { get; set; }
        public string SolutionA { get; set; }
        public Nullable<short> Icon { get; set; }
        public Nullable<short> Icon1 { get; set; }
        public Nullable<short> Icon2 { get; set; }
        public Nullable<int> Buttons { get; set; }
        public Nullable<int> ButtonMap { get; set; }
        public Nullable<int> ButtonSet { get; set; }
        public string KeyMap { get; set; }
        public string Description { get; set; }
        public bool ISProblem { get; set; }
        public byte[] wzTimeStamp { get; set; }
        public string MessageType { get; set; }
    }
}