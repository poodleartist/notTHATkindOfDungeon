using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models
{
    public class Scene
    {
//      The Scene class is the base class of all scenes.
//      Scenes are the little parts in sections.

//      ~ Andrew J. O'Connor ~

//      ~ PROPERTY ~                                        ~ EXAMPLE / DESCRIPTION ~ 
//      -----------------------------------------------------------------------------------------------------

        public int SceneNumber { get; set; }                // Unique to each scene.

        public string Heading { get; set; }                  // The header for a scene.

        public string MainParagraph { get; set; }           // The main (big) paragraph for each scene

        public string Prompt { get; set; }                  // Smaller message to prompt the user's choice.
                                                            // This is set to describe something when we
                                                            // don't want the main paragraph to change;
                                                            // this will help players not lose track of
                                                            // what is happening.
//-----------------------------------------------------------------------------------------------------------

 //      ~ FUNCTIONS ~

        // ~ CONSTRUCTOR ~
        //   To be used whenever a scene is prepared.
        public Scene()
        {
            SceneNumber = 0;
            MainParagraph = "";
            Prompt = "";
        }
    }
}
