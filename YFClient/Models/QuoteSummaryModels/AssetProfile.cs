using System;
using System.Runtime.Serialization;


namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Asset profile is one of the possible modules.
    /// </summary>
    [DataContract]
    public class AssetProfile
    {

        [DataMember(Name ="address1")]
        public string Address1 { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "zip")]
        public string Zip { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        [DataMember(Name = "website")]
        public string Website { get; set; }

        [DataMember(Name = "industry")]
        public string Industry { get; set; }

        [DataMember(Name = "sector")]
        public string Sector { get; set; }

        [DataMember(Name = "longBusinessSummary")]
        public string LongBusinessSummary { get; set; }

        [DataMember(Name = "fullTimeEmployees")]
        public decimal FullTimeEmployees { get; set; }

        [DataMember(Name = "companyOfficers")]
        public CompanyOfficer[] CompanyOfficers { get; set; }

        [DataMember(Name = "auditRisk")]
        public decimal AuditRisk { get; set; }

        [DataMember(Name = "boardRisk")]
        public decimal BoardRisk { get; set; }

        [DataMember(Name = "compensationRisk")]
        public decimal CompensationRisk { get; set; }

        [DataMember(Name = "shareHolderRightsRisk")]
        public decimal ShareHolderRightsRisk { get; set; }

        [DataMember(Name = "overallRisk")]
        public decimal OverallRisk { get; set; }

        [DataMember(Name = "governanceEpochDate")]
        public decimal GovernanceEpochDate { get; set; }

        [DataMember(Name = "compensationAsOfEpochDate")]
        public decimal CompensationAsOfEpochDate { get; set; }

        [DataMember(Name = "maxAge")]
        public decimal MaxAge { get; set; }


        public AssetProfile()
        {
        }

    }
}
