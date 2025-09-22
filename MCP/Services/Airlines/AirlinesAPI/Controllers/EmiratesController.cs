using AirlinesData.Entities;
using AirlinesService.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AirlinesAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmiratesController : ControllerBase
    {
        private readonly IEmiratesBuisnessServices EmiratesBusinessService;

        public EmiratesController(IEmiratesBuisnessServices EmiratesBusinessService)
        {
            this.EmiratesBusinessService = EmiratesBusinessService;
        }

        // GET: api/<EmiratesController>
        [HttpGet]
        public List<SearchFlightsModel> GetSearchFlights()
        {
            try
            {
                return EmiratesBusinessService.GetEmiratesSearchFlightDetails();
            }
            catch (Exception ex)
            {
                return new List<SearchFlightsModel>();
            }

        }

        // GET: api/<EmiratesController>
        [HttpGet]
        public List<FlightCostModel> GetFlightCost()
        {
            try
            {
                return EmiratesBusinessService.GetEmiratesFlightCostDetails();
            }
            catch (Exception ex)
            {
                return new List<FlightCostModel>();
            }

        }

        // GET: api/<EmiratesController>
        [HttpGet]
        public List<BookingDetailsModel> GetBookingDetails()
        {
            try
            {
                return EmiratesBusinessService.GetEmiratesBookingDetails();
            }
            catch (Exception ex)
            {
                return new List<BookingDetailsModel>();
            }

        }

        // GET: api/<EmiratesController>
        [HttpGet]
        public List<BookFlightModel> GetBookFlights()
        {
            try
            {
                return EmiratesBusinessService.GetEmiratesBookFlightDetails();
            }
            catch (Exception ex)
            {
                return new List<BookFlightModel>();
            }

        }
    }
}
