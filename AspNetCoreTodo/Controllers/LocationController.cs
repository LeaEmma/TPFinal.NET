using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers
{
    public class LocationControllers : Controller
    {
        private readonly ILocationItemService _locationItemService;
        public LocationController(ILocationItemService locationItemService)
        {
            _locationItemService = locationItemService;
        }
        public async Task<IActionResult> Index()
        {
            // Get to-do items from database
            var items = await _locationItemService.GetLocationAsync();
            // Put items into a model
            var model = new LocationViewModel()
            {
                Items = items
            };

            // Pass the view to a model and render
            return View(model);
        }
    }
}