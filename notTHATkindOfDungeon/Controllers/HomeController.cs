using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using notTHATkindOfDungeon.Data;
using notTHATkindOfDungeon.Models;

namespace notTHATkindOfDungeon.Controllers
{
    public class HomeController : Controller
    {
        // Following code is to try to get the gear to save in the database,
        // couldn't get it to work, so ignore the following line for now
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is about notTHATkindOfDungeon. Don't blame us for the title's warning.";

            return View("~/Views/AboutUs/About.cshtml");
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "This is a Contact Page, might not be what you're looking for however it's notThatkindofContactPage. hahaha";

            return View("~/Views/ContactUs/Contact.cshtml");
        }

        public IActionResult CreateGearForm()
        {
            ViewData["Message"] = "Create Gear for the shop here.";
            return View("~/Views/Gear/CreateGearForm.cshtml");
        }
        [HttpGet]
        public IActionResult AddItem()
        {
            return View("CreateGearForm");
        }


        [HttpPost]
        public async Task<IActionResult> AddItem(Gear Gear)
        {   // the following if statement only allows items to be created
            // if the required fields are filled out
            if (ModelState.IsValid)
            {
                _context.Add(Gear);
                await _context.SaveChangesAsync();
                // put it back to repository until I can figure out adding to DB
                // Repository.AddGear(Gear);
              
                return View("~/Views/Gear/ItemAdded.cshtml", Gear);
            }
            else
            {
                //there is a validation error
                return View("~/Views/Gear/CreateGearForm.cshtml");
            }
        }

        public async Task<IActionResult> ShowShop()
        {
            return View(await _context.Gears.ToListAsync());
            
            
            // Have it set back to the repository until I can get it to pull from Gears database
            //return View(Repository.Gear);
            //Ignore the following 3 lines for now.
            //var gear =
          // return View(gear);
           // return View();

        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
