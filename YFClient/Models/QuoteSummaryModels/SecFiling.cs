using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class SecFiling
    {

        [DataMember(Name ="date")]
        public string Date { get; set; }

        [DataMember(Name = "epochDate")]
        public decimal? EpochDate { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "edgarUrl")]
        public string EdgarUrl { get; set; }

        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }


        public SecFiling()
        {
        }
    }
}
