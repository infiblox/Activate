using AirlinesData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesService.Interfaces
{
    public interface IBritishAirlinesBuisnessServices
    {
        List<SearchFlightsModel> GetBritishAirlinesSearchFlightDetails();
        List<FlightCostModel> GetBritishAirlinesFlightCostDetails();
        List<BookingDetailsModel> GetBritishAirlinesBookingDetails();
        List<BookFlightModel> GetBritishAirlinesBookFlightDetails();
    }
}
