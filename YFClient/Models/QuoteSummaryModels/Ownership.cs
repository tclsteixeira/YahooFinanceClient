using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class Ownership
    {

        [DataMember(Name ="maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name ="reportDate")]
        public FormatedData ReportDate { get; set; }

        [DataMember(Name = "organization")]
        public string Organization { get; set; }

        [DataMember(Name = "pctHeld")]
        public FormatedData PctHeld { get; set; }

        [DataMember(Name = "position")]
        public FormatedData Position { get; set; }

        [DataMember(Name = "value")]
        public FormatedData Value { get; set; }


        public Ownership()
        {
        }

    }

}
