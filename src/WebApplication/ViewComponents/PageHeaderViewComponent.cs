using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.ViewComponents
{
    public class PageHeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string filter)
        {
            string header;

            if (ViewBag.PageHeader == null)
            {
                header = string.Empty;
            }
            else
            {
                header = ViewBag.PageHeader as string;
            }
            return View(header);
        }
    }
}