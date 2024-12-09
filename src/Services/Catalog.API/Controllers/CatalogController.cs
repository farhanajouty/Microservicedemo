﻿using Catalog.API.Interfaces.Manager;
using Catalog.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Catalog.API.Controllers
{
    
    [ApiController]
    public class CatalogController : ControllerBase
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
            var product = _productManager.GetAll();
            return Ok(product);


        }

    }
}
