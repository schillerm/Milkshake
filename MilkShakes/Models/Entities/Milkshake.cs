using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MilkShakes.Models.Entities
{
    public class Milkshake
    {
        [Key]
        public int MilkShakeID { get; set; }
        public string Name { get; set; }
    }
}