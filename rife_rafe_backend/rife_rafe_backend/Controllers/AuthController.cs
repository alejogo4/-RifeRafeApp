using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rife_rafe_backend.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rife_rafe_backend.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: AuthController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            ViewData["DocumentType"] = _context.DocumentType.ToList();
            return View();
        }
    }
}
