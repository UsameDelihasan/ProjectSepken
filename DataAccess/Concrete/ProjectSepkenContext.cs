using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class ProjectSepkenContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProjectSepken;Trusted_Connection=true");
        }
        

    }
}
