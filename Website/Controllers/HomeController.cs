using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            _logger.LogInformation("Hit - Home()");
            return View();
        }
    }
}
