using BlazingPizza.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Server.Models
{
    public class PizzaStoreContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}
        // or

        public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options) 
            : base(options) { }

        public DbSet<PizzaSpecial> Specials { get; set; }

    }
}
