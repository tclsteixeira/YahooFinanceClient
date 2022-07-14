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
//using System.Threading.Tasks;
using YFClient;
using YFClient.Models;
using YFClient.Models.AutoCompleteModels;
using YFClient.Models.ChartDataModels;
using YFClient.Models.HistDataModels;
using YFClient.Models.MarketSummary;
using YFClient.Models.OptionsModels;
using YFClient.Models.QuoteSummaryModels;
using YFClient.Models.RecommendationsModels;
using YFClient.Models.ResearchInsightsModels;
using YFClient.Models.ScreenersModels;
using YFClient.Models.Trending;

namespace YFSharp
{

    /// <summary>
    /// Class to test YAHOO Finance API client library (YFClient.cs).
    /// </summary>
    public class YAHOOFinanceFullTest
    {
        // Your API key
        // To get an API key, subscribe the free plan at https://www.yahoofinanceapi.com/tutorial
        private readonly string APIKey = "put_here_your_API_Key";


        public YAHOOFinanceFullTest()
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
                    Console.WriteLine();
                }

                /*
                 * QUOTE HISTORY DATA               
                */

                QuoteHistData hist = await client.GetQuotesHistData("AAPL");

                if (hist != null)
                {
                    //QuoteResponseResultItem item = results.QuoteResponse.Results[0];

                    Console.WriteLine($"Stocks historical data for 'AAPL':");
                    Console.WriteLine();
                    Console.WriteLine("Symbol: " + hist.symbol);
                    Console.WriteLine("Data Granularity: " + hist.DataGranularity);
                    Console.WriteLine("Start: " + hist.Start);
                    Console.WriteLine("End: " + hist.End);
                    Console.WriteLine("Previous Close: " + hist.PreviousClose);
                    Console.WriteLine("Chart Previous Close: " + hist.ChartPreviousClose);
                    Console.WriteLine("TimeStamps: " + hist.TimeStamps);
                    Console.WriteLine("Values: " + hist.Values);


                //    //Console.WriteLine(item.symbol);

                    Console.WriteLine();
                    Console.WriteLine("-------- End history---------");
                    Console.WriteLine();
                }


                /*
                 * SUMMARY DATA               
                */

                // get summary data for all modules ("modules" is a required query parameter
                // for this api end point)
                // Note: you can choose only the modules you want
                string modules = YahooClient.BuildModulesParam(
                   YahooClient.C_STR_MOD_ASSET_PROFILE,
                   YahooClient.C_STR_MOD_DEFAULT_KEY_STATISTICS,
                   YahooClient.C_STR_MOD_PRICE, YahooClient.C_STR_MOD_EARNINGS,
                   YahooClient.C_STR_MOD_ESG_SCORES, YahooClient.C_STR_MOD_SECFILINGS,
                   YahooClient.C_STR_MOD_INDEX_TREND, YahooClient.C_STR_MOD_SECTOR_TREND,
                   YahooClient.C_STR_MOD_EARNINGS_TREND, YahooClient.C_STR_MOD_FINANTIAL_DATA,
                   YahooClient.C_STR_MOD_FUND_OWNERSHIP, YahooClient.C_STR_MOD_INDUSTRY_TREND,
                   YahooClient.C_STR_MOD_SUMMARY_DETAIL, YahooClient.C_STR_MOD_CALENDAR_EVENTS,
                   YahooClient.C_STR_MOD_INSIDER_HOLDERS, YahooClient.C_STR_MOD_SUMMARY_PROFILE,
                   YahooClient.C_STR_MOD_EARNINGS_HISTORY, YahooClient.C_STR_MOD_INSIDER_TRANSACTIONS,
                   YahooClient.C_STR_MOD_MAJOR_DIRECT_HOLDERS, YahooClient.C_STR_MOD_RECOMMENDATION_TREND,
                   YahooClient.C_STR_MOD_BALANCE_SHEET_HISTORY, YahooClient.C_STR_MOD_INSTITUTION_OWNERSHIP,
                   YahooClient.C_STR_MOD_MAJOR_HOLDERS_BREAKDOWN, YahooClient.C_STR_MOD_INCOME_STATEMENT_HISTORY,
                   YahooClient.C_STR_MOD_UPGRADE_DOWNGRADE_HISTORY, YahooClient.C_STR_MOD_NETSHARE_PURCHASE_ACTIVITY,
                   YahooClient.C_STR_MOD_NETSHARE_PURCHASE_ACTIVITY, YahooClient.C_STR_MOD_CASH_FLOW_STATETMENT_HISTORY,
                   YahooClient.C_STR_MOD_BALANCE_SHEET_HISTORY_QUARTERLY, YahooClient.C_STR_MOD_INCOME_STATEMENT_HISTORY_QUARTERLY,
                   YahooClient.C_STR_MOD_CASH_FLOW_STATETMENT_HISTORY_QUARTERLY
                );

