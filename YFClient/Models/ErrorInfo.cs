using System;
using System.Runtime.Serialization;

namespace YFClient.Models
{
    [DataContract]
    public class ErrorInfo
    {
        [DataMember(Name ="code")]
        public string Code { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        public ErrorInfo()
        {

        }
    }
}
