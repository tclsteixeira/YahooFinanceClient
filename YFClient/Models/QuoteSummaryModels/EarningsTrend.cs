using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Earnings trend module.
    /// </summary>
    [DataContract]
    public class EarningsTrend
    {

        [DataMember(Name ="trend")]
        public EarningTrend[] EarningsTrendList { get; set; }

        public EarningsTrend()
        {
        }
    }

}
