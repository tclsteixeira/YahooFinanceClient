using System;
using System.Runtime.Serialization;

namespace YFClient.Models.RecommendationsModels
{

    /// <summary>
    /// Recommendation instance.
    /// </summary>
    [DataContract]
    public class RecommendationInstance : JSonClass
    {

        [DataMember(Name ="finance")]
        public RecommendationFinance Finance { get; set; }


        public RecommendationInstance()
        {
        }
    }
}
