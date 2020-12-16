using Microsoft.EntityFrameworkCore;

namespace WebPhoneStore.Models.ProductsModels
{
    public class ProductDataContext: DbContext
    {
        public DbSet<Category>Categories { get; set; }
        public DbSet<Brand>Brands { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<Image>Images { get; set; }

        public ProductDataContext(DbContextOptions<ProductDataContext> options) : base(options) { }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ComputerWorld;Username=Volodymyr;" +
        //                              "Password=Volodimir@10091984");
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasAlternateKey(i => i.Name);
            modelBuilder.Entity<Category>().HasAlternateKey(i => i.Slug);
            modelBuilder.Entity<Brand>().HasAlternateKey(i => i.Name);
            modelBuilder.Entity<Brand>().HasAlternateKey(i => i.Slug);
            modelBuilder.Entity<Product>().HasAlternateKey(i => i.Slug);
            modelBuilder.Entity<Image>().HasAlternateKey(i => i.Slug);
        }
    }
}