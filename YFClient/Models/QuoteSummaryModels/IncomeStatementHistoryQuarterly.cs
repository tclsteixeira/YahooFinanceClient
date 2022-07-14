using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module incomeStatementHistoryQuarterly.
    /// </summary>
    [DataContract]
    public class IncomeStatementHistoryQuarterly
    {

        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "incomeStatementHistory")]
        public IncomeStatementHistoryItem[] IncomeStatementHistory { get; set; }


        public IncomeStatementHistoryQuarterly()
        {
        }
    }
}
