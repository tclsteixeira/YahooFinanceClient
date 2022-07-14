using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class EarningsFinancialChartBase
    {

        [DataMember(Name = "revenue")]
        public FormatedData Revenue { get; set; }

        [DataMember(Name = "earnings")]
        public FormatedData Earnings { get; set; }


        public EarningsFinancialChartBase()
        {
        }
    }
}
