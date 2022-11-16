using BookFare.Model;
using Microsoft.EntityFrameworkCore;

namespace BookFare.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
