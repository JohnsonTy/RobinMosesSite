﻿using RobinMoses.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RobinMoses.Data
{
    public class WebDbContext : IdentityDbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options) : base(options) { }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<SpecialItem> SpecialItems { get; set; }
    }

}

