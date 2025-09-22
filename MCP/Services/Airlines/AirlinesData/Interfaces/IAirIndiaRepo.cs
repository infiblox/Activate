using AirlinesData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesData.Interfaces
{
    public interface IAirIndiaRepo
    {
        List<SearchFlightsModel> GetAirIndiaSearchFlight(string MockResponseJsonPath);
        List<FlightCostModel> GetAirIndiaFlightCost(string MockResponseJsonPath);
        List<BookingDetailsModel> GetAirIndiaBookingDetails(string MockResponseJsonPath);
        List<BookFlightModel> GetAirIndiaBookFlight(string MockResponseJsonPath);
    }
}
