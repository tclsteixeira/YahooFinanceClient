using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ScreenersModels
{

    /// <summary>
    /// Screeners instance.
    /// </summary>
    [DataContract]
    public class ScreenersInstance : JSonClass
    {

        [DataMember(Name ="finance")]
        public ScreenerFinance Finance { get; set; }


        public ScreenersInstance()
        {
        }
    }
}
