using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class RecommendationTrend
    {

        [DataMember(Name = "trend")]
        public RecommendationTrendPeriod[] TrendPeriods {get; set;}

        [DataMember(Name ="maxAge")]
        public int? MaxAge { get; set; }


        public RecommendationTrend()
        {
        }
    }

}
