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
        // Following code is to try to get the gear to save in the database
        // Once it's working, I might move to a separate "GearController"
       //private CreateGearDbContext db = new CreateGearDbContext();
       
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
        
        public IActionResult AddItem(Gear createGear)
        {   // the following if statement only allows items to be created
            // if the required fields are filled out
            if (ModelState.IsValid)
            {
                // now storing in database, don't need repository
                // Repository.AddGear(createGear);
                
                return View("ItemAdded", createGear);
            }
            else
            {
                //there is a validation error
                return View("CreateGearForm");
            }
        }

        public IActionResult ShowShop()
        { // getting rid of the repository, as it resets every time you restart the program,
          // replacing with an actual database to pull things from
          //  return View(Repository.CreateGears);
          //  var gear = from g in db.CreateGears
          //             orderby g.ItemName
          //            select g;
          // return View(gear);
            return View();

        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
