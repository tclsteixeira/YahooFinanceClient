using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class EarningHistoryPeriod
    {

        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "epsActual")]
        public FormatedData EpsActual { get; set; }

        [DataMember(Name = "epsEstimate")]
        public FormatedData EpsEstimate { get; set; }

        [DataMember(Name = "epsDifference")]
        public FormatedData EpsDifference { get; set; }

        [DataMember(Name = "surprisePercent")]
        public FormatedData SurprisePercent { get; set; }

        [DataMember(Name = "quarter")]
        public FormatedData Quarter { get; set; }

        [DataMember(Name = "period")]
        public string Period { get; set; }


        public EarningHistoryPeriod()
        {
        }

    }
}
