using Microsoft.EntityFrameworkCore;

namespace FirstWebApp_08_22.Data
{
    public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(

                new Currency() { Id = 1,Title="INR",Description="Indian INR"},
                new Currency() { Id = 2,Title="Doller",Description="USA"},
                new Currency() { Id = 3,Title="Euro",Description= "France" },
                new Currency() { Id = 4,Title="Yen",Description="Japan"}

                );
            modelBuilder.Entity<Language>().HasData(

                new Language() { Id = 1, Title = "Hindi", Description = "India" },
                new Language() { Id = 2, Title = "English", Description = "USA" },
                new Language() { Id = 3, Title = "German", Description = "Germany" },
                new Language() { Id = 4, Title = "Japanese", Description = "Japan" }

                );

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }


    }

}
