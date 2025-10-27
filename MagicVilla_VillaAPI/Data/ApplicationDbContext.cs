using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Villa>()
            //   .Property(v => v.CreatedDate)
            //   .HasDefaultValueSql("GETUTCDATE()");
                
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "This is the Royal Villa",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    //CreatedDate = DateTime.Now
                    //CreatedDate = DateTime.UtcNow
                    CreatedDate = new DateTime(2024, 09, 23)
                },
                new Villa
                {
                    Id = 2,
                    Name = "Premium Pool Villa",
                    Details = "This is the Premium Pool Villa",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                    Occupancy = 4,
                    Rate = 300,
                    Sqft = 600,
                    Amenity = "",
                    //CreatedDate = DateTime.Now
                    //CreatedDate = DateTime.UtcNow
                    CreatedDate = new DateTime(2024, 09, 23)
                },
                new Villa
                {
                    Id = 3,
                    Name = "Luxury Beach Villa",
                    Details = "This is the Luxury Beach Villa",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",
                    Occupancy = 6,
                    Rate = 500,
                    Sqft = 750,
                    Amenity = "",
                    //CreatedDate = DateTime.Now
                    //CreatedDate = DateTime.UtcNow
                    CreatedDate = new DateTime(2024, 09, 23)
                },
                new Villa
                {
                    Id = 4,
                    Name = "Executive Villa",
                    Details = "This is the Executive Villa",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",
                    Occupancy = 3,
                    Rate = 180,
                    Sqft = 400,
                    Amenity = "",
                    //CreatedDate = DateTime.Now
                    //CreatedDate = DateTime.UtcNow
                    CreatedDate = new DateTime(2024, 09, 23)
                },
                new Villa
                {
                    Id = 5,
                    Name = "Family Villa",
                    Details = "This is the Family Villa",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                    Occupancy = 8,
                    Rate = 350,
                    Sqft = 900,
                    Amenity = "",
                    //CreatedDate = DateTime.Now
                    //CreatedDate = DateTime.UtcNow 
                    CreatedDate = new DateTime(2024, 09, 23)
                }

                );
        }
    }
}
