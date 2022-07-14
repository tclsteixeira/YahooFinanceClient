using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class ScorePerformance
    {

        [DataMember(Name ="min")]
        public decimal? Min { get; set; }

        [DataMember(Name = "avg")]
        public decimal? Avg { get; set; }

        [DataMember(Name = "max")]
        public decimal? Max { get; set; }


        public ScorePerformance()
        {
        }

    }
}
