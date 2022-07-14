using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{
    [DataContract]
    public class EarningTrend
    {

        [DataMember(Name ="maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "period")]
        public string Period { get; set; }

        [DataMember(Name = "endDate")]
        public string EndDate { get; set; }

        [DataMember(Name = "growth")]
        public FormatedData Growth { get; set; }

        [DataMember(Name = "earningsEstimate")]
        public EarningsEstimate EarningsEstimate { get; set; }

        [DataMember(Name = "revenueEstimate")]
        public RevenueEstimate RevenueEstimate { get; set; }

        [DataMember(Name = "epsTrend")]
        public EpsTrend EpsTrend { get; set; }

        [DataMember(Name = "epsRevisions")]
        public EpsRevisions EpsRevisions { get; set; }


        public EarningTrend()
        {
        }

    }

}
