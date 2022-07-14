using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class EarningsFinancialsChart
    {

        [DataMember(Name ="quarterly")]
        public EarningsFinancialChartQuarterly[] Quarterly { get; set; }

        [DataMember(Name = "yearly")]
        public EarningsFinancialChartYearly[] Yearly { get; set; }


        public EarningsFinancialsChart()
        {
        }
    }

}
