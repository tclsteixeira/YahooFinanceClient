using System;
using System.Runtime.Serialization;

namespace YFClient.Models.MarketSummary
{

    /// <summary>
    /// Market summary api.
    /// </summary>
    [DataContract]
    public class MarketSummary : JSonClass
    {

        [DataMember(Name ="marketSummaryResponse")]
        public MarketSummaryResponse MarketSummaryResponse { get; set; }


        public MarketSummary()
        {
        }
    }

}
