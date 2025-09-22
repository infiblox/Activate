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
    public class BritishAirlinesRepo : IBritishAirlinesRepo
    {
        public List<SearchFlightsModel> GetBritishAirlinesSearchFlight(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return BritishAirlinesLoadJson.LoadBritishAirlinesSearchFlightJson(MockResponseJsonPath);
        }

        public List<FlightCostModel> GetBritishAirlinesFlightCost(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return BritishAirlinesLoadJson.LoadBritishAirlinesFlightCostJson(MockResponseJsonPath);
        }

        public List<BookingDetailsModel> GetBritishAirlinesBookingDetails(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return BritishAirlinesLoadJson.LoadBritishAirlinesBookingDetailsJson(MockResponseJsonPath);
        }

        public List<BookFlightModel> GetBritishAirlinesBookFlight(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return BritishAirlinesLoadJson.LoadBritishAirlinesBookFlightJson(MockResponseJsonPath);
        }
    }
}
