using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IronOcr;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using Restaurant.Data;
using Restaurant.Models;
using System.Diagnostics;

namespace Restaurant.Controllers
{
    public class ScansController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostEnvironment hostingEnvironment;

        public ScansController(ApplicationDbContext context, IHostEnvironment environment)
        {
            _context = context;
            hostingEnvironment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ScanMenu(IFormFile file)
        {
            // Setting up the upload path for the menu
            string upload = Path.Combine(hostingEnvironment.ContentRootPath, "Menus");

            // As long as the file is greater than 0 in length, execute the following code to upload to the directory
            if (file.Length > 0)
            {
                string filePath = Path.Combine(upload, file.FileName);
                using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                /* 
                * Everything above this point is for saving the file to a temporary directory first for processing later
                * Everything below this point is processing the PDFs via OCR
                */

                var Ocr = new IronTesseract();
                using (var input = new OcrInput(filePath))
                {

                    // TODO: Change action here or make the Scan button unclickable with JavaScript
                    if (input == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        // Sharpen file and make clearer for processing
                        input.DeNoise();
                        input.Deskew();

                        var result = Ocr.Read(input);

                        ViewData["MenuText"] = result.Text;


                        string[] glutenCheck = { "glutenfree", "gluten-free", "gluten free", "gf" };
                        string[] dairyCheck = { "milk", "dairy", "cheese", "cream", "lactose" };
                        string[] nutCheck = { "nut", "nuts", "peanuts" };
                        string[] soyCheck = { "soy", "soya", "tofu", "edamame" };
                        string[] otherCheck = { "celery", "shellfish", "vegetarian", "vegan", "halal", "kosher" };

                        if (glutenCheck.Any(result.Text.Contains))
                        {
                            ViewData["glutenCheck"] = "This menu mentions gluten-free.";
                        }

                        if (dairyCheck.Any(result.Text.Contains))
                        {
                            ViewData["dairyCheck"] = "This menu mentions dairy-containing ingredients.";
                        }

                        if (nutCheck.Any(result.Text.Contains))
                        {
                            ViewData["nutCheck"] = "This menu mentions nuts.";
                        }

                        if (soyCheck.Any(result.Text.Contains))
                        {
                            ViewData["soyCheck"] = "This menu mentions soy, tofu or edamame.";
                        }

                        foreach (var item in otherCheck)
                        {
                            // Extra parameter to ignore case sensitivity
                            if (result.Text.Contains(item, StringComparison.OrdinalIgnoreCase))
                            {
                                ViewData["otherCheck"] += item + ", ";
                            }
                        }

                    }

                    // Delete File from directory
                    System.IO.File.Delete(filePath);
                }
            }

            return View("Index");

        }
    }
}
