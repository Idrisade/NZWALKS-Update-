using RegionsWalksAPI.Models.Domains;

namespace RegionsWalksAPI.Repositories
{
    public interface IRegionRepository 
    {
        IEnumerable<Region> GetAll();
    }
}
