using System;

namespace WebApplication.Models
{
    public class Notification
    {
        public string Icon { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
        
        public Notification(string icon, string message, DateTime date, string url)
        {
            Icon = icon;
            Message = message;
            Date = date;
            Url = url;
        }
    }
}