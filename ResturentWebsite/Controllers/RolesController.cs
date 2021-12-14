using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ResturentWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturentWebsite.Controllers
{
    [Authorize]
    public class RolesController : Controller
    {

        //Identity User 
        //IdentityRole

        private RoleManager<IdentityRole> roleManager;
        private UserManager<IdentityUser> userManager;

        public RolesController(RoleManager<IdentityRole> roleManager,
            UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View(roleManager.Roles);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoleID,RoleName")] RoleModel roleModel)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await roleManager
                  .CreateAsync(new IdentityRole(roleModel.RoleName));

                if (result.Succeeded)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(roleModel);
        }
    }


}
