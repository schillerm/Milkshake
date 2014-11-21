using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace MilkShakes.Models.Entities
{
    public class MilkshakeDB
    {
        public DbSet<Milkshake> Milkshakes { get; set; }
        public DbSet<Milk> Milks { get; set; }
        public DbSet<Fruit> Fruits { get; set; }
    }
}