using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace WebApplication.Controllers
{
    public class FinancialController : BaseController
    {
        public IActionResult Help()
        {
            SetHeader("Financial Help");
            AddBreadcrumb("Financial Help", Url.Action("Help"));
            return View();
        }
        
        public IActionResult Bills()
        {
            SetHeader("Bills");
            AddBreadcrumb("Bills", Url.Action("Bills"));
            return View();
        }
    }
}