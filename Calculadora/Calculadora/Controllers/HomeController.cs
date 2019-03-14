using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculadora.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }  
        // GET: Post
        [HttpPost]
        public ActionResult Index(string btn,string visor){
            return View();
        }
    }
}