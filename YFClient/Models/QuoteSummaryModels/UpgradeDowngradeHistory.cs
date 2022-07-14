using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module UpgradeDowngradeHistory.
    /// </summary>
    [DataContract]
    public class UpgradeDowngradeHistory
    {

        [DataMember(Name ="maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name ="history")]
        public UpgradeDowngradeHistoryItem[] HistoryList { get; set; }

        public UpgradeDowngradeHistory()
        {
        }
    }
}
