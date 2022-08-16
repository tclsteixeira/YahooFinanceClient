using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
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

namespace YFClient
{

    /// <summary>
    /// Implements the client class to load Yahoo Finance API data.
    /// </summary>
    public class YahooClient
    {

        // API base address
        private const string base_url = @"https://yfapi.net/";

        // API end points ------

        // resumed quotes info
        private const string url_quotes = @"v6/finance/quote?symbols={0}";

        // option chains data for a particular stock market company
        private const string url_options = @"v7/finance/options/{0}";

        // historical data for various intervals and ranges
        private const string url_spark = @"v8/finance/spark?symbols={0}";

        // very detailed information for a particular ticker symbol
        private const string url_quoteSummary = @"v11/finance/quoteSummary/{0}";

        // chart data
        private const string url_chart = @"v8/finance/chart/{0}";

        // list of similar stocks
        private const string url_recommendationsbysymbol = @"v6/finance/recommendationsbysymbol/{0}";    // {0} = symbol

        // list of most added stocks to the watchlist
        private const string url_screener_predefined = @"ws/screeners/v1/finance/screener/predefined/saved";

        // research insights
        private const string url_insights = base_url + @"ws/insights/v1/finance/insights?symbol={0}";

        // auto complete stock suggestions
        private const string url_autocomplete = @"v6/finance/autocomplete?query={0}&lang={1}&region={2}";

        // live market summary information at the request time
        private const string url_marketSummary = @"v6/finance/quote/marketSummary?lang={0},region={1}";

        // trending stocks in a specific region
        private const string url_trending = @"v1/finance/trending/{0}";// {0}={region}



        #region Modules parameter constants

        /* ******************************************************************
         * Quote summary modules parameter options:
         *        
         * In QuoteSummary all possible modules are -> 
         * 
         * assetProfile
         * %2CsummaryProfile%2CsummaryDetail%2CesgScores%2Cprice%2C
         * incomeStatementHistory%2CincomeStatementHistoryQuarterly%2C
         * balanceSheetHistory%2CbalanceSheetHistoryQuarterly%2C
         * cashflowStatementHistory%2CcashflowStatementHistoryQuarterly%2C
         * defaultKeyStatistics%2CfinancialData%2CcalendarEvents%2CsecFilings%2C
         * recommendationTrend%2CupgradeDowngradeHistory%2CinstitutionOwnership%2CfundOwnership%2C
         * majorDirectHolders%2CmajorHoldersBreakdown%2C
         * insiderTransactions%2CinsiderHolders%2CnetSharePurchaseActivity%2C
         * earnings%2CearningsHistory%2CearningsTrend%2C
         * industryTrend%2CindexTrend%2CsectorTrend
         *         
         **********************************************************************/
        public const string C_STR_MOD_ASSET_PROFILE = "assetProfile";
        public const string C_STR_MOD_SUMMARY_PROFILE = "summaryProfile";
        public const string C_STR_MOD_SUMMARY_DETAIL = "summaryDetail";
        public const string C_STR_MOD_ESG_SCORES = "esgScores";
        public const string C_STR_MOD_PRICE = "price";
        public const string C_STR_MOD_INCOME_STATEMENT_HISTORY = "incomeStatementHistory";
        public const string C_STR_MOD_INCOME_STATEMENT_HISTORY_QUARTERLY = "incomeStatementHistoryQuarterly";
        public const string C_STR_MOD_BALANCE_SHEET_HISTORY = "balanceSheetHistory";
        public const string C_STR_MOD_BALANCE_SHEET_HISTORY_QUARTERLY = "balanceSheetHistoryQuarterly";
        public const string C_STR_MOD_CASH_FLOW_STATETMENT_HISTORY = "cashflowStatementHistory";
        public const string C_STR_MOD_CASH_FLOW_STATETMENT_HISTORY_QUARTERLY = "cashflowStatementHistoryQuarterly";
        public const string C_STR_MOD_DEFAULT_KEY_STATISTICS = "defaultKeyStatistics";
        public const string C_STR_MOD_FINANTIAL_DATA = "financialData";
        public const string C_STR_MOD_CALENDAR_EVENTS = "calendarEvents";
        public const string C_STR_MOD_SECFILINGS = "secFilings";
        public const string C_STR_MOD_RECOMMENDATION_TREND = "recommendationTrend";
        public const string C_STR_MOD_UPGRADE_DOWNGRADE_HISTORY = "upgradeDowngradeHistory";
        public const string C_STR_MOD_INSTITUTION_OWNERSHIP = "institutionOwnership";
        public const string C_STR_MOD_FUND_OWNERSHIP = "fundOwnership";
        public const string C_STR_MOD_MAJOR_DIRECT_HOLDERS = "majorDirectHolders";
        public const string C_STR_MOD_MAJOR_HOLDERS_BREAKDOWN = "majorHoldersBreakdown";
        public const string C_STR_MOD_INSIDER_TRANSACTIONS = "insiderTransactions";
        public const string C_STR_MOD_INSIDER_HOLDERS = "insiderHolders";
        public const string C_STR_MOD_NETSHARE_PURCHASE_ACTIVITY = "netSharePurchaseActivity";
        public const string C_STR_MOD_EARNINGS = "earnings";
        public const string C_STR_MOD_EARNINGS_HISTORY = "earningsHistory";
        public const string C_STR_MOD_EARNINGS_TREND = "earningsTrend";
        public const string C_STR_MOD_INDUSTRY_TREND = "industryTrend";
        public const string C_STR_MOD_INDEX_TREND = "indexTrend";
        public const string C_STR_MOD_SECTOR_TREND = "sectorTrend";

