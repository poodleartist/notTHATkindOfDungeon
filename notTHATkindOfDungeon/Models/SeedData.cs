using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using notTHATkindOfDungeon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Gears.Any())
            {
                context.Gears.AddRange(
                    new Gear
                    {
                        ItemName = "Golden Toothpick",
                        ItemDescription = "Tiny, almost worthless item. ",
                        ScoreRequirement = 0,
                        ItemType = "Weapon",
                        Attack = 1,
                        Defense = 0,
                        HealingPower = 0,
                        InventoryIncrease = 0
                    },
                    new Gear
                    {
                        ItemName = "Wood Dagger",
                        ItemDescription = "A small wooden dagger, not very strong. ",
                        ScoreRequirement = 0,
                        ItemType = "Weapon",
                        Attack = 2,
                        Defense = 0,
                        HealingPower = 0,
                        InventoryIncrease = 0
                    },
                    new Gear
                    {
                        ItemName = "Iron Sword",
                        ItemDescription = "Medium strength sword. Not bad. ",
                        ScoreRequirement = 3,
                        ItemType = "Weapon",
                        Attack = 5,
                        Defense = 0,
                        HealingPower = 0,
                        InventoryIncrease = 0
                    },
                    new Gear
                    {
                        ItemName = "Steel Sword",
                        ItemDescription = "A good strong sword. ",
                        ScoreRequirement = 5,
                        ItemType = "Weapon",
                        Attack = 10,
                        Defense = 0,
                        HealingPower = 0,
                        InventoryIncrease = 0
                    },
                    new Gear
                    {
                        ItemName = "Wooden Shield",
                        ItemDescription = "Everyone has to start somewhere. ",
                        ScoreRequirement = 0,
                        ItemType = "Defense",
                        Attack = 3,
                        Defense = 0,
                        HealingPower = 0,
                        InventoryIncrease = 0
                    },
                    new Gear
                    {
                        ItemName = "Piece of Paper",
                        ItemDescription = "...why? ",
                        ScoreRequirement = 0,
                        ItemType = "Armor",
                        Attack = 0,
                        Defense = 0,
                        HealingPower = 0,
                        InventoryIncrease = 0
                    },
                    new Gear
                    {
                        ItemName = "Iron Chainmail",
                        ItemDescription = "Light-weight, medium strength. ",
                        ScoreRequirement = 5,
                        ItemType = "Armor",
                        Attack = 0,
                        Defense = 15,
                        HealingPower = 0,
                        InventoryIncrease = 0
                    },
                    new Gear
                    {
                        ItemName = "Steel Plate Suit ",
                        ItemDescription = "Very strong. ",
                        ScoreRequirement = 20,
                        ItemType = "Armor",
                        Attack = 0,
                        Defense = 15,
                        HealingPower = 0,
                        InventoryIncrease = 0
                    },
                    new Gear
                    {
                        ItemName = "Bread Crumbs ",
                        ItemDescription = "Tiny crumbs, won't heal much. ",
                        ScoreRequirement = 0,
                        ItemType = "Healing",
                        Attack = 0,
                        Defense = 0,
                        HealingPower = 1,
                        InventoryIncrease = 0
                    },
                    new Gear
                    {
                        ItemName = "Meatball Sub",
                        ItemDescription = "Delicious, will heal nicely ",
                        ScoreRequirement = 2,
                        ItemType = "Healing",
                        Attack = 0,
                        Defense = 0,
                        HealingPower = 5,
                        InventoryIncrease = 0
                    },
                    new Gear
                    {
                        ItemName = "Healing Potion of Awesomeness! ",
                        ItemDescription = "This will heal the worst of wounds. ",
                        ScoreRequirement = 5,
                        ItemType = "Healing",
                        Attack = 0,
                        Defense = 0,
                        HealingPower = 20,
                        InventoryIncrease = 0
                    },
                    new Gear
                    {
                        ItemName = "Simple Backpack",
                        ItemDescription = "This will help you carry more gear. ",
                        ScoreRequirement = 1,
                        ItemType = "Bag Upgrade",
                        Attack = 0,
                        Defense = 0,
                        HealingPower = 0,
                        InventoryIncrease = 5
                    },
                    new Gear
                    {
                        ItemName = "Prada Suitcase ",
                        ItemDescription = "You can haul a lot of stuff with this. ",
                        ScoreRequirement = 5,
                        ItemType = "Bag Upgrade",
                        Attack = 0,
                        Defense = 0,
                        HealingPower = 0,
                        InventoryIncrease = 15
                    }
                    );
                context.SaveChanges();

            }
        }


    }
}
