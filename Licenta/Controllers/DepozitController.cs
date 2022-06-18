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
    public class DepozitController : ApiController
    {
        private IDepozitService service = new DepozitService();

        [HttpGet]
        public IHttpActionResult List()
        {
            try
            {
                IEnumerable<ServiceLayer.ListaDepozite_SP_Result> result = service.List();
                return Ok(result);
            }
            catch(Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
