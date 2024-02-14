using Microsoft.AspNetCore.Mvc;
using Mission06_Galbraith.Models;
using System.Diagnostics;

namespace Mission06_Galbraith.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _context;
        public HomeController(MovieFormContext temp) //Constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Form response) 
        {
            _context.Form.Add(response); //Add record to the database
            _context.SaveChanges();
            return View("FormConfirmation");
        }
    }
}
