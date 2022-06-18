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
    public class FacultateController : ApiController
    {
        private IFacultateService service = new FacultateService();

        [HttpGet]

        public IHttpActionResult List()
        {
            try
            {
                IEnumerable<ServiceLayer.ListaFacultati_SP_Result> result = service.List();
                if (result.Count() > 0)
                    return Ok(result);
                else
                    return StatusCode(HttpStatusCode.NoContent);
            }
            catch(Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
