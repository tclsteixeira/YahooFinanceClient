using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class CompanyOfficer
    {

        [DataMember(Name ="maxAge")]
        public decimal MaxAge { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "age")]
        public int Age { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "yearBorn")]
        public int YearBorn { get; set; }

        [DataMember(Name = "fiscalYear")]
        public int FiscalYear { get; set; }

        [DataMember(Name = "totalPay")]
        public FormatedData TotalPay { get; set; }

        [DataMember(Name = "exercisedValue")]
        public FormatedData ExercisedValue { get; set; }

        [DataMember(Name = "unexercisedValue")]
        public FormatedData UnexercisedValue { get; set; }


        public CompanyOfficer()
        {
        }

    }


}
