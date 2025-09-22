using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesData.Entities
{
    public class SearchFlightsModel
    {
        public required string flightId { get; set; }
        public required string airline { get; set; }
        public required Departure departure { get; set; }
        public required Arrival arrival { get; set; }
        public required string duration { get; set; }
        public float price { get; set; }
        public int stops { get; set; }
        public required string aircraftType { get; set; }
    }
}


public class Departure
{
    public required string airport { get; set; }
    public DateTime time { get; set; }
}

public class Arrival
{
    public required string airport { get; set; }
    public DateTime time { get; set; }
}

