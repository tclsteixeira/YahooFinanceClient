using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ResearchInsightsModels
{

    [DataContract]
    public class RIResult
    {

        [DataMember(Name ="symbol")]
        public string Symbol { get; set; }

        [DataMember(Name = "instrumentInfo")]
        public InstrumentInfo InstrumentInfo { get; set; }

        [DataMember(Name = "reports")]
        public RIReportItem[] Reports { get; set; }

        [DataMember(Name = "companySnapshot")]
        public RICompanySnapshot CompanySnapshot { get; set; }

        [DataMember(Name = "error")]
        public ErrorInfo Error { get; set; }


        public RIResult()
        {
        }
    }
}
