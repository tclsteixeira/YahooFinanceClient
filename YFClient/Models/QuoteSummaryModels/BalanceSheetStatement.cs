using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class BalanceSheetStatement
    {

        [DataMember(Name ="maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "endDate")]
        public FormatedData EndDate { get; set; }

        [DataMember(Name = "cash")]
        public FormatedData Cash { get; set; }

        [DataMember(Name = "shortTermInvestments")]
        public FormatedData ShortTermInvestments { get; set; }

        [DataMember(Name = "netReceivables")]
        public FormatedData NetReceivables { get; set; }

        [DataMember(Name = "inventory")]
        public FormatedData Inventory { get; set; }

        [DataMember(Name = "otherCurrentAssets")]
        public FormatedData OtherCurrentAssets { get; set; }

        [DataMember(Name = "totalCurrentAssets")]
        public FormatedData TotalCurrentAssets { get; set; }

        [DataMember(Name = "longTermInvestments")]
        public FormatedData LongTermInvestments { get; set; }

        [DataMember(Name = "propertyPlantEquipment")]
        public FormatedData PropertyPlantEquipment { get; set; }

        [DataMember(Name = "otherAssets")]
        public FormatedData OtherAssets { get; set; }

        [DataMember(Name = "totalAssets")]
        public FormatedData TotalAssets { get; set; }

        [DataMember(Name = "accountsPayable")]
        public FormatedData AccountsPayable { get; set; }

        [DataMember(Name = "shortLongTermDebt")]
        public FormatedData ShortLongTermDebt { get; set; }

        [DataMember(Name = "otherCurrentLiab")]
        public FormatedData OtherCurrentLiab { get; set; }

        [DataMember(Name = "longTermDebt")]
        public FormatedData LongTermDebt { get; set; }

        [DataMember(Name = "otherLiab")]
        public FormatedData OtherLiab { get; set; }

        [DataMember(Name = "totalCurrentLiabilities")]
        public FormatedData TotalCurrentLiabilities { get; set; }

        [DataMember(Name = "totalLiab")]
        public FormatedData TotalLiab { get; set; }

        [DataMember(Name = "commonStock")]
        public FormatedData CommonStock { get; set; }

        [DataMember(Name = "retainedEarnings")]
        public FormatedData RetainedEarnings { get; set; }

        [DataMember(Name = "treasuryStock")]
        public FormatedData TreasuryStock { get; set; }

        [DataMember(Name = "otherStockholderEquity")]
        public FormatedData OtherStockholderEquity { get; set; }

        [DataMember(Name = "totalStockholderEquity")]
        public FormatedData TotalStockholderEquity { get; set; }

        [DataMember(Name = "netTangibleAssets")]
        public FormatedData NetTangibleAssets { get; set; }


        public BalanceSheetStatement()
        {
        }

    }
}
