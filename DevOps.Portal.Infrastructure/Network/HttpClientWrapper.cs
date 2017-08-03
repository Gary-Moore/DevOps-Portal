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
        public async Task<T> GetDataAsync<T>(Uri url, ICredentials credentials = null) where T : class
        {
            try
            {
                using (var handler = new HttpClientHandler{ Credentials = credentials }) 
                using (var client = new HttpClient(handler))
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.GetStringAsync(url);
                    return JsonConvert.DeserializeObject<T>(response);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public async Task<NetworkResponse<T>> PostDataAsync<T>(Uri url, string data, string contentType, ICredentials credentials,
            Func<string, T> convertAction) where T : class
        {
            var content = new StringContent(data, System.Text.Encoding.UTF8, contentType);
            try
            {
                using (var handler = new HttpClientHandler { Credentials = credentials })
                using (var client = new HttpClient(handler))
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                    var response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var reponseContent = await response.Content.ReadAsStringAsync();
                        var contentData  = convertAction(reponseContent);
                        return new NetworkResponse<T>(contentData);
                    }

                    return new NetworkResponse<T>(new [] {response.ReasonPhrase});
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<T> SendDataAsync<T>(Uri url, string data, HttpMethod httpMethod, string contentType, ICredentials credentials,
            Func<string, T> convertAction) where T : class
        {
            try
            {
                using (var handler = new HttpClientHandler() { Credentials = credentials })
                using (var client = new HttpClient(handler))
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var requestContent = new HttpRequestMessage(httpMethod, url)
                    {
                        //Content = new StringContent(data)
                    };
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


        public async Task<T> SendDataAsync<T>(Uri url, string data, ICredentials credentials,
            Func<string, T> convertAction) where T : class
        {
            try
            {
                using (var handler = new HttpClientHandler() {Credentials = credentials})
                using (var client = new HttpClient(handler))
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var requestContent = new HttpRequestMessage(HttpMethod.Get, url)
                    {
                        //Content = new StringContent(data)
                    };
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
    }
}
