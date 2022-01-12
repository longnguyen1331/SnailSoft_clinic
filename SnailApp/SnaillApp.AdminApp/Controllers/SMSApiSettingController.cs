using System.Collections.Generic;
using System.Threading.Tasks;
using SnailApp.AdminApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace SnailApp.AdminApp.Controllers
{
    public class SMSApiSettingController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = new BaseViewModel();
            ViewBag.Title = "SMS Api Settings";
            model.Breadcrumbs = new List<string>() { "Settings", "SMS Api Settings" };

            return View(model);
        }
    }
}