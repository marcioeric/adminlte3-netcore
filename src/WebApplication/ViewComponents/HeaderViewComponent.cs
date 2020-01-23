using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string filter)
        {
            var messages = GetData();
            return View(messages);
        }

        private static List<Notification> GetData()
        {
            var messages = new List<Notification>
            {
                new Notification("fas fa-envelope", "15 messages", DateTime.Today, "#"),
                new Notification("fas fa-chart-pie", "New predicts are available", DateTime.Today.Subtract(TimeSpan.FromDays(1)), "#")
            };

            return messages;
        }
    }
}