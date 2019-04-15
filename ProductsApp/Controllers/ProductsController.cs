using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        #region Get Started with ASP.NET Web API 2
        //
        // GET: /Products/
        Product[] products = new Product[]
        {
            new Product{Id =1, Name = "Tomato Soup", Category = "Groceries", Price=1},
            new Product{Id =2, Name = "Hammer", Category = "Hardware", Price=2},
            new Product{Id =3, Name = "Kids Toy", Category = "Toys", Price=3}
        };

        public IEnumerable<Product > GetAllProducts()
        {
            return products;
        }


        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                // If the requst does not match an existing product ID, 
                // the controller calls ApiController.NotFound to create a 404 (Not Found) response.
                return NotFound();  //Returns a NotFoundResult
            }
            return Ok(product); // Returns an OkNegotiatedContentResult
        }

        #endregion

    }
}