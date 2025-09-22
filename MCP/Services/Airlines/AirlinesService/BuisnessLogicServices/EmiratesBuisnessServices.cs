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
    public class EmiratesBuisnessServices : IEmiratesBuisnessServices
    {
        private readonly IEmiratesRepo EmiratesRepo;
        private readonly string MockResponseJsonPath;
        public EmiratesBuisnessServices(IEmiratesRepo EmiratesRepo)
        {
            this.EmiratesRepo = EmiratesRepo;

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

        public List<SearchFlightsModel> GetEmiratesSearchFlightDetails()
        {
            // Implementation here
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }

            return EmiratesRepo.GetEmiratesSearchFlight(path);
        }


        public List<FlightCostModel> GetEmiratesFlightCostDetails()
        {
            // Implementation here
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }

            return EmiratesRepo.GetEmiratesFlightCost(path);
        }

        public List<BookingDetailsModel> GetEmiratesBookingDetails()
        {
            // Implementation here
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }

            return EmiratesRepo.GetEmiratesBookingDetails(path);
        }

        public List<BookFlightModel> GetEmiratesBookFlightDetails()
        {
            // Implementation here
            string path = AppDomain.CurrentDomain.BaseDirectory + MockResponseJsonPath;

            if (string.IsNullOrEmpty(path))
            {
                throw new InvalidOperationException("MockResponseJsonPath is not set correctly.");
            }

            return EmiratesRepo.GetEmiratesBookFlight(path);
        }
    }
}
