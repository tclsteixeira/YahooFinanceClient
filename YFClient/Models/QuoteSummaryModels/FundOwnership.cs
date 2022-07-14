using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module fundOwnership
    /// </summary>
    [DataContract]
    public class FundOwnership
    {

        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "ownershipList")]
        public Ownership[] OwnershipList { get; set; }


        public FundOwnership()
        {
        }
    }

}
