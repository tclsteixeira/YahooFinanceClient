using System;
using System.Runtime.Serialization;


namespace YFClient.Models.ChartDataModels
{

    [DataContract]
    public class ChartQuoteIndicator
    {

        [DataMember(Name ="open")]
        public decimal?[] Open { get; set; }

        [DataMember(Name = "volume")]
        public decimal?[] Volume { get; set; }

        [DataMember(Name ="low")]
        public decimal?[] Low { get; set; }

        [DataMember(Name = "high")]
        public decimal?[] High { get; set; }

        [DataMember(Name = "close")]
        public decimal?[] Close { get; set; }


        public ChartQuoteIndicator()
        {
        }

    }


}
