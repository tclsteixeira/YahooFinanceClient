using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class UpgradeDowngradeHistoryItem
    {

        [DataMember(Name = "epochGradeDate")]
        public decimal? EpochGradeDate { get; set; }

        [DataMember(Name = "firm")]
        public string Firm { get; set; }

        [DataMember(Name = "toGrade")]
        public string ToGrade { get; set; }

        [DataMember(Name = "fromGrade")]
        public string FromGrade { get; set; }

        [DataMember(Name = "main")]
        public string Main { get; set; }

        public UpgradeDowngradeHistoryItem()
        {
        }
    }
}
