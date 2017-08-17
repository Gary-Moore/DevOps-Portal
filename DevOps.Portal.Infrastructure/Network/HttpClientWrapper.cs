using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DevOps.Portal.Infrastructure.Network
{
    public class HttpClientWrapper : IHttpClientWrapper
    {
        public async Task<NetworkResponse<T>> GetDataAsync<T>(Uri url, string data, string contentType, ICredentials credentials,
            Func<string, T> convertAction) where T : class
        {
            return await SendDataAsync(url, data, contentType, HttpMethod.Get, credentials, convertAction);
        }

        public async Task<NetworkResponse<T>> PostDataAsync<T>(Uri url, string data, string contentType, ICredentials credentials,
            Func<string, T> convertAction) where T : class
        {
            return await SendDataAsync(url, data, contentType, HttpMethod.Post, credentials, convertAction);
        }
        
        public async Task<NetworkResponse<T>> PutDataAsync<T>(Uri url, string data, string contentType, ICredentials credentials,
            Func<string, T> convertAction) where T : class
        {
            return await SendDataAsync(url, data, contentType, HttpMethod.Put, credentials, convertAction);
        }

        private static async Task<NetworkResponse<T>> SendDataAsync<T>(Uri url, string data, string contentType, HttpMethod httpMethod, ICredentials credentials,
            Func<string, T> convertAction) where T : class
        {
            try
            {
                using (var handler = new HttpClientHandler { Credentials = credentials })
                using (var client = new HttpClient(handler))
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaContentTypes.Json));

                    var requestMessage = new HttpRequestMessage(httpMethod, url);
                    if (data != null)
                    {
                        var requestContent = new StringContent(data, System.Text.Encoding.UTF8, contentType);
                        requestMessage.Content = requestContent;
                    }

                    var response = await client.SendAsync(requestMessage);

                    var reponseContent = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        var contentData = convertAction(reponseContent);
                        return new NetworkResponse<T>(contentData);
                    }

                    return new NetworkResponse<T>(new[] { reponseContent });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
