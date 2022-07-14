using System;
using System.Runtime.Serialization;

namespace YFClient.Models
{
    [DataContract]
    public class QuoteResponseResultItem
    {
        [DataMember(Name = "language")]
        public string Language { get; set; }

        [DataMember(Name = "region")]
        public string Region { get; set; }

        [DataMember(Name = "quoteType")]
        public string QuoteType { get; set; }

        [DataMember(Name = "typeDisp")]
        public string TypeDisp { get; set; }

        [DataMember(Name = "quoteSourceName")]
        public string QuoteSourceName { get; set; }

        [DataMember(Name = "triggerable")]
        public bool? Triggerable { get; set; }

        [DataMember(Name = "customPriceAlertConfidence")]
        public string CustomPriceAlertConfidence { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "marketState")]
        public string MarketState { get; set; }

        [DataMember(Name = "firstTradeDateMilliseconds")]
        public decimal? FirstTradeDateMilliseconds { get; set; }

        [DataMember(Name = "priceHint")]
        public long? PriceHint { get; set; }

        [DataMember(Name = "regularMarketChange")]
        public decimal? RegularMarketChange { get; set; }

        [DataMember(Name = "regularMarketChangePercent")]
        public decimal? RegularMarketChangePercent { get; set; }

        [DataMember(Name = "regularMarketTime")]
        public decimal? RegularMarketTime { get; set; }

        [DataMember(Name = "regularMarketPrice")]
        public decimal? RegularMarketPrice { get; set; }

        [DataMember(Name = "regularMarketDayHigh")]
        public decimal? RegularMarketDayHigh { get; set; }

        [DataMember(Name = "regularMarketDayRange")]
        public string RegularMarketDayRange { get; set; }

        [DataMember(Name = "regularMarketDayLow")]
        public decimal? RegularMarketDayLow { get; set; }

        [DataMember(Name = "regularMarketVolume")]
        public decimal? RegularMarketVolume { get; set; }

        [DataMember(Name = "regularMarketPreviousClose")]
        public decimal? RegularMarketPreviousClose { get; set; }

        [DataMember(Name = "bid")]
        public decimal? Bid { get; set; }

        [DataMember(Name = "ask")]
        public decimal? Ask { get; set; }

        [DataMember(Name = "bidSize")]
        public decimal? BidSize { get; set; }

        [DataMember(Name = "exchange")]
        public string Exchange { get; set; }

        [DataMember(Name = "shortName")]
        public string ShortName { get; set; }

        [DataMember(Name = "longName")]
        public string LongName { get; set; }

        [DataMember(Name = "messageBoardId")]
        public string MessageBoardId { get; set; }

        [DataMember(Name = "exchangeTimezoneName")]
        public string ExchangeTimezoneName { get; set; }

        [DataMember(Name = "exchangeTimezoneShortName")]
        public string ExchangeTimezoneShortName { get; set; }

        [DataMember(Name = "gmtOffSetMilliseconds")]
        public decimal? GmtOffSetMilliseconds { get; set; }

        [DataMember(Name = "market")]
        public string Market { get; set; }

        [DataMember(Name = "esgPopulated")]
        public string EsgPopulated { get; set; }

        [DataMember(Name = "pageViewGrowthWeekly")]
        public decimal? PageViewGrowthWeekly { get; set; }

        [DataMember(Name = "averageAnalystRating")]
        public string AverageAnalystRating { get; set; }

        [DataMember(Name = "tradeable")]
        public bool? Tradeable { get; set; }

        [DataMember(Name = "askSize")]
        public decimal? AskSize { get; set; }

        [DataMember(Name = "fullExchangeName")]
        public string FullExchangeName { get; set; }

        [DataMember(Name = "financialCurrency")]
        public string FinancialCurrency { get; set; }

        [DataMember(Name = "regularMarketOpen")]
        public decimal? RegularMarketOpen { get; set; }

        [DataMember(Name = "averageDailyVolume3Month")]
        public decimal? AverageDailyVolume3Month { get; set; }

        [DataMember(Name = "averageDailyVolume10Day")]
        public decimal? AverageDailyVolume10Day { get; set; }

        [DataMember(Name = "fiftyTwoWeekLowChange")]
        public decimal? FiftyTwoWeekLowChange { get; set; }

        [DataMember(Name = "fiftyTwoWeekLowChangePercent")]
        public decimal? FiftyTwoWeekLowChangePercent { get; set; }

        [DataMember(Name = "fiftyTwoWeekRange")]
        public string FiftyTwoWeekRange { get; set; }

        [DataMember(Name = "fiftyTwoWeekHighChange")]
        public decimal? FiftyTwoWeekHighChange { get; set; }

        [DataMember(Name = "fiftyTwoWeekHighChangePercent")]
        public decimal? FiftyTwoWeekHighChangePercent { get; set; }

        [DataMember(Name = "fiftyTwoWeekLow")]
        public decimal? FiftyTwoWeekLow { get; set; }

        [DataMember(Name = "fiftyTwoWeekHigh")]
        public decimal? FiftyTwoWeekHigh { get; set; }

        [DataMember(Name = "dividendDate")]
        public decimal? DividendDate { get; set; }

        [DataMember(Name = "earningsTimestamp")]
        public decimal? EarningsTimestamp { get; set; }

        [DataMember(Name = "earningsTimestampStart")]
        public decimal? EarningsTimestampStart { get; set; }

        [DataMember(Name = "earningsTimestampEnd")]
        public decimal? EarningsTimestampEnd { get; set; }

        [DataMember(Name = "trailingAnnualDividendRate")]
        public decimal? TrailingAnnualDividendRate { get; set; }

        [DataMember(Name = "trailingPE")]
        public decimal? TrailingPE { get; set; }

