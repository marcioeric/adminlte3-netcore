using Microsoft.AspNetCore.Mvc;

namespace WebApplication.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string filter) => View();
    }
}