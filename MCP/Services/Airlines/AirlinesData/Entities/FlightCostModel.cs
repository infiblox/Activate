
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesData.Entities
{
    public class FlightCostModel
    {
        public required string flightId { get; set; }
        public required string flightName { get; set; }
        public float flightcost { get; set; }
    }
}
