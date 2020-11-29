using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models
{
    public class Repository
    {
        private static List<Gear> createGears = new List<Gear>();

        public static IEnumerable<Gear> CreateGears
        {
            get { return createGears; }
        }

        public static void AddGear(Gear createGear)
        {
            createGears.Add(createGear);
        }

    }
}
