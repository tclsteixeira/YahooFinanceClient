using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class FormatedData
    {

        [DataMember(Name ="raw")]
        public decimal Raw { get; set; }

        [DataMember(Name = "fmt")]
        public string Fmt { get; set; }

        [DataMember(Name = "longfmt")]
        public string LongFmt { get; set; }


        public FormatedData()
        {
        }
    }


}
