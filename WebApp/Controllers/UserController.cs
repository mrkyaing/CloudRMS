using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers {
    [Authorize(Roles = "Admin")]
    public class UserController : Controller {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly SignInManager<AppUser> signInManager;

        public UserController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager) {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
        }
        public async Task<IActionResult> Index() {
            List<UserViewModel> models = new List<UserViewModel>();
            var users = userManager.Users.ToList();
            foreach (var u in users) {
                UserViewModel user = new UserViewModel();
                user.Id= u.Id;
                user.Name = u.FullName;
                user.Email = u.Email;
                var roles = await userManager.GetRolesAsync(u);
                user.AppRoleId = roles.FirstOrDefault();
                models.Add(user);
            }
            return View(models);
        }

        [HttpGet]
        public IActionResult Entry() {
            UserViewModel model = new UserViewModel();
            model.ApplicationRoles = roleManager.Roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            }).ToList();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Entry(UserViewModel model) {
            if (ModelState.IsValid) {
                var user = new AppUser
                {
                    FullName = model.Name,
                    UserName = model.UserName,
                    Email = model.Email
                };
                IdentityResult result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded) {
                    AppRole applicationRole = await roleManager.FindByIdAsync(model.AppRoleId);
                    if (applicationRole != null) {
                        IdentityResult roleResult = await userManager.AddToRoleAsync(user, applicationRole.Name);
                        if (roleResult.Succeeded) {
                            await signInManager.SignInAsync(user, isPersistent: false);
                            return RedirectToAction("Index");
                        }
                    }
                }

            }
            model.ApplicationRoles = roleManager.Roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            }).ToList();
            return View(model);
        }
    }
}
