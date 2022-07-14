using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class EarningsChart
    {

        [DataMember(Name = "quarterly")]
        public EarningsChartQuarterly[] Quarterly { get; set; }

        [DataMember(Name = "currentQuarterEstimate")]
        public FormatedData CurrentQuarterEstimate { get; set; }

        [DataMember(Name = "currentQuarterEstimateDate")]
        public string CurrentQuarterEstimateDate { get; set; }

        [DataMember(Name = "currentQuarterEstimateYear")]
        public int? CurrentQuarterEstimateYear { get; set; }

        [DataMember(Name = "earningsDate")]
        public FormatedData[] EarningsDate { get; set; }


        public EarningsChart()
        {
        }
    }

}
