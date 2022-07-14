using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class CashflowStatement
    {

        [DataMember(Name ="maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "endDate")]
        public FormatedData EndDate { get; set; }

        [DataMember(Name = "netIncome")]
        public FormatedData NetIncome { get; set; }

        [DataMember(Name = "depreciation")]
        public FormatedData Depreciation { get; set; }

        [DataMember(Name = "changeToNetincome")]
        public FormatedData ChangeToNetincome { get; set; }

        [DataMember(Name = "changeToAccountReceivables")]
        public FormatedData ChangeToAccountReceivables { get; set; }

        [DataMember(Name = "changeToLiabilities")]
        public FormatedData ChangeToLiabilities { get; set; }

        [DataMember(Name = "changeToInventory")]
        public FormatedData ChangeToInventory { get; set; }

        [DataMember(Name = "changeToOperatingActivities")]
        public FormatedData ChangeToOperatingActivities { get; set; }

        [DataMember(Name = "totalCashFromOperatingActivities")]
        public FormatedData TotalCashFromOperatingActivities { get; set; }

        [DataMember(Name = "capitalExpenditures")]
        public FormatedData CapitalExpenditures { get; set; }

        [DataMember(Name = "investments")]
        public FormatedData Investments { get; set; }

        [DataMember(Name = "otherCashflowsFromInvestingActivities")]
        public FormatedData OtherCashflowsFromInvestingActivities { get; set; }

        [DataMember(Name = "totalCashflowsFromInvestingActivities")]
        public FormatedData TotalCashflowsFromInvestingActivities { get; set; }

        [DataMember(Name = "dividendsPaid")]
        public FormatedData DividendsPaid { get; set; }

        [DataMember(Name = "netBorrowings")]
        public FormatedData netBorrowings { get; set; }

        [DataMember(Name = "otherCashflowsFromFinancingActivities")]
        public FormatedData OtherCashflowsFromFinancingActivities { get; set; }

        [DataMember(Name = "totalCashFromFinancingActivities")]
        public FormatedData TotalCashFromFinancingActivities { get; set; }

        [DataMember(Name = "changeInCash")]
        public FormatedData ChangeInCash { get; set; }

        [DataMember(Name = "repurchaseOfStock")]
        public FormatedData RepurchaseOfStock { get; set; }

        [DataMember(Name = "issuanceOfStock")]
        public FormatedData IssuanceOfStock { get; set; }


        public CashflowStatement()
        {
        }
    }

}
