using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class EarningsEstimate
    {

        [DataMember(Name ="avg")]
        public FormatedData Avg { get; set; }

        [DataMember(Name = "low")]
        public FormatedData Low { get; set; }

        [DataMember(Name = "high")]
        public FormatedData High { get; set; }

        [DataMember(Name = "yearAgoEps")]
        public FormatedData YearAgoEps { get; set; }

        [DataMember(Name = "numberOfAnalysts")]
        public FormatedData NumberOfAnalysts { get; set; }

        [DataMember(Name = "growth")]
        public FormatedData Growth { get; set; }



        public EarningsEstimate()
        {
        }
    }

}
