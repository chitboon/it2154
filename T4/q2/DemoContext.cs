using Microsoft.EntityFrameworkCore;

namespace demo {
    public class DemoContext: DbContext
    {
        public DbSet<Book> Books { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlite("Data Source=Demo.db");
        }
    }
}