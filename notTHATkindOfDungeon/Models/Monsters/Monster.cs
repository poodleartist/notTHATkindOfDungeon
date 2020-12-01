using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models
{
    public class Monster
    {
//      The monster class is the base class of all the other monster classes

//      ~ Andrew J. O'Connor ~

//      ~ PROPERTY ~                                        ~ EXAMPLE / DESCRIPTION ~ 
//      -----------------------------------------------------------------------------------------------------

//      ~ Details ~        
        // public string Race { get; set; }                    // Goblin, Skeleton, etc.
        public string Description { get; set; }             // Displayed with the "examine" command.
                                                            // e.g. "He doesn't look friendly"
        public string Name { get; set; }                    // Typically, this will be for bosses.

//      ~ Stats ~
        public int Level { get; set; }                      // The approximate level a player should be to
                                                            // confidently battle the monster.
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }                     // The max amount of damage a monster can do;
                                                            // every monster's strong attack will have a range
                                                            // of 1-[Attack].

        // public int Defense { get; set; }                 // Defense isn't necessary, but if we decide
                                                            // to implement it, it will be the amount of
                                                            // damage subtracted from the player's attack.

//      ~ Misc. ~
        public string Message { get; set; }                 // E.g. "Goblin used Slash!"
        public int MinGold { get; set; }                    // The lowest amount of gold a monster may drop.
        public int MaxGold { get; set; }                    // The highest amount of gold a monster can drop.
        public int GoldDropped { get; set; }                // The actual amount of gold to be dropped.
                                                            // Every monster has a 50/50 chance to drop no gold.

        // public Item ItemDropped { get; set; }            // Will create an Item object later.

        //-----------------------------------------------------------------------------------------------------



//      ~ FUNCTIONS ~

        // ~ TAKE DAMAGE ~
        //   Damages the monster by a specified amount & returns the new health amount.
        public int TakeDamage(int damage)
        {
            Health -= damage;
            return Health;
        }



        // ~ DETERMINE GOLD DROPPED ~
        //   First determines if gold will drop (1 in 2 probability).
        //   Then returns how much (if any) will be dropped.
        public int DropGold(int min, int max)
        {
            // Generate random number; if 0, no gold is dropped; if 1, some gold is dropped.
            Random random = new Random();
            int drop = random.Next(0, 1);
            int amount = 0;

            // If gold is to be dropped ...
            if (drop == 1)
            {
                // Generate another random number between 2 and 8.
                // This will determine how much gold will drop.
                // The range will vary depending on monster type.
                amount = random.Next(min, max);
            }
            return amount;
        }




    }
}
