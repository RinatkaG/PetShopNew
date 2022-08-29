using Microsoft.EntityFrameworkCore;
using PetShopNew.Models;

namespace PetShopNew.Data
{
    public class DBInfo : DbContext
    {
        public DBInfo(DbContextOptions<DBInfo> options) : base(options)
        {
      
        }
        public DbSet<Animals>? animals { get; set; }
        public DbSet<Category>? category { get; set; }
        public DbSet<Comments>? comment { get; set; }

     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Fish" },
                new Category { CategoryId = 2, Name = "Mammals" },
                new Category { CategoryId = 3, Name = "Birds" },
                new Category { CategoryId = 4, Name = "Amphibians" },
                new Category { CategoryId = 5, Name = "Reptiles" }
            );

            modelBuilder.Entity<Animals>().HasData(
                new Animals { AnimalsId = 1, Name = "Josh", CategoryId = 3 },
                new Animals { AnimalsId = 2, Name = "Kfir", CategoryId = 2 },
                new Animals { AnimalsId = 3, Name = "Edmond", CategoryId = 5 }
            );

            modelBuilder.Entity<Comments>().HasData(
                new Comments { CommentsId = 1, Comment ="very cute!" ,AnimalsId =2},
                new Comments { CommentsId = 2, Comment = "they are very smart" ,AnimalsId =2 },
                new Comments { CommentsId = 3, Comment = "I want one!" , AnimalsId = 1 },
                new Comments { CommentsId = 4, Comment = "soooo uglyyy",AnimalsId =3 }
                );
        }
    }
}

