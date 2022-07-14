using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{
    /// <summary>
    /// Module cashflowStatementHistory.
    /// </summary>
    [DataContract]
    public class CashflowStatementHistory
    {

        [DataMember(Name ="maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name ="cashflowStatements")]
        public CashflowStatement[] CashflowStatements { get; set; }

        public CashflowStatementHistory()
        {
        }

    }
}
