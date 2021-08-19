using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workshop.Data;
using workshop.Services;

namespace workshop.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Private Members

        private readonly IElasticsearchService _service;

        #endregion

        #region Constructor

        public ProductController(IElasticsearchService service)
        {
            _service = service;
        }

        #endregion


        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _service.GetDocuments<Product>();
        }


        [HttpPost]
        public async Task SaveProduct([FromBody]Product product)
        {
            await _service.InsertDocument(product);
        }
    }
}
