using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers;

public class AccountController : TemplateController
{
    public IActionResult Login()
    {
        return View();
    }
    
    public IActionResult Register()
    {
        return View();
    }
    
    public IActionResult ForgotPassword()
    {
        return View();
    }
    
    public IActionResult RecoverPassword()
    {
        return View();
    }
}