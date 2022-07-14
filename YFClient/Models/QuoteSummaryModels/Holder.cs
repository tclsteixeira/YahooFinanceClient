using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class Holder
    {
     
        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "relation")]
        public string Relation { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "transactionDescription")]
        public string TransactionDescription { get; set; }

        [DataMember(Name = "latestTransDate")]
        public FormatedData LatestTransDate { get; set; }

        [DataMember(Name = "positionDirect")]
        public FormatedData PositionDirect { get; set; }

        [DataMember(Name = "positionDirectDate")]
        public FormatedData PositionDirectDate { get; set; }


        public Holder()
        {
        }

    }

}
