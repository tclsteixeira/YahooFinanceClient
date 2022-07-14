
using System;
using System.Runtime.Serialization;

namespace YFClient.Models
{
    [DataContract]
    public class Quote : JSonClass
    {
        [DataMember(Name = "quoteResponse")]
        public QuoteResponse QuoteResponse { get; set; }



        public Quote()
        {
        }
    }
}
