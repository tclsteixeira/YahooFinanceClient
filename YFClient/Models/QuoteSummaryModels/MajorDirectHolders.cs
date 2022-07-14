using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module majorDirectHolders.
    /// </summary>
    [DataContract]
    public class MajorDirectHolders
    {

        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name ="holders")]
        public MajorDirectHolder[] Holders { get; set; }

        public MajorDirectHolders()
        {
        }

    }

}
