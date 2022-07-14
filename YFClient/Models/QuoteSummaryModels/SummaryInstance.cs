using System;
using System.Runtime.Serialization;


namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Represents a quote summary instance (main class for deserialization).
    /// </summary>
    [DataContract]
    public class SummaryInstance : JSonClass
    {

        [DataMember(Name ="quoteSummary")]
        public QuoteSummary QuoteSummary { get; set; }

        public SummaryInstance()
        {
        }
    }

}
