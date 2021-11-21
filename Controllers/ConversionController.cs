using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankCommoditiesWebService.Models;

namespace BankCommoditiesWebService.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ConversionController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ConversionController> _logger;

        public ConversionController(ILogger<ConversionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Conversion> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Conversion
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
