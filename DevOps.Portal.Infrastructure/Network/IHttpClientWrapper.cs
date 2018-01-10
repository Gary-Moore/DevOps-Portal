using System;
using System.Net;
using System.Threading.Tasks;

namespace DevOps.Portal.Infrastructure.Network
{
    public interface IHttpClientWrapper
    {
        Task<NetworkResponse<T>> PostDataAsync<T>(Uri url, string data, string contentType, ICredentials credentials,
            Func<string, T> convertAction, CustomHeader customHeader = null) where T : class;

        Task<NetworkResponse<T>> PutDataAsync<T>(Uri url, string data, string contentType, ICredentials credentials,
            Func<string, T> convertAction, string acceptContent = MediaContentTypes.Json, CustomHeader customHeader = null) where T : class;

        Task<NetworkResponse<T>> GetDataAsync<T>(Uri url, string data, string contentType, ICredentials credentials,
            Func<string, T> convertAction, CustomHeader customHeader = null) where T : class;

        Task<NetworkResponse<T>> DeleteDataAsync<T>(Uri url, string data, string contentType, ICredentials credentials,
            Func<string, T> convertAction, CustomHeader customHeader = null) where T : class;

        Task DownloadZip(Uri requestUri, string fileName);
    }
}