using System;
using System.Runtime.Serialization;

namespace YFClient.Models.Trending
{

    [DataContract]
    public class TrendingQuote
    {

        [DataMember(Name ="symbol")]
        public string Symbol { get; set; }

        public TrendingQuote()
        {
        }
    }
}
