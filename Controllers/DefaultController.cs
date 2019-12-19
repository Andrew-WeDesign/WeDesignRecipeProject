using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WeDesignFood.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Models.Recipe Recipe)
        {
            if (ModelState.IsValid)
            {
                // Logic to add the book to DB
                return RedirectToAction("Index");
            }
            return View(Recipe);
        }

    }
}