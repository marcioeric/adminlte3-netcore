using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.ViewComponents
{
    public class BreadcrumbViewComponent : ViewComponent
    {
        public BreadcrumbViewComponent()
        {
            
        }
        
        public IViewComponentResult Invoke(string filter)
        {
            if (ViewBag.Breadcrumb == null)
            {
                ViewBag.Breadcrumb = new List<Breadcrumb>();
            }
            
            return View(ViewBag.Breadcrumb as List<Breadcrumb>);
        }
    }
}