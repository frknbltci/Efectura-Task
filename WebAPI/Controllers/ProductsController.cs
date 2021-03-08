using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
//using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductsController : ControllerBase
//    {
//        private IProductService _productService;

//        Ioc Container newliyoruz hep ortak bir yerde ordan çağıırıyoruz

//        public ProductsController(IProductService productService)
//        {
//            _productService = productService;
//        }

//        [HttpGet("getall")]
//        public IActionResult GetList()
//        {
//            var result = _productService.GetAll();
//            if (result.Success)
//            {
//                return Ok(result);
//            }

//            return BadRequest(result.Message);


//            return BadRequest();
//        }

//        [HttpGet("getlistbycategory")]
//        public IActionResult GetListByCategory(int categoryId)
//        {
//            var result = _productService.GetListByCategory(categoryId);
//            if (result.Success)
//            {
//                return Ok(result);

//            }
//            return BadRequest(result.Message);

//        }

//        [HttpGet("getbyid")]
//        public IActionResult GetById(int productId)
//        {
//            var result = _productService.GetById(productId);
//            if (result.Success)
//            {

//                return Ok(result);
//            }
//            return BadRequest(result.Message);
//        }

//        [AllowAnonymous]
//        [HttpPost("add")]
//        public IActionResult Add([FromBody] Product product)
//        {
//            var result = _productService.Add(product);
//            if (result.Success)
//            {
//                return Ok(product);

//            }
//            return BadRequest(result.Message);
//        }

//        [HttpGet]
//        public List<Product> Get()
//        {
//            return new List<Product>()
//            {
//                new Product{ProductId=1,ProductName="data1"},
//                new Product{ProductId=2,ProductName="data2"}

//            };
//        }

//    }

}
