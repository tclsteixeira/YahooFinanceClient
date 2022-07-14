using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ChartDataModels
{

    [DataContract]
    public class ChartResultItem
    {

        [DataMember(Name ="meta")]
        public ChartMeta Meta { get; set; }

        [DataMember(Name = "timestamp")]
        public decimal[] Timestamp { get; set; }

        [DataMember(Name = "indicators")]
        //[DataMember(Name = "quote")]
        //public ChartQuoteIndicator[] Indicators { get; set; }


        public ChartIndicators Indicators { get; set; }


        public ChartResultItem()
        {
        }

    }

}
