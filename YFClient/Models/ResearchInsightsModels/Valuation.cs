using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ResearchInsightsModels
{

    [DataContract]
    public class Valuation
    {

        [DataMember(Name ="color")]
        public double? Color { get; set; }

        [DataMember(Name ="description")]
        public string Description { get; set; }

        [DataMember(Name = "discount")]
        public string Discount { get; set; }

        [DataMember(Name = "relativeValue")]
        public string RelativeValue { get; set; }

        [DataMember(Name = "provider")]
        public string Provider { get; set; }


        public Valuation()
        {
        }

    }

}
