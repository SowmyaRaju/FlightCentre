using Microsoft.AspNetCore.Mvc;
using FlightFinder.API.Models;
using FlightFinder.API.Services;
using System;
using System.Net;

namespace FlightFinder.API.Controllers
{
    [ApiController]
    [Route("api/flights")]
    public class FlightsController : Controller
    {
        private readonly IFlightCentreService _flightCentreService;

        public FlightsController(IFlightCentreService flightCentreService)
        {
            _flightCentreService = flightCentreService;
        }

        [HttpPost]
        [Route("count")]
        public ActionResult CountFlights([FromBody] FlightRequest request)
        {
            try
            {
                if (request == null || string.IsNullOrEmpty(request.Input))
                {
                    return BadRequest("Input string is required.");
                }

                int flightCount = _flightCentreService.CountFlights(request.Input);
                return Ok(new { Count = flightCount });
            }
            catch (Exception ex)
            {
                string errorMessage = $"An error occurred while processing the request. Exception: {ex}";
                return BadRequest(errorMessage);
            }
        }
    }
}