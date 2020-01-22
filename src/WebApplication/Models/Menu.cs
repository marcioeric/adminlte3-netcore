using System;
using System.Collections.Generic;
using WebApplication.Enums;

namespace WebApplication.Models
{
    public class Menu
    {
        public string DisplayName { get; set; }
        public string Url { get; set; }
        public MenuType Type { get; set; }
        public Badge Badge { get; set; }
        public string Icon { get; set; }
        public List<Menu> Children { get; set; }
        public Tuple<int, int> LinkCounter { get; set; }
        
        public Menu(string displayName = "", string url = "", MenuType type = MenuType.Header, Badge badge = null, string icon = "", List<Menu> children = null, Tuple<int, int> linkCounter = null)
        {
            DisplayName = displayName;
            Url = url;
            Type = type;
            Badge = badge;
            Icon = icon;
            Children = children;
            LinkCounter = linkCounter;
        }
    }
}