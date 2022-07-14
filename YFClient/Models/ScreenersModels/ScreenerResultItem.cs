using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ScreenersModels
{

    [DataContract]
    public class ScreenerResultItem
    {

        [DataMember(Name ="id")]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "canonicalName")]
        public string CanonicalName { get; set; }

        [DataMember(Name = "criteriaMeta")]
        public CriteriaMeta CriteriaMeta { get; set; }

        //[DataMember(Name = "criteria")]
        //public CriteriaItem[] Criteria { get; set; }

        [DataMember(Name = "rawCriteria")]
        public string RawCriteria { get; set; }

        [DataMember(Name = "start")]
        public int? Start { get; set; }

        [DataMember(Name = "count")]
        public int? Count { get; set; }

        [DataMember(Name = "total")]
        public int? Total { get; set; }

        [DataMember(Name = "quotes")]
        public ScreenerQuote[] Quotes { get; set; }

        [DataMember(Name = "useRecords")]
        public bool? UseRecords { get; set; }

        [DataMember(Name = "predefinedScr")]
        public bool? PredefinedScr { get; set; }

        [DataMember(Name = "versionId")]
        public decimal? VersionId { get; set; }

        [DataMember(Name = "creationDate")]
        public decimal? CreationDate { get; set; }

        [DataMember(Name = "lastUpdated")]
        public decimal? LastUpdated { get; set; }

        [DataMember(Name = "isPremium")]
        public bool? IsPremium { get; set; }

        [DataMember(Name = "iconUrl")]
        public string IconUrl { get; set; }


        public ScreenerResultItem()
        {
        }
    }
}
