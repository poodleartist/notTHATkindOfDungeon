using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models
{
    interface IPlayerRepository
    {
        IQueryable<Player> Players { get; }
    }
}
