using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class CalendarEventsEarnings
    {

        [DataMember(Name = "earningsDate")]
        public FormatedData[] EarningsDate { get; set; }

        [DataMember(Name = "earningsAverage")]
        public FormatedData EarningsAverage { get; set; }

        [DataMember(Name = "earningsLow")]
        public FormatedData EarningsLow { get; set; }

        [DataMember(Name = "earningsHigh")]
        public FormatedData EarningsHigh { get; set; }

        [DataMember(Name = "revenueAverage")]
        public FormatedData RevenueAverage { get; set; }

        [DataMember(Name = "revenueLow")]
        public FormatedData RevenueLow { get; set; }

        [DataMember(Name = "revenueHigh")]
        public FormatedData RevenueHigh { get; set; }


        public CalendarEventsEarnings()
        {
        }

    }
}
