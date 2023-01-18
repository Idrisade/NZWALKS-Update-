using RegionsWalksAPI.Data;
using RegionsWalksAPI.Models.Domains;

namespace RegionsWalksAPI.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NzWalksDbContext nZWalksDbContext;

        public RegionRepository(NzWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }
        public IEnumerable<Region> GetAll()
        {
           return nZWalksDbContext.Regions.ToList();
        }
    }
}
