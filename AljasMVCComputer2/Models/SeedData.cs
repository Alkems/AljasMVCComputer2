using AljasMVCComputer2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AljasMVCComputer2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AljasMVCComputer2Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AljasMVCComputer2Context>>()))
            {
                // Look for any movies.
                if (context.Computer.Any())
                {
                    return;   // DB has been seeded
                }

                context.Computer.AddRange(
                    new Computer
                    {
                        Title = "Computer v12",
                        Specs = "Ultra Fast",
                        Price = 6999
                    },

                    new Computer
                    {
                        Title = "Computer v12 Lite",
                        Specs = "Ultra Fast",
                        Price = 3500
                    },

                    new Computer
                    {
                        Title = "Computer v10",
                        Specs = "Fast",
                        Price = 2000
                    },

                    new Computer
                    {
                        Title = "Computer v8",
                        Specs = "Average",
                        Price = 1000
                    },

                    new Computer
                    {
                        Title = "Computer v8 Lite",
                        Specs = "Slow",
                        Price = 600
                    }
                );
                context.SaveChanges();
            }
        }
    }
}