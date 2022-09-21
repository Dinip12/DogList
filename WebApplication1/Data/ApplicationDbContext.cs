using System.Data.Entity;
using WebApplication1.Models;

namespace DogList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public ApplicationDbContext() : base("Server=(localdb)\\mssqllocaldb;Database=DoggyStyle;Trusted_Connection=True;")
        {
            Dogs = this.Set<Dog>();
            
        }
    }
}
