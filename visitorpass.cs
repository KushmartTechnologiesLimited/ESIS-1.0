//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESIS
{
    using System;
    using System.Collections.Generic;
    
    public partial class visitorpass
    {
        public int visitorpassID { get; set; }
        public string visitorname { get; set; }
        public Nullable<int> visitorcardnumber { get; set; }
        public string address { get; set; }
        public string contactnumber { get; set; }
        public Nullable<int> numberofvisitors { get; set; }
        public string visitpurpose { get; set; }
        public string meetingwith { get; set; }
        public Nullable<System.DateTime> visitdate { get; set; }
        public Nullable<System.TimeSpan> intime { get; set; }
        public Nullable<System.TimeSpan> outtime { get; set; }
        public string comments { get; set; }
    }
}
