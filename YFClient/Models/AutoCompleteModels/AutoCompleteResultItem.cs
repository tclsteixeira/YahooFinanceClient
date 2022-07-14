using System;
using System.Runtime.Serialization;

namespace YFClient.Models.AutoCompleteModels
{

    [DataContract]
    public class AutoCompleteResultItem
    {

        [DataMember(Name ="symbol")]
        public string Symbol { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "exch")]
        public string Exch { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "exchDisp")]
        public string ExchDisp { get; set; }

        [DataMember(Name = "typeDisp")]
        public string TypeDisp { get; set; }


        public AutoCompleteResultItem()
        {
        }
    }
}
