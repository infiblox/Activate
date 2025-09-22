using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesData.Entities
{
    public class BookFlightModel
    {
        public required string flightId { get; set; }
        public bool flightavailable { get; set; }
    }

}
