using AirlinesData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesService.Interfaces
{
    public interface IAirIndiaBuisnessServices
    {
        List<SearchFlightsModel> GetAirIndiaSearchFlightDetails();
        List<FlightCostModel> GetAirIndiaFlightCostDetails();
        List<BookingDetailsModel> GetAirIndiaBookingDetails();
        List<BookFlightModel> GetAirIndiaBookFlightDetails();
    }
}
