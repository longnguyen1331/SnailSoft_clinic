using System.Collections.Generic;
using System.Threading.Tasks;
using SnailApp.AdminApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace SnailApp.AdminApp.Controllers
{
    public class NotificationTemplate : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = new BaseViewModel();
            ViewBag.Title = "Notification Template";
            model.Breadcrumbs = new List<string>() { "Settings", "Notification Template" };

            return View(model);
        }
    }
}