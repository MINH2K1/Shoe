using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopShoe.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopShoe.Infastructure.DbContext
{
    public class ShopShoeDbContext : IdentityDbContext<AppUser, AppRole,int>
    {
        public ShopShoeDbContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<AppUser> AppUsers { get; set; }
        DbSet<AppUser> AppRole { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }

    }
}