        #endregion Modules parameter constants


        #region Chart parameters constants

        /***********************************************************************
         * 
         *  Chart data paramaters
         * 
         *  range : 1d 5d 1mo 3mo 6mo 1y 5y 10y ytd max  (defaut = 1mo) 
         *  (type string)
         * 
         *  interval : 1m 5m 15m 1d 1wk 1mo  (default = 1d)      
         *  (type string)
         * 
         *  comparisons : The tickers for comparison separated by comma. Max 10 tickers.
         *  (type string)    Ex: MSFT,^VIX        
         *        
         ***********************************************************************/

        public const string C_STR_CHART_RANGE_1d = "1d";
        public const string C_STR_CHART_RANGE_5d = "5d";
        public const string C_STR_CHART_RANGE_1mo = "1mo";  // default
        public const string C_STR_CHART_RANGE_3mo = "3mo";
        public const string C_STR_CHART_RANGE_6mo = "6mo";
        public const string C_STR_CHART_RANGE_1y = "1y";
        public const string C_STR_CHART_RANGE_5y = "5y";
        public const string C_STR_CHART_RANGE_10y = "10y";
        public const string C_STR_CHART_RANGE_ytd = "ytd";
        public const string C_STR_CHART_RANGE_max = "max";

        public const string C_STR_CHART_INTERVAL_1m = "1m";
        public const string C_STR_CHART_INTERVAL_5m = "5m";
        public const string C_STR_CHART_INTERVAL_15m = "15m";
        public const string C_STR_CHART_INTERVAL_1d = "1d"; // default
        public const string C_STR_CHART_INTERVAL_1wk = "1wk";
        public const string C_STR_CHART_INTERVAL_1mo = "1mo";

        #endregion Chart parameters constants


        #region Region parameter constants

        /*
         * Region query parameter
         * 
         * US AU CA FR DE HK US IT ES GB IN
         * 
         */

        public const string C_STR_REGION_US = "US";
        public const string C_STR_REGION_AU = "AU";
        public const string C_STR_REGION_CA = "CA";
        public const string C_STR_REGION_FR = "FR";
        public const string C_STR_REGION_DE = "DE";
        public const string C_STR_REGION_HK = "HK";
        public const string C_STR_REGION_IT = "IT";
        public const string C_STR_REGION_ES = "ES";
        public const string C_STR_REGION_GB = "GB";
        public const string C_STR_REGION_IN = "IN";

        #endregion Region parameter constants


        #region Lang parameter constants

        /*
         * Lang query parameter
         * 
         * en fr de it es zh
         * 
         */

