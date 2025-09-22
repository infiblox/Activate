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
    public class AirIndiaRepo : IAirIndiaRepo
    {
        public List<SearchFlightsModel> GetAirIndiaSearchFlight(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return loadJson.LoadAirIndiaSearchFlightJson(MockResponseJsonPath,true);
        }

        public List<FlightCostModel> GetAirIndiaFlightCost(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return loadJson.LoadAirIndiaFlightCostJson(MockResponseJsonPath);
        }

        public List<BookingDetailsModel> GetAirIndiaBookingDetails(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return loadJson.LoadAirIndiaBookingDetailsJson(MockResponseJsonPath);
        }

        public List<BookFlightModel> GetAirIndiaBookFlight(string MockResponseJsonPath)
        {
            // Implementation of the method  
            return loadJson.LoadAirIndiaBookFlightJson(MockResponseJsonPath);
        }
    }
}
