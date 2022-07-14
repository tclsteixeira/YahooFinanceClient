using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class InsiderHolders
    {

        [DataMember(Name ="holders")]
        public InsiderHolder[] Holders { get; set; }

        public InsiderHolders()
        {
        }
    }
}
