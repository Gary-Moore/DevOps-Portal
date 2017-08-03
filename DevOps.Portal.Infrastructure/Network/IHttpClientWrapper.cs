using System;
using System.Net;
using System.Threading.Tasks;

namespace DevOps.Portal.Infrastructure.Network
{
    public interface IHttpClientWrapper
    {
        Task<T> GetDataAsync<T>(Uri url, ICredentials credentials = null) where T : class;

        Task<NetworkResponse<T>> PostDataAsync<T>(Uri url, string data, string contentType, ICredentials credentials,
            Func<string, T> convertAction) where T : class;

        Task<T> SendDataAsync<T>(Uri url, string data, ICredentials credentials,
            Func<string, T> convertAction) where T : class;
    }
}