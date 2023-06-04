using inventory_managemnt_system.Data;
using inventory_managemnt_system.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new computerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<computerContext>>()))
            {
                // Look for any movies.
                if (context.Computer.Any())
                {
                    return;   // DB has been seeded
                }

                context.Computer.AddRange(
                    new Computer
                    {
                        ID = 123453,
                        SerialNum = 65345,
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        RoomNum = "the holiday inn 165",
                        desc = "best computer you'll ever use",
                        operatingSystem = "windows",
                        owner = "henry"
                    },

                    new Computer
                    {
                        ID = 123454,
                        SerialNum = 652345,
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        RoomNum = "the holiday inn 166",
                        desc = "best computer you'll ever use ever!",
                        operatingSystem = "windows",
                        owner = "joey"
                    },

                    new Computer
                    {
                        ID = 1233453,
                        SerialNum = 653425,
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        RoomNum = "the holiday inn 167",
                        desc = "best computer you'll never ever use",
                        operatingSystem = "windows",
                        owner = "jessica"
                    },

                    new Computer
                    {
                        ID = 2223453,
                        SerialNum = 653415,
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        RoomNum = "the holiday inn 169",
                        desc = "best computer",
                        operatingSystem = "windows",
                        owner = "bart "
                    }
                ); 
                context.SaveChanges();
            }
        }
    }
}