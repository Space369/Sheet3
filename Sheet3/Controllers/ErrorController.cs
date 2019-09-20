using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet3.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error

        [Route("Error/Index/{id}")]
        public ActionResult Index(int id)
        {
            ViewBag.CurrentError = id;
            return View();
        }
    }
}