using Microsoft.AspNetCore.Mvc;
using TravelSiteBETAPI.Entities;
using TravelSiteBETAPI.Repositories;

namespace TravelSiteBETAPI.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class HotelRatingsController : ControllerBase
    {
        private readonly IRatingService _HotelRatingService;
        public HotelRatingsController(IRatingService hotelRatingService)
        {
            _HotelRatingService = hotelRatingService;
        }
        [HttpGet("{hotelid}")]
        public async Task<ActionResult<List<HotelRatings>>> ReturnRatings(int hotelid)
        {
            var hotelRatings = await _HotelRatingService.ReturnRatings(hotelid);
            if (hotelRatings == null)
            {
                return NotFound();
            }
            return hotelRatings;
        }
    }
}
