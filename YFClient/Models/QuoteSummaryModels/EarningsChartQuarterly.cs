using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class EarningsChartQuarterly
    {

        [DataMember(Name ="date")]
        public string Date { get; set; }

        [DataMember(Name = "actual")]
        public FormatedData Actual { get; set; }

        [DataMember(Name = "estimate")]
        public FormatedData Estimate { get; set; }


        public EarningsChartQuarterly()
        {
        }

    }

}
