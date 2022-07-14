using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ResearchInsightsModels
{

    [DataContract]
    public class RIReportItem
    {

        [DataMember(Name ="id")]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "provider")]
        public string Provider { get; set; }

        [DataMember(Name = "publishedOn")]
        public string PublishedOn { get; set; }

        [DataMember(Name = "summary")]
        public string Summary { get; set; }


        public RIReportItem()
        {
        }
    }
}
