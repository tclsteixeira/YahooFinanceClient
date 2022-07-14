using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ChartDataModels
{

    [DataContract]
    public class Period
    {

        [DataMember(Name = "timezone")]
        public string Timezone { get; set; }

        [DataMember(Name = "start")]
        public decimal Start { get; set; }

        [DataMember(Name = "end")]
        public decimal End { get; set; }

        [DataMember(Name = "gmtoffset")]
        public decimal GMTOffset { get; set; }



        public Period()
        {
        }

    }

}
