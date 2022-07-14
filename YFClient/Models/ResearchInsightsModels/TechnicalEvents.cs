using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ResearchInsightsModels
{

    [DataContract]
    public class TechnicalEvents
    {

        [DataMember(Name = "provider")]
        public string Provider { get; set; }

        [DataMember(Name = "shortTerm")]
        public string ShortTerm { get; set; }

        [DataMember(Name = "midTerm")]
        public string MidTerm { get; set; }

        [DataMember(Name = "longTerm")]
        public string LongTerm { get; set; }


        public TechnicalEvents()
        {
        }
    }

}
