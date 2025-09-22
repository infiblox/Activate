using AirlinesData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesData.Interfaces
{
    public interface IAmericanAirlinesRepo
    {
        List<SearchFlightsModel> GetAmericanAirlinesSearchFlight(string MockResponseJsonPath);
        List<FlightCostModel> GetAmericanAirlinesFlightCost(string MockResponseJsonPath);
        List<BookingDetailsModel> GetAmericanAirlinesBookingDetails(string MockResponseJsonPath);
        List<BookFlightModel> GetAmericanAirlinesBookFlight(string MockResponseJsonPath);
    }
}
