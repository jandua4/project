using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class AllergyGroupsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AllergyGroupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AllergyGroups
        [Authorize(Policy = "writepolicy")]
        public async Task<IActionResult> Index(string searchString, string currentFilter, int? pageNumber)
        {
            // Page number is set to 1 if there is a search string
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var allergyGroup = from g in _context.AllergyGroups
                               .OrderBy(g => g.GroupName)
                               select g;

            // Search function
            ViewData["CurrentFilter"] = searchString;
            if (!string.IsNullOrEmpty(searchString))
            {
                allergyGroup = allergyGroup.Where(g => g.GroupName.Contains(searchString));
            }

            // Number of records per page before paginating
            int pageSize = 10;


            return View(await PaginatedList<AllergyGroup>.CreateAsync(allergyGroup.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: AllergyGroups/Details/5
        [Authorize(Policy = "writepolicy")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allergyGroup = await _context.AllergyGroups
                .Include(a => a.Allergies)
                .FirstOrDefaultAsync(m => m.GroupID == id);

            if (allergyGroup == null)
            {
                return NotFound();
            }

            return View(allergyGroup);
        }

        // GET: AllergyGroups/Create
        [Authorize(Policy = "writepolicy")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: AllergyGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroupID,GroupName")] AllergyGroup allergyGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(allergyGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(allergyGroup);
        }

        // GET: AllergyGroups/Edit/5
        [Authorize(Policy = "writepolicy")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allergyGroup = await _context.AllergyGroups.FindAsync(id);
            if (allergyGroup == null)
            {
                return NotFound();
            }
            return View(allergyGroup);
        }

        // POST: AllergyGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroupID,GroupName")] AllergyGroup allergyGroup)
        {
            if (id != allergyGroup.GroupID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(allergyGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AllergyGroupExists(allergyGroup.GroupID))
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
            return View(allergyGroup);
        }

        // GET: AllergyGroups/Delete/5
        [Authorize(Policy = "writepolicy")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allergyGroup = await _context.AllergyGroups
                .FirstOrDefaultAsync(m => m.GroupID == id);
            if (allergyGroup == null)
            {
                return NotFound();
            }

            return View(allergyGroup);
        }

        // POST: AllergyGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var allergyGroup = await _context.AllergyGroups.FindAsync(id);
            _context.AllergyGroups.Remove(allergyGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AllergyGroupExists(int id)
        {
            return _context.AllergyGroups.Any(e => e.GroupID == id);
        }
    }
}
