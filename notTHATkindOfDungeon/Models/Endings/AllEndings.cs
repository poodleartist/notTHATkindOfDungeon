using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models.Endings
{
    public class AllEndings
    {
        Ending[] endings;

        public void PrepareEndings()
        {


            Ending dummyEnding = new Ending( 0,
                                             "dummy ending",
                                             "this is so that we can more easily use the ending number value." );
            endings[0] = dummyEnding;



            Ending apathy = new Ending( 1,
                                        "Apathy",
                                        "You ignore the intrigue your mind gave you.  Every step on the way back to your house was a step way from any adventure you may have had beyond the door of The Dungeon." );
            endings[1] = apathy;

            

            Ending cowardice = new Ending( 2,
                                           "Cowardice",
                                           "Despite the warnings of the knight, you turn your back and walk through the door, leaving the knight and his allies to battle Valmor on their own.  Stepping back up to street level, you feel the cold air carress your face as you resume your walk back home.  And in all his evil, Valmor smiles at your decision." );
            endings[2] = cowardice;
        }
    }
}
