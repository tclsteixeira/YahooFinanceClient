using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module incomeStatementHistory.
    /// </summary>
    [DataContract]
    public class IncomeStatementHistory
    {

        [DataMember(Name ="incomeStatementHistory")]
        public IncomeStatementHistoryItem[] IncomeStatementHistoryList { get; set; }

        public IncomeStatementHistory()
        {
        }

    }

}
