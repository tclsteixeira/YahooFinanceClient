using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ResearchInsightsModels
{

    [DataContract]
    public class RICompanySnapshot
    {

        [DataMember(Name = "sectorInfo")]
        public string SectorInfo { get; set; }

        [DataMember(Name ="company")]
        public RISnapshot Company { get; set; }

        [DataMember(Name = "sector")]
        public RISnapshot Sector { get; set; }


        public RICompanySnapshot()
        {
        }
    }

}
