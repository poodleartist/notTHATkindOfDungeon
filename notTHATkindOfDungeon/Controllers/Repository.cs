using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models
{
    public class Repository
    {
        private static List<CreateGear> createGears = new List<CreateGear>();

        public static IEnumerable<CreateGear> CreateGears
        {
            get { return createGears; }
        }

        public static void AddGear(CreateGear createGear)
        {
            createGears.Add(createGear);
        }

    }
}
