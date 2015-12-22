using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PClement.Club.Models.Config;
using Microsoft.Extensions.OptionsModel;

namespace PClement.Club.Controllers
{
    public class HomeController : Controller
    {
        private IOptions<FooConfig> _config;

        public HomeController(IOptions<FooConfig> fooConfig)
        {
            _config = fooConfig;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = _config.Value.Bar;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
