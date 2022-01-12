using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Controllers
{
    public class UsersController : Controller
    {
        UserManager<IdentityUser> userManager;

        public UsersController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        [Authorize(Policy = "readpolicy")]
        public IActionResult Index()
        {
            var users = userManager.Users.ToList();
            return View(users);
        }

        [Authorize(Policy = "writepolicy")]
        public IActionResult Create()
        {
            return View(new IdentityUser());
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityUser user)
        {
            await userManager.CreateAsync(user);
            return RedirectToAction("Index");
        }
    }
}