using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ResearchInsightsModels
{

    [DataContract]
    public class KeyTechnicals
    {

        [DataMember(Name ="provider")]
        public string Provider { get; set; }

        [DataMember(Name = "support")]
        public decimal? Support { get; set; }

        [DataMember(Name = "resistance")]
        public decimal? Resistance { get; set; }

        [DataMember(Name = "stopLoss")]
        public decimal? StopLoss { get; set; }


        public KeyTechnicals()
        {
        }
    }

}
