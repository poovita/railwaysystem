//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rail.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dadar
    {
        public int Train_number { get; set; }
        public string Train_name { get; set; }
        public string Source_stn { get; set; }
        public string Dest_stn { get; set; }
        public Nullable<System.TimeSpan> Arrival { get; set; }
        public Nullable<System.TimeSpan> Depart { get; set; }
        public Nullable<System.TimeSpan> halt { get; set; }
        public string Su { get; set; }
        public string Mo { get; set; }
        public string Tu { get; set; }
        public string We { get; set; }
        public string Th { get; set; }
        public string Fr { get; set; }
        public string Sa { get; set; }
        public string train_priority { get; set; }
        public string platform { get; set; }
    }
}
