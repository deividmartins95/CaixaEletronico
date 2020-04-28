using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class LogoutController : Controller
    {
        [Route("Logout", Name = "Desconectar")]
        public ActionResult Desconectar()

        {

            Session.Remove("nome");
            return RedirectToAction("Index", "Login");

        }
    }
}
