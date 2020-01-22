using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Enums;
using WebApplication.Models;

namespace WebApplication.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string filter)
        {
            var sidebars = new List<Menu>();

            sidebars.Add(new Menu("Main Navigation"));
            sidebars.Add(new Menu("Home", Url.Action("Index", "Home"), MenuType.Link));
            sidebars.Add(new Menu("Privacy", Url.Action("Privacy", "Home"), MenuType.Link));

            return View(sidebars);
        }
    }
}