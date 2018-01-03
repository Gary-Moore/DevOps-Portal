using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DevOps.Portal.Infrastructure.Configuration;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;

namespace DevOps.Portal.Data
{
    public class DevOpsPortalRepository<T> : IDevOpsPortalRepository<T> where T : class 
    {
        private readonly DocumentClient _client;

        public DevOpsPortalRepository(IConfiguration configuration)
        {
            _client = new DocumentClient(new Uri(configuration.StorageUriEndpoint), configuration.StorageAccountKey);
        }

        public async Task<T> GetItemAsync(string id)
        {
            try
            {
                var document =
                    await _client.ReadDocumentAsync(
                        CreateUri(id));
                return (T) (dynamic) document;
            }
            catch (DocumentClientException e)
            {
                if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return null;
                }
                throw;
            }
        }

        public async Task<IEnumerable<T>> GetItemsAysnc(Expression<Func<T, bool>> predicate)
        {
            IDocumentQuery<T> query = _client
                .CreateDocumentQuery<T>(CreateUri(),
                    new FeedOptions()
                    {
                        MaxItemCount = -1
                    }).Where(predicate)
                .AsDocumentQuery();

            var results = new List<T>();
            while (query.HasMoreResults)
            {
                results.AddRange(await query.ExecuteNextAsync<T>());
            }

            return results;
        }
        
        public async Task<Document> CreateAsync(T item)
        {
            return await _client.CreateDocumentAsync(CreateUri(), item);
        }

        public async Task<Document> UpdateItemAsync(string id, T item)
        {
            return await _client.ReplaceDocumentAsync(CreateUri(id), item);
        }

        public async Task DeleteItemAsync(string id)
        {
            await _client.DeleteDocumentAsync(CreateUri(id));
        }

        private static Uri CreateUri(string id = null)
        {
            if (id == null)
            {
                return UriFactory.CreateDocumentCollectionUri("DevopsPortal", "SolutionTemplates");
            }
            return UriFactory.CreateDocumentUri("DevopsPortal", "SolutionTemplates", id);
        }
    }
}
