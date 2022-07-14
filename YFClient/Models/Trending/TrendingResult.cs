using System;
using System.Runtime.Serialization;

namespace YFClient.Models.Trending
{

    [DataContract]
    public class TrendingResult
    {

        [DataMember(Name ="count")]
        public int? Count { get; set; }

        [DataMember(Name ="quotes")]
        public TrendingQuote[] Quotes { get; set; }

        [DataMember(Name = "jobTimestamp")]
        public decimal? JobTimestamp { get; set; }

        [DataMember(Name = "startInterval")]
        public decimal? StartInterval { get; set; }


        public TrendingResult()
        {
        }
    }
}
