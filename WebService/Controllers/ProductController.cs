using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService.Models;

namespace WebService.Controllers
{
    public class ProductController : ApiController
    {
        Productos[] Product = new Productos[]
        {
                new Productos { Codigo = 1, Nombre = "Celular", Precio = 150000, Fotografia = "http://thumbs.buscape.com.br/celular-e-smartphone/smartphone-samsung-galaxy-j5-sm-j500m_200x200-PU960bf_1.jpg"},
                new Productos { Codigo = 2, Nombre = "Audifonos", Precio = 8000, Fotografia = "http://cdn1.coppel.com/images/catalog/pm/2421313-1.jpg?iresize=width:300,height:240"},
                new Productos { Codigo = 3, Nombre = "Reloj", Precio = 25000, Fotografia = "https://media.linio.com.co/p/smart-watch-9257-5858412-1-product.jpg"},
                new Productos { Codigo = 4, Nombre = "Parlantes", Precio = 20000, Fotografia = "http://falabella.scene7.com/is/image/FalabellaCO/2004297_1?$producto308$&iv=kDrnd3&wid=924&hei=924&fit=fit,1"},
                new Productos { Codigo = 5, Nombre = "Foco", Precio = 2500, Fotografia = "https://ae01.alicdn.com/kf/HTB1b94DLXXXXXXVXFXXq6xXFXXXr/La-gran-muralla-cree-led-mini-linterna-foco-larga-viga-de-la-l%C3%A1mpara-de-mano-18650.jpg"}

        };

        [Route("Product/getall")]
        public HttpResponseMessage GetAllProducts()
        {

            // Get a list of products from a database.
            IEnumerable<Productos> productsList = Product;

            // Write the list to the response body.
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, productsList);
            response.Headers.Add("Access-Control-Allow-Headers", "User-Agent, Content-Type, Accept, X-ApplicationId, Authorization, Host, Content-Length");
            response.Headers.Add("Access-Control-Allow-Methods", "*");
            response.Headers.Add("Access-Control-Allow-Origin", "*");

            return response;
        }

        [Route("getbyid/{id}")]
        [HttpGet]
        public HttpResponseMessage GetProduct(int id)
        {


            var product = Product.FirstOrDefault((p) => p.Codigo == id);
            if (product == null)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.NoContent, "");
                response.Headers.Add("Access-Control-Allow-Headers", "User-Agent, Content-Type, Accept, X-ApplicationId, Authorization, Host, Content-Length");
                response.Headers.Add("Access-Control-Allow-Methods", "*");
                response.Headers.Add("Access-Control-Allow-Origin", "*");
                return response;
            }
            else
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, product);
                response.Headers.Add("Access-Control-Allow-Headers", "User-Agent, Content-Type, Accept, X-ApplicationId, Authorization, Host, Content-Length");
                response.Headers.Add("Access-Control-Allow-Methods", "*");
                response.Headers.Add("Access-Control-Allow-Origin", "*");
                return response;
            }
        }
    }
}

   