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
        public async Task<T> GetDataAsync<T>(Uri url, string data, ICredentials credentials,
            Func<string, T> convertAction) where T : class
        {
            try
            {
                using (var handler = new HttpClientHandler() { Credentials = credentials })
                using (var client = new HttpClient(handler))
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaContentTypes.Json));
                    var requestContent = new HttpRequestMessage(HttpMethod.Get, url);
                    var response = await client.SendAsync(requestContent);
                    var content = await response.Content.ReadAsStringAsync();
                    return convertAction(content);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
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

                    var requestContent = new StringContent(data, System.Text.Encoding.UTF8, contentType);
                    var requestMessage = new HttpRequestMessage(httpMethod, url) {Content = requestContent};

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
