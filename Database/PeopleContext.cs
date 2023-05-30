using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions<PeopleContext> options)
            : base(options)
        {

        }

        public  DbSet<Person> People { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
        }
    }
}