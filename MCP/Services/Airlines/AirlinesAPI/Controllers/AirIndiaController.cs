using AirlinesData.Entities;
using AirlinesService.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AirlinesAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AirIndiaController : ControllerBase
    {
        private readonly IAirIndiaBuisnessServices airIndiaBusinessService;

        public AirIndiaController(IAirIndiaBuisnessServices airIndiaBusinessService)
        {
            this.airIndiaBusinessService = airIndiaBusinessService;
        }

        // GET: api/<AirIndiaController>
        [HttpGet]
        public List<SearchFlightsModel> GetSearchFlights()
        {
            try
            {
               return airIndiaBusinessService.GetAirIndiaSearchFlightDetails();
            }
            catch (Exception ex)
            {
                return new List<SearchFlightsModel>();
            }
            
        }

        // GET: api/<AirIndiaController>
        [HttpGet]
        public List<FlightCostModel> GetFlightCost()
        {
            try
            {
                return airIndiaBusinessService.GetAirIndiaFlightCostDetails();
            }
            catch (Exception ex)
            {
                return new List<FlightCostModel>();
            }

        }

        // GET: api/<AirIndiaController>
        [HttpGet]
        public List<BookingDetailsModel> GetBookingDetails()
        {
            try
            {
                return airIndiaBusinessService.GetAirIndiaBookingDetails();
            }
            catch (Exception ex)
            {
                return new List<BookingDetailsModel>();
            }

        }

        // GET: api/<AirIndiaController>
        [HttpGet]
        public List<BookFlightModel> GetBookFlights()
        {
            try
            {
                return airIndiaBusinessService.GetAirIndiaBookFlightDetails();
            }
            catch (Exception ex)
            {
                return new List<BookFlightModel>();
            }

        }
    }
}
