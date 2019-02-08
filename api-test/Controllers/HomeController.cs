using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_test.Controllers
{
    [Route("/")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult<string> Index() 
        //public IActionResult Index()
        {
            var pid = BL.Pid.Get();
            return $"PID:{pid}";
        }
    }
}