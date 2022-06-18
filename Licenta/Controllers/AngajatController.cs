using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiceLayer.Interfaces;
using ServiceLayer.Classes;

namespace Licenta.Controllers
{
    public class AngajatController : ApiController
    {
        private IAngajatService service = new AngajatService();

        [HttpGet]

        public IHttpActionResult List(int id)
        {
            try
            {
                IEnumerable<ServiceLayer.IdentifAngajFacult_Result> result = service.List(id);
                return Ok(result);
            }
            catch(Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
