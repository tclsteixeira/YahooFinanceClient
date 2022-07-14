using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    /// <summary>
    /// Module "insiderTransations".
    /// </summary>
    [DataContract]
    public class InsiderTransactions
    {

        [DataMember(Name ="transactions")]
        public InsiderTransaction[] Transactions { get; set; }

        public InsiderTransactions()
        {
        }
    }

}
