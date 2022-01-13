using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [Authorize(Policy = "writepolicy")]
        public IActionResult Index()
        {
            var users = userManager.Users.ToList();
            return View(users);
        }

        [Authorize(Policy = "writepolicy")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await userManager.FindByIdAsync(id);

            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserName,NormalizedUserName,Email,NormalizedEmail")] IdentityUser user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }
            try
            {
                IdentityUser thisUser = await userManager.FindByIdAsync(user.Id);
                thisUser.UserName = user.UserName;
                thisUser.Email = user.Email;
                await userManager.UpdateAsync(thisUser);
            }
            catch (DbUpdateConcurrencyException)
            {
                return View();
            }

            return RedirectToAction("Index");
        }


        [Authorize(Policy = "writepolicy")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await userManager.Users
                .FirstOrDefaultAsync(r => r.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: FoodChains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            await userManager.DeleteAsync(user);
            return RedirectToAction(nameof(Index));
        }

    }
}