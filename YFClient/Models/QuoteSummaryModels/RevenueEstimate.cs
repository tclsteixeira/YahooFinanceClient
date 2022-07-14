using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class RevenueEstimate
    {

        [DataMember(Name = "avg")]
        public FormatedData Avg { get; set; }

        [DataMember(Name = "low")]
        public FormatedData Low { get; set; }

        [DataMember(Name = "high")]
        public FormatedData High { get; set; }

        [DataMember(Name = "yearAgoRevenue")]
        public FormatedData YearAgoRevenue { get; set; }

        [DataMember(Name = "numberOfAnalysts")]
        public FormatedData NumberOfAnalysts { get; set; }

        [DataMember(Name = "growth")]
        public FormatedData Growth { get; set; }



        public RevenueEstimate()
        {
        }
    }
}
