using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Controllers
{
    public class FoodChainsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FoodChainsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FoodChains
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {

            // Sort Functionality
            ViewData["NameSort"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["GFSort"] = sortOrder == "GlutenFreeOptions" ? "gf_desc" : "GlutenFreeOptions";
            ViewData["VegeSort"] = sortOrder == "VegetarianOptions" ? "vege_desc" : "VegetarianOptions";
            ViewData["VeganSort"] = sortOrder == "VeganOptions" ? "vegan_desc" : "VeganOptions";
            ViewData["DFSort"] = sortOrder == "DairyFreeOptions" ? "dairy_desc" : "DairyFreeOptions";
            ViewData["NFSort"] = sortOrder == "NutFreeOptions" ? "nut_desc" : "NutFreeOptions";

            // Call FoodChains model and include Allergies model
            var foodchains = from f in _context.FoodChains
                             select f;

            // Search function
            ViewData["CurrentFilter"] = searchString;
            if (!string.IsNullOrEmpty(searchString))
            {
                foodchains = foodchains.Where(f => f.FoodChainName.Contains(searchString));
            }

            // Switch case for sorting results
            switch (sortOrder)
            {
                case "name_desc":
                    foodchains = foodchains.OrderByDescending(s => s.FoodChainName);
                    break;
                case "GlutenFreeOptions":
                    foodchains = foodchains.OrderBy(s => s.GlutenFreeOptions);
                    break;
                case "gf_desc":
                    foodchains = foodchains.OrderByDescending(s => s.GlutenFreeOptions);
                    break;
                case "VegetarianOptions":
                    foodchains = foodchains.OrderBy(s => s.VegetarianOptions);
                    break;
                case "vege_desc":
                    foodchains = foodchains.OrderByDescending(s => s.VegetarianOptions);
                    break;
                case "VeganOptions":
                    foodchains = foodchains.OrderBy(s => s.VeganOptions);
                    break;
                case "vegan_desc":
                    foodchains = foodchains.OrderByDescending(s => s.VeganOptions);
                    break;
                case "DairyFreeOptions":
                    foodchains = foodchains.OrderBy(s => s.DairyFreeOptions);
                    break;
                case "dairy_desc":
                    foodchains = foodchains.OrderByDescending(s => s.DairyFreeOptions);
                    break;
                case "NutFreeOptions":
                    foodchains = foodchains.OrderBy(s => s.NutFreeOptions);
                    break;
                case "nut_desc":
                    foodchains = foodchains.OrderByDescending(s => s.NutFreeOptions);
                    break;
                default:
                    foodchains = foodchains.OrderBy(s => s.FoodChainName);
                    break;
            }

            return View(await foodchains.AsNoTracking().ToListAsync());
        }

        // GET: FoodChains/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodChain = await _context.FoodChains
                .FirstOrDefaultAsync(m => m.FoodChainID == id);
            if (foodChain == null)
            {
                return NotFound();
            }

            return View(foodChain);
        }

        // GET: FoodChains/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FoodChains/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FoodChainID,FoodChainName,Description,MenuLink,GlutenFreeOptions,VegetarianOptions,VeganOptions,DairyFreeOptions,NutFreeOptions,OtherOptions")] FoodChain foodChain)
        {
            if (ModelState.IsValid)
            {
                _context.Add(foodChain);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(foodChain);
        }

        // GET: FoodChains/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodChain = await _context.FoodChains.FindAsync(id);
            if (foodChain == null)
            {
                return NotFound();
            }
            return View(foodChain);
        }

        // POST: FoodChains/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FoodChainID,FoodChainName,Description,MenuLink,GlutenFreeOptions,VegetarianOptions,VeganOptions,DairyFreeOptions,NutFreeOptions,OtherOptions")] FoodChain foodChain)
        {
            if (id != foodChain.FoodChainID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(foodChain);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FoodChainExists(foodChain.FoodChainID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(foodChain);
        }

        // GET: FoodChains/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodChain = await _context.FoodChains
                .FirstOrDefaultAsync(m => m.FoodChainID == id);
            if (foodChain == null)
            {
                return NotFound();
            }

            return View(foodChain);
        }

        // POST: FoodChains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var foodChain = await _context.FoodChains.FindAsync(id);
            _context.FoodChains.Remove(foodChain);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FoodChainExists(int id)
        {
            return _context.FoodChains.Any(e => e.FoodChainID == id);
        }
    }
}
