using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module balanceSheetHistoryQuarterly.
    /// </summary>
    [DataContract]
    public class BalanceSheetHistoryQuarterly
    {

        [DataMember(Name ="maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "balanceSheetStatements")]
        public BalanceSheetStatement[] BalanceSheetStatements { get; set; }


        public BalanceSheetHistoryQuarterly()
        {
        }
    }
}
