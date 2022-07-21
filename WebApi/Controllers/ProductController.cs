using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ProductController : ApiController
    {
        static List<String> Products = new List<string>()
        {
            "Mobile", "Laptop", "TV"
        };

        [HttpGet]
        public List<string> GetProduct()
        {
            return Products;
        }

        [HttpGet]
        public string GetProductById( int id)
        {
            return Products[id];
        }

       [HttpGet]

       public void AddProduct(string Name)
        {
            Products.Add(Name);
        }
    }
}
