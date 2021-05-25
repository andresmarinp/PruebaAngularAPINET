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
    public class AnimalController : ControllerBase
    {
        private readonly GranjaAppContext _context;

        public AnimalController(GranjaAppContext context)
        {
            _context = context;
        }

        // GET: Animales
        [HttpGet]
        public IEnumerable<AnimalViewModel> Get()
        {
            return _context.AnimalViewModel.ToArray();
        }


      
    }
}
