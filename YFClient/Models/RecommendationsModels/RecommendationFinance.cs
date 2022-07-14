using System;
using System.Runtime.Serialization;

namespace YFClient.Models.RecommendationsModels
{

    [DataContract]
    public class RecommendationFinance
    {

        [DataMember(Name ="result")]
        public RecommendedResultItem[] Results { get; set; }

        [DataMember(Name ="error")]
        public ErrorInfo Error { get; set; }


        public RecommendationFinance()
        {
        }

    }

}
