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
    public class BritishAirlinesBuisnessServices : IBritishAirlinesBuisnessServices
    {
        private readonly IBritishAirlinesRepo BritishAirlinesRepo;
        private readonly string MockResponseJsonPath;
        public BritishAirlinesBuisnessServices(IBritishAirlinesRepo BritishAirlinesRepo)
        {
            this.BritishAirlinesRepo = BritishAirlinesRepo;

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

        public List<SearchFlightsModel> GetBritishAirlinesSearchFlightDetails()
        {
            // Implementation here
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }

            return BritishAirlinesRepo.GetBritishAirlinesSearchFlight(path);
        }


        public List<FlightCostModel> GetBritishAirlinesFlightCostDetails()
        {
            // Implementation here
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }

            return BritishAirlinesRepo.GetBritishAirlinesFlightCost(path);
        }

        public List<BookingDetailsModel> GetBritishAirlinesBookingDetails()
        {
            // Implementation here
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }

            return BritishAirlinesRepo.GetBritishAirlinesBookingDetails(path);
        }

        public List<BookFlightModel> GetBritishAirlinesBookFlightDetails()
        {
            // Implementation here
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }

            return BritishAirlinesRepo.GetBritishAirlinesBookFlight(path);
        }
    }
}
