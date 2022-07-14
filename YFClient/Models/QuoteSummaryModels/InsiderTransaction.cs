using System;
using System.Runtime.Serialization;

namespace YFClient.Models.QuoteSummaryModels
{

    [DataContract]
    public class InsiderTransaction
    {

        [DataMember(Name ="maxAge")]
        public int? MaxAge { get; set; }

        [DataMember(Name = "shares")]
        public FormatedData Shares { get; set; }

        [DataMember(Name = "value")]
        public FormatedData Value { get; set; }

        [DataMember(Name = "fileUrl")]
        public string FileUrl { get; set; }

        [DataMember(Name = "transactionText")]
        public string TransactionText { get; set; }

        [DataMember(Name = "filerName")]
        public string FilerName { get; set; }

        [DataMember(Name = "filerRelation")]
        public string FilerRelation { get; set; }

        [DataMember(Name = "moneyText")]
        public string MoneyText { get; set; }

        [DataMember(Name = "startDate")]
        public FormatedData StartDate { get; set; }

        [DataMember(Name = "ownership")]
        public string Ownership { get; set; }


        public InsiderTransaction()
        {
        }
    }
}
