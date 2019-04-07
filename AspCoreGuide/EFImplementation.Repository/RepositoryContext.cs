namespace EFImplementation.Repository
{
    using EFImplementation.Repository.Models;
    using Microsoft.EntityFrameworkCore;

    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Owner> owners { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer();
        //}
    }
}