using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.ViewComponents
{
    public class PageAlertViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string filter)
        {
            List<PageAlert> messages;
            if (ViewBag.PageAlerts == null)
            {
                messages = new List<PageAlert>();
            }
            else
            {
                messages = new List<PageAlert>(ViewBag.PageAlerts);
            }
            return View(messages);
        }
    }
}