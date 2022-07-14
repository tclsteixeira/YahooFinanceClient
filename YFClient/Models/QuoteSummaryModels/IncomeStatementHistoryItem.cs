using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class IncomeStatementHistoryItem
    {

        [DataMember(Name ="maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "endDate")]
        public FormatedData EndDate { get; set; }

        [DataMember(Name = "totalRevenue")]
        public FormatedData TotalRevenue { get; set; }

        [DataMember(Name = "costOfRevenue")]
        public FormatedData CostOfRevenue { get; set; }

        [DataMember(Name = "grossProfit")]
        public FormatedData GrossProfit { get; set; }

        [DataMember(Name = "researchDevelopment")]
        public FormatedData ResearchDevelopment { get; set; }

        [DataMember(Name = "sellingGeneralAdministrative")]
        public FormatedData SellingGeneralAdministrative { get; set; }

        [DataMember(Name = "nonRecurring")]
        public FormatedData NonRecurring { get; set; }

        [DataMember(Name = "otherOperatingExpenses")]
        public FormatedData OtherOperatingExpenses { get; set; }

        [DataMember(Name = "totalOperatingExpenses")]
        public FormatedData TotalOperatingExpenses { get; set; }

        [DataMember(Name = "operatingIncome")]
        public FormatedData OperatingIncome { get; set; }

        [DataMember(Name = "totalOtherIncomeExpenseNet")]
        public FormatedData TotalOtherIncomeExpenseNet { get; set; }

        [DataMember(Name = "ebit")]
        public FormatedData Ebit { get; set; }

        [DataMember(Name = "interestExpense")]
        public FormatedData InterestExpense { get; set; }

        [DataMember(Name = "incomeBeforeTax")]
        public FormatedData IncomeBeforeTax { get; set; }

        [DataMember(Name = "incomeTaxExpense")]
        public FormatedData IncomeTaxExpense { get; set; }

        [DataMember(Name = "minorityInterest")]
        public FormatedData MinorityInterest { get; set; }

        [DataMember(Name = "netIncomeFromContinuingOps")]
        public FormatedData NetIncomeFromContinuingOps { get; set; }

        [DataMember(Name = "discontinuedOperations")]
        public FormatedData DiscontinuedOperations { get; set; }

        [DataMember(Name = "extraordinaryItems")]
        public FormatedData ExtraordinaryItems { get; set; }

        [DataMember(Name = "effectOfAccountingCharges")]
        public FormatedData EffectOfAccountingCharges { get; set; }

        [DataMember(Name = "otherItems")]
        public FormatedData OtherItems { get; set; }

        [DataMember(Name = "netIncome")]
        public FormatedData NetIncome { get; set; }

        [DataMember(Name = "netIncomeApplicableToCommonShares")]
        public FormatedData NetIncomeApplicableToCommonShares { get; set; }


        public IncomeStatementHistoryItem()
        {
        }

    }

}
