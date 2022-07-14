using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ChartDataModels
{

    [DataContract]
    public class ChartIndicators
    {

        [DataMember(Name = "quote")]
        public ChartQuoteIndicator[] Quote { get; set; }


        public ChartIndicators()
        {
        }

    }

}
