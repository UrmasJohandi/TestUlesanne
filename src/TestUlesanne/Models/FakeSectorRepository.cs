using System.Collections.Generic;

namespace TestUlesanne.Models
{
    public class FakeSectorRepository : ISectorRepository
    {
        public IEnumerable<Sector> Sectors => new List<Sector> {
            new Sector { SectorId = 1,   Name = "Manufacturing", ParentId = 0, Level = 0},
            new Sector { SectorId = 19,  Name = "Construction materials", ParentId = 1, Level = 1 },
            new Sector { SectorId = 18,  Name = "Electronics and Optics", ParentId = 1, Level = 1 },
            new Sector { SectorId = 6,   Name = "Food and Beverage", ParentId = 1, Level = 1 },
            new Sector { SectorId = 342, Name = "Bakery & confectionery products", ParentId = 6, Level = 2 },
            new Sector { SectorId = 43,  Name = "Beverages", ParentId = 6, Level = 2 },
            new Sector { SectorId = 42,  Name = "Fish & fish products", ParentId = 6, Level = 2 },
            new Sector { SectorId = 40,  Name = "Meat & meat products", ParentId = 6, Level = 2 },
            new Sector { SectorId = 39,  Name = "Milk & dairy products", ParentId = 6, Level = 2 },
            new Sector { SectorId = 437, Name = "Other", ParentId = 6, Level = 2 },
            new Sector { SectorId = 378, Name = "Sweets & snack food", ParentId = 6, Level = 2 },
            new Sector { SectorId = 13,  Name = "Furniture", ParentId = 1, Level = 1 },
            new Sector { SectorId = 389, Name = "Bathroom/sauna", ParentId = 13, Level = 2 },
            new Sector { SectorId = 385, Name = "Bedroom", ParentId = 13, Level = 2 },
            new Sector { SectorId = 390, Name = "Children's room", ParentId = 13, Level = 2 },
            new Sector { SectorId = 98,  Name = "Kitchen", ParentId = 13, Level = 2 },
            new Sector { SectorId = 101, Name = "Living room", ParentId = 13, Level = 2 },
            new Sector { SectorId = 392, Name = "Office", ParentId = 13, Level = 2 },
            new Sector { SectorId = 394, Name = "Other (Furniture)", ParentId = 13, Level = 2 },
            new Sector { SectorId = 341, Name = "Outdoor", ParentId = 13, Level = 2 },
            new Sector { SectorId = 99,  Name = "Project furniture", ParentId = 13, Level = 2 }
        };
    }
}
