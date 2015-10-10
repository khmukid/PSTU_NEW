using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSTU.Controllers
{
    public class StepsController : Controller
    {
        //
        // GET: /PSTUSteps/
        public ActionResult Step(string id)
        {
            ViewData["step"] = id;
            return View();
        }
	}
}