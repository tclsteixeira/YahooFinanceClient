using System.Threading.Tasks;

namespace YFClient
{

    /// <summary>
    /// Web client interface.
    /// </summary>
    public interface IWebClient
    {
        Task<string> DownloadFile(string baseAddr, string endPoint, string pars = "");
    }

}
