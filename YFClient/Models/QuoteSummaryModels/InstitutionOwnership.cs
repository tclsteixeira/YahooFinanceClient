using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module institutionOwnership.
    /// </summary>
    [DataContract]
    public class InstitutionOwnership
    {

        [DataMember(Name ="maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "ownershipList")]
        public Ownership[] OwnershipList { get; set; }


        public InstitutionOwnership()
        {
        }

    }

}
