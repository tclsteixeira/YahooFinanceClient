using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module balanceSheetHistory.
    /// </summary>
    [DataContract]
    public class BalanceSheetHistory
    {

        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "balanceSheetStatements")]
        public BalanceSheetStatement[] BalanceSheetStatements { get; set; }

        public BalanceSheetHistory()
        {
        }

    }

}