        [DataMember(Name = "trailingAnnualDividendYield")]
        public decimal? TrailingAnnualDividendYield { get; set; }

        [DataMember(Name = "epsTrailingTwelveMonths")]
        public decimal? EpsTrailingTwelveMonths { get; set; }

        [DataMember(Name = "epsForward")]
        public decimal? EpsForward { get; set; }

        [DataMember(Name = "epsCurrentYear")]
        public decimal? EpsCurrentYear { get; set; }

        [DataMember(Name = "priceEpsCurrentYear")]
        public decimal? PriceEpsCurrentYear { get; set; }

        [DataMember(Name = "sharesOutstanding")]
        public decimal? SharesOutstanding { get; set; }

        [DataMember(Name = "bookValue")]
        public decimal? BookValue { get; set; }

        [DataMember(Name = "fiftyDayAverage")]
        public decimal? FiftyDayAverage { get; set; }

        [DataMember(Name = "fiftyDayAverageChange")]
        public decimal? FiftyDayAverageChange { get; set; }

        [DataMember(Name = "fiftyDayAverageChangePercent")]
        public decimal? FiftyDayAverageChangePercent { get; set; }

        [DataMember(Name = "twoHundredDayAverage")]
        public decimal? TwoHundredDayAverage { get; set; }

        [DataMember(Name = "twoHundredDayAverageChange")]
        public decimal? TwoHundredDayAverageChange { get; set; }

        [DataMember(Name ="twoHundredDayAverageChangePercent")]
        public decimal? TwoHundredDayAverageChangePercent { get; set; }

        [DataMember(Name = "marketCap")]
        public decimal? MarketCap { get; set; }

        [DataMember(Name = "forwardPE")]
        public decimal? ForwardPE { get; set; }

        [DataMember(Name = "priceToBook")]
        public decimal? PriceToBook { get; set; }

        [DataMember(Name = "sourceInterval")]
        public decimal? SourceInterval { get; set; }

        [DataMember(Name = "exchangeDataDelayedBy")]
        public decimal? ExchangeDataDelayedBy { get; set; }

        [DataMember(Name = "displayName")]
        public string DisplayName { get; set; }

        [DataMember(Name = "symbol")]
        public string Symbol { get; set; }


        public QuoteResponseResultItem()
        {

            //"language":"en-US","region":"US","quoteType":"EQUITY",
            //"typeDisp":"Equity","quoteSourceName":"Nasdaq Real Time Price",
            //"triggerable":true,"customPriceAlertConfidence":"HIGH","currency":"USD","marketState":"REGULAR",
            //\"firstTradeDateMilliseconds\":345479400000,\"priceHint\":2,\"regularMarketChange\":0.13999939,\"" +
            	//"regularMarketChangePercent\":0.08363166,\"regularMarketTime\":1650483735,\"regularMarketPrice\":167.54," +
            	//"\"regularMarketDayHigh\":168.86,\"regularMarketDayRange\":\"166.1 - 168.86\",\"regularMarketDayLow\":166.1," +
            	//"\"regularMarketVolume\":53817784,\"regularMarketPreviousClose\":167.4,\"bid\":167.45,\"ask\":167.46," +
            	//"\"bidSize\":13,\"exchange\":\"NMS\",\"shortName\":\"Apple Inc.\"," +
            	//"\"longName\":\"Apple Inc.\",\"messageBoardId\":\"finmb_24937\",\"exchangeTimezoneName\":\"America/New_York\",\"exchangeTimezoneShortName\":\"EDT\",\"gmtOffSetMilliseconds\":-14400000," +
            	//"\"market\":\"us_market\",\"esgPopulated\":false,\"pageViewGrowthWeekly\":-0.02690424,\"averageAnalystRating\":\"1.9 - Buy\"," +
            	//"\"tradeable\":false,\"askSize\":10,\"fullExchangeName\":\"NasdaqGS\",\"financialCurrency\":\"USD\"," +
            	//"\"regularMarketOpen\":168.76,\"averageDailyVolume3Month\":92470895,\"averageDailyVolume10Day\":75059090,\"fiftyTwoWeekLowChange\":45.289993," +
            	//"\"fiftyTwoWeekLowChangePercent\":0.3704703,\"fiftyTwoWeekRange\":\"122.25 - 182.94\",\"fiftyTwoWeekHighChange\":-15.400009,\"fiftyTwoWeekHighChangePercent\":-0.08418065," +
            	//"\"fiftyTwoWeekLow\":122.25,\"fiftyTwoWeekHigh\":182.94,\"dividendDate\":1644451200,\"earningsTimestamp\":1651176000,\"earningsTimestampStart\":1651176000," +
            	//"\"earningsTimestampEnd\":1651176000,\"trailingAnnualDividendRate\":0.865,\"trailingPE\":27.853699,\"trailingAnnualDividendYield\":0.0051672645,\"epsTrailingTwelveMonths\":6.015," +
            	//"\"epsForward\":6.57,\"epsCurrentYear\":6.17,\"priceEpsCurrentYear\":27.153969,\"sharesOutstanding\":16319399936,\"bookValue\":4.402," +
            	//"\"fiftyDayAverage\":167.5322,\"fiftyDayAverageChange\":0.007797241,\"fiftyDayAverageChangePercent\":4.6541747E-5,\"twoHundredDayAverage\":158.64494," +
            	//"\"twoHundredDayAverageChange\":8.89505,\"twoHundredDayAverageChangePercent\":0.056068916,\"marketCap\":2734152220672,\"forwardPE\":25.50076," +
            	//"\"priceToBook\":38.05997,\"sourceInterval\":15,\"exchangeDataDelayedBy\":0,\"displayName\":\"Apple\"," +
            	//"\"symbol\":\"AAPL\"}],\"error\":null}}
        }

    }
}
