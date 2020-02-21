using AspNetMvcEFBootstrapAngular.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcEFBootstrapAngular.Data
{
    public class ItemsContext : DbContext
    {
        public ItemsContext(DbContextOptions<ItemsContext> options):base(options)
        {

        }

        public DbSet<Item> Items { get; set; }

    }
}