        public const string C_STR_LANG_EN = "en";
        public const string C_STR_LANG_FR = "fr";
        public const string C_STR_LANG_DE = "de";
        public const string C_STR_LANG_IT = "it";
        public const string C_STR_LANG_ES = "es";
        public const string C_STR_LANG_ZH = "zh";

        #endregion Lang parameter constants


        #region Saved Screeners parameter constants

        /*
         * Screener "scrids" query parameter options
         * 
         * Ex:  "day_gainers" -> Stocks ordered in descending order by price percent change with respect to the previous close.
         *      "day_losers" -> Stocks ordered in ascending order by price percent change with respect to the previous close.
         *      "most_shorted_stocks" -> Stocks with the highest short interest positions ordered by short % of shares outstanding from Nasdaq and NYSE reports released every two weeks.
         *      "undervalued_growth_stocks" -> Stocks with earnings growth rates better than 25% and relatively low PE and PEG ratios.
         *      "growth_technology_stocks" -> Technology stocks with revenue and earnings growth in excess of 25%.      
         *      "most_actives" -> Stocks ordered in descending order by intraday trade volume.
         *      "undervalued_large_caps" -> Large cap stocks that are potentially undervalued.
         *      "aggressive_small_caps" -> Small cap stocks with earnings growth rates better than 25%.
         *      "small_cap_gainers" -> Small Caps with a 1 day price change of 5.0% or more.
         *      "top_mutual_funds" -> Funds with Performance Rating of 4 & 5 ordered by Percent Change.
         *      "portfolio_anchors" -> Funds with Performance Rating of 4 & 5 and top-half returns that could serve as a rock-solid core of an investor's portfolio.
         *      "solid_large_growth_funds" -> Large Growth Funds with Performance Rating of 4 & 5 and top-half returns.
         *      "solid_mid-cap_growth_funds" -> Mid-Cap Growth Funds with Performance Rating of 4 & 5 and top-half returns.
         *      "conservative_foreign_funds" -> Foreign funds with Performance Rating of 4 & 5, low risk and top-half returns.
         *      "high_yield_bond" -> High Yield Bond with Performance Rating of 4 & 5, low risk and top-half returns.
         *
         */

        public const string C_STR_SCREENER_day_gainers = "day_gainers";
        public const string C_STR_SCREENER_day_losers = "day_losers";
        public const string C_STR_SCREENER_most_shorted_stocks = "most_shorted_stocks";
        public const string C_STR_SCREENER_undervalued_growth_stocks = "undervalued_growth_stocks";
        public const string C_STR_SCREENER_growth_technology_stocks = "growth_technology_stocks";
        public const string C_STR_SCREENER_most_actives = "most_actives";
        public const string C_STR_SCREENER_undervalued_large_caps = "undervalued_large_caps";
        public const string C_STR_SCREENER_aggressive_small_caps = "aggressive_small_caps";
        public const string C_STR_SCREENER_small_cap_gainers = "small_cap_gainers";
        public const string C_STR_SCREENER_top_mutual_funds = "top_mutual_funds";
        public const string C_STR_SCREENER_portfolio_anchors = "portfolio_anchors";
        public const string C_STR_SCREENER_solid_large_growth_funds = "solid_large_growth_funds";
        public const string C_STR_SCREENER_solid_mid_cap_growth_funds = "solid_midcap_growth_funds";
        public const string C_STR_SCREENER_conservative_foreign_funds = "conservative_foreign_funds";
        public const string C_STR_SCREENER_high_yield_bond = "high_yield_bond";

        #endregion Saved Screeners parameter constants



        public YahooClient(string APIKey) : base()
        {
            this.WebClie = new WebClient(APIKey);
        }


        /// <summary>
        /// Gets or sets the web client instance.
        /// </summary>
        /// <value>The web clieient instance.</value>
        private IWebClient WebClie { get; set; } = null;


        /// <summary>
        /// Builds the parameters list separated by a given separator char.
        /// </summary>
        /// <returns>The parameters list string.</returns>
        /// <param name="parameters">The list of parameters.</param>
        private static string BuildParamsListSepByChar(char sep, params string[] parameters)
        {
            StringBuilder sb = new StringBuilder();

            if ((parameters == null) || (parameters.Length == 0))
                return string.Empty;

            sb.Append(parameters[0]);

            for (int i = 1; i < parameters.Length; i++)
            {
                sb.Append(sep).Append(parameters[i]);
            }

            return sb.ToString();
        }


