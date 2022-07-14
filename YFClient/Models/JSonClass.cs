using System;
using System.Runtime.Serialization;

namespace YFClient.Models
{

    [DataContract]
    public class JSonClass
    {

        /// <summary>
        /// Gets or sets the JSon file content.
        /// </summary>
        /// <value>The JSon content.</value>
        public string JSonTxt { get; set; }

        public JSonClass()
        {
        }

    }

}
