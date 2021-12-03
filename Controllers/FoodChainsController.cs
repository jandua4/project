using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Models;

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
        public async Task<IActionResult> Index()
        {
            return View(await _context.FoodChains.ToListAsync());
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
        public async Task<IActionResult> Create([Bind("FoodChainID,Name,Description,Filename")] FoodChain foodChain)
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
        public async Task<IActionResult> Edit(int id, [Bind("FoodChainID,Name,Description,Filename")] FoodChain foodChain)
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