        /// <summary>
        /// Builds the modules parameter.
        /// </summary>
        /// <returns>Returns the modules parameter string.</returns>
        /// <param name="modules">The list of modules.</param>
        /// <remarks>
        /// 
        ///  ex: modules=module1,module2,...,moduleN
        /// 
        /// </remarks>
        public static string BuildModulesParam(params string[] modules)
        {
            const char C_SEP = ',';
            return BuildParamsListSepByChar(C_SEP, modules);
        }



        #region Json files download methods


        /// <summary>
        /// Downloads the quotes resume json file.
        /// </summary>
        /// <returns>The quotes resume file.</returns>
        /// <param name="stocks">The stocks to retrieve separated by commas.</param>
        /// <remarks>
        /// Ex: stocks = "AAPL, GOOGL, MSFT"
        /// </remarks>
        public async Task<string> DownloadQuotesResumeFile(string stocks)
        {
            string txtData="";

            if (string.IsNullOrWhiteSpace(stocks))
                throw new ArgumentException($"Parameter {nameof(stocks)} is empty.");

            txtData = await this.WebClie.DownloadFile(base_url,  string.Format(YahooClient.url_quotes, stocks));
            return txtData;
        }


        /// <summary>
        /// Downloads the quote options json file.
        /// </summary>
        /// <returns>Return the quote options file JSon.</returns>
        /// <param name="stocks">The stock to retrieve options.</param>
        /// <remarks>
        ///     ex: stocks = "AAPL"
        /// 
        /// </remarks>
        public async Task<string> DownloadOptionsFile(string stocks)
        {
            string txtData;

            if (string.IsNullOrWhiteSpace(stocks))
                throw new ArgumentException($"Parameter {nameof(stocks)} is empty.");

            txtData = await this.WebClie.DownloadFile(YahooClient.base_url, string.Format(YahooClient.url_options, stocks));
            return txtData;
        }


        /// <summary>
        /// Downloads the quote historical data json file.
        /// </summary>
        /// <returns>Return the quote historical data file JSon.</returns>
        /// <param name="stocks">The stock to retrieve.</param>
        /// <remarks>
        ///     ex: stocks = "AAPL, GOOGL"
        /// </remarks>
        public async Task<string> DownloadQuotesHistoricalDataFile(string stocks)
        {
            string txtData="";

            if (string.IsNullOrWhiteSpace(stocks))
                throw new ArgumentException($"Parameter {nameof(stocks)} is empty.");

            txtData = await this.WebClie.DownloadFile(YahooClient.base_url, string.Format(YahooClient.url_spark, stocks));
            return txtData;
        }


        /// <summary>
        /// Downloads the quote summary json file.
        /// </summary>
        /// <returns>Return the quote summary file JSon.</returns>
        /// <param name="stock">The stock to retrieve.</param>
        /// <param name="modules">Is a required parameter. Ex: 'defaultKeyStatistics,assetProfile'</param>
        /// <remarks>
        ///     ex: stocks = "AAPL"
        /// 
        ///     In QuoteSummary all possible modules are -> 
        /// 
        ///    modules = assetProfile,summaryProfile,summaryDetail,esgScores,price,incomeStatementHistory,
        ///              incomeStatementHistoryQuarterly,balanceSheetHistory,balanceSheetHistoryQuarterly,
        ///              cashflowStatementHistory,cashflowStatementHistoryQuarterly,defaultKeyStatistics,
        ///              financialData,calendarEvents,secFilings,recommendationTrend,upgradeDowngradeHistory,
        ///              institutionOwnership,fundOwnership,majorDirectHolders,majorHoldersBreakdown,insiderTransactions,
        ///              insiderHolders,netSharePurchaseActivity,earnings,earningsHistory,earningsTrend,
        ///              industryTrend,indexTrend,sectorTrend
        /// 
        /// </remarks>
        public async Task<string> DownloadQuotesSummaryFile(string stock, string modules)
        {
            string txtData;

            if (string.IsNullOrWhiteSpace(stock))
                throw new ArgumentException($"Parameter {nameof(stock)} is empty.");

            txtData = await this.WebClie.DownloadFile(YahooClient.base_url, string.Format(YahooClient.url_quoteSummary, stock), $"modules={modules}");
            return txtData;
        }


