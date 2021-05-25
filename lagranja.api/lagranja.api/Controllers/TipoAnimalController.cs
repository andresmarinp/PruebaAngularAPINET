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
    public class TipoAnimalController : ControllerBase
    {
        private readonly GranjaAppContext _context;

        public TipoAnimalController(GranjaAppContext context)
        {
            _context = context;
        }

        // GET: TipoAnimales
        [HttpGet]
        public IEnumerable<TipoAnimalViewModel> Get()
        {
            return _context.TipoAnimalViewModel.ToArray();
        }


      
    }
}
