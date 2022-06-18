using ServiceLayer.Classes;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Licenta.Controllers
{
    public class TestController : ApiController
    {
        private ITest _service = new Test();
        [HttpGet]
        public IHttpActionResult List(int idFacultate)
        {
            try
            {
                IEnumerable<ServiceLayer.IdentifAngajFacult_Result> result = _service.List(idFacultate);
                if (result.Count() > 0)
                    return Ok(result);
                else
                    return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
