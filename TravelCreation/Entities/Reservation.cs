using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelCreation.Entities
{
    public class Reservation
    {

        [Key]
        public Guid ReservationID { get; set; }

        [StringLength(36)]
        public string UserID { get; set; }

        [StringLength(36)]
        public string GuestID { get; set; }

        public string Notes { get; set; }

        public decimal? Subtotal { get; set; }

        public decimal? Tax { get; set; }

        public decimal? Fees { get; set; }

        public decimal? Total { get; set; }
    }

}

