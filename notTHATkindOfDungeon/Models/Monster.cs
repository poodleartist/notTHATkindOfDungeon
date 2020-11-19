using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models
{
    public class Monster
    {
//      ~ PROPERTY ~                                        ~ EXAMPLE / DESCRIPTION ~ 
//      -----------------------------------------------------------------------------------------------------
//
//      ~ Details ~        
        public string Race { get; set; }                    // Goblin, Skeleton, etc.
        public string Description { get; set; }             // Displayed with the "examine" command.
                                                            // e.g. "He doesn't look friendly"
        public string Name { get; set; }                    // Typically, this will be for bosses.

//      ~ Stats ~
        public int Health { get; set; }
        public int Attack { get; set; }
        // public int Defense { get; set; }                 // Defense isn't necessary, but if we decide
                                                            // to implement it, it will be the amount of
                                                            // damage subtracted from the player's attack.

        // public Item ItemDropped { get; set; }            // Will create an Item object later.

        










    }
}
