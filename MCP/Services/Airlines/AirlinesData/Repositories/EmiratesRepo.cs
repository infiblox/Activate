using AirlinesData.Entities;
using AirlinesData.Helpers;
using AirlinesData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesData.Repositories
{
    public class EmiratesRepo : IEmiratesRepo
    {
        public List<SearchFlightsModel> GetEmiratesSearchFlight(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return EmiratesLoadJson.LoadEmiratesSearchFlightJson(MockResponseJsonPath);
        }

        public List<FlightCostModel> GetEmiratesFlightCost(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return EmiratesLoadJson.LoadEmiratesFlightCostJson(MockResponseJsonPath);
        }

        public List<BookingDetailsModel> GetEmiratesBookingDetails(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return EmiratesLoadJson.LoadEmiratesBookingDetailsJson(MockResponseJsonPath);
        }

        public List<BookFlightModel> GetEmiratesBookFlight(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return EmiratesLoadJson.LoadEmiratesBookFlightJson(MockResponseJsonPath);
        }
    }
}
