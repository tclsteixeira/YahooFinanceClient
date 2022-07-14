using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module calendarEvents.
    /// </summary>
    [DataContract]
    public class CalendarEvents
    {

        [DataMember(Name = "maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "exDividendDate")]
        public FormatedData ExDividendDate { get; set; }

        [DataMember(Name = "dividendDate")]
        public FormatedData DividendDate { get; set; }

        [DataMember(Name = "earnings")]
        public CalendarEventsEarnings Earnings { get; set; }


        public CalendarEvents()
        {
        }

    }

}
