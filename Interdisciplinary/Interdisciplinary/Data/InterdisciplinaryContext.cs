using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Interdisciplinary.Models;

namespace Interdisciplinary.Data
{
    public class InterdisciplinaryContext : DbContext
    {
        public InterdisciplinaryContext(DbContextOptions<InterdisciplinaryContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<FoodTag> FoodTags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<FoodTag>().ToTable("FoodTag");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Food>().ToTable("Food");
            modelBuilder.Entity<Tag>().ToTable("Tag");

        }
    }
}
