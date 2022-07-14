using System;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace YFClient
{

    /// <summary>
    /// Web client base class for Yahoo client.
    /// </summary>
    public class WebClient : IWebClient
    {
        private static HttpClient mClient = new HttpClient();
        private readonly string mAPIKey = string.Empty;


        /// <summary>
        /// Initializes a new instance of the <see cref="T:YFClient.WebClient"/> class.
        /// </summary>
        /// <param name="APIKey">Your Yahoo finance API key.</param>
        public WebClient(string APIKey)
        {
            this.mAPIKey = APIKey;
        }


        /// <summary>
        /// Checks if an internet connection is available.
        /// </summary>
        /// <returns>Returns <c>true</c>, if internet connection available, <c>false</c> otherwise.</returns>
        public static bool IsInternetAvailable()
        {
            const string host = "www.google.com";
            try
            {
                Dns.GetHostEntry(host); //using System.Net;
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }


        /// <summary>
        /// Sets the base address.
        /// </summary>
        /// <param name="client">The http client instance.</param>
        /// <param name="baseAddr">The base address.</param>
        private void SetBaseAddr(HttpClient client, string baseAddr)
        {
            if (client.BaseAddress != null)
            {
                if (client.BaseAddress.AbsoluteUri == baseAddr)
                {
                    // do nothing
                    System.Diagnostics.Debug.WriteLine("Same base address.");
                    return;
                }
                else
                {
                    // different base address
                    client.Dispose();
                    client = new HttpClient();

                    System.Diagnostics.Debug.WriteLine("New base address.");
                }
            }
            else
            {
            }

            client.BaseAddress = new Uri(baseAddr);
        }



        #region IWebClient interface implementation


        /// <summary>
        /// Downloads json file from Yahoo finance service using the specified URL.
        /// </summary>
        /// <returns>The requested json file if succeeded.</returns>
        /// <param name="baseAddr">The host base address.</param>
        /// <param name="endPoint">The API end point.</param>
        /// <param name="pars">Other request parameters.
        /// 
        /// ex: In some API end points you must provide query parameters.
        /// 
        /// </param>
        public async Task<string> DownloadFile(string baseAddr, string endPoint, string pars = "")
        {
            string JSONContent = string.Empty;
            this.SetBaseAddr(mClient, baseAddr);

            mClient.DefaultRequestHeaders.Clear();
            mClient.DefaultRequestHeaders.Add("X-API-KEY", this.mAPIKey);
            mClient.DefaultRequestHeaders.Add("accept", "application/json");

            string parStr = "";
            if (!string.IsNullOrWhiteSpace(pars))
                parStr = "?" + pars;

            // Note: If using await thows an exception
            //       Maybe a bug in mono httpclient class????
            JSONContent = mClient.GetStringAsync(endPoint + parStr).Result;
            return JSONContent;
        }

        #endregion IWebClient interface implementation


    }

}
