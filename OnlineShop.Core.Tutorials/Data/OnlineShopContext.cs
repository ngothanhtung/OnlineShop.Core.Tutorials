using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Tutorials.Data;

namespace OnlineShop.Core.Tutorials.Data
{
    public class OnlineShopContext : DbContext
    {
        public OnlineShopContext (DbContextOptions<OnlineShopContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
