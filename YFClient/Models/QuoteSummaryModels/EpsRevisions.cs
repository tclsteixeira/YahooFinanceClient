using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{
    [DataContract]
    public class EpsRevisions
    {

        [DataMember(Name = "upLast7days")]
        public FormatedData UpLast7days { get; set; }

        [DataMember(Name = "upLast30days")]
        public FormatedData UpLast30days { get; set; }

        [DataMember(Name = "downLast30days")]
        public FormatedData DownLast30days { get; set; }

        [DataMember(Name = "downLast90days")]
        public FormatedData DownLast90days { get; set; }


        public EpsRevisions()
        {
        }
    }
}
