using Microsoft.AspNetCore.Mvc;

namespace WebApplication.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string filter) => View();
    }
}