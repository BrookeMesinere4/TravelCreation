using Microsoft.AspNetCore.Mvc;
using TravelCreation.Entities;
using TravelCreation.Repositories;

namespace TravelCreation.Controllers
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
        [HttpGet("{gethotelRoomAvailyByDate}")]
        public async Task<List<Hotel>> gethotelRoomAvailyByDate(int hotelid)
        {
            var hotelRoomAvailyByDate = await hotelService.hotelRoomAvailyByDate(hotelid);
            if (hotelRoomAvailyByDate == null)
            {
                return NotFound();
            }
            return hotelRoomAvailyByDate;

        }


    }
}
