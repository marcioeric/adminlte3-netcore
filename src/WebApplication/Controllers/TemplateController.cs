using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Enums;
using WebApplication.Models;

namespace WebApplication.Controllers;
public abstract class TemplateController : Controller
{
    internal void AddBreadcrumb(string displayName, string url)
    {
        List<Breadcrumb> breadcrumbs;

        if (ViewBag.Breadcrumb == null)
        {
            breadcrumbs = new List<Breadcrumb>();
        }
        else
        {
            breadcrumbs = ViewBag.Breadcrumb as List<Breadcrumb>;
        }

        breadcrumbs.Add(new Breadcrumb(displayName, url));
        ViewBag.Breadcrumb = breadcrumbs;
    }

    internal void SetHeader(string pageHeader)
    {
        ViewBag.PageHeader = new Tuple<string>(pageHeader);
    }
    
    internal void AddPageAlerts(PageAlertType pageAlertType, string title, string description = "")
    {
        List<PageAlert> pageAlerts;
        
        if (ViewBag.PageAlerts == null)
        {
            pageAlerts = new List<PageAlert>();
        }
        else
        {
            pageAlerts = ViewBag.PageAlerts as List<PageAlert>;
        }
        
        pageAlerts.Add(new PageAlert(pageAlertType, title, description));
        ViewBag.PageAlerts = pageAlerts;
    }
}