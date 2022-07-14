using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class Earnings
    {

        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name ="earningsChart")]
        public EarningsChart EarningsChart { get; set; }

        [DataMember(Name = "financialsChart")]
        public EarningsFinancialsChart FinancialsChart { get; set; }

        [DataMember(Name = "financialCurrency")]
        public string FinancialCurrency { get; set; }



        public Earnings()
        {
        }

    }

}
