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
                        Specs = "3080TI 12gb, I9, 64gb",
                        Price = 6999
                    },

                    new Computer
                    {
                        Title = "Computer v12 Lite",
                        Specs = "2080TI 8gb, I7, 32gb",
                        Price = 3500
                    },

                    new Computer
                    {
                        Title = "Computer v10",
                        Specs = "1080TI 8gb, I7, 16gb",
                        Price = 2000
                    },

                    new Computer
                    {
                        Title = "Computer v8",
                        Specs = "1050TI 4gb, I5, 8gb",
                        Price = 1000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}