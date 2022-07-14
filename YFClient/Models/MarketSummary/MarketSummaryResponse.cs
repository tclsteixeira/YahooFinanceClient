using System;
using System.Runtime.Serialization;

namespace YFClient.Models.MarketSummary
{

    [DataContract]
    public class MarketSummaryResponse
    {

        [DataMember(Name = "result")]
        public MarketSummaryResultItem[] Result { get; set; }

        [DataMember(Name = "error")]
        public ErrorInfo Error { get; set; }


        public MarketSummaryResponse()
        {
        }
    }

}
