using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Enums;

namespace WebApplication.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            SetHeader("Dashboard");
            return View();
        }
        
        public IActionResult Privacy()
        {
            SetHeader("Privacy Policy");
            AddBreadcrumb("Privacy Policy", Url.Action("Privacy"));
            AddPageAlerts(PageAlertType.Error, "Error", "Something went wrong");
            AddPageAlerts(PageAlertType.Info, "Info");
            AddPageAlerts(PageAlertType.Success, "Success");
            AddPageAlerts(PageAlertType.Warning, "Warning");
            return View();
        }
    }
}