using System;
using System.Net;
using System.Threading.Tasks;

namespace DevOps.Portal.Infrastructure.Network
{
    public interface IHttpClientWrapper
    {
        Task<NetworkResponse<T>> PostDataAsync<T>(Uri url, string data, string contentType, ICredentials credentials,
            Func<string, T> convertAction) where T : class;

        Task<NetworkResponse<T>> PutDataAsync<T>(Uri url, string data, string contentType, ICredentials credentials,
            Func<string, T> convertAction) where T : class;

        Task<T> GetDataAsync<T>(Uri url, string data, ICredentials credentials,
            Func<string, T> convertAction) where T : class;
    }
}