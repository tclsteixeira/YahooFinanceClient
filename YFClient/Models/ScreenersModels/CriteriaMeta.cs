using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ScreenersModels
{

    [DataContract]
    public class CriteriaMeta
    {

        [DataMember(Name ="size")]
        public int? Size { get; set; }

        [DataMember(Name = "offset")]
        public decimal? Offset { get; set; }

        [DataMember(Name = "sortField")]
        public string SortField { get; set; }

        [DataMember(Name = "sortType")]
        public string SortType { get; set; }

        [DataMember(Name = "quoteType")]
        public string QuoteType { get; set; }

        [DataMember(Name = "topOperator")]
        public string TopOperator { get; set; }

        [DataMember(Name ="criteria")]
        public CriteriaItem[] Criteria { get; set; }


        public CriteriaMeta()
        {
        }
    }
}
