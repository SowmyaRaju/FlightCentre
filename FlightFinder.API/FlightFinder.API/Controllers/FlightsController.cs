using FlightFinder.API.Models;
using FlightFinder.API.Services;
using Microsoft.AspNetCore.Mvc;



namespace FlightFinder.API.Controllers
{
    public class FlightsController : Controller
    {
        private readonly IFlightCentreService _flightCentreService;

        public FlightsController(IFlightCentreService flightCentreService)
        {
            _flightCentreService = flightCentreService;
        }

        [HttpPost]
        [Route("api/flight/count")]
        public IHttpActionResult CountFlights([FromBody] FlightRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.Input))
            {
                return (IHttpActionResult)BadRequest("Input string is required.");
            }
                
            int flightCount = _flightCentreService.CountFlights(request.Input);
            return (IHttpActionResult)Ok(new { Count = flightCount });
        }
    }
}