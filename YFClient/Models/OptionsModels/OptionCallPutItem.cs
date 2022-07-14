using System;
using System.Runtime.Serialization;

namespace YFClient.Models.OptionsModels
{

    [DataContract]
    public class OptionCallPutItem
    {

        [DataMember(Name = "contractSymbol")]
        public string ContractSymbol { get; set; }

        [DataMember(Name = "strike")]
        public decimal? Strike { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "lastPrice")]
        public decimal? LastPrice { get; set; }

        [DataMember(Name = "change")]
        public decimal? Change { get; set; }

        [DataMember(Name = "percentChange")]
        public decimal? PercentChange { get; set; }

        [DataMember(Name = "volume")]
        public int? Volume { get; set; }

        [DataMember(Name = "openInterest")]
        public decimal? OpenInterest { get; set; }

        [DataMember(Name = "bid")]
        public decimal? Bid { get; set; }

        [DataMember(Name = "ask")]
        public decimal? Ask { get; set; }

        [DataMember(Name = "contractSize")]
        public string ContractSize { get; set; }

        [DataMember(Name = "expiration")]
        public decimal? Expiration { get; set; }

        [DataMember(Name = "lastTradeDate")]
        public decimal? LastTradeDate { get; set; }

        [DataMember(Name = "impliedVolatility")]
        public decimal? ImpliedVolatility { get; set; }

        [DataMember(Name = "inTheMoney")]
        public bool? InTheMoney { get; set; }


        public OptionCallPutItem()
        {
        }
    }
}
