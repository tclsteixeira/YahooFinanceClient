using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module netSharePurchaseActivity.
    /// </summary>
    [DataContract]
    public class NetSharePurchaseActivity
    {

        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "period")]
        public string Period { get; set; }

        [DataMember(Name = "buyInfoCount")]
        public FormatedData BuyInfoCount { get; set; }

        [DataMember(Name = "buyInfoShares")]
        public FormatedData BuyInfoShares { get; set; }

        [DataMember(Name = "sellInfoCount")]
        public FormatedData SellInfoCount { get; set; }

        [DataMember(Name = "sellInfoShares")]
        public FormatedData SellInfoShares { get; set; }

        [DataMember(Name = "netInfoCount")]
        public FormatedData NetInfoCount { get; set; }

        [DataMember(Name = "netInfoShares")]
        public FormatedData NetInfoShares { get; set; }

        [DataMember(Name = "netPercentInsiderShares")]
        public FormatedData NetPercentInsiderShares { get; set; }

        [DataMember(Name = "totalInsiderShares")]
        public FormatedData TotalInsiderShares { get; set; }


        public NetSharePurchaseActivity()
        {
        }

    }

}
