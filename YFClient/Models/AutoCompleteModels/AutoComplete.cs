using System;
using System.Runtime.Serialization;

namespace YFClient.Models.AutoCompleteModels
{

    /// <summary>
    /// Main class for autoComplete API.
    /// </summary>
    [DataContract]
    public class AutoComplete : JSonClass
    {

        [DataMember(Name ="ResultSet")]
        public AutoCompleteResultSet ResultSet { get; set; }

        [DataMember(Name ="error")]
        public ErrorInfo Error { get; set; }

        public AutoComplete()
        {
        }

    }
}
