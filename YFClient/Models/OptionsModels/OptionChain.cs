using System;
using System.Runtime.Serialization;

namespace YFClient.Models.OptionsModels
{

    [DataContract]
    public class OptionChain
    {

        [DataMember(Name ="result")]
        public OptionResultItem[] Results { get; set; }

        [DataMember(Name ="error")]
        public ErrorInfo Error { get; set; }


        public OptionChain()
        {
        }
    }

}
