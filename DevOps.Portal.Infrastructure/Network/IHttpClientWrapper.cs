using System.Net;
using System.Threading.Tasks;

namespace DevOps.Portal.Infrastructure.Network
{
    public interface IHttpClientWrapper
    {
        Task<T> GetDataAsync<T>(string url, ICredentials credentials = null) where T : class;
        Task<string> PostDataAsync(string url, string data, ICredentials credentials);
    }
}