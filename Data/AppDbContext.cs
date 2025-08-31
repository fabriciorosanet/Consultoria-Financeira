using System;
using LandingPage.Models;
using Microsoft.EntityFrameworkCore;

namespace LandingPage.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }	

        public DbSet<Lead> Leads { get; set; } = null!;
    }
}
