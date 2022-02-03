using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crudapi.Models;
namespace crudapi.Models
{
    public class RecipesDbContext : DbContext
    {

        public DbSet<Recipe> Recipes { get; set; }
        public RecipesDbContext(DbContextOptions<RecipesDbContext> options):base(options)
        {
        } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().ToTable("Recipe");
        }
    }
}
