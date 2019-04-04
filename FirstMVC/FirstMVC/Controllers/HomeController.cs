using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
          public ViewResult Index()
         {
            // int hour = DateTime.Now.Hour;
            //ViewBag.Greeting = hour < 12 ? "Good Moring" : "Good AfterNoon";
            Employee em = new Employee();
            string name = "Mohit";
            int id = 2342;
            em.id = id;
            em.name = name;
             return View("View");
         }
         /*public IActionResult Index()
          {
              return View();
          }

          public IActionResult About()
          {
              ViewData["Message"] = "Your application description page.";

              return View();
          }

          public IActionResult Contact()
          {
              ViewData["Message"] = "Your contact page.";

              return View();
          }

          public IActionResult Privacy()
          {
              return View();
          }

          [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
          public IActionResult Error()
          {
              return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
          }*/
    }
}
