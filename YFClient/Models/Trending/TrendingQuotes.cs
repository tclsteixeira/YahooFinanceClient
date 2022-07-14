using System;
using System.Runtime.Serialization;

namespace YFClient.Models.Trending
{

    [DataContract]
    public class TrendingQuotes : JSonClass
    {

        [DataMember(Name ="finance")]
        public FinanceTrend Finance { get; set; }

        public TrendingQuotes()
        {
        }
    }
}
