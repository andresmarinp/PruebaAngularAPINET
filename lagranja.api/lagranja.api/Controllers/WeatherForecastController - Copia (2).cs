using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lagranja.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CorralController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Corral 1", "Corral 2", "Corral 3", "Corral 4"
        };

        private readonly ILogger<CorralController> _logger;

        public CorralController(ILogger<CorralController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Corral> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Corral
            {               
                Nombre = Summaries[rng.Next(Summaries.Length)],
                Capacidad = rng.Next(-20, 55)
            })
            .ToArray();
        }
    }
}
