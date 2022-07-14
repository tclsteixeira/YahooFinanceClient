using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ResearchInsightsModels
{

    /// <summary>
    /// Recommendation.
    /// </summary>
    [DataContract]
    public class Recommendation
    {

        [DataMember(Name = "targetPrice")]
        public decimal? TargetPrice { get; set; }

        [DataMember(Name = "provider")]
        public string Provider { get; set; }

        [DataMember(Name = "rating")]
        public string Rating { get; set; }


        public Recommendation()
        {
        }
    }

}
