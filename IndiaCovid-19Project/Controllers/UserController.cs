using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndiaCovid_19Project.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [Authorize]
        public ActionResult UserHomePage()
        {
            return View();
        }
       
    }
}