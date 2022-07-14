using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Default keystatistics is one of the possible modules.
    /// </summary>
    [DataContract]
    public class DefaultKeyStatistics
    {

        // TODO: Some fields missing (unknown types)

        [DataMember(Name ="maxAge")]
        public int MaxAge { get; set; }

        [DataMember(Name = "priceHint")]
        public FormatedData PriceHint { get; set; }

        [DataMember(Name = "enterpriseValue")]
        public FormatedData EnterpriseValue { get; set; }

        [DataMember(Name = "forwardPE")]
        public FormatedData ForwardPE { get; set; }

        [DataMember(Name = "profitMargins")]
        public FormatedData ProfitMargins { get; set; }

        [DataMember(Name = "floatShares")]
        public FormatedData FloatShares { get; set; }

        [DataMember(Name = "sharesOutstanding")]
        public FormatedData SharesOutstanding { get; set; }

        [DataMember(Name = "sharesShort")]
        public FormatedData SharesShort { get; set; }

        [DataMember(Name = "sharesShortPriorMonth")]
        public FormatedData SharesShortPriorMonth { get; set; }

        [DataMember(Name = "sharesShortPreviousMonthDate")]
        public FormatedData SharesShortPreviousMonthDate { get; set; }

        [DataMember(Name = "dateShortInterest")]
        public FormatedData DateShortInterest { get; set; }

        [DataMember(Name = "sharesPercentSharesOut")]
        public FormatedData SharesPercentSharesOut { get; set; }

        [DataMember(Name = "heldPercentInsiders")]
        public FormatedData HeldPercentInsiders { get; set; }

        [DataMember(Name = "heldPercentInstitutions")]
        public FormatedData HeldPercentInstitutions { get; set; }

        [DataMember(Name = "shortRatio")]
        public FormatedData ShortRatio { get; set; }

        [DataMember(Name = "shortPercentOfFloat")]
        public FormatedData ShortPercentOfFloat { get; set; }

        [DataMember(Name = "impliedSharesOutstanding")]
        public FormatedData ImpliedSharesOutstanding { get; set; }

        [DataMember(Name = "morningStarOverallRating")]
        public FormatedData MorningStarOverallRating { get; set; }

        [DataMember(Name = "morningStarRiskRating")]
        public FormatedData MorningStarRiskRating { get; set; }

        // ?????????????
        //DataMember(Name = "category")]
        //public FormatedData PriceHint { get; set; }

        [DataMember(Name = "bookValue")]
        public FormatedData BookValue { get; set; }

        [DataMember(Name = "priceToBook")]
        public FormatedData PriceToBook { get; set; }

        [DataMember(Name = "annualReportExpenseRatio")]
        public FormatedData AnnualReportExpenseRatio { get; set; }

        [DataMember(Name = "lastFiscalYearEnd")]
        public FormatedData LastFiscalYearEnd { get; set; }

        [DataMember(Name = "nextFiscalYearEnd")]
        public FormatedData NextFiscalYearEnd { get; set; }

        [DataMember(Name = "mostRecentQuarter")]
        public FormatedData MostRecentQuarter { get; set; }

        [DataMember(Name = "earningsQuarterlyGrowth")]
        public FormatedData EarningsQuarterlyGrowth { get; set; }

        [DataMember(Name = "netIncomeToCommon")]
        public FormatedData NetIncomeToCommon { get; set; }

        [DataMember(Name = "trailingEps")]
        public FormatedData TrailingEps { get; set; }

        [DataMember(Name = "forwardEps")]
        public FormatedData ForwardEps { get; set; }

        [DataMember(Name = "pegRatio")]
        public FormatedData PegRatio { get; set; }

        [DataMember(Name = "lastSplitFactor")]
        public string LastSplitFactor { get; set; }

        [DataMember(Name = "lastSplitDate")]
        public FormatedData LastSplitDate { get; set; }

        [DataMember(Name = "enterpriseToRevenue")]
        public FormatedData EnterpriseToRevenue { get; set; }

        [DataMember(Name = "enterpriseToEbitda")]
        public FormatedData EnterpriseToEbitda { get; set; }

        [DataMember(Name = "52WeekChange")]
        public FormatedData _52WeekChange { get; set; }

        [DataMember(Name = "SandP52WeekChange")]
        public FormatedData SandP52WeekChange { get; set; }

        [DataMember(Name = "lastDividendValue")]
        public FormatedData LastDividendValue { get; set; }

        [DataMember(Name = "lastDividendDate")]
        public FormatedData LastDividendDate { get; set; }

        //[DataMember(Name = "enterpriseToEbitda")]
        //public FormatedData PriceHint { get; set; }

        //[DataMember(Name = "enterpriseToEbitda")]
        //public FormatedData PriceHint { get; set; }



        public DefaultKeyStatistics()
        {
        }

    }

}
