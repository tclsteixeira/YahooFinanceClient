using System;
using System.Runtime.Serialization;

namespace YFClient.Models.Trending
{
    [DataContract]
    public class FinanceTrend
    {

        [DataMember(Name ="result")]
        public TrendingResult[] Result { get; set; }

        [DataMember(Name ="error")]
        public ErrorInfo Error { get; set; }

        public FinanceTrend()
        {
        }

    }

}
