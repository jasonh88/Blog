using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers.Api
{
    public class CacheController : Controller
    {
        // GET: Cache
        public ActionResult Index()
        {
            return View();
        }
    }
}