using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace TestUlesanne.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();

            if (!context.Sectors.Any())
            {
                context.Sectors.AddRange(
                new Sector
                {
                    SectorId = 1,
                    Name = "Manufacturing",
                    ParentId = 0,
                    Level = 0,
                    OrderNr = 1
                },
                new Sector
                {
                    SectorId = 19,
                    Name = "Construction materials",
                    ParentId = 1,
                    Level = 1,
                    OrderNr = 2
                },
                new Sector
                {
                    SectorId = 18,
                    Name = "Electronics and Optics",
                    ParentId = 1,
                    Level = 1,
                    OrderNr = 3
                },
                new Sector
                {
                    SectorId = 6,
                    Name = "Food and Beverage",
                    ParentId = 1,
                    Level = 1,
                    OrderNr = 4
                },
                new Sector
                {
                    SectorId = 342,
                    Name = "Bakery & confectionery products",
                    ParentId = 6,
                    Level = 2,
                    OrderNr = 5
                },
                new Sector
                {
                    SectorId = 43,
                    Name = "Beverages",
                    ParentId = 6,
                    Level = 2,
                    OrderNr = 6
                },
                new Sector
                {
                    SectorId = 42,
                    Name = "Fish & fish products",
                    ParentId = 6,
                    Level = 2,
                    OrderNr = 7
                },
                new Sector
                {
                    SectorId = 40,
                    Name = "Meat & meat products",
                    ParentId = 6,
                    Level = 2,
                    OrderNr = 8
                },
                new Sector
                {
                    SectorId = 39,
                    Name = "Milk & dairy products",
                    ParentId = 6,
                    Level = 2,
                    OrderNr = 9
                },
                new Sector
                {
                    SectorId = 437,
                    Name = "Other",
                    ParentId = 6,
                    Level = 2,
                    OrderNr = 10
                },
                new Sector
                {
                    SectorId = 378,
                    Name = "Sweets & snack food",
                    ParentId = 6,
                    Level = 2,
                    OrderNr = 11
                },
                new Sector
                {
                    SectorId = 13,
                    Name = "Furniture",
                    ParentId = 1,
                    Level = 1,
                    OrderNr = 12
                },
                new Sector
                {
                    SectorId = 389,
                    Name = "Bathroom/sauna",
                    ParentId = 13,
                    Level = 2,
                    OrderNr = 13
                },
                new Sector
                {
                    SectorId = 385,
                    Name = "Bedroom",
                    ParentId = 13,
                    Level = 2,
                    OrderNr = 14
                },
                new Sector
                {
                    SectorId = 390,
                    Name = "Children's room",
                    ParentId = 13,
                    Level = 2,
                    OrderNr = 15
                },
                new Sector
                {
                    SectorId = 98,
                    Name = "Kitchen",
                    ParentId = 13,
                    Level = 2,
                    OrderNr = 16
                },
                new Sector
                {
                    SectorId = 101,
                    Name = "Living room",
                    ParentId = 13,
                    Level = 2,
                    OrderNr = 17
                },
                new Sector
                {
                    SectorId = 392,
                    Name = "Office",
                    ParentId = 13,
                    Level = 2,
                    OrderNr = 18
                },
                new Sector
                {
                    SectorId = 394,
                    Name = "Other (Furniture)",
                    ParentId = 13,
                    Level = 2,
                    OrderNr = 19
                },
                new Sector
                {
                    SectorId = 341,
                    Name = "Outdoor",
                    ParentId = 13,
                    Level = 2,
                    OrderNr = 20
                },
                new Sector
                {
                    SectorId = 99,
                    Name = "Project furniture",
                    ParentId = 13,
                    Level = 2,
                    OrderNr = 21
                },
                new Sector
                {
                    SectorId = 12,
                    Name = "Machinery",
                    ParentId = 1,
                    Level = 1,
                    OrderNr = 22
                },
                new Sector
                {
                    SectorId = 94,
                    Name = "Machinery components",
                    ParentId = 12,
                    Level = 2,
                    OrderNr = 23
                },
                new Sector
                {
                    SectorId = 91,
                    Name = "Machinery equipment/tools",
                    ParentId = 12,
                    Level = 2,
                    OrderNr = 24
                },
                new Sector
                {
                    SectorId = 224,
                    Name = "Manufacture of machinery",
                    ParentId = 12,
                    Level = 2,
                    OrderNr = 25
                },
                new Sector
                {
                    SectorId = 97,
                    Name = "Maritime",
                    ParentId = 12,
                    Level = 2,
                    OrderNr = 26
                },
                new Sector
                {
                    SectorId = 271,
                    Name = "Aluminium and steel workboats",
                    ParentId = 97,
                    Level = 3,
                    OrderNr = 27
                },
                new Sector
                {
                    SectorId = 269,
                    Name = "Boat/Yacht building",
                    ParentId = 97,
                    Level = 3,
                    OrderNr = 28
                },
                new Sector
                {
                    SectorId = 230,
                    Name = "Ship repair and conversion",
                    ParentId = 97,
                    Level = 3,
                    OrderNr = 29
                },
                new Sector
                {
                    SectorId = 93,
                    Name = "Metal structures",
                    ParentId = 12,
                    Level = 2,
                    OrderNr = 30
                },
                new Sector
                {
                    SectorId = 508,
                    Name = "Other",
                    ParentId = 12,
                    Level = 2,
                    OrderNr = 31
                },
                new Sector
                {
                    SectorId = 227,
                    Name = "Repair and maintenance service",
                    ParentId = 12,
                    Level = 2,
                    OrderNr = 32
                },
                new Sector
                {
                    SectorId = 11,
                    Name = "Metalworking",
                    ParentId = 1,
                    Level = 1,
                    OrderNr = 33
                },
                new Sector
                {
                    SectorId = 67,
                    Name = "Construction of metal structures",
                    ParentId = 12,
                    Level = 2,
                    OrderNr = 34
                },
                new Sector
                {
                    SectorId = 263,
                    Name = "Houses and buildings",
                    ParentId = 12,
                    Level = 2,
                    OrderNr = 35
                },
                new Sector
                {
                    SectorId = 267,
                    Name = "Metal products",
                    ParentId = 12,
                    Level = 2,
                    OrderNr = 36
                },
                new Sector
                {
                    SectorId = 542,
                    Name = "Metal works",
                    ParentId = 12,
                    Level = 2,
                    OrderNr = 37
                },
                new Sector
                {
                    SectorId = 75,
                    Name = "CNC-machining",
                    ParentId = 542,
                    Level = 3,
                    OrderNr = 38
                },
                new Sector
                {
                    SectorId = 62,
                    Name = "Forgings, Fasteners",
                    ParentId = 542,
                    Level = 3,
                    OrderNr = 39
                },
                new Sector
                {
                    SectorId = 69,
                    Name = "Gas, Plasma, Laser cutting",
                    ParentId = 542,
                    Level = 3,
                    OrderNr = 40
                },
                new Sector
                {
                    SectorId = 66,
                    Name = "MIG, TIG, Aluminum welding",
                    ParentId = 542,
                    Level = 3,
                    OrderNr = 41
                },
                new Sector
                {
                    SectorId = 9,
                    Name = "Plastic and Rubber",
                    ParentId = 1,
                    Level = 1,
                    OrderNr = 42
                },
                new Sector
                {
                    SectorId = 54,
                    Name = "Packaging",
                    ParentId = 9,
                    Level = 2,
                    OrderNr = 43
                },
                new Sector
                {
                    SectorId = 556,
                    Name = "Plastic goods",
                    ParentId = 9,
                    Level = 2,
                    OrderNr = 44
                },
                new Sector
                {
                    SectorId = 559,
                    Name = "Plastic processing technology",
                    ParentId = 9,
                    Level = 2,
                    OrderNr = 45
                },
                new Sector
                {
                    SectorId = 55,
                    Name = "Blowing",
                    ParentId = 559,
                    Level = 3,
                    OrderNr = 46
                },
                new Sector
                {
                    SectorId = 57,
                    Name = "Moulding",
                    ParentId = 559,
                    Level = 3,
                    OrderNr = 47
                },
                new Sector
                {
                    SectorId = 53,
                    Name = "Plastics welding and processing",
                    ParentId = 559,
                    Level = 3,
                    OrderNr = 48
                },
                new Sector
                {
                    SectorId = 560,
                    Name = "Plastic profiles",
                    ParentId = 9,
                    Level = 2,
                    OrderNr = 49
                },
                new Sector
                {
                    SectorId = 5,
                    Name = "Printing",
                    ParentId = 1,
                    Level = 1,
                    OrderNr = 50
                },
                new Sector
                {
                    SectorId = 148,
                    Name = "Advertising",
                    ParentId = 5,
                    Level = 2,
                    OrderNr = 51
                },
                new Sector
                {
                    SectorId = 150,
                    Name = "Book/Periodicals printing",
                    ParentId = 5,
                    Level = 2,
                    OrderNr = 52
                },
                new Sector
                {
                    SectorId = 145,
                    Name = "Labelling and packaging printing",
                    ParentId = 5,
                    Level = 2,
                    OrderNr = 53
                },
                new Sector
                {
                    SectorId = 7,
                    Name = "Textile and Clothing",
                    ParentId = 1,
                    Level = 1,
                    OrderNr = 54
                },
                new Sector
                {
                    SectorId = 44,
                    Name = "Clothing",
                    ParentId = 7,
                    Level = 2,
                    OrderNr = 55
                },
                new Sector
                {
                    SectorId = 45,
                    Name = "Textile",
                    ParentId = 7,
                    Level = 2,
                    OrderNr = 56
                },
                new Sector
                {
                    SectorId = 8,
                    Name = "Wood",
                    ParentId = 1,
                    Level = 1,
                    OrderNr = 57
                },
                new Sector
                {
                    SectorId = 337,
                    Name = "Other (Wood)",
                    ParentId = 8,
                    Level = 2,
                    OrderNr = 58
                },
                new Sector
                {
                    SectorId = 51,
                    Name = "Wooden building materials",
                    ParentId = 8,
                    Level = 2,
                    OrderNr = 59
                },
                new Sector
                {
                    SectorId = 47,
                    Name = "Wooden houses",
                    ParentId = 8,
                    Level = 2,
                    OrderNr = 60
                },
                new Sector
                {
                    SectorId = 3,
                    Name = "Other",
                    ParentId = 0,
                    Level = 0,
                    OrderNr = 61
                },
                new Sector
                {
                    SectorId = 37,
                    Name = "Creative industries",
                    ParentId = 3,
                    Level = 1,
                    OrderNr = 62
                },
                new Sector
                {
                    SectorId = 29,
                    Name = "Creative industries",
                    ParentId = 3,
                    Level = 1,
                    OrderNr = 63
                },
                new Sector
                {
                    SectorId = 33,
                    Name = "Environment",
                    ParentId = 3,
                    Level = 1,
                    OrderNr = 64
                },
                new Sector
                {
                    SectorId = 2,
                    Name = "Service",
                    ParentId = 0,
                    Level = 0,
                    OrderNr = 65
                },
                new Sector
                {
                    SectorId = 25,
                    Name = "Business services",
                    ParentId = 2,
                    Level = 1,
                    OrderNr = 66
                },
                new Sector
                {
                    SectorId = 35,
                    Name = "Engineering",
                    ParentId = 2,
                    Level = 1,
                    OrderNr = 67
                },
                new Sector
                {
                    SectorId = 28,
                    Name = "Information Technology and Telecommunications",
                    ParentId = 2,
                    Level = 1,
                    OrderNr = 68
                },
                new Sector
                {
                    SectorId = 581,
                    Name = "Data processing, Web portals, E-marketing",
                    ParentId = 28,
                    Level = 2,
                    OrderNr = 69
                },
                new Sector
                {
                    SectorId = 576,
                    Name = "Programming, Consultancy",
                    ParentId = 28,
                    Level = 2,
                    OrderNr = 70
                },
                new Sector
                {
                    SectorId = 121,
                    Name = "Software, Hardware",
                    ParentId = 28,
                    Level = 2,
                    OrderNr = 71
                },
                new Sector
                {
                    SectorId = 122,
                    Name = "Telecommunications",
                    ParentId = 28,
                    Level = 2,
                    OrderNr = 72
                },
                new Sector
                {
                    SectorId = 22,
                    Name = "Tourism",
                    ParentId = 2,
                    Level = 1,
                    OrderNr = 73
                },
                new Sector
                {
                    SectorId = 141,
                    Name = "Translation services",
                    ParentId = 2,
                    Level = 1,
                    OrderNr = 74
                },
                new Sector
                {
                    SectorId = 21,
                    Name = "Transpost and Logistics",
                    ParentId = 2,
                    Level = 1,
                    OrderNr = 75
                },
                new Sector
                {
                    SectorId = 111,
                    Name = "Air",
                    ParentId = 21,
                    Level = 2,
                    OrderNr = 76
                },
                new Sector
                {
                    SectorId = 114,
                    Name = "Rail",
                    ParentId = 21,
                    Level = 2,
                    OrderNr = 77
                },
                new Sector
                {
                    SectorId = 112,
                    Name = "Road",
                    ParentId = 21,
                    Level = 2,
                    OrderNr = 78
                },
                new Sector
                {
                    SectorId = 113,
                    Name = "Water",
                    ParentId = 21,
                    Level = 2,
                    OrderNr = 79
                });

                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                context.Users.AddRange(
                new User
                {
                    Name = "Urmas Johandi"
                },
                new User
                {
                    Name = "John Doe"
                },
                new User
                {
                    Name = "Brian Wilson"
                });

                context.SaveChanges();
            }

            if (!context.UsersChoices.Any())
            {
                context.UsersChoices.AddRange(
                    new UsersChoice
                    {
                        UserId = 1,
                        SectorId = 19
                    },
                    new UsersChoice
                    {
                        UserId = 1,
                        SectorId = 18
                    },
                    new UsersChoice
                    {
                        UserId = 1,
                        SectorId = 389
                    },
                    new UsersChoice
                    {
                        UserId = 1,
                        SectorId = 385
                    },
                    new UsersChoice
                    {
                        UserId = 1,
                        SectorId = 390
                    },
                    new UsersChoice
                    {
                        UserId = 1,
                        SectorId = 98
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
