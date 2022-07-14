using System;
using System.Runtime.Serialization;

namespace YFClient.Models.RecommendationsModels
{

    [DataContract]
    public class RecommendedSymbol
    {

        [DataMember(Name ="symbol")]
        public string Symbol { get; set; }

        [DataMember(Name = "score")]
        public decimal? Score { get; set; }


        public RecommendedSymbol()
        {
        }

    }

}
