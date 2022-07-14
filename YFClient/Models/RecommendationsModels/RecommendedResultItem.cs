using System;
using System.Runtime.Serialization;

namespace YFClient.Models.RecommendationsModels
{

    [DataContract]
    public class RecommendedResultItem
    {

        [DataMember(Name ="symbol")]
        public string QuerySymbol { get; set; }

        [DataMember(Name ="recommendedSymbols")]
        public RecommendedSymbol[] RecommendedSymbols { get; set; }


        public RecommendedResultItem()
        {
        }
    }
}
