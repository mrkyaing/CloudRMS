using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using WebApp.Data;
using WebApp.Models;
using System.Linq;

namespace WebApp.Controllers {
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller {
        private readonly RoleManager<AppRole> roleManager;
        private readonly UserManager<AppUser> userManager;
        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager) {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        public IActionResult Index() {
            List<RoleViewModel> model = new List<RoleViewModel>();
            model = roleManager.Roles.Select(r => new RoleViewModel
            {
                RoleName = r.Name,
                Id = r.Id,
                Description = r.Description,
                NumberOfUsers =1,//userManager.GetUsersInRoleAsync(r.Name).Result.Count()
            }).ToList();
            return View(model);
        }
        public IActionResult Entry() => View();
        [HttpPost]
        public async Task<IActionResult> Entry(RoleViewModel model) {
            if (ModelState.IsValid) {

                AppRole applicationRole = new AppRole
                {
                    CreatedDate = DateTime.UtcNow
                };
                applicationRole.Name = model.RoleName;
                applicationRole.Description = model.Description;
                applicationRole.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                IdentityResult roleRuslt = await roleManager.CreateAsync(applicationRole);
                if (roleRuslt.Succeeded) {
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
    }
}