        /// <summary>
        /// Downloads the chart data json file for a given quote.
        /// </summary>
        /// <returns>Return the quote summary file JSon.</returns>
        /// <param name="stock">The stock to retrieve.</param>
        /// <param name="range">The data range (1d 5d 1mo 3mo 6mo 1y 5y 10y ytd max  (defaut = 1mo))</param>
        /// <param name="interval">The chart interval (1m 5m 15m 1d 1wk 1mo  (default = 1d)).</param>
        /// <remarks>
        ///     ex: stocks = "AAPL"
        /// 
        /// </remarks>
        public async Task<string> DownloadChartFile(string stock, string range = "", string interval = "")
        {
            string txtData;

            if (string.IsNullOrWhiteSpace(stock))
                throw new ArgumentException($"Parameter {nameof(stock)} is empty.");

            string parStr = string.Empty;

            if (!string.IsNullOrWhiteSpace(range))
                parStr += "range=" + range;

            if (!string.IsNullOrWhiteSpace(interval))
            {
                if (parStr.Length > 0)
                    parStr += "&";
                parStr += "interval=" + interval;
            }

            txtData = await this.WebClie.DownloadFile(YahooClient.base_url, string.Format(YahooClient.url_chart, stock), parStr); 
            return txtData;
        }


        /// <summary>
        /// Downloads the trending json file.
        /// </summary>
        /// <returns>The trending quotes file.</returns>
        /// <param name="lang">One of the supported language code</param>
        /// <param name="region">One of the supported region code.</param>
        /// <remarks>
        /// 
        /// Ex: lang="en"
        /// Available options are: "en" "fr" "de" "it" "es" "zh"
        /// 
        /// Ex: region = "US"
        /// Available options are: "US", "AU", "CA", "FR", "DE", "HK", "US", "IT", 
        ///                       "ES", "GB", "IN"
        /// </remarks>
        public async Task<string> DownloadMarketSummaryFile(string lang, string region)
        {
            string txtData = "";

            // "en" by default
            lang = (string.IsNullOrWhiteSpace(lang) ? C_STR_LANG_EN : lang);

            // "US" by default
            region = (string.IsNullOrWhiteSpace(region) ? C_STR_REGION_US : region);

            txtData = await this.WebClie.DownloadFile(base_url, string.Format(YahooClient.url_marketSummary, lang, region));
            return txtData;
        }


        /// <summary>
        /// Downloads the trending json file.
        /// </summary>
        /// <returns>The trending quotes file.</returns>
        /// <param name="region">One of the supported region code.</param>
        /// <remarks>
        /// Ex: region = "US"
        /// Available options are "US", "AU", "CA", "FR", "DE", "HK", "US", "IT", 
        ///                       "ES", "GB", "IN"
        /// </remarks>
        public async Task<string> DownloadTrendingFile(string region)
        {
            string txtData = "";

            if (string.IsNullOrWhiteSpace(region))
                throw new ArgumentException($"Parameter {nameof(region)} is empty.");

            txtData = await this.WebClie.DownloadFile(base_url, string.Format(YahooClient.url_trending, region));
            return txtData;
        }


        /// <summary>
        /// Downloads the autocomplete json file.
        /// </summary>
        /// <returns>The trending quotes file.</returns>
        /// <param name="lang">One of the supported language code</param>
        /// <param name="region">One of the supported region code.</param>
        /// <param name="query">The query parameter (required).</param>
        /// <remarks>
        /// 
        /// Ex: lang="en"
        /// Available options are: "en" "fr" "de" "it" "es" "zh"
        /// 
        /// Ex: region = "US"
        /// Available options are: "US", "AU", "CA", "FR", "DE", "HK", "US", "IT", 
        ///                       "ES", "GB", "IN"
        /// 
        /// Ex: query="apple"
        /// 
        /// </remarks>
        public async Task<string> DownloadAutoCompleteFile(string lang, string region, string query)
        {
            string txtData = "";

            // "en" by default
            lang = (string.IsNullOrWhiteSpace(lang) ? C_STR_LANG_EN : lang);

            // "US" by default
            region = (string.IsNullOrWhiteSpace(region) ? C_STR_REGION_US : region);

            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException($"Parameter {nameof(query)} is empty.");

            txtData = await this.WebClie.DownloadFile(base_url, string.Format(YahooClient.url_autocomplete, query, lang, region));
            return txtData;
        }


