using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Clockopedia.Data;
using System;
using System.Linq;

namespace Clockopedia.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ClockopediaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ClockopediaContext>>()))
            {
                // Look for any movies.
                if (context.Clock.Any())
                {
                    return;   // DB has been seeded
                }

                context.Clock.AddRange(
                    new Clock
                    {
                        Name = "Minimalist Office Wall Clock",
                        ManufactureDate = DateTime.Parse("2024-4-5"),
                        Category = "Wall Clock",
                        Color="Black",
                        Timeformat="Analog",
                        Price = 34.99M,
                        Warrenty="Yes"
                    },

                     new Clock
                     {
                         Name = "Nautical Ship's Bell Clock",
                         ManufactureDate = DateTime.Parse("1955-09-28"),
                         Category = "Ship's Bell Clock",
                         Color = "Brass",
                         Timeformat = "Analog",
                         Price = 199.99M,
                         Warrenty="No"
                     },

                     new Clock
                     {
                         Name = "Sports-Themed Wall Clock",
                         ManufactureDate = DateTime.Parse("2022-01-20"),
                         Category = "Sport Wall Clock",
                         Color = "White",
                         Timeformat = "Analog",
                         Price = 29.99M,
                         Warrenty="Yes"
                     },

                     new Clock
                     {
                         Name = "Retro Flip Clock",
                         ManufactureDate = DateTime.Parse("1980-06-03"),
                         Category = "Flip Clock",
                         Color = "Ivory",
                         Timeformat = "Digital Flip",
                         Price = 39.99M,
                         Warrenty = "Yes"
                     },
                      new Clock
                      {
                          Name = "Outdoor Garden Sundial",
                          ManufactureDate = DateTime.Parse("2001-04-18"),
                          Category = "Garden Sundial",
                          Color = "Bronze",
                          Timeformat = "Solar",
                          Price = 59.99M,
                          Warrenty = "No"
                      },
                       new Clock
                       {
                           Name = "TechWave",
                           ManufactureDate = DateTime.Parse("2023-03-15"),
                           Category = "Digital Desk Clock",
                           Color = "Silver",
                           Timeformat = "Digital",
                           Price = 24.99M,
                           Warrenty = "Yes"
                       },
                        new Clock
                        {
                            Name = "Antique Elegance",
                            ManufactureDate = DateTime.Parse("1965-07-12"),
                            Category = "Mantel Clock",
                            Color = "Mahogany",
                            Timeformat = "Analog",
                            Price = 149.99M,
                            Warrenty = "Yes"
                        },
                         new Clock
                         {
                             Name = "Adventurous Animals",
                             ManufactureDate = DateTime.Parse("2020-05-30"),
                             Category = "Children's Wall Clock",
                             Color = "Multi-color",
                             Timeformat = "Analog",
                             Price = 19.99M,
                             Warrenty = "No"
                         },

                        new Clock
                         {
                             Name = "ConnectiTime",
                                ManufactureDate = DateTime.Parse("2021-11-10"),
                             Category = "Smart Clock",
                            Color = "White",
                            Timeformat = "Digital",
                            Price = 79.99M,
                            Warrenty = "No"
                        },
                           new Clock
                           {
                               Name = "Black Forest Melody",
                               ManufactureDate = DateTime.Parse("1890-12-05"),
                               Category = "Cuckoo Clock",
                               Color = "Dark Wood",
                               Timeformat = "Analog",
                               Price = 299.99M,
                               Warrenty = "Yes"
                           }
                );
                context.SaveChanges();
            }
        }
    }
}