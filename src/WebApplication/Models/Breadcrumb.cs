namespace WebApplication.Models
{
    public class Breadcrumb
    {
        public string DisplayName { get; set; }
        public string Url { get; set; }
        
        public Breadcrumb(string displayName, string url)
        {
            DisplayName = displayName;
            Url = url;
        }

        public Breadcrumb(string displayName)
        {
            DisplayName = displayName;
        }
    }
}