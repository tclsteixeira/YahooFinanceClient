using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class EarningsFinancialChartQuarterly
        : EarningsFinancialChartBase
    {

        [DataMember(Name = "date")]
        public string Date { get; set; }

        public EarningsFinancialChartQuarterly()
        {
        }
    }
}
