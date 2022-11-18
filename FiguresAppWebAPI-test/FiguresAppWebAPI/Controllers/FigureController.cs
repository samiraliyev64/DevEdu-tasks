using FiguresAppWebAPI.Figures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiguresAppWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FigureController : Controller
    {
        private readonly ILogger<FigureController> _logger;

        public FigureController(ILogger<FigureController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<Figure> GetFigures()
        {
            
        }
    }
}
