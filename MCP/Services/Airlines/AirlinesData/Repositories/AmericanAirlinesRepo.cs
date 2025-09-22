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
    public class AmericanAirlinesRepo : IAmericanAirlinesRepo
    {
        public List<SearchFlightsModel> GetAmericanAirlinesSearchFlight(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return AmericanAirlinesLoadJson.LoadAmericanAirlinesSearchFlightJson(MockResponseJsonPath);
        }

        public List<FlightCostModel> GetAmericanAirlinesFlightCost(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return AmericanAirlinesLoadJson.LoadAmericanAirlinesFlightCostJson(MockResponseJsonPath);
        }

        public List<BookingDetailsModel> GetAmericanAirlinesBookingDetails(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return AmericanAirlinesLoadJson.LoadAmericanAirlinesBookingDetailsJson(MockResponseJsonPath);
        }

        public List<BookFlightModel> GetAmericanAirlinesBookFlight(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return AmericanAirlinesLoadJson.LoadAmericanAirlinesBookFlightJson(MockResponseJsonPath);
        }
    }
}
