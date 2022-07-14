using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ResearchInsightsModels
{

    [DataContract]
    public class RISnapshot
    {

        [DataMember(Name = "innovativeness")]
        public decimal? Innovativeness { get; set; }

        [DataMember(Name = "hiring")]
        public decimal? Hiring { get; set; }

        [DataMember(Name = "sustainability")]
        public decimal? Sustainability { get; set; }

        [DataMember(Name = "insiderSentiments")]
        public decimal? InsiderSentiments { get; set; }

        [DataMember(Name = "earningsReports")]
        public decimal? EarningsReports { get; set; }

        [DataMember(Name = "dividends")]
        public decimal? Dividends { get; set; }


        public RISnapshot()
        {
        }
    }

}
