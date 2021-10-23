using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rife_rafe_backend.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            
        }

        public ActionResult validateSession(string view)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                if (string.IsNullOrEmpty(token))
                {
                    return Redirect("/auth");
                }
            }
            catch (Exception ex)
            {
                return Redirect("/auth");
            }
            return View(view);
        }
    }
}
