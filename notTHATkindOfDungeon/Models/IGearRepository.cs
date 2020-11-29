using System.Linq;

namespace notTHATkindOfDungeon.Models
{
    public interface IGearRepository
    {
        IQueryable<Gear> Gears { get; }
    }
}