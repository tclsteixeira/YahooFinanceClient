using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class FinancialData
    {

        [DataMember(Name ="maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "currentPrice")]
        public FormatedData CurrentPrice { get; set; }

        [DataMember(Name = "targetHighPrice")]
        public FormatedData TargetHighPrice { get; set; }

        [DataMember(Name = "targetLowPrice")]
        public FormatedData TargetLowPrice { get; set; }

        [DataMember(Name = "targetMeanPrice")]
        public FormatedData TargetMeanPrice { get; set; }

        [DataMember(Name = "targetMedianPrice")]
        public FormatedData TargetMedianPrice { get; set; }

        [DataMember(Name = "recommendationMean")]
        public FormatedData RecommendationMean { get; set; }

        [DataMember(Name = "recommendationKey")]
        public string RecommendationKey { get; set; }

        [DataMember(Name = "numberOfAnalystOpinions")]
        public FormatedData NumberOfAnalystOpinions { get; set; }

        [DataMember(Name = "totalCash")]
        public FormatedData TotalCash { get; set; }

        [DataMember(Name = "totalCashPerShare")]
        public FormatedData TotalCashPerShare { get; set; }

        [DataMember(Name = "ebitda")]
        public FormatedData Ebitda { get; set; }

        [DataMember(Name = "totalDebt")]
        public FormatedData TotalDebt { get; set; }

        [DataMember(Name = "quickRatio")]
        public FormatedData QuickRatio { get; set; }

        [DataMember(Name = "currentRatio")]
        public FormatedData CurrentRatio { get; set; }

        [DataMember(Name = "totalRevenue")]
        public FormatedData TotalRevenue { get; set; }

        [DataMember(Name = "debtToEquity")]
        public FormatedData DebtToEquity { get; set; }

        [DataMember(Name = "revenuePerShare")]
        public FormatedData RevenuePerShare { get; set; }

        [DataMember(Name = "returnOnAssets")]
        public FormatedData ReturnOnAssets { get; set; }

        [DataMember(Name = "returnOnEquity")]
        public FormatedData ReturnOnEquity { get; set; }

        [DataMember(Name = "grossProfits")]
        public FormatedData GrossProfits { get; set; }

        [DataMember(Name = "freeCashflow")]
        public FormatedData FreeCashflow { get; set; }

        [DataMember(Name = "operatingCashflow")]
        public FormatedData OperatingCashflow { get; set; }

        [DataMember(Name = "earningsGrowth")]
        public FormatedData EarningsGrowth { get; set; }

        [DataMember(Name = "revenueGrowth")]
        public FormatedData RevenueGrowth { get; set; }

        [DataMember(Name = "grossMargins")]
        public FormatedData GrossMargins { get; set; }

        [DataMember(Name = "ebitdaMargins")]
        public FormatedData EbitdaMargins { get; set; }

        [DataMember(Name = "operatingMargins")]
        public FormatedData OperatingMargins { get; set; }

        [DataMember(Name = "profitMargins")]
        public FormatedData ProfitMargins { get; set; }

        [DataMember(Name = "financialCurrency")]
        public string FinancialCurrency { get; set; }


        public FinancialData()
        {
        }

    }
}
