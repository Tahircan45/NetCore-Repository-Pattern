using Microsoft.EntityFrameworkCore;
using NetCore_Repository_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_Repository_Pattern.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<User> users { set; get; }
        public DbSet<Product> products { set; get; }
    }
}
