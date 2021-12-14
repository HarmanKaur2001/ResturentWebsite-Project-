using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ResturentWebsite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResturentWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Dishes> Dishes { get; set; }

        public DbSet<Events> Events { get; set; }

        public DbSet<FeedBack> FeedBack { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<OurTeam> OurTeam { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
