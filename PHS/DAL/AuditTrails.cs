//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuditTrails
    {
        public int ID { get; set; }
        public string Action { get; set; }
        public string RecordTable { get; set; }
        public int RecordID { get; set; }
        public string Record { get; set; }
        public int Actionby { get; set; }
        public System.DateTime ActionDate { get; set; }
    }
}