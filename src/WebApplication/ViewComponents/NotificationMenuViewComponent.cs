using Microsoft.AspNetCore.Mvc;

namespace WebApplication.ViewComponents
{
    public class NotificationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string filter) => View();
    }
}