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
            if (String.Empty == id) { id = Convert.ToString(1); }
            ViewData["step_id"] =id;
            return View("Step");
        }
	}
}