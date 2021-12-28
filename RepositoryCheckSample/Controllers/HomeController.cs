using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepositoryCheckSample.Controllers
{
    
    public class HomeController : Controller
    {
        //home controller
        public ActionResult Index()
        {
            return View();
        }

    }
}