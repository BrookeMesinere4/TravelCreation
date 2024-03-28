using Microsoft.AspNetCore.Mvc;
using TravelSiteBETAPI.Entities;
using TravelSiteBETAPI.Repositories;

namespace TravelSiteBETAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : Controller
    {
        private readonly IHotelService hotelService;
        public HotelsController(IHotelService hotelService) 
        {
            this.hotelService = hotelService;
        }
        [HttpGet("{hotelid}")]
        public async Task<List<Hotel>> ReturnHotelDetails(int hotelid)
        {
            var hotelDetails = await hotelService.ReturnHotelDetails(hotelid);
            if (hotelDetails == null)
            {
                //return NotFound();
            }
            return hotelDetails;
        }

        
    }
}
