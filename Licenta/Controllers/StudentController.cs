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
    public class StudentController : ApiController
    {
        private IStudentService service = new StudentService();

        [HttpGet]
        public IHttpActionResult List(int id)
        {
            try
            {
                IEnumerable<ServiceLayer.IdentifStudentFacult_SP_Result> result = service.List(id);
                return Ok(result);
            }
            catch(Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message);
            }
        } 

        [HttpGet]
        public IHttpActionResult StudentByCNP(string cnp)
        {
            try
            {
                ServiceLayer.IdentifStudentCnp_SP_Result result = service.StudentByCNP(cnp);
                return Ok(result);
            }
            catch(Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
