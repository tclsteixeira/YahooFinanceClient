using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module earningsHistory.
    /// </summary>
    [DataContract]
    public class EarningsHistory
    {

        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name ="history")]
        public EarningHistoryPeriod[] History { get; set; }


        public EarningsHistory()
        {
        }

    }

}
