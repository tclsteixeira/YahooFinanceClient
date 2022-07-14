using System;
using System.Runtime.Serialization;
using YFClient.Models.QuoteSummaryModels;

namespace YFClient.Models.MarketSummary
{

    [DataContract]
    public class MarketSummaryResultItem
    {

        [DataMember(Name = "FullExchangeName")]
        public string FullExchangeName { get; set; }

        [DataMember(Name = "symbol")]
        public string Symbol { get; set; }

        [DataMember(Name = "gmtOffSetMilliseconds")]
        public decimal? GmtOffSetMilliseconds { get; set; }

        [DataMember(Name = "language")]
        public string Language { get; set; }

        [DataMember(Name = "regularMarketTime")]
        public FormatedData RegularMarketTime { get; set; }

        [DataMember(Name = "regularMarketChangePercent")]
        public FormatedData RegularMarketChangePercent { get; set; }

        [DataMember(Name = "quoteType")]
        public string QuoteType { get; set; }

        [DataMember(Name = "typeDisp")]
        public string TypeDisp { get; set; }

        [DataMember(Name = "tradeable")]
        public bool Tradeable { get; set; }

        [DataMember(Name = "regularMarketPreviousClose")]
        public FormatedData RegularMarketPreviousClose { get; set; }

        [DataMember(Name = "exchangeTimezoneName")]
        public string ExchangeTimezoneName { get; set; }

        [DataMember(Name = "regularMarketChange")]
        public FormatedData RegularMarketChange { get; set; }

        [DataMember(Name = "exchangeDataDelayedBy")]
        public decimal? ExchangeDataDelayedBy { get; set; }

        [DataMember(Name = "firstTradeDateMilliseconds")]
        public decimal? FirstTradeDateMilliseconds { get; set; }

        [DataMember(Name = "exchangeTimezoneShortName")]
        public string ExchangeTimezoneShortName { get; set; }

        [DataMember(Name = "customPriceAlertConfidence")]
        public string CustomPriceAlertConfidence { get; set; }

        [DataMember(Name = "regularMarketPrice")]
        public FormatedData RegularMarketPrice { get; set; }

        [DataMember(Name = "marketState")]
        public string MarketState { get; set; }

        [DataMember(Name = "market")]
        public string Market { get; set; }

        [DataMember(Name = "quoteSourceName")]
        public string QuoteSourceName { get; set; }

        [DataMember(Name = "priceHint")]
        public decimal? PriceHint { get; set; }

        [DataMember(Name = "sourceInterval")]
        public decimal? SourceInterval { get; set; }

        [DataMember(Name = "exchange")]
        public string Exchange { get; set; }

        [DataMember(Name = "shortName")]
        public string ShortName { get; set; }

        [DataMember(Name = "region")]
        public string Region { get; set; }

        [DataMember(Name = "triggerable")]
        public bool Triggerable { get; set; }


        public MarketSummaryResultItem()
        {
        }

    }

}
