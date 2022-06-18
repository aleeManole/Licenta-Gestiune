using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Microsoft.AspNetCore.Cors;
using ServiceLayer.Attributes;
using ServiceLayer.Classes;
using ServiceLayer.Interfaces;

namespace Licenta.Controllers
{
    public class SubinventarController : ApiController
    {
        private ISubinventarService service = new SubinventarService();

        [HttpPost]
        public IHttpActionResult Add(SubinventarAttributes subinventarAttributes)
        {
            try
            {
                var result = service.Add(subinventarAttributes);
                return Ok(result);
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public IHttpActionResult Update(SubinventarAttributes subinventarAttributes)
        {
            try
            {
                service.Update(subinventarAttributes);
                return Ok();
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete]
        [EnableCors]
        public IHttpActionResult Delete(long idSubinventar)
        {
            try
            {
                service.Delete(idSubinventar);
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
                IEnumerable<ServiceLayer.ListaSubinv_SP_Result> result = service.List();
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
        public IHttpActionResult SubinvByObj(long id)
        {
            try
            {
                IEnumerable<ServiceLayer.IdentifSubinvObiect_Result> result = service.SubinventareByObj(id);
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
