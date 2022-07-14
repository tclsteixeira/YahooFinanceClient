/******************************************************************************
 *                                                                            *
 * Test Yahoo finance (v6 and v7) api client library.                               *
 *                                                                            *
 * In order to use Yahoo finance services you must have an API key.           *
 * To subscribe the free plan go to https://www.yahoofinanceapi.com/tutorial  *
 *      
 * LICENSE
 * 
 * Copyright (c) 2022 Massachusetts Institute of Technology                                                                    *
 * Copyright (c) 2022 Tiago C. Teixeira
 *
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the
 * "Software"), to deal in the Software without restriction, including
 * without limitation the rights to use, copy, modify, merge, publish,
 * distribute, sublicense, and/or sell copies of the Software, and to
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
 * LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
 * OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
 * WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */



using System;
using YFClient;
using YFClient.Models;

namespace YFSharp
{

    /// <summary>
    /// Class to test YAHOO Finance API client library (YFClient.cs).
    /// </summary>
    public class YAHOOFinanceShortTest
    {
        // Your API key
        //private readonly string APIKey = "put_here_your_API_Key";
        private readonly string APIKey = "HeNhDPG5lE8wlllC4cJIL5jxiPI3c7B1edeVMgp4";


        public YAHOOFinanceShortTest()
        {
        }


        /// <summary>
        /// Tests the Yahoo Finance API client library 'YFClient'.
        /// </summary>
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
                Quote results = client.GetQuotesResults("AAPL").Result;

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
            catch (Exception ex)
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
