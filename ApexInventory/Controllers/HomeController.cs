using ApexInventory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic;

namespace ApexInventory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Item> listItems = new List<Item>()
            {
               new Item() { ItemId = 101, Name = "Lamp", Description = "Info.." },
               new Item() { ItemId = 102, Name = "Vase", Description = "Info.." },
               new Item() {ItemId = 103, Name = "Cupboard", Description = "Info.."},
               new Item() {ItemId = 104, Name = "Computer", Description = "Info.."},
               new Item() {ItemId = 105, Name = "Chair", Description = "Info.."}
            };
            return View(listItems);
        }

        public IActionResult Details(int Id)
        {
            var itemDetails = new Item() { ItemId = Id, Name = "Lamp", Description = "Info..." };

            return View(itemDetails);
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