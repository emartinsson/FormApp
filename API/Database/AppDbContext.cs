using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        
    }
}

