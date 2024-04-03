using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class HomeController(ILogger<HomeController> logger) : Controller
    {
        private readonly ILogger _logger = logger;

        [Route("")]
        public IActionResult Home()
        {
            _logger.LogInformation("Hit - Home()");
            return View();
        }

        [Route("/privacy")]
        public IActionResult Privacy()
        {
            _logger.LogInformation("Hit - Privacy()");
            return View();
        }
    }
}
