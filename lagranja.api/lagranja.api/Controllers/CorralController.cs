using lagranja.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lagranja.api.Data;

namespace lagranja.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CorralController : ControllerBase
    {
        private readonly GranjaAppContext _context;

        public CorralController(GranjaAppContext context)
        {
            _context = context;
        }

        // GET: Corrales
        [HttpGet]
        public IEnumerable<CorralViewModel> Get()
        {
            return _context.CorralViewModel.ToArray();
        }

        // GET: Corrales
        [HttpPost("addCorral")]
        public async Task<IActionResult> AddCorral([FromBody] CorralViewModel corralViewModel)
        {
            _context.Add(corralViewModel);
            await _context.SaveChangesAsync();
            return Ok();
        }


        /* private readonly ILogger<CorralController> _logger;

         public CorralController(ILogger<CorralController> logger)
         {
             _logger = logger;
         }

         [HttpGet("{id}")]
         public IEnumerable<Corral> Get(int id)
         {
             var rng = new Random();
             return Enumerable.Range(1, 5).Select(index => new Corral
             {
                 Nombre = Summaries[rng.Next(Summaries.Length)],
                 Capacidad = rng.Next(20, 55)
             })
             .ToArray();
         }

         [HttpPost("addCorral")]
         public ActionResult AddCorral([FromBody] CorralViewModel corral)
         {
             return Ok();
         }*/
    }
}
