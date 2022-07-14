using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace YFClient.Models
{

    /// <summary>
    /// Quote response results list.
    /// </summary>
    /// <remarks>
    /// Binds to JSon object returned by "v6/finance/quote?symbols={0}"
    /// </remarks>
    [DataContract]
    public class QuoteResponse
    {
        [DataMember(Name ="result")]
        public QuoteResponseResultItem[] Results { get; set; }

        [DataMember(Name = "error")]
        public ErrorInfo Error { get; set; }

        //[DataMember(Name ="result")]
        //public result Result { get; set; }


        public QuoteResponse()
        {
            //result = new List
        }
    }

}
