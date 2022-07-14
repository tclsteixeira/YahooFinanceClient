using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module price.
    /// </summary>
    [DataContract]
    public class Price
    {

        [DataMember(Name ="maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "preMarketChangePercent")]
        public FormatedData PreMarketChangePercent { get; set; }

        [DataMember(Name = "preMarketChange")]
        public FormatedData PreMarketChange { get; set; }

        [DataMember(Name = "preMarketTime")]
        public decimal? PreMarketTime { get; set; }

        [DataMember(Name = "preMarketPrice")]
        public FormatedData PreMarketPrice { get; set; }

        [DataMember(Name = "preMarketSource")]
        public string PreMarketSource { get; set; }

        [DataMember(Name = "postMarketChange")]
        public FormatedData PostMarketChange { get; set; }

        [DataMember(Name = "postMarketPrice")]
        public FormatedData PostMarketPrice { get; set; }

        [DataMember(Name = "regularMarketChangePercent")]
        public FormatedData RegularMarketChangePercent { get; set; }

        [DataMember(Name = "regularMarketChange")]
        public FormatedData RegularMarketChange { get; set; }

        [DataMember(Name = "regularMarketTime")]
        public decimal? RegularMarketTime { get; set; }

        [DataMember(Name = "priceHint")]
        public FormatedData PriceHint { get; set; }

        [DataMember(Name = "regularMarketPrice")]
        public FormatedData RegularMarketPrice { get; set; }

        [DataMember(Name = "regularMarketDayHigh")]
        public FormatedData RegularMarketDayHigh { get; set; }

        [DataMember(Name = "regularMarketDayLow")]
        public FormatedData RegularMarketDayLow { get; set; }

        [DataMember(Name = "regularMarketVolume")]
        public FormatedData RegularMarketVolume { get; set; }

        [DataMember(Name = "averageDailyVolume10Day")]
        public FormatedData AverageDailyVolume10Day { get; set; }

        [DataMember(Name = "averageDailyVolume3Month")]
        public FormatedData AverageDailyVolume3Month { get; set; }

        [DataMember(Name = "regularMarketPreviousClose")]
        public FormatedData RegularMarketPreviousClose { get; set; }

        [DataMember(Name = "regularMarketSource")]
        public string RegularMarketSource { get; set; }

        [DataMember(Name = "regularMarketOpen")]
        public FormatedData RegularMarketOpen { get; set; }

        [DataMember(Name = "strikePrice")]
        public FormatedData StrikePrice { get; set; }

        [DataMember(Name = "openInterest")]
        public FormatedData OpenInterest { get; set; }

        [DataMember(Name = "exchange")]
        public string Exchange { get; set; }

        [DataMember(Name = "exchangeName")]
        public string ExchangeName { get; set; }

        [DataMember(Name = "exchangeDataDelayedBy")]
        public decimal? ExchangeDataDelayedBy { get; set; }

        [DataMember(Name = "marketState")]
        public string MarketState { get; set; }

        [DataMember(Name = "quoteType")]
        public string QuoteType { get; set; }

        [DataMember(Name = "symbol")]
        public string Symbol { get; set; }

        [DataMember(Name = "underlyingSymbol")]
        public string UnderlyingSymbol { get; set; }

        [DataMember(Name = "shortName")]
        public string ShortName { get; set; }

        [DataMember(Name = "longName")]
        public string LongName { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "quoteSourceName")]
        public string QuoteSourceName { get; set; }

        [DataMember(Name = "currencySymbol")]
        public string CurrencySymbol { get; set; }

        [DataMember(Name = "fromCurrency")]
        public string FromCurrency { get; set; }

        [DataMember(Name = "toCurrency")]
        public string ToCurrency { get; set; }

        [DataMember(Name = "lastMarket")]
        public string LastMarket { get; set; }

        [DataMember(Name = "volume24Hr")]
        public FormatedData Volume24Hr { get; set; }

        [DataMember(Name = "volumeAllCurrencies")]
        public FormatedData VolumeAllCurrencies { get; set; }

        [DataMember(Name = "circulatingSupply")]
        public FormatedData CirculatingSupply { get; set; }

        [DataMember(Name = "marketCap")]
        public FormatedData MarketCap { get; set; }


        public Price()
        {
        }

    }

}
