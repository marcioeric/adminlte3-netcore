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

            var financialMenus = new List<Menu>()
            {
                new Menu()
                {
                    DisplayName = "Help",
                    Type = MenuType.Link,
                    Url = Url.Action("Help", "Financial"),
                    Icon = "fas fa-hands-helping"
                },
                new Menu()
                {
                    DisplayName = "Bills",
                    Type = MenuType.Link,
                    Url = Url.Action("Bills", "Financial"),
                    Icon = null
                }
            };

            sidebars.Add(new Menu("Main Navigation"));
            sidebars.Add(new Menu("Home", Url.Action("Index", "Home"), MenuType.Home, icon: "fas fa-home"));
            sidebars.Add(new Menu("Privacy",Url.Action("Privacy", "Home"), MenuType.Link, icon: "fas fa-user-shield"));
            sidebars.Add(new Menu("Financial", type: MenuType.Tree, icon: "fas fa-dollar-sign", children: financialMenus));

            return View(sidebars);
        }
    }
}