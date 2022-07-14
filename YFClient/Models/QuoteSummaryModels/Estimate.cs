using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class Estimate
    {

        [DataMember(Name = "period")]
        public string Period { get; set; }

        [DataMember(Name = "growth")]
        public FormatedData Growth{ get; set; }


        public Estimate()
        {
        }
    }
}
