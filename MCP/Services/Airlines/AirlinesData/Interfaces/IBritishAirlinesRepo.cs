using AirlinesData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesData.Interfaces
{
    public interface IBritishAirlinesRepo
    {
        List<SearchFlightsModel> GetBritishAirlinesSearchFlight(string MockResponseJsonPath);
        List<FlightCostModel> GetBritishAirlinesFlightCost(string MockResponseJsonPath);
        List<BookingDetailsModel> GetBritishAirlinesBookingDetails(string MockResponseJsonPath);
        List<BookFlightModel> GetBritishAirlinesBookFlight(string MockResponseJsonPath);
    }
}
