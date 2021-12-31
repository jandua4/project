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

            // Declare the MenuText empty for processing later
            string MenuText = "";

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
                * Everything below this poing if processing the PDFs via OCR
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

                        /*
                        string[] allergyList = { "gluten", "dairy", "celery", "shellfish", "soy", "nut" };
                        // if result contains any entry from this array, return the matching issues
                        if (allergyList.All(MenuText.Contains))
                        {
                            Console.WriteLine("Yes");
                        }
                        */
                    }

                    // Delete File from directory
                    System.IO.File.Delete(filePath);
                }
            }

            return View("Index");

        }
    }
}
