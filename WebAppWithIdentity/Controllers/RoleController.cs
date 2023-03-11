using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithIdentity.Models;
using WebAppWithIdentity.Models.ViewModels;

namespace WebAppWithIdentity.Controllers
{
    [Authorize]
    public class RoleController : Controller
    {
        private readonly RoleManager<ApplicationRole> roleManager;

        public RoleController(RoleManager<ApplicationRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            List<RoleViewModel> model = new List<RoleViewModel>();
            model = roleManager.Roles.Select(r => new RoleViewModel
            {
                RoleName = r.Name,
                Id = r.Id,
                Description = r.Description,
                NumberOfUsers =10// r.Users.Count
            }).ToList();
            return View(model);
        }
   [Authorize(Policy = "rolecreation")]
        public  IActionResult Entry() => View();
     [Authorize(Policy = "rolecreation")]
        [HttpPost]
        public async Task<IActionResult> Entry(RoleViewModel model)
        {
            if (ModelState.IsValid) {

                ApplicationRole applicationRole =new ApplicationRole
               {
                   CreatedDate = DateTime.UtcNow
               };
                applicationRole.Name = model.RoleName;
                applicationRole.Description = model.Description;
                applicationRole.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                IdentityResult roleRuslt =await roleManager.CreateAsync(applicationRole);
                if (roleRuslt.Succeeded) {
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
    }
}
