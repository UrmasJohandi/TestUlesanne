using System.Collections.Generic;

namespace TestUlesanne.Models
{
    public interface ISectorRepository
    {
        IEnumerable<Sector> Sectors { get; }
    }
}
