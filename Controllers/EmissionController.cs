using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Emission_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmissionController : ControllerBase
    {

        EmissionDbContext dbContext;
        private readonly ILogger<EmissionController> _logger;

        public EmissionController(ILogger<EmissionController> logger, EmissionDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Emission> Get()
        {

            Console.WriteLine("handlig a Get Request");

            var blog = dbContext.emission
                .OrderBy(b => b.start);

            return blog;

        }
    }
}