        /// <summary>
        /// Downloads the research insights json file.
        /// </summary>
        /// <returns>Returns the research insights json file for given symbol.</returns>
        /// <param name="symbol">The symbol to download insights json file.</param>
        /// <remarks>
        /// 
        /// Ex: symbol="AAPL"
        /// 
        /// </remarks>
        public async Task<string> DownloadResearchInsightsFile(string symbol)
        {
            string txtData = "";

            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException($"Parameter {nameof(symbol)} is required.");

            txtData = await this.WebClie.DownloadFile(base_url, string.Format(YahooClient.url_insights, symbol));
            return txtData;
        }


        /// <summary>
        /// Downloads the recommendations by symbol json file.
        /// </summary>
        /// <returns>Returns the recommendations by symbol file for given symbol.</returns>
        /// <param name="symbol">The symbol to get recommendations.</param>
        /// <remarks>
        /// 
        /// Ex: symbol="AAPL"
        /// 
        /// </remarks>
        public async Task<string> DownloadRecommendationsBySymbolFile(string symbol)
        {
            string txtData = "";

            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException($"Parameter {nameof(symbol)} is required.");

            txtData = await this.WebClie.DownloadFile(base_url, string.Format(YahooClient.url_recommendationsbysymbol, symbol));
            return txtData;
        }


        /// <summary>
        /// Downloads the screener json file.
        /// </summary>
        /// <returns>Returns the screener file for given scrids parameter.</returns>
        /// <param name="scrIds">The screener ids query parameter.</param>
        /// <param name="count">Number of returned itens.</param>
        /// <remarks>
        /// 
        /// Ex: count  = 5             
        ///     scrids = "day_gainers, day_losers"  // required
        /// 
        /// </remarks>
        public async Task<string> DownloadScreenerFile(string scrIds, int count = 5)
        {
            string txtData = "";

            if (string.IsNullOrWhiteSpace(scrIds))
                throw new ArgumentException($"Parameter {nameof(scrIds)} is required.");

            string queryParStr = "count=" + count;
            queryParStr += "&";
            queryParStr += "scrIds=" + scrIds;

            txtData = await this.WebClie.DownloadFile(base_url, string.Concat(YahooClient.url_screener_predefined, "?", queryParStr));
            return txtData;
        }


        #endregion Json files download methods



        #region Methods to get class instances filled with Json files quotes data


