using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ChartDataModels
{
    [DataContract]
    public class ChartInstance : JSonClass
    {

        [DataMember(Name = "chart")]
        public ChartResult Chart { get; set; }


        //[DataMember(Name = "result")]
        //public ChartResultItem[] Result { get; set; }

        //[DataMember(Name = "error")]
        //public ErrorInfo Error { get; set; }


        public ChartInstance()
        {
        }
    }

}
