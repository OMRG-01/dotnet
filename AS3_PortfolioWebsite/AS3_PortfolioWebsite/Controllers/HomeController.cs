using System.Diagnostics;
using AS3_PortfolioWebsite.Models;
using Microsoft.AspNetCore.Mvc;



namespace PortfolioWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult TechSkills()
        {
            return View();
        }

        public ActionResult Download()
        {
            return View();
        }
    }
}
