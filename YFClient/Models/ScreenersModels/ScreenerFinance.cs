using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ScreenersModels
{

    [DataContract]
    public class ScreenerFinance
    {

        [DataMember(Name = "result")]
        public ScreenerResultItem[] Results { get; set; }


        [DataMember(Name ="error")]
        public ErrorInfo Error { get; set; }


        public ScreenerFinance()
        {
        }
    }
}
