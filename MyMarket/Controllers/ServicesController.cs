using System;
using Microsoft.AspNetCore.Mvc;
using MyMarket.Domain;

namespace MyMarket.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;

        public ServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageStores");
            return View(dataManager.ServiceItems.GetServiceItems());
        }
    }
}
