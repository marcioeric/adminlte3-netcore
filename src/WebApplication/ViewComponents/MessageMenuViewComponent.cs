using Microsoft.AspNetCore.Mvc;

namespace WebApplication.ViewComponents
{
    public class MessageMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string filter) => View();
    }
}