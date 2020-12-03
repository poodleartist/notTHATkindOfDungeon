using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace notTHATkindOfDungeon.Models
{
    public class Gear
    { 
        [Key]
        public int ItemId { get; set; }
        [Required(ErrorMessage ="Please enter item name")]
        public string ItemName { get; set; }
        [Required(ErrorMessage ="Please enter a simple item description")]
        public string ItemDescription { get; set; }
        [Required(ErrorMessage ="Please enter minimum score player must have to use item")]
        public int ScoreRequirement { get; set; }
        [Required(ErrorMessage ="Please choose type of item")]
        public string ItemType { get; set; }
        public int? Attack { get; set; }
        public int? Defense { get; set; }
        public int? HealingPower { get; set; }
        public int? InventoryIncrease { get; set; }
    }

}
