using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ResearchInsightsModels
{

    /// <summary>
    /// Research insights instance.
    /// </summary>
    [DataContract]
    public class ResearchInsightsInstance : JSonClass
    {

        [DataMember(Name ="finance")]
        public RIFinance Finance { get; set; }

        public ResearchInsightsInstance()
        {
        }
    }
}
