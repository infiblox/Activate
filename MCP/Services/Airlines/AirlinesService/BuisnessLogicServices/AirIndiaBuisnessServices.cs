using AirlinesData.Entities;
using AirlinesData.Interfaces;
using AirlinesData.Repositories;
using AirlinesService.Helpers;
using AirlinesService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesService.BuisnessLogicServices
{
    public class AirIndiaBuisnessServices : IAirIndiaBuisnessServices
    {
        private readonly IAirIndiaRepo airIndiaRepo;
        private readonly string MockResponseJsonPath;

        public AirIndiaBuisnessServices(IAirIndiaRepo airIndiaRepo)
        {
            this.airIndiaRepo = airIndiaRepo;

            // Ensure ConfigurationHelper.config is properly initialized before accessing it
            if (ConfigurationHelper.config == null)
            {
                throw new InvalidOperationException("ConfigurationHelper.config is not initialized.");
            }

            // Correctly retrieve the configuration value
            MockResponseJsonPath = ConfigurationHelper.config.GetSection("Location").Value;

            if (string.IsNullOrEmpty(MockResponseJsonPath))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not configured properly.");
            }
        }

        public List<SearchFlightsModel> GetAirIndiaSearchFlightDetails()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }

            return airIndiaRepo.GetAirIndiaSearchFlight(path);
        }

        public List<FlightCostModel> GetAirIndiaFlightCostDetails()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }

            return airIndiaRepo.GetAirIndiaFlightCost(path);
        }

        public List<BookingDetailsModel> GetAirIndiaBookingDetails()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }

            return airIndiaRepo.GetAirIndiaBookingDetails(path);
        }

        public List<BookFlightModel> GetAirIndiaBookFlightDetails()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }

            return airIndiaRepo.GetAirIndiaBookFlight(path);
        }
    }
}
