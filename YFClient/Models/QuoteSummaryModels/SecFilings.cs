using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module secFilings.
    /// </summary>
    [DataContract]
    public class SecFilings
    {

        [DataMember(Name ="filings")]
        public SecFiling[] Filings { get; set; }

        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }


        public SecFilings()
        {
        }

    }
}