                // if you just want the json file uncomment next line
                string summaryJson = await client.DownloadQuotesSummaryFile("AAPL", modules);
                Console.WriteLine("Summary json file loaded successfully.");

                // Load summary into class instance for 'AAPL' quote
                SummaryInstance summary = await client.GetQuoteSummaryResults("AAPL", modules);
                Console.WriteLine("Summary instance data loaded successfully.");


                /*
                * CHART DATA
                */

                // Load json file with quote's chart data for 'AAPL' quote
                string chartJson = await client.DownloadChartFile("AAPL");
                Console.WriteLine("Chart json file loaded successfully.");

                // Load chart data into class instance for 'AAPL' quote
                ChartInstance chart = await client.GetChartResults("AAPL");
                Console.WriteLine("Chart instance data loaded successfully.");


                /*
                 * TRENDING DATA               
                */

                // Load json file with trending data
                string trendingJson = await client.DownloadTrendingFile(YahooClient.C_STR_REGION_US);
                Console.WriteLine("Trending json file loaded successfully.");

                // Load trending data into class instance
                TrendingQuotes trend = await client.GetTrendingQuotes(YahooClient.C_STR_REGION_US);
                Console.WriteLine("Trending instance data loaded successfully.");


                /*
                 * MARKET SUMMARY DATA               
                */

                // Load json file with market summary data
                string marketSummaryJson = await client.DownloadMarketSummaryFile(YahooClient.C_STR_LANG_EN, YahooClient.C_STR_REGION_US);
                Console.WriteLine("Market summary json file loaded successfully.");

                // Load market summary data into class instance
                MarketSummary markSumm = await client.GetMarketSummary(YahooClient.C_STR_LANG_EN, YahooClient.C_STR_REGION_US);
                Console.WriteLine("Market summary instance data loaded successfully.");


                /*
                 * AUTOCOMPLETE DATA               
                */

                // Load json file with autocomplete data related to word 'apple' in this case
                string autoCompleteJson = await client.DownloadAutoCompleteFile(YahooClient.C_STR_LANG_EN, YahooClient.C_STR_REGION_US, "apple");
                Console.WriteLine("Autocomplete json file loaded successfully.");

                // Load autocomplete data into class instance related with word 'apple'
                AutoComplete autoComp = await client.GetAutoComplete("apple", YahooClient.C_STR_LANG_EN, YahooClient.C_STR_REGION_US );
                Console.WriteLine("Autocomplete instance data related with 'apple' loaded successfully.");


                /*
                 * RESEARCH INSIGHTS DATA               
                */

                // Load json file with insights data related to word 'apple' in this case
                string insightsJson = await client.DownloadResearchInsightsFile("AAPL");
                Console.WriteLine("Research insights json file loaded successfully.");

                // Load insights data into class instance for 'AAPL' quote
                ResearchInsightsInstance insights = await client.GetResearchInsights("AAPL");
                Console.WriteLine("Research insights instance data loaded successfully.");


                /*
                 * RECOMMENDATIONS BY SYMBOL DATA               
                */

                // Load json file with recommendations data for 'AAPL' quote
                string recommendationsJson = await client.DownloadRecommendationsBySymbolFile("AAPL");
                Console.WriteLine("Recommendations by symbol json file loaded successfully.");

                // Load recommendations data into class instance for 'AAPL' quote
                RecommendationInstance recBySymbol = await client.GetRecommendationBySymbol("AAPL");
                Console.WriteLine("Recommendations instance data loaded successfully.");


                /*
                 * SAVED SCREENERS DATA               
                */

                // Load json file with screener data for a given screener Id
                string screenerJson = await client.DownloadScreenerFile(YahooClient.C_STR_SCREENER_day_losers, 5);
                Console.WriteLine("Saved screener json file loaded successfully.");

                // Load screener data into class instance for screener id="day_losers"
                ScreenersInstance screeners = await client.GetScreeners(YahooClient.C_STR_SCREENER_day_losers, 5);
                Console.WriteLine("Screener instance data loaded successfully.");


                /*
                 * QUOTE OPTIONS DATA               
                */

                // Load json file with options data for quote 'AAPL'
                string optionsJson = await client.DownloadOptionsFile("AAPL");
                Console.WriteLine("Options json file loaded successfully.");

                // Load options data into class instance for quote 'AAPL'
                OptionsInstance options = await client.GetOptions("AAPL");
                Console.WriteLine("Options instance data loaded successfully.");

                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("Done.");

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


