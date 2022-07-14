using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class EarningsFinancialChartYearly 
        : EarningsFinancialChartBase
    {

        [DataMember(Name = "date")]
        public int? Date { get; set; }


        public EarningsFinancialChartYearly()
        {
        }
    }

}
