using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ResearchInsightsModels
{

    [DataContract]
    public class RIFinance
    {

        [DataMember(Name ="result")]
        public RIResult Result { get; set; }

        public RIFinance()
        {
        }
    }
}
