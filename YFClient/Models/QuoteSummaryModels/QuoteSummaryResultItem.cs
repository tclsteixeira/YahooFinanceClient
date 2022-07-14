using System;
using System.Runtime.Serialization;


namespace YFClient.Models.QuoteSummaryModels
{

    /*
     * In quote summary query you must specify the module names in the query parameters
     * At 2022-06-13, 28 module names are supported.
     * This class allows you to store the returned data from all modules info in his data members.
     * The data members from modules you didn't request will be left empty or null.    
    */

    [DataContract]
    public class QuoteSummaryResultItem
    {

        // 28 modules (all modules supported to date 2022-06-13)

        // Module assetProfile
        [DataMember(Name = "assetProfile")]
        public AssetProfile Profile { get; set; }

        // Module defaultKeyStatistics
        [DataMember(Name = "defaultKeyStatistics")]
        public DefaultKeyStatistics DefaultKeyStats { get; set; }

        // Module recommendationTrend
        [DataMember(Name = "recommendationTrend")]
        public RecommendationTrend RecommTrend { get; set; }

        // Module recommendationTrend
        [DataMember(Name = "insiderHolders")]
        public InsiderHolders InsiderHolders { get; set; }

        // Module earningsTrend
        [DataMember(Name = "earningsTrend")]
        public EarningsTrend EarningsTrend { get; set; }

        // Module insiderTransactions
        [DataMember(Name = "insiderTransactions")]
        public InsiderTransactions InsiderTransactions { get; set; }

        // Module finantialData
        [DataMember(Name = "financialData")]
        public FinancialData FinancialData { get; set; }

        // Module secFilings
        [DataMember(Name = "secFilings")]
        public SecFilings SecFilings { get; set; }

        // Module cashflowStatementHistory
        [DataMember(Name = "cashflowStatementHistory")]
        public CashflowStatementHistory CashflowStatementHistory { get; set; }

        // Module indexTrend
        [DataMember(Name = "indexTrend")]
        public IndexTrend IndexTrend { get; set; }

        // Module industryTrend
        [DataMember(Name = "industryTrend")]
        public IndustryTrend IndustryTrend { get; set; }

        // Module incomeStatementHistory
        [DataMember(Name = "incomeStatementHistory")]
        public IncomeStatementHistory IncomeStatementHistory { get; set; }

        // Module fundOwnership
        [DataMember(Name = "fundOwnership")]
        public FundOwnership FundOwnership { get; set; }

        // Module calendarEvents
        [DataMember(Name = "calendarEvents")]
        public CalendarEvents CalendarEvents { get; set; }

        // Module upgradeDowngradeHistory
        [DataMember(Name = "upgradeDowngradeHistory")]
        public UpgradeDowngradeHistory UpgradeDowngradeHistory { get; set; }

        // Module price
        [DataMember(Name = "price")]
        public Price Price { get; set; }

        // Module balanceSheetHistory
        [DataMember(Name = "balanceSheetHistory")]
        public BalanceSheetHistory BalanceSheetHistory { get; set; }

        // Module institutionOwnership
        [DataMember(Name = "institutionOwnership")]
        public InstitutionOwnership InstitutionOwnership { get; set; }

        // Module majorHoldersBreakdown
        [DataMember(Name = "majorHoldersBreakdown")]
        public MajorHoldersBreakdown MajorHoldersBreakdown { get; set; }

        // Module balanceSheetHistoryQuarterly
        [DataMember(Name = "balanceSheetHistoryQuarterly")]
        public BalanceSheetHistoryQuarterly BalanceSheetHistoryQuarterly { get; set; }

        // Module earningsHistory
        [DataMember(Name = "earningsHistory")]
        public EarningsHistory EarningsHistory { get; set; }

        // Module majorDirectHolders
        [DataMember(Name = "majorDirectHolders")]
        public MajorDirectHolders MajorDirectHolders { get; set; }

        // Module esgScores
        [DataMember(Name = "esgScores")]
        public EsgScores EsgScores { get; set; }

        // Module netSharePurchaseActivity
        [DataMember(Name = "netSharePurchaseActivity")]
        public NetSharePurchaseActivity NetSharePurchaseActivity { get; set; }

        // Module sectorTrend
        [DataMember(Name = "sectorTrend")]
        public SectorTrend SectorTrend { get; set; }

        // Module incomeStatementHistoryQuarterly
        [DataMember(Name = "incomeStatementHistoryQuarterly")]
        public IncomeStatementHistoryQuarterly IncomeStatementHistoryQuarterly { get; set; }

        // Module cashflowStatementHistoryQuarterly
        [DataMember(Name = "cashflowStatementHistoryQuarterly")]
        public CashflowStatementHistoryQuarterly CashflowStatementHistoryQuarterly { get; set; }

        // Module earnings
        [DataMember(Name = "earnings")]
        public Earnings Earnings { get; set; }


        public QuoteSummaryResultItem()
        {
        }

    }

}
