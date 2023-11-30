namespace Ecommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books",
                }, new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies",
                }, new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games",
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Ready Player One",
                    Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                    Price = 7.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Prison Break",
                    Description = "A story of the two brothers, Michael Scofield and Lincoln Burrows.",
                    ImageUrl = "https://resizing.flixster.com/pCE28S2R4XLyrCkU5_ZKCuu6hLY=/206x305/v2/https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p185128_b_v8_ag.jpg",
                    Price = 7.99m,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    Title = "GTA V",
                    Description = "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar North and published by Rockstar Games. ",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png",
                    Price = 69.99m,
                    CategoryId = 3
                }
                );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
