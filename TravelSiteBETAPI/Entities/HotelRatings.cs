using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelSiteBETAPI.Entities
{
    public class HotelRatings
    {
        public int HotelRatingsID { get; set; }
        public int HotelID { get; set; }
        public int rating { get; set; }
        public string? userID { get; set; }
        public string? Review { get; set; }
    }
}
