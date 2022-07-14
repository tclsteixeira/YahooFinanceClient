using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ResearchInsightsModels
{

    [DataContract]
    public class InstrumentInfo
    {

        [DataMember(Name = "technicalEvents")]
        public TechnicalEvents TechnicalEvents { get; set; }

        [DataMember(Name = "keyTechnicals")]
        public KeyTechnicals KeyTechnicals { get; set; }

        [DataMember(Name = "valuation")]
        public Valuation Valuation { get; set; }

        [DataMember(Name = "recommendation")]
        public Recommendation Recommendation { get; set; }


        public InstrumentInfo()
        {
        }


    }
}
