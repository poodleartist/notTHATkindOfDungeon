using notTHATkindOfDungeon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models
{
    public class GearRepository : IGearRepository
    {
        private ApplicationDbContext context;
        public GearRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Gear> Gears => context.Gears;
    }
    
    
}