        /// <summary>
        /// Gets the quotes results.
        /// </summary>
        /// <returns>The quotes results if succeeded.</returns>
        /// <param name="stocks">Stocks string separated by commas.</param>
        /// <remarks>
        ///     ex: stocks = "APPL, GOOGL"
        /// </remarks>
        public async Task<Quote> GetQuotesResults(string stocks)
        {
            Quote FResult = null;
            try
            {
                // download json file
                string json = await this.DownloadQuotesResumeFile( stocks );

                // deserialize to object class
                FResult = Deserialize<Quote>(json);
                FResult.JSonTxt = json;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FResult;
        }


        /// <summary>
        /// Gets the quotes summary results.
        /// </summary>
        /// <returns>The quotes summary results if succeeded.</returns>
        /// <param name="stocks">Stocks string separated by commas.</param>
        /// <remarks>
        ///     ex: stocks = "AAPL"
        ///     ex: modules = "assetProfile,defaultKeyStatistics, ..."  // see constants for available options
        /// </remarks>
        public async Task<SummaryInstance> GetQuoteSummaryResults(string stocks, string modules)
        {
            SummaryInstance FResult = null;
            try
            {
                // download json file
                string json = await this.DownloadQuotesSummaryFile(stocks, modules);

                // deserialize to object class
                FResult = Deserialize<SummaryInstance>(json);
                FResult.JSonTxt = json;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FResult;
        }


        /// <summary>
        /// Gets the market summary symbols.
        /// </summary>
        /// <returns>The market summary symbols if succeeded.</returns>
        /// <param name="lang">One of the supported language code.</param>
        /// <param name="region">Region code.</param>
        /// <remarks>
        ///     ex: region = "US"
        ///     Available options are "US", "AU", "CA", "FR", "DE", "HK", "US", "IT", 
        ///                       "ES", "GB", "IN"
        /// 
        /// </remarks>
        public async Task<MarketSummary> GetMarketSummary( string lang, string region )
        {
            MarketSummary FResult = null;
            try
            {
                // download json file
                string json = await this.DownloadMarketSummaryFile(region, lang);

                // deserialize to object class
                FResult = Deserialize<MarketSummary>(json);
                FResult.JSonTxt = json;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FResult;
        }


        /// <summary>
        /// Gets the trending quotes.
        /// </summary>
        /// <returns>The trending quotes if succeeded.</returns>
        /// <param name="region">Region code.</param>
        /// <remarks>
        ///     ex: region = "US"
        ///     Available options are "US", "AU", "CA", "FR", "DE", "HK", "US", "IT", 
        ///                       "ES", "GB", "IN"
        /// 
        /// </remarks>
        public async Task<TrendingQuotes> GetTrendingQuotes(string region)
        {
            TrendingQuotes FResult = null;
            try
            {
                // download json file
                string json = await this.DownloadTrendingFile(region);

                // deserialize to object class
                FResult = Deserialize<TrendingQuotes>(json);
                FResult.JSonTxt = json;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FResult;
        }


        /// <summary>
        /// Gets the sugested symbols based on a given criteria.
        /// </summary>
        /// <returns>Returns the sugested symbols based on a given criteria if succeeded.</returns>
        /// <param name="lang">One of the supported language code.</param>
        /// <param name="region">Region code.</param>
        /// <param name="query">The query word (required).</param>
        /// <remarks>
        /// 
        ///     Ex: lang="en"
        ///     Available options are: "en" "fr" "de" "it" "es" "zh"
        /// 
        ///     ex: region = "US"
        ///     Available options are "US", "AU", "CA", "FR", "DE", "HK", "US", "IT", 
        ///                       "ES", "GB", "IN"
        /// 
        ///     ex: query="apple"  // get symbols related to the word 'apple'
        /// 
        /// </remarks>
        public async Task<AutoComplete> GetAutoComplete(string query, string lang, string region)
        {
            AutoComplete FResult = null;
            try
            {
                // download json file
                string json = await this.DownloadAutoCompleteFile(lang, region, query);

                // deserialize to object class
                FResult = Deserialize<AutoComplete>(json);
                FResult.JSonTxt = json;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FResult;
        }


        /// <summary>
        /// Gets the research insights data for a given symbol.
        /// </summary>
        /// <returns>Returns the research insights data if succeeded.</returns>
        /// <param name="symbol">The symbol to get its research insitghs data.</param>
        /// <remarks>
        /// 
        ///    Ex: symbol="AAPL"
        /// 
        /// </remarks>
        public async Task<ResearchInsightsInstance> GetResearchInsights(string symbol)
        {
            ResearchInsightsInstance FResult = null;
            try
            {
                // download json file
                string json = await this.DownloadResearchInsightsFile(symbol);

                // deserialize to object class
                FResult = Deserialize<ResearchInsightsInstance>(json);
                FResult.JSonTxt = json;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FResult;
        }


        /// <summary>
        /// Gets the recommended symbos data for a given symbol or group of symbols.
        /// </summary>
        /// <returns>Returns the recommended symbos data for a given symbol or group of symbols if succeeded.</returns>
        /// <param name="symbols">The symbols to get its recommendation data.</param>
        /// <remarks>
        /// 
        ///    Ex: symbol="AAPL,META"
        /// 
        /// </remarks>
        public async Task<RecommendationInstance> GetRecommendationBySymbol(string symbols)
        {
            RecommendationInstance FResult = null;
            try
            {
                // download json file
                string json = await this.DownloadRecommendationsBySymbolFile(symbols);

                // deserialize to object class
                FResult = Deserialize<RecommendationInstance>(json);
                FResult.JSonTxt = json;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FResult;
        }


        /// <summary>
        /// Gets the screeners instance data for a given screener Id or group of screeners Ids.
        /// </summary>
        /// <returns>Returns the screeners instance data for a given screener Id or group of screeners Ids.</returns>
        /// <param name="scrIds">The symbols to get its recommendation data.</param>
        /// <remarks>
        /// 
        ///    Ex: scrIds="day_gainers"
        /// 
        ///    Note: I d'ont know how to set multiple Ids in query string :-(
        /// 
        ///          This doesn't work : scrIds="day_gainers,day_losers"
        /// 
        /// </remarks>
        public async Task<ScreenersInstance> GetScreeners(string scrIds, int count=5)
        {
            ScreenersInstance FResult = null;
            try
            {
                // download json file
                string json = await this.DownloadScreenerFile(scrIds, count);

                // deserialize to object class
                FResult = Deserialize<ScreenersInstance>(json);
                FResult.JSonTxt = json;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FResult;
        }


        /// <summary>
        /// Gets the options instance data for a given stock or group of stocks.
        /// </summary>
        /// <returns>Returns the options instance data for a given stock or group of stocks.</returns>
        /// <param name="stocks">The symbols to get its options data.</param>
        /// <remarks>
        /// 
        ///    Ex: stocks="AAPL"
        /// 
        /// </remarks>
        public async Task<OptionsInstance> GetOptions(string stocks)
        {
            OptionsInstance FResult = null;
            try
            {
                // download json file
                string json = await this.DownloadOptionsFile(stocks);

                // deserialize to object class
                FResult = Deserialize<OptionsInstance>(json);
                FResult.JSonTxt = json;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FResult;
        }


        /// <summary>
        /// Gets the quotes results.
        /// </summary>
        /// <returns>The quotes historical data if succeeded.</returns>
        /// <param name="stocks">Stocks string separated by commas.</param>
        /// <remarks>
        ///     ex: stocks = "APPL, GOOGL"
        /// </remarks>
        public async Task<QuoteHistData> GetQuotesHistData(string stocks)
        {
            QuoteHistData FResult = null;
            try
            {
                // download json file
                string json = await this.DownloadQuotesHistoricalDataFile(stocks);

                if (string.IsNullOrWhiteSpace(json))
                    throw new Exception("Server returned an empty string.");
                else
                {
                    // dirty workarround
                    // DataContratJsonSerializer can not read json text to dictionaries
                    // At least i do not know how to do it :(
                    int startPos = json.IndexOf(":{", StringComparison.InvariantCulture) + 1;
                    int len = json.Length - startPos - 1;
                    json = json.Substring(startPos, len);

                    // deserialize to object class
                    FResult = Deserialize<QuoteHistData>(json);
                    FResult.JSonTxt = json;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FResult;
        }


        /// <summary>
        /// Gets the chart results.
        /// </summary>
        /// <returns>The charts data if succeeded.</returns>
        /// <param name="stocks">Stocks string separated by commas.</param>
        /// <remarks>
        ///     ex: stocks = "APPL, GOOGL"
        /// </remarks>
        public async Task<ChartInstance> GetChartResults(string stocks)
        {
            ChartInstance FResult = null;
            try
            {
                // download json file
                string json = await this.DownloadChartFile(stocks);

                if (string.IsNullOrWhiteSpace(json))
                    throw new Exception("Server returned an empty string.");
                else
                {
                    // deserialize to object class
                    FResult = Deserialize<ChartInstance>(json);
                    FResult.JSonTxt = json;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FResult;
        }


        #endregion Methods to get class instances filled with Json files quotes data




        /// <summary>
        /// Deserialize the specified json file to a compatible object class.
        /// </summary>
        /// <returns>Returns the deserialized class instance.</returns>
        /// <param name="json">The source Json file content.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        private static T Deserialize<T>(string json)
        {
            T obj = Activator.CreateInstance<T>();
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            obj = (T)serializer.ReadObject(ms);
            ms.Close();
            return obj;
        }

    }

}
