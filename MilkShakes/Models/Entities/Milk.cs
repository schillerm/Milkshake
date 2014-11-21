using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MilkShakes.Models.Entities
{
    public class Milk
    {
        [Key]
        public int MilkID { get; set; }
        public string Name { get; set; }
    }
}