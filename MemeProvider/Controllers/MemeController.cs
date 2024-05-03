using MemeProvider.Interfaces;
using MemeProvider.Interfaces.Repositories;
using MemeProvider.Models;
using Microsoft.AspNetCore.Mvc;

namespace MemeProvider.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemeController : ControllerBase
    {
        private readonly ILogger<MemeController> _logger;
        public readonly IMemeProvider _memeRepo;

        public MemeController(ILogger<MemeController> logger, IMemeProvider memeProvider)
        {
            _logger = logger;
            _memeRepo = memeProvider;
        }

        [HttpGet(Name = "GetMeme")]
        public string Get([FromQuery] string type= "default")
        {
          return _memeRepo.GetMeme(type);
        }
    }
}
