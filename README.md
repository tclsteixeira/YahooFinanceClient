## YFClient  
  
  **YFClient** is a csharp self-contained client library that provides full access to the 2022 Yahoo Finance API.
In order to use it you must have an API key. If you don't have one yet you can subscribe the free plan at [https://www.yahoofinanceapi.com/tutorial](https://www.yahoofinanceapi.com/tutorial).


### Usage example

```csharp
using System;
using YFClient;
using YFClient.Models;

namespace YFSharp
{

    /// <summary>
    /// Class to test YAHOO Finance API client library (YFClient.cs).
    /// </summary>
    public class YAHOOFinanceTest
    {
        // Your API key
        private readonly string APIKey = "put_here_your_API_Key";
       
        public YAHOOFinanceTest()
        {
        }


        /// <summary>
        /// Tests the Yahoo Finance API client library 'YFClient'.
        /// </summary>
	/// <remarks>
	/// Tested with Mono version 6.12.0.182 on a Debian 11 OS.
	/// </remarks>
        public async void Teste()
        {
            try
            {
                Console.WriteLine(" ----- Test Yahoo Finance client library -----");
                Console.WriteLine();

                // must provide your Yahoo API key
                YahooClient client = new YahooClient(this.APIKey);

                // There are two ways to work with this library:
                //
                //  1- You can get the data directly from the returned json file and
                //     process the data yourself, 
                //  
                //     Ex: string marketSummaryJson = await client.DownloadMarketSummaryFile(YahooClient.C_STR_LANG_EN, YahooClient.C_STR_REGION_US);
                //
                //  or
                //
                //  2- you can get a class instance with fields already filled 
                //     with data returned in the json file.
                //
                //     Ex: MarketSummary markSumm = await client.GetMarketSummary(YahooClient.C_STR_LANG_EN, YahooClient.C_STR_REGION_US);
                // 


                // Get resumed quote info
                Quote results =  client.GetQuotesResults("AAPL").Result;

                if (results != null)
                {
                    QuoteResponseResultItem item = results.QuoteResponse.Results[0];

                    Console.WriteLine($"Stocks result for 'AAPL':");
                    Console.WriteLine();
                    Console.WriteLine("Symbol: " + item.Symbol);
                    Console.WriteLine("Display Name: " + item.DisplayName);
                    Console.WriteLine("Quote Source Name: " + item.QuoteSourceName);
                    Console.WriteLine("Short Name: " + item.ShortName);
                    Console.WriteLine("Long Name: " + item.LongName);
                    Console.WriteLine("Currency: " + item.Currency);
                    Console.WriteLine("Financial Currency: " + item.FinancialCurrency);
                    Console.WriteLine("Language: " + item.Language);
                    Console.WriteLine("Market: " + item.Market);
                    Console.WriteLine("Market State: " + item.MarketState);
                    Console.WriteLine("Regular Market Price: " + item.RegularMarketPrice);
                    Console.WriteLine("Regular Market Day Hight: " + item.RegularMarketDayHigh);
                    Console.WriteLine("Regular Market Day Low: " + item.RegularMarketDayLow);
                    Console.WriteLine("Ask: " + item.Ask);
                    Console.WriteLine("Ask Size: " + item.AskSize);
                    Console.WriteLine("Bid: " + item.Bid);
                    Console.WriteLine("Bid Size: " + item.BidSize);

                    Console.WriteLine();
                    Console.WriteLine("-------- End resumed quote info ---------");
                }
	    }
	    catch(Exception ex)
	    {
		if (!WebClient.IsInternetAvailable())
                    Console.WriteLine("Host not found! Please check your internet connection.");
                else
                    Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.ToString());
	    }
	}
    }
}
```


<i>Copyright (c) 2022 Tiago C. Teixeira</i>

  


> Written with [StackEdit](https://stackedit.io/).
