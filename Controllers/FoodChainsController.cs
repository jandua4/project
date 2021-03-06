using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Restaurant.Data;
using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Controllers
{
    public class FoodChainsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostEnvironment hostingEnvironment;

        public FoodChainsController(ApplicationDbContext context, IHostEnvironment environment)
        {
            _context = context;
            hostingEnvironment = environment;
        }

        // GET: FoodChains
        // Includes pagination, sorting and searching
        [Authorize(Policy = "writepolicy")]
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            // Sort Functionality
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSort"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["GFSort"] = sortOrder == "glutenfree" ? "gf_desc" : "glutenfree";
            ViewData["VegeSort"] = sortOrder == "vegetarian" ? "vege_desc" : "vegetarian";
            ViewData["VeganSort"] = sortOrder == "vegan" ? "vegan_desc" : "vegan";
            ViewData["DFSort"] = sortOrder == "dairyfree" ? "dairy_desc" : "dairyfree";
            ViewData["NFSort"] = sortOrder == "nutfree" ? "nut_desc" : "nutfree";

            // Page number is set to 1 if there is a search string
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            // Call FoodChains model
            var foodchains = from f in _context.FoodChains
                             select f;

            // Search function
            ViewData["CurrentFilter"] = searchString;
            if (!string.IsNullOrEmpty(searchString))
            {
                foodchains = foodchains.Where(f => f.FoodChainName.Contains(searchString));
            }

            // Switch case for sorting results
            foodchains = sortOrder switch
            {
                "name_desc" => foodchains.OrderByDescending(s => s.FoodChainName),
                "glutenfree" => foodchains.OrderBy(s => s.GlutenFreeOptions),
                "gf_desc" => foodchains.OrderByDescending(s => s.GlutenFreeOptions),
                "vegetarian" => foodchains.OrderBy(s => s.VegetarianOptions),
                "vege_desc" => foodchains.OrderByDescending(s => s.VegetarianOptions),
                "vegan" => foodchains.OrderBy(s => s.VeganOptions),
                "vegan_desc" => foodchains.OrderByDescending(s => s.VeganOptions),
                "dairyfree" => foodchains.OrderBy(s => s.DairyFreeOptions),
                "dairy_desc" => foodchains.OrderByDescending(s => s.DairyFreeOptions),
                "nutfree" => foodchains.OrderBy(s => s.NutFreeOptions),
                "nut_desc" => foodchains.OrderByDescending(s => s.NutFreeOptions),
                _ => foodchains.OrderBy(s => s.FoodChainName),
            };

            // Number of records per page before paginating
            int pageSize = 10;

            return View(await PaginatedList<FoodChain>.CreateAsync(foodchains.AsNoTracking(), pageNumber ?? 1, pageSize));
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

            return View(foodChain);
        }

        // GET: FoodChains/Create
        [Authorize(Policy = "writepolicy")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: FoodChains/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FoodChainID,FoodChainName,Description,GlutenFreeOptions,VegetarianOptions,VeganOptions,DairyFreeOptions,NutFreeOptions,OtherOptions")] FoodChain foodChain)
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
        [Authorize(Policy = "writepolicy")]
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
        public async Task<IActionResult> Edit(int id, [Bind("FoodChainID,FoodChainName,Description,GlutenFreeOptions,VegetarianOptions,VeganOptions,DairyFreeOptions,NutFreeOptions,OtherOptions")] FoodChain foodChain)
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
        [Authorize(Policy = "writepolicy")]
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

        /*
        *  This is the upload controller action.
        *  Returns a view and handles upload processing.
        *  Custom written action
        *  Author: Aman Jandu
        */
        // GET: FoodChains/Upload/5
        [Authorize(Policy = "writepolicy")]
        public async Task<IActionResult> Upload(int? id)
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

        // POST upload action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(IFormFile file, [Bind("FoodChainID,FoodChainName,Description,GlutenFreeOptions,VegetarianOptions,VeganOptions,DairyFreeOptions,NutFreeOptions,OtherOptions")] FoodChain foodChain)
        {
            if (file != null)
            {
                // Max Length is less than 5MB
                if (file.Length > 0 && file.Length < 5242880)
                {
                    using (var target = new MemoryStream())
                    {
                        file.CopyTo(target);
                        foodChain.MenuLink = target.ToArray();

                        _context.FoodChains.Update(foodChain);
                        await _context.SaveChangesAsync();
                    }
                }
                // Add an error associated with the file upload if it does not meet the requirements of the IF statement above.
                else
                {
                    ModelState.AddModelError(nameof(foodChain.MenuLink), "This file is not usable. Please try a different file that is less than 5MB.");
                    return View(foodChain);
                }
            }
            // Null files are allowed if the restaurant does not want to provide a menu.
            else
            {
                RedirectToAction(nameof(Index));
            }
            // Return to Index page after code execution.
            return RedirectToAction(nameof(Index));
        }

        /*
        *  This is the controller action to handle downloading menus.
        *  Checks if a menu is not null, and then converts the varbinary data to a pdf and generates a file.
        *  Custom written action
        *  Author: Aman Jandu
        */
        [HttpPost]
        public async Task<IActionResult> Download(int? id)
        {
            var foodChain = await _context.FoodChains
                .FirstOrDefaultAsync(x => x.FoodChainID == id);

            if (foodChain == null)
            {
                return NotFound();
            }
            if (foodChain.MenuLink == null)
            {
                return View(foodChain);
            }
            else
            {
                // Generate PDF from the varbinary data in the database
                byte[] byteArr = foodChain.MenuLink;
                string mimeType = "application/pdf";
                return new FileContentResult(byteArr, mimeType)
                {
                    FileDownloadName = $"{foodChain.FoodChainName} Menu.pdf"
                };
            }
        }

        /*
         * Custom Written Action
         * View to return a list of restaurants
         * This view returns restaurants that match the allergy criteria in the dropdown box (generated from allergy groups and allergies database tables).
         * Utilises a ViewModel to handle multiple models in a single view
         * 
         * Author: Aman Jandu
         */
        public async Task<IActionResult> AvoidAllergy(int? pageNumber, int? allergyselect, string selectedValue, string currentFilter, string searchString)
        {
            // Instantiate the ViewModel
            var viewModel = new AllergyGroupFoodChain();
            
            // Set up database connections
            // Allocates View Model Properties to _context Models
            var foodChains = from f in _context.FoodChains
                             .OrderBy(i => i.FoodChainName)
                             .AsEnumerable()
                             select f;

            var allergies = from a in _context.Allergies
                            .Include(g => g.AllergyGroup)
                            select a;

            var allergyGroups = from g in _context.AllergyGroups
                                select g;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            // Search box filter
            ViewData["CurrentFilter"] = searchString;

            // Selected Value filter
            ViewData["selectedValue"] = selectedValue;
            ViewData["allergyselect"] = allergyselect;

            // Search function
            if (!string.IsNullOrEmpty(searchString))
            {
                foodChains = foodChains.Where(f => f.FoodChainName.Contains(searchString, StringComparison.OrdinalIgnoreCase));
            }            

            // As long as the Dropdown is not empty
            if (allergyselect != null)
            {
                // If string is empty
                if (string.IsNullOrEmpty(selectedValue))
                {
                    foodChains = foodChains;
                }

                // If string is 'None'
                if (selectedValue == "None")
                {
                    foodChains = foodChains;
                }

                // Gluten-Free results only
                if (selectedValue == "Gluten")
                {
                    foodChains = foodChains.Where(f => f.GlutenFreeOptions == "Yes");
                }

                // Vegetarian results only
                if (selectedValue == "Vegetarian")
                {
                    foodChains = foodChains.Where(f => f.VegetarianOptions == "Yes");
                }

                // Vegetarian results only
                if (selectedValue == "Vegan")
                {
                    foodChains = foodChains.Where(f => f.VeganOptions == "Yes");
                }

                // Dairy-Free results only
                if (selectedValue == "Dairy")
                {
                    foodChains = foodChains.Where(f => f.DairyFreeOptions == "Yes");
                }

                // Nut-Free results only
                if (selectedValue == "Nuts")
                {
                    foodChains = foodChains.Where(f => f.NutFreeOptions == "Yes");
                }


                // Search through all other allergies
                if ((allergyselect != null) &&
                    (!string.IsNullOrEmpty(selectedValue)) &&
                    (selectedValue != "") &&
                    (selectedValue != "None") &&
                    (selectedValue != "Gluten") &&
                    (selectedValue != "Vegetarian") &&
                    (selectedValue != "Vegan") &&
                    (selectedValue != "Dairy") &&
                    (selectedValue != "Nuts"))
                {
                    /*
                     * If the selected option isn't empty and does not match the other options
                     * return all results from the chosen Allergy Group that has associated allergies
                     * and check them against the value of the "OtherOptions" column
                     */

                    // Select all allergies where the Allergy.GroupID == the value of the allergyselect dropdown.
                    // Join on the Allergy Groups table where GroupID = GroupID. Get all Allergy.Names
                    var names = from a in allergies
                                where a.GroupID == allergyselect
                                join g in allergyGroups on a.GroupID equals g.GroupID
                                select a.Name;

                    // For each returned allergy, append it to a hidden element for searching.
                    foreach (var name in names)
                    {
                        ViewData["AllergyNames"] += name + ", ";
                        System.Diagnostics.Debug.WriteLine(name);
                    }

                    // Split the results string by comma and space (in case the allergy name has a space)
                    string matches = ViewData["AllergyNames"].ToString();
                    string[] matchingAllergies = matches.Split(',');

                    // Return results where OtherOptions != null and intersects with the matching allergies. Finds allergies separated by commas OR commas and spaces
                    foodChains = foodChains
                        .AsEnumerable()
                        .Where(f => f.OtherOptions != null &&
                        f.OtherOptions.Split(new string[] { ", " }, StringSplitOptions.None).Intersect(matchingAllergies).Any() ||
                        f.OtherOptions != null &&
                        f.OtherOptions.Split(',', StringSplitOptions.None).Intersect(matchingAllergies).Any());

                }
            }

            int pageSize = 3;

            return View(new AllergyGroupFoodChain
            {
                FoodChains = await PaginatedList<FoodChain>.CreateAsync(foodChains.AsQueryable().AsNoTracking(), pageNumber ?? 1, pageSize),
                Allergies = allergies,
                AllergyGroups = allergyGroups
            });
        }


        private bool FoodChainExists(int id)
        {
            return _context.FoodChains.Any(e => e.FoodChainID == id);
        }

    }
}
