using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ChartDataModels
{

    [DataContract]
    public class ChartQuote
    {

        [DataMember(Name ="quote")]
        public ChartQuoteIndicator[] Quote { get; set; }

        public ChartQuote()
        {
        }
    }

}
