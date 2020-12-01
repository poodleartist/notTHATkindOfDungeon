using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string UserName { get; set; }
        public int Score { get; set; }
        public int GameProgress { get; set; }
        public int GoldPieces { get; set; }
        public int TotalHitpoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TotalInventorySpaces { get; set; }
        public int FilledInventorySpaces { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
    }
}
