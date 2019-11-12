using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pluralSight.Models;
using pluralSight.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pluralSight.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        // GET: /<controller>/
        //public ViewResult List()
        public IActionResult Get()
        {
            var model = new HomeViewModel();
            model.Greeting = "Okok";
            return View(model);
        }
    }
}
