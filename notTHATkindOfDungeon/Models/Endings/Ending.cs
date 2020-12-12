using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models.Endings
{
    public class Ending
    {
        public int endingNumber { get; set; }
        public string endingName { get; set; }
        public string endingText { get; set; }

        public Ending(int number, string name, string text)
        {
            endingNumber = number;
            endingName = name;
            endingText = text;
        }

        public Ending()
        {
            endingNumber = 0;
            endingName = "";
            endingText = "";
        }

    }
}
