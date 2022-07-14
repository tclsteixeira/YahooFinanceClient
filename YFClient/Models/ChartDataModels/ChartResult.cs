﻿using System;
using System.Runtime.Serialization;


namespace YFClient.Models.ChartDataModels
{

    [DataContract]
    public class ChartResult : JSonClass
    {

        [DataMember(Name ="result")]
        public ChartResultItem[] Result { get; set; }

        [DataMember(Name ="error")]
        public ErrorInfo Error { get; set; }


        public ChartResult()
        {
        }
    }

}
