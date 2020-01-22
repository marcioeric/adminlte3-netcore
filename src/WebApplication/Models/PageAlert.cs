using WebApplication.Enums;

namespace WebApplication.Models
{
    public class PageAlert
    {
        public PageAlertType Type { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        
        public PageAlert(PageAlertType type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }
    }
}