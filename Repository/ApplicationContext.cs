using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorApp.Repository.Models;

namespace RazorApp.Repository
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Group> Groups { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }

    }
}
