using Microsoft.AspNetCore.Mvc;
using RegionsWalksAPI.Models.Domains;
using RegionsWalksAPI.Repositories;

namespace RegionsWalksAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;

        public RegionsController(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }
        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions = regionRepository.GetAll();

            //return DTO regions
            var regionsDTO = new List<Models.DTOs.Region>();
            regions.ToList().ForEach(region =>
            {
                var regionDTO = new Models.DTOs.Region()
                {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    Area = region.Area,
                    Latitude = region.Latitude,
                    Longitude = region.Longitude,
                    Population = region.Population,

                };

                regionsDTO.Add(regionDTO);

            });

            return Ok(regions);

        }
    }
    
}
