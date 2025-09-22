using AirlinesData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesService.Interfaces
{
    public interface IAmericanAirlinesBuisnessServices
    {
        List<SearchFlightsModel> GetAmericanAirlinesSearchFlightDetails();
        List<FlightCostModel> GetAmericanAirlinesFlightCostDetails();
        List<BookingDetailsModel> GetAmericanAirlinesBookingDetails();
        List<BookFlightModel> GetAmericanAirlinesBookFlightDetails();
    }
}
