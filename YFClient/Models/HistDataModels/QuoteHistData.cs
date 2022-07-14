using System;
using System.Runtime.Serialization;

namespace YFClient.Models.HistDataModels
{
    [DataContract]
    public class QuoteHistData : JSonClass
    {

        [DataMember(Name ="symbol")]
        public string symbol { get; set; }

        [DataMember(Name = "timestamp")]
        public decimal[] TimeStamps { get; set; }

        [DataMember(Name = "close")]
        public decimal[] Values { get; set; }

        // date
        [DataMember(Name = "end")]
        public decimal End { get; set; }

        // date
        [DataMember(Name = "start")]
        public decimal Start { get; set; }

        [DataMember(Name = "dataGranularity")]
        public decimal DataGranularity { get; set; }

        [DataMember(Name = "previousClose")]
        public decimal PreviousClose { get; set; }

        [DataMember(Name = "chartPreviousClose")]
        public decimal ChartPreviousClose { get; set; }

        [DataMember(Name = "error")]
        public ErrorInfo Error { get; set; }

        public QuoteHistData()
        {
        }
    }
}
