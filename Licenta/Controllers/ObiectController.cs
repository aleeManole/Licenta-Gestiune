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
    public class ObiectController : ApiController
    {
        private IObiectService service = new ObiectService();

        [HttpPost]
        public IHttpActionResult Add(long idObiect, string nume, string categorie)
        {
            try
            {
                var result = service.Add(idObiect, nume, categorie);
                return Ok(result);
            }
            catch(Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        [HttpPut]
        public IHttpActionResult Update(long idObiect, string nume, string categorie)
        {
            try
            {
                service.Update(idObiect, nume, categorie);
                return Ok();
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(long idObiect)
        {
            try
            {
                service.Delete(idObiect);
                return Ok();
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        public IHttpActionResult List()
        {
            try
            {
                IEnumerable<ServiceLayer.ListaObiecte_SP_Result> result = service.List();
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

        [HttpGet]
        public IHttpActionResult GetObiectByNume(string nume)
        {
            try
            {
                IEnumerable<ServiceLayer.IdentifObiectNume_SP_Result> result = service.GetObiectByNume(nume);
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
