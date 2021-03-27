using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace BikeProducts.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Mongoose",
                    Description = "All-Terrain Fat Tire Bike",
                    Category = "Adult Bikes",
                    Price = 275
                },
                new Product
                {
                    Name = "Mobo Triton",
                    Description = "Ultimate 3-Wheeled Cruiser",
                    Category = "Adult Bikes",
                    Price = 438.95m
                },
                new Product
                {
                    Name = "Hyper E-Ride",
                    Description = "Electric Mountain Bike",
                    Category = "Adult Bikes",
                    Price = 499.99m
                },
                new Product
                {
                    Name = "TITAN Pathfinder",
                    Description = "Dual Suspension Mountain Bike",
                    Category = "Adult Bikes",
                    Price = 600
                },
                new Product
                {
                    Name = "Kent Bike",
                    Description = "BMX Girls Bike in Satin Purple",
                    Category = "Kids Bikes",
                    Price = 250
                },
                new Product
                {
                    Name = "Genesis",
                    Description = "Illusion Girls Bike",
                    Category = "Kids Bikes",
                    Price = 160
                },
                new Product
                {
                    Name = "Madd Gear",
                    Description = "Free Style BMX Boys Bike",
                    Category = "Kids Bike",
                    Price = 188
                }
            );
                context.SaveChanges();
            }
        }
    }
}