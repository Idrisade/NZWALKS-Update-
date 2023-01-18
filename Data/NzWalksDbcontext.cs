using Microsoft.EntityFrameworkCore;
using RegionsWalksAPI.Models.Domains;

namespace RegionsWalksAPI.Data
{
    public class NzWalksDbContext: DbContext 
    {
        public NzWalksDbContext(DbContextOptions<NzWalksDbContext> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }   

    }
         
    
    
} 
