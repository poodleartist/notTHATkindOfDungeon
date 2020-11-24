using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using notTHATkindOfDungeon.Models;

namespace notTHATkindOfDungeon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is about notTHATkindOfDungeon. Don't blame us for the title's warning.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "This is a Contact Page, might not be what you're looking for however it's notThatkindofContactPage. hahaha";

            return View();
        }
        
        public IActionResult CreateGearForm()
        {
            ViewData["Message"] = "Create Gear for the shop here.";
            return View();
        }

        public IActionResult AddItem(CreateGear createGear)
        {
            if (ModelState.IsValid)
            {
                //TODO: store created gear in database
                Repository.AddGear(createGear);
                return View("ItemAdded", createGear);
            }
            else
            {
                //there is a validation error
                return View("CreateGearForm");
            }
        }

        public IActionResult ShowShop()
        {
            return View(Repository.CreateGears);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
