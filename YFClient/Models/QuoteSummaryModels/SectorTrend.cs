using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module sectorTrend.
    /// </summary>
    [DataContract]
    public class SectorTrend
    {

        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "symbol")]
        public string Symbol { get; set; }

        [DataMember(Name = "peRatio")]
        public FormatedData PeRatio { get; set; }

        [DataMember(Name = "pegRatio")]
        public FormatedData PegRatio { get; set; }

        [DataMember(Name = "estimates")]
        public Estimate[] Estimates { get; set; }


        public SectorTrend()
        {
        }

    }
}
