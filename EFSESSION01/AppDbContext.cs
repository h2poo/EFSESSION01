using EFSESSION01.models;
using Microsoft.EntityFrameworkCore;

namespace EFSESSION01
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=MyCompanyG01;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Book> Books { get; }
        public DbSet<Author> Authors { get; }
        public DbSet<Category> Categories { get; }
    }
}
