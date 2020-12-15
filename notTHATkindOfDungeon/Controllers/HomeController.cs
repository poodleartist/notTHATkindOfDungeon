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
using notTHATkindOfDungeon.Models.Sections;

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
            return View("~/Views/Shop/ShowShop.cshtml",await _context.Gears.ToListAsync());
        }

        public async Task<IActionResult> ShowPlayers()
        {
            return View(await _context.Players.ToListAsync());

        }
        [HttpGet]
        public IActionResult AddPlayer()
        {
            return View("AddPlayer");
        }
        [HttpPost]
        public async Task<IActionResult> AddPlayer(Player Player)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Player);
                await _context.SaveChangesAsync();

                return View("~/Views/Home/ShowPlayers.cshtml",Player);

            }
            else
            {
                return View("~/Views/Home/AddPlayer.cshtml");
            }
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //This is the beginning of where the game logic starts
        public async Task<IActionResult> PlayGameAsync(Player activePlayer, int? choice)
        { 
            int playerProgress = activePlayer.GameProgress;
            
            if(playerProgress == 0)
            {
                activePlayer.GameProgress++;
                _context.Update(activePlayer);
                await _context.SaveChangesAsync();
                ViewData["Title"] = "In the beginning....";
                ViewData["heading"] = "Late one night...";
                ViewData["paragraph"] = "The air around you is chilled, riddled with mist, and perhaps a hint of magic. Your shoes are on the brink of slipping on the rain coated sidewalk. The view around you painted by the neon lights of the shops and bars. Surrounded by an array of shops closed early, (due to reduced hours), you stumble your way along. Your mind weak from sleep deprivation and caffeine withdrawl. In the darkness, a faint red light emerges in the distance. You find yourself intrigued. You've walked this path every night for months, yet this blood red glow has no place in your memory. The next two steps allow you to see that the glow is a neon sign.";
                ViewData["option1"] = "Turn around, walk away quickly.";
                ViewData["option2"] = "Read the sign.";
                ViewData["activePlayer"] = activePlayer;
                return View("~/Views/Home/TwoOptions.cshtml", activePlayer);
            }
            else if (activePlayer.GameProgress == 1)
            {
                if (choice == 1)
                {
                    activePlayer.GameProgress = activePlayer.GameProgress++;
                    _context.Update(activePlayer);
                    await _context.SaveChangesAsync();
                    ViewData["Title"] = "In the beginning....";
                    ViewData["heading"] = "You turn to leave";
                    ViewData["paragraph"] = "For a long moment you stand with your back to the sign. Urging yourself to walk away. Who cares if there's a new place you've never seen before. It's late, cold, wet, and you should hurry home. But still you stand there-unable to leave. Finally you turn around and inspect the sign.";
                    ViewData["option1"] = "Read the sign.";
                    ViewData["option2"] = "Read the sign in a funny accent in your head.";
                    return View("~/Views/Home/TwoOptions.cshtml", activePlayer);
                }
                else if (choice == 2)
                {
                    activePlayer.GameProgress = activePlayer.GameProgress+2;
                    _context.Update(activePlayer);
                    await _context.SaveChangesAsync();
                    ViewData["Title"] = "In the beginning....";
                    ViewData["heading"] = "The Dungeon";
                    ViewData["paragraph"] = "The medieval style lettering simply reads 'The Dungeon'. Beneath these words there shines an arrow directing your attention to a stairway leading to underground cafes and shops. You peer down the stairs and find a similar sign, though bigger, perhaps redundant and pointless, indicating the entrance to the Dungeon is the first door at the bottom of the stairs. It now appears to be a nightclub...";
                    ViewData["option1"] = "Turn around, walk away for real.";
                    ViewData["option2"] = "Walk down the stairs, appease your curiousity.";
                    return View("~/Views/Home/TwoOptions.cshtml", activePlayer);
                }
                else
                {
                    ViewData["Title"] = "In the beginning....";
                    ViewData["heading"] = "Late one night...";
                    ViewData["paragraph"] = "The air around you is chilled, riddled with mist, and perhaps a hint of magic. Your shoes are on teh brink of slipping on the rain coated sidewalk. The view around you painted by the neon lights of the shops and bars. Surrounded by an array of shops closed early, (due to reduced hours), you stumble your way along. Your mind weak from sleep deprivation and caffeine withdrawl. In the darkness, a faint red light emerges in the distance. You find yourself intrigued. You've walked this path every night for months, yet this blood red glow has no place in your memory. The next two steps allow you to see that the glow is a neon sign.";
                    ViewData["option1"] = "Turn around, walk away quickly.";
                    ViewData["option2"] = "Read the sign.";
                    return View("~/Views/Home/TwoOptions.cshtml", activePlayer);

                }

            }else
            {
                ViewData["heading"] = "Something went wrong.";
                ViewData["paragraph"] = "This isn't implemented yet.";
                return View("~/Views/Home/TwoOptions.cshtml", activePlayer);
            }

        }


    }
}
