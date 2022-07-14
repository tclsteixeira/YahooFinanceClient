using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module majorHoldersBreakdown.
    /// </summary>
    [DataContract]
    public class MajorHoldersBreakdown
    {

        [DataMember(Name ="maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "insidersPercentHeld")]
        public FormatedData InsidersPercentHeld { get; set; }

        [DataMember(Name = "institutionsPercentHeld")]
        public FormatedData InstitutionsPercentHeld { get; set; }

        [DataMember(Name = "institutionsFloatPercentHeld")]
        public FormatedData InstitutionsFloatPercentHeld { get; set; }

        [DataMember(Name = "institutionsCount")]
        public FormatedData InstitutionsCount { get; set; }


        public MajorHoldersBreakdown()
        {
        }
    }

}
