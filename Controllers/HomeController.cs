using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Miguel.Models;

namespace Miguel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.eunaoacredito = "Miguel"; 
            ViewData["nome"] = "Nallar";

            //return View();
            //return Content("Eu não acredito");
            //return Redirect("https://www.univille.edu.br/");
            //return RedirectToAction("Privacy"); //Muito utilizado nas telas de Login. Verificação

            /*var item = new {
                Nome = "Zezinho",
                Endereco = "Rua lalala"

            };

            return Json(item);
        }*/

        byte[] fileBytes = System.IO.File.ReadAllBytes(@"C:\Miguel\wwwroot\favicon.ico"); 
        return File(fileBytes, System.Net.Mime.MediaTypeNames.Image.Jpeg);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
