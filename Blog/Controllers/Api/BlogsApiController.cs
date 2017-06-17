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
    [RoutePrefix("api/blogs")]
    public class BlogsApiController : ApiController
    {
        [HttpGet]
        [Route]
        public HttpResponseMessage GetBlogs()
        {
            BlogsService blogsSvc = new BlogsService();
            List<Blogs> blogList = blogsSvc.GetBlogs();
            return Request.CreateResponse(HttpStatusCode.OK, blogList);
        }

        [HttpPost]
        [Route]
        public HttpResponseMessage CreateBlog(Blogs model)
        {
            BlogsService blogSvc = new BlogsService();
            int id = blogSvc.CreateBlog(model);
            return Request.CreateResponse(HttpStatusCode.OK, id);
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage DeleteBlog(int id)
        {
            BlogsService blogSvc = new BlogsService();
            blogSvc.DeleteBlog(id);
            return Request.CreateResponse(HttpStatusCode.OK, id);
        }

        [HttpPut]
        [Route("{id}")]
        public HttpResponseMessage UpdateBlog([FromUri] int id, [FromBody]Blogs model)
        {
            BlogsService blogSvc = new BlogsService();
            blogSvc.UpdateBlog(id, model);
            return Request.CreateResponse(HttpStatusCode.OK, id);
        }

    }
}

