using System;
using System.Runtime.Serialization;

namespace YFClient.Models.OptionsModels
{

    [DataContract]
    public class OptionResultItem
    {

        [DataMember(Name = "underlyingSymbol")]
        public string UnderlyingSymbol { get; set; }

        [DataMember(Name = "expirationDates")]
        public decimal?[] ExpirationDates { get; set; }

        [DataMember(Name = "strikes")]
        public decimal?[] Strikes { get; set; }

        [DataMember(Name = "hasMiniOptions")]
        public bool? HasMiniOptions { get; set; }

        [DataMember(Name = "quote")]
        public OptionsQuote Quote { get; set; }

        [DataMember(Name = "options")]
        public OptionItem[] Options { get; set; }


        public OptionResultItem()
        {
        }
    }
}
