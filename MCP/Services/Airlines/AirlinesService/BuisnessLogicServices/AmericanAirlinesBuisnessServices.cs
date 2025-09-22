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
    public class AmericanAirlinesBuisnessServices : IAmericanAirlinesBuisnessServices
    {
        private readonly IAmericanAirlinesRepo AmericanAirlinesRepo;
        private readonly string MockResponseJsonPath;
        public AmericanAirlinesBuisnessServices(IAmericanAirlinesRepo AmericanAirlinesRepo)
        {
            this.AmericanAirlinesRepo = AmericanAirlinesRepo;

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

        public List<SearchFlightsModel> GetAmericanAirlinesSearchFlightDetails()
        {
            // Implementation here
            string path = AppDomain.CurrentDomain.BaseDirectory+ MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }
            
            return AmericanAirlinesRepo.GetAmericanAirlinesSearchFlight(path);
        }


        public List<FlightCostModel> GetAmericanAirlinesFlightCostDetails()
        {
            // Implementation here
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }

            return AmericanAirlinesRepo.GetAmericanAirlinesFlightCost(path);
        }

        public List<BookingDetailsModel> GetAmericanAirlinesBookingDetails() 
        {
            // Implementation here
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }

            return AmericanAirlinesRepo.GetAmericanAirlinesBookingDetails(path);
        }

        public List<BookFlightModel> GetAmericanAirlinesBookFlightDetails()
        {
            // Implementation here
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }
            
            return AmericanAirlinesRepo.GetAmericanAirlinesBookFlight(MockResponseJsonPath);
        }
    }
}
