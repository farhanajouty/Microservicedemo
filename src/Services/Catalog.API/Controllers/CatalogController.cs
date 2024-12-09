using Catalog.API.Interfaces.Manager;
using Catalog.API.Models;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System.Net;

namespace Catalog.API.Controllers
{
    
    [ApiController]
    public class CatalogController : BaseController
    {
        IProductManager _productManager;
        public CatalogController(IProductManager productManager) {

            _productManager = productManager;

        }

        [HttpGet]
        [Route("api/Catalog/GetProducts")]
        [ProducesResponseType(typeof(IEnumerable<Product>),(int)HttpStatusCode.OK)]
        public IActionResult GetProducts()
        {

            try
            {
                var product = _productManager.GetAll();
                return CustomResult(product, HttpStatusCode.Accepted);
            }
            catch (Exception ex)
            {

                return CustomResult(ex.Message,HttpStatusCode.BadRequest);
            }
          


        }


        [HttpGet]
        [Route("api/Catalog/AddProduct")]
        [ProducesResponseType(typeof(IEnumerable<Product>), (int)HttpStatusCode.OK)]
        public IActionResult AddProduct([FromBody]Product product)
        {

            try
            {
                product.Id=ObjectId.GenerateNewId().ToString();
                var isSaved = _productManager.Add(product);

                return CustomResult(product, HttpStatusCode.Accepted);
            }
            catch (Exception ex)
            {

                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }



        }

    }
}
