using System.Collections.Generic;
using System.Linq;

namespace TestUlesanne.Models
{
    public class EFSectorRepository : ISectorRepository
    {
        private ApplicationDbContext context;
        public EFSectorRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Sector> Sectors => context.Sectors.OrderBy(x => x.OrderNr);
    }
}
