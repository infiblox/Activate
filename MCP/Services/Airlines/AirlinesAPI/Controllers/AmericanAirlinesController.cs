using AirlinesData.Entities;
using AirlinesService.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AirlinesAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AmericanAirlinesController : ControllerBase
    {
        private readonly IAmericanAirlinesBuisnessServices AmericanAirlinesBusinessService;

        public AmericanAirlinesController(IAmericanAirlinesBuisnessServices AmericanAirlinesBusinessService)
        {
            this.AmericanAirlinesBusinessService = AmericanAirlinesBusinessService;
        }

        // GET: api/<AmericanAirlinesController>
        [HttpGet]
        public List<SearchFlightsModel> GetSearchFlights()
        {
            try
            {
                return AmericanAirlinesBusinessService.GetAmericanAirlinesSearchFlightDetails();
            }
            catch (Exception ex)
            {
                return new List<SearchFlightsModel>();
            }

        }

        // GET: api/<AmericanAirlinesController>
        [HttpGet]
        public List<FlightCostModel> GetFlightCost()
        {
            try
            {
                return AmericanAirlinesBusinessService.GetAmericanAirlinesFlightCostDetails();
            }
            catch (Exception ex)
            {
                return new List<FlightCostModel>();
            }

        }

        // GET: api/<AmericanAirlinesController>
        [HttpGet]
        public List<BookingDetailsModel> GetBookingDetails()
        {
            try
            {
                return AmericanAirlinesBusinessService.GetAmericanAirlinesBookingDetails();
            }
            catch (Exception ex)
            {
                return new List<BookingDetailsModel>();
            }

        }

        // GET: api/<AmericanAirlinesController>
        [HttpGet]
        public List<BookFlightModel> GetBookFlights()
        {
            try
            {
                return AmericanAirlinesBusinessService.GetAmericanAirlinesBookFlightDetails();
            }
            catch (Exception ex)
            {
                return new List<BookFlightModel>();
            }

        }
    }
}
