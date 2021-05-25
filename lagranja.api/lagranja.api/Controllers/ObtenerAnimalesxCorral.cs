using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lagranja.api.Models;

namespace lagranja.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ObtenerAnimalesxCorral : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Corral 1", "Corral 2", "Corral 3", "Corral 4"
        };

        private readonly ILogger<ObtenerAnimalesxCorral> _logger;

        public ObtenerAnimalesxCorral(ILogger<ObtenerAnimalesxCorral> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public IEnumerable<CorralViewModel> Get(int id)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new CorralViewModel
            {
                Nombre = Summaries[rng.Next(Summaries.Length)],
                Capacidad = rng.Next(20, 55)
            })
            .ToArray();
        }
    }
}
