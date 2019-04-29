using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap.Controllers
{
    public class BadgesController : Controller
    {
        // GET: Badges
        public ActionResult Index()
        {
            return View();
        }
    }
}