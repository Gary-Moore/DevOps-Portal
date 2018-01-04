using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;

namespace DevOps.Portal.Data
{
    public interface IDevOpsPortalRepository<T> where T : class
    {
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAysnc(Expression<Func<T, bool>> predicate);
        Task<Document> CreateAsync(T item);
        Task<Document> UpdateItemAsync(string id, T item);
        Task DeleteItemAsync(string id);
    }
}