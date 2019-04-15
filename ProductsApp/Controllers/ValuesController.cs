using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        /// Http verbs: Httpget, HttpPut, HttpPost, HttpDelete, HttpHead, HttpOptions, HttpPatch
        /// </summary>
        /// <returns>HttpResponseMessage</returns>
        
        
        //[Route("api/{Controller}/getvalue")]
        /// <summary>
        /// You can override the action name by using the [ActionName] attributre
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetValue")]
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

        /// <summary>
        /// Retrieve the product details
        /// </summary>
        /// <returns>HttpResponseMessage</returns>
        public HttpResponseMessage GetProductDetails()
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns>returns build-in actionresult</returns>
        [HttpGet]
        [Route("api/{controller}/GetCustomAR")]
        public IHttpActionResult GetCustomAR()
        {
            return new TextResult("Hello, World!", Request);
        }
        #endregion
    }

    /// <summary>
    /// Asynchronously creates an HttpRespinseMessage
    /// It was introduced in Web API 2.0
    /// If a controllor action returns an IHttpActionResult, 
    /// Web API calls the ExecureAsync method tho create an HttpResponseMessage. 
    /// Then it converts the HttpResponseMessage into an Http response message.
    /// </summary>
    public class TextResult : IHttpActionResult
    {
        string _value;
        HttpRequestMessage _request;
        public TextResult(string value, HttpRequestMessage request)
        {
            _value = value;
            _request = request;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage()
            {
                Content = new StringContent(_value),
                RequestMessage = _request
            };
            return Task.FromResult (response);
        }
    }

}
