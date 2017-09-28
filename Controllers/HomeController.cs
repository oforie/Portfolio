using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("home/education")]
        public IActionResult Education()
        {
            return View();
        }

        [HttpGet]
        [Route("home/project")]
        public IActionResult projects()
        {
            return View();
        }

        [HttpGet]
        [Route("home/contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
