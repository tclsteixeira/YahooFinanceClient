using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class QuoteSummary
    {

        [DataMember(Name = "result")]
        public QuoteSummaryResultItem[] QuoteResults { get; set; }


        //[DataMember(Name ="result")]
        //public QuoteSummaryResult Result { get; set; }

        [DataMember(Name ="error")]
        public ErrorInfo Error { get; set; }


        public QuoteSummary()
        {
        }
    }

}
