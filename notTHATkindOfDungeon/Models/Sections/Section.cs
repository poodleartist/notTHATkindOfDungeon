using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models.Sections
{
    public class Section
    {
//      The Section class is the base class of all the game's sections.

//      ~ Andrew J. O'Connor ~

//      ~ PROPERTY ~                                        ~ EXAMPLE / DESCRIPTION ~ 
//      -----------------------------------------------------------------------------------------------------
        
        public int SectionNumber { get; set; }              // Uniquely identifies each scene with a number.
        public string SectionName { get; set; }             // Uniquely identifies each scene with a name.

        public int CurrentSceneNumber { get; set; }         // Scenes are smaller sections within sections.
        public string CurrentSceneName { get; set; }

        //-----------------------------------------------------------------------------------------------------
    }
}
