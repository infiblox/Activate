

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesData.Entities
{
    public class BookingDetailsModel
    {
        public required string bookingId { get; set; }
        public required string bookingStatus { get; set; }
        public DateTime bookingDate { get; set; }
        public required string passengerName { get; set; }
        public required string flightNumber { get; set; }
        public required string flightClass { get; set; }
        public DateTime departureDate { get; set; }
        public DateTime arrivalDate { get; set; }
    }
}
