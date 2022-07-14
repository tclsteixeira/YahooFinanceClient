using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module esgScores.
    /// </summary>
    [DataContract]
    public class EsgScores
    {

        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "totalEsg")]
        public FormatedData TotalEsg { get; set; }

        [DataMember(Name = "environmentScore")]
        public FormatedData EnvironmentScore { get; set; }

        [DataMember(Name = "socialScore")]
        public FormatedData SocialScore { get; set; }

        [DataMember(Name = "governanceScore")]
        public FormatedData GovernanceScore { get; set; }

        [DataMember(Name = "ratingYear")]
        public int? RatingYear { get; set; }

        [DataMember(Name = "ratingMonth")]
        public int? RatingMonth { get; set; }

        [DataMember(Name = "highestControversy")]
        public int? HighestControversy { get; set; }

        [DataMember(Name = "peerCount")]
        public int? PeerCount { get; set; }

        [DataMember(Name = "esgPerformance")]
        public string EsgPerformance { get; set; }

        [DataMember(Name = "peerGroup")]
        public string PeerGroup { get; set; }

        [DataMember(Name = "relatedControversy")]
        public string[] RelatedControversy { get; set; }

        [DataMember(Name = "peerEsgScorePerformance")]
        public ScorePerformance PeerEsgScorePerformance { get; set; }

        [DataMember(Name = "peerGovernancePerformance")]
        public ScorePerformance PeerGovernancePerformance { get; set; }

        [DataMember(Name = "peerSocialPerformance")]
        public ScorePerformance PeerSocialPerformance { get; set; }

        [DataMember(Name = "peerEnvironmentPerformance")]
        public ScorePerformance PeerEnvironmentPerformance { get; set; }

        [DataMember(Name = "peerHighestControversyPerformance")]
        public ScorePerformance PeerHighestControversyPerformance { get; set; }

        [DataMember(Name = "percentile")]
        public FormatedData Percentile { get; set; }

        [DataMember(Name = "environmentPercentile")]
        public FormatedData EnvironmentPercentile { get; set; }

        [DataMember(Name = "socialPercentile")]
        public FormatedData SocialPercentile { get; set; }

        [DataMember(Name = "governancePercentile")]
        public FormatedData GovernancePercentile { get; set; }

        [DataMember(Name = "adult")]
        public bool Adult { get; set; }

        [DataMember(Name = "alcoholic")]
        public bool Alcoholic { get; set; }

        [DataMember(Name = "animalTesting")]
        public bool AnimalTesting { get; set; }

        [DataMember(Name = "catholic")]
        public bool Catholic { get; set; }

        [DataMember(Name = "controversialWeapons")]
        public bool ControversialWeapons { get; set; }

        [DataMember(Name = "smallArms")]
        public bool SmallArms { get; set; }

        [DataMember(Name = "furLeather")]
        public bool FurLeather { get; set; }

        [DataMember(Name = "gambling")]
        public bool Gambling { get; set; }

        [DataMember(Name = "gmo")]
        public bool Gmo { get; set; }

        [DataMember(Name = "militaryContract")]
        public bool MilitaryContract { get; set; }

        [DataMember(Name = "nuclear")]
        public bool Nuclear { get; set; }

        [DataMember(Name = "pesticides")]
        public bool Pesticides { get; set; }

        [DataMember(Name = "palmOil")]
        public bool PalmOil { get; set; }

        [DataMember(Name = "coal")]
        public bool Coal { get; set; }

        [DataMember(Name = "tobacco")]
        public bool Tobacco { get; set; }


        public EsgScores()
        {
        }

    }

}
