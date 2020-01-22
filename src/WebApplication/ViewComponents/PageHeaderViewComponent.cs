using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.ViewComponents
{
    public class PageHeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string filter)
        {
            Tuple<string> header;

            if (ViewBag.PageHeader == null)
            {
                header = new Tuple<string>(string.Empty);
            }
            else
            {
                header = ViewBag.PageHeader as Tuple<string>;
            }
            return View(header);
        }
    }
}