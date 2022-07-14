using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ChartDataModels
{

    [DataContract]
    public class CurrentTradingPeriod
    {

        [DataMember(Name ="pre")]
        public Period Pre { get; set; }

        [DataMember(Name = "regular")]
        public Period Regular { get; set; }

        [DataMember(Name = "post")]
        public Period Post { get; set; }



        public CurrentTradingPeriod()
        {
        }
    }
}
