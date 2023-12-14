using AspNetCoreBooksStore.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreBooksStore
{
    public class BooksStoreDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public BooksStoreDbContext(DbContextOptions<BooksStoreDbContext> options)
              : base(options)
        {
        }
    }
}
