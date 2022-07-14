using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class EpsTrend
    {

        [DataMember(Name = "current")]
        public FormatedData Current { get; set; }

        [DataMember(Name = "7daysAgo")]
        public FormatedData SevendaysAgo { get; set; }

        [DataMember(Name = "30daysAgo")]
        public FormatedData ThirtydaysAgo { get; set; }

        [DataMember(Name = "60daysAgo")]
        public FormatedData SixtydaysAgo { get; set; }

        [DataMember(Name = "90daysAgo")]
        public FormatedData NinetydaysAgo { get; set; }


        public EpsTrend()
        {
        }
    }
}
