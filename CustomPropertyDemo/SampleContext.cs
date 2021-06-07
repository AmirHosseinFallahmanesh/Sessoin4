using CustomPropertyDemo.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CustomPropertyDemo
{
    public class SampleContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasKey(A=>A.AutorCode);

            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new WriterConfiguration());


            modelBuilder.Entity<Company>()
        .HasMany(c => c.Employees)
        .WithOne();

            modelBuilder.Entity<Employee>()
     .HasOne(e => e.Company)
     .WithMany();


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.;Database=demo4;Trusted_Connection=True;");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
