using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module cashflowStatementHistoryQuarterly.
    /// </summary>
    [DataContract]
    public class CashflowStatementHistoryQuarterly
    {

        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "cashflowStatements")]
        public CashflowStatement[] CashflowStatements { get; set; }


        public CashflowStatementHistoryQuarterly()
        {
        }

    }

}
