using Abc.MvcWebUI.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Abc.MvcWebUI.Controllers
{
    [Authorize(Roles = "admin")]

    public class AdminController : Controller
    {

        private UserManager<ApplicationUser> userManager;
        public AdminController()
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            userManager = new UserManager<ApplicationUser>(userStore);
        }



        // GET: Admin
   
        public ActionResult Index()
        {

            return View(userManager.Users);


        }
        
        public async Task<ActionResult> Delete(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            var result = await userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                TempData["UserDeleted"] = "Kullanıcı Başarıyla Silindi";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["UserDeleted"] = "Kullanıcı Silme Sırasında Hata Oluştu";
                return RedirectToAction("Index");
            }
        }

    }
}




