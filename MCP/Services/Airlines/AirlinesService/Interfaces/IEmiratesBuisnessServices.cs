using AirlinesData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesService.Interfaces
{
    public interface IEmiratesBuisnessServices
    {
        List<SearchFlightsModel> GetEmiratesSearchFlightDetails();
        List<FlightCostModel> GetEmiratesFlightCostDetails();
        List<BookingDetailsModel> GetEmiratesBookingDetails();
        List<BookFlightModel> GetEmiratesBookFlightDetails();
    }
}
