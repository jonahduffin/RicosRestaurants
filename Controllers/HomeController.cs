using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RicosRestaurants.Models;

namespace RicosRestaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();
            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                string? favDish = r.favoriteDish ?? "It's all tasty!";
                restaurantList.Add($"#{r.rank}: {r.restaurantName} -- Fav Dish: {favDish} -- Address: {r.address} -- Phone: {r.restaurantPhone} -- Website: {r.websiteLink}");
            }

            return View(restaurantList);
        }
        [HttpGet]
        public IActionResult Submit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submit(RestaurantSubmission newSubmission)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                SubmissionStorage.AddSubmission(newSubmission);
                return View("ViewSubmissions", SubmissionStorage.Submissions);
            }
        }

        public IActionResult ViewSubmissions()
        {
            return View(SubmissionStorage.Submissions);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
