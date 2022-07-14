using System;
using System.Runtime.Serialization;

namespace YFClient.Models.ScreenersModels
{

    [DataContract]
    public class CriteriaItem
    {

        [DataMember(Name ="field")]
        public string Field { get; set; }

        [DataMember(Name = "operators")]
        public string[] Operators { get; set; }

        [DataMember(Name = "values")]
        public decimal?[] Values { get; set; }

        [DataMember(Name = "labelsSelected")]
        public string[] LabelsSelected { get; set; }


        public CriteriaItem()
        {
        }
    }
}
