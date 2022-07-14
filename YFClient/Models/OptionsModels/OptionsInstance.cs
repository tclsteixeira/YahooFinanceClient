using System;
using System.Runtime.Serialization;

namespace YFClient.Models.OptionsModels
{

    /// <summary>
    /// Options instance.
    /// </summary>
    [DataContract]
    public class OptionsInstance : JSonClass
    {

        [DataMember(Name ="optionChain")]
        public OptionChain OptionChain { get; set; }

        public OptionsInstance()
        {
        }
    }
}
