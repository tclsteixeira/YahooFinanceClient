using System;
using System.Runtime.Serialization;

namespace YFClient.Models.OptionsModels
{

    [DataContract]
    public class OptionItem
    {

        [DataMember(Name ="expirationDate")]
        public decimal? ExpirationDate { get; set; }

        [DataMember(Name = "hasMiniOptions")]
        public bool? HasMiniOptions { get; set; }

        [DataMember(Name = "calls")]
        public OptionCallPutItem[] Calls { get; set; }

        [DataMember(Name = "puts")]
        public OptionCallPutItem[] Puts { get; set; }


        public OptionItem()
        {
        }
    }
}
