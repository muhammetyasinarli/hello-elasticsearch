using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workshop.Data;
using workshop.Mapping;

namespace workshop.Services
{
    public class ElasticsearchService : IElasticsearchService
    {
        private readonly IElasticClient _elasticClient;

        public ElasticsearchService(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public async Task<IEnumerable<T>> GetDocuments<T>() where T:class
        {
            var response = await _elasticClient.SearchAsync<T>();
            return response.Documents.ToList();
        }

        public async Task InsertDocument<T>(T item) where T : class
        {           
            await _elasticClient.IndexDocumentAsync<T>(item);
        }
    }
}
