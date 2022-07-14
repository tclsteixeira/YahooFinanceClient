using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ChartDataModels
{

    [DataContract]
    public class ChartMeta
    {
        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "symbol")]
        public string Symbol { get; set; }

        [DataMember(Name = "exchangeName")]
        public string ExchangeName { get; set; }

        [DataMember(Name = "instrumentType")]
        public string InstrumentType { get; set; }

        [DataMember(Name = "firstTradeDate")]
        public decimal FirstTradeDate { get; set; }

        [DataMember(Name = "regularMarketTime")]
        public decimal RegularMarketTime { get; set; }

        [DataMember(Name = "gmtoffset")]
        public decimal Gmtoffset { get; set; }

        [DataMember(Name = "timezone")]
        public string TimeZone { get; set; }

        [DataMember(Name = "exchangeTimezoneName")]
        public string ExchangeTimezoneName { get; set; }

        [DataMember(Name = "regularMarketPrice")]
        public decimal RegularMarketPrice { get; set; }

        [DataMember(Name = "chartPreviousClose")]
        public decimal ChartPreviousClose { get; set; }

        [DataMember(Name = "previousClose")]
        public Decimal PreviousClose { get; set; }

        [DataMember(Name = "scale")]
        public decimal Scale { get; set; }

        [DataMember(Name = "priceHint")]
        public decimal PriceHint { get; set; }

        [DataMember(Name = "currentTradingPeriod")]
        public CurrentTradingPeriod CurrentTradingPeriod { get; set; }

        [DataMember(Name = "tradingPeriods")]
        public Period[][] TradingPeriods { get; set; }

        [DataMember(Name = "dataGranularity")]
        public string DataGranularity { get; set; }

        [DataMember(Name = "range")]
        public string Range { get; set; }

        [DataMember(Name = "validRanges")]
        public string[] ValidRanges { get; set; }



        public ChartMeta()
        {
        }
    }

}
