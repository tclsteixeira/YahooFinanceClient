using System;
using System.Runtime.Serialization;

namespace YFClient.Models.AutoCompleteModels
{

    [DataContract]
    public class AutoCompleteResultSet
    {

        [DataMember(Name ="Query")]
        public string Query { get; set; }

        [DataMember(Name ="Result")]
        public AutoCompleteResultItem[] Results { get; set; }

        public AutoCompleteResultSet()
        {
        }
    }
}
