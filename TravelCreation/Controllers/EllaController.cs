﻿using Microsoft.AspNetCore.Mvc;
using TravelCreation.Repositories;

using TravelCreation.Entities;

namespace TravelCreation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EllaController : Controller
    {

        private readonly IEllaAPI hotelservice;
        public EllaController(IEllaAPI hotelservice)
        { this.hotelservice = hotelservice; }

        [HttpGet("HotelSearchByRadius/longitude={longitude}&latitude={latitude}")]
        public async Task<List<Hotel>> spHotelSearchByRadius(decimal latitude, decimal longitude)
        {
            var hotelDetails = await hotelservice.spHotelSearchByRadius(latitude, longitude);
            if (hotelDetails == null)
            {
            }
            return hotelDetails;

        }
        [HttpGet("RoomGetAvailabilityByDateRange/StartDate={StartDate}&EndDate={EndDate}")]
        public async Task<List<RoomAvail>> spRoomGetAvailabilityByDateRange(DateTime StartDate, DateTime EndDate)
        {
            var RoomAvail = await hotelservice.spRoomGetAvailabilityByDateRange(StartDate, EndDate);
            if (RoomAvail == null)
            { }
            return RoomAvail;
        }
    }
}
