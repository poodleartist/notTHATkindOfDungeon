using notTHATkindOfDungeon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models
{
    public class PlayerRepository : IPlayerRepository
    {
        private ApplicationDbContext context;
        public PlayerRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Player> Players => context.Players;
    }
}
