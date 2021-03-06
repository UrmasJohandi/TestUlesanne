﻿using Microsoft.EntityFrameworkCore;

namespace TestUlesanne.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UsersChoice> UsersChoices { get; set; }
    }
}
