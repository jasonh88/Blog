using Blog.Models.ViewModels;
using Blog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Blog.Controllers
{
    [RoutePrefix("api/progress")]
    public class ProgressApiController : ApiController
    {
        [HttpGet]
        [Route]
        public HttpResponseMessage GetProgress()
        {
            ProgressService progSvc = new ProgressService();
            List<Progress> progressList = progSvc.GetProgress();
            return Request.CreateResponse(HttpStatusCode.OK, progressList);
        }

        [HttpPost]
        [Route]
        public HttpResponseMessage CreateProgress(Progress model)
        {
            ProgressService progSvc = new ProgressService();
            int id = progSvc.CreateProgress(model);
            return Request.CreateResponse(HttpStatusCode.OK, id);
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage DeleteProgress(int id)
        {
            ProgressService progSvc = new ProgressService();
            progSvc.DeleteProgress(id);
            return Request.CreateResponse(HttpStatusCode.OK, id);
        }

        [HttpPut]
        [Route("{id}")]
        public HttpResponseMessage UpdateProgress([FromUri] int id, [FromBody]Progress model)
        {
            ProgressService progSvc = new ProgressService();
            progSvc.UpdateProgress(id, model);
            return Request.CreateResponse(HttpStatusCode.OK, id);
        }
    }
}
