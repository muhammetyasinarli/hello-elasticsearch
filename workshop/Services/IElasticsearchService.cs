using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workshop.Data;

namespace workshop.Services
{
    public interface IElasticsearchService
    {
        Task InsertDocument<T>(T item) where T : class;
        Task<IEnumerable<T>> GetDocuments<T>() where T : class;
    }
}
