using AirlinesData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesData.Interfaces
{
    public interface IEmiratesRepo
    {
        List<SearchFlightsModel> GetEmiratesSearchFlight(string MockResponseJsonPath);
        List<FlightCostModel> GetEmiratesFlightCost(string MockResponseJsonPath);
        List<BookingDetailsModel> GetEmiratesBookingDetails(string MockResponseJsonPath);
        List<BookFlightModel> GetEmiratesBookFlight(string MockResponseJsonPath);
    }
}
