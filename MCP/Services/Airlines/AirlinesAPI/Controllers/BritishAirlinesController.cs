using AirlinesData.Entities;
using AirlinesService.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AirlinesAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BritishAirlinesController : ControllerBase
    {
        private readonly IBritishAirlinesBuisnessServices BritishAirlinesBusinessService;

        public BritishAirlinesController(IBritishAirlinesBuisnessServices BritishAirlinesBusinessService)
        {
            this.BritishAirlinesBusinessService = BritishAirlinesBusinessService;
        }

        // GET: api/<BritishAirlinesController>
        [HttpGet]
        public List<SearchFlightsModel> GetSearchFlights()
        {
            try
            {
                return BritishAirlinesBusinessService.GetBritishAirlinesSearchFlightDetails();
            }
            catch (Exception ex)
            {
                return new List<SearchFlightsModel>();
            }

        }

        // GET: api/<BritishAirlinesController>
        [HttpGet]
        public List<FlightCostModel> GetFlightCost()
        {
            try
            {
                return BritishAirlinesBusinessService.GetBritishAirlinesFlightCostDetails();
            }
            catch (Exception ex)
            {
                return new List<FlightCostModel>();
            }

        }

        // GET: api/<BritishAirlinesController>
        [HttpGet]
        public List<BookingDetailsModel> GetBookingDetails()
        {
            try
            {
                return BritishAirlinesBusinessService.GetBritishAirlinesBookingDetails();
            }
            catch (Exception ex)
            {
                return new List<BookingDetailsModel>();
            }

        }

        // GET: api/<BritishAirlinesController>
        [HttpGet]
        public List<BookFlightModel> GetBookFlights()
        {
            try
            {
                return BritishAirlinesBusinessService.GetBritishAirlinesBookFlightDetails();
            }
            catch (Exception ex)
            {
                return new List<BookFlightModel>();
            }

        }
    }
}
