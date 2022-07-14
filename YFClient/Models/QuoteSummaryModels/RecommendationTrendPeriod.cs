using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class RecommendationTrendPeriod
    {

        [DataMember(Name ="period")]
        public string Period { get; set; }

        [DataMember(Name = "strongBuy")]
        public int? StrongBuy { get; set; }

        [DataMember(Name = "buy")]
        public int? Buy { get; set; }

        [DataMember(Name = "hold")]
        public int? Hold { get; set; }

        [DataMember(Name = "sell")]
        public int? Sell { get; set; }

        [DataMember(Name = "strongSell")]
        public int? StrongSell { get; set; }


        public RecommendationTrendPeriod()
        {
        }
    }

}
