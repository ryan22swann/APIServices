//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Law_Classification
    {
        public int ID { get; set; }
        public string Jurisdiction { get; set; }
        public string Law { get; set; }
        public Nullable<double> Debt_Collection_Banking { get; set; }
        public Nullable<double> Political { get; set; }
        public Nullable<double> Crime_Penalty { get; set; }
        public Nullable<double> Property_Sale { get; set; }
        public Nullable<double> Generic_Scam { get; set; }
        public Nullable<double> Legitimate { get; set; }
        public Nullable<double> Profanity { get; set; }
        public Nullable<double> Foreign { get; set; }
        public Nullable<System.TimeSpan> Start_Time { get; set; }
        public Nullable<System.TimeSpan> End_Time { get; set; }
        public Nullable<System.DateTime> Time_Stamp { get; set; }
        public Nullable<double> Target_Value { get; set; }
    }
}
