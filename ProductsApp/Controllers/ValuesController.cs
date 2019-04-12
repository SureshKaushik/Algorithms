using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ValuesController : ApiController
    {

        #region Acion Results in Web API 2

        /// <summary>
        /// return type = void
        /// Return empty 204 (No Content)
        /// </summary>
        public void Post()
        {

        }

        /// <summary>
        /// return type = HttpResponseMessage
        /// Convert directly to an HTTP response message.
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "value");
            response.Content = new StringContent("hello", Encoding.Unicode);
            response.Headers.CacheControl = new CacheControlHeaderValue()
            {
                MaxAge = TimeSpan.FromMinutes(20)
            };
            return response;
        }

        public HttpResponseMessage Get()
        {
            Product[] products = new Product[]
            {
                new Product{Id =1, Name = "Tomato Soup", Category = "Groceries", Price=1},
                new Product{Id =2, Name = "Hammer", Category = "Hardware", Price=2},
                new Product{Id =3, Name = "Kids Toy", Category = "Toys", Price=3}
            };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, products);
            return response;
        }

        ////////
        #endregion
    }
}
