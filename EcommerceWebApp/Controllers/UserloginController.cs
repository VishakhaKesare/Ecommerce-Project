using EcommerceWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWebApp.Controllers
{
    public class UserloginController : Controller
    {
        // GET: Userlogin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(ecom_adminUser admin_user)
        {
            //string username = "admin@admin.com";
            //string password = "Admin@2024";
            if (admin_user == null)
            {

            }
            else if (admin_user != null)
            {
                if (ModelState.IsValid)
                {
                    DB_ECOM_ENTITIES ecommerceEntities = new DB_ECOM_ENTITIES();

                    var obj=ecommerceEntities.ecom_adminUser.Where(e=> e.Username.Equals(admin_user.Username)&&e.Password.Equals(admin_user.Password)).FirstOrDefault();

                    if (obj != null)
                    {
                        Session["username"]=obj.Username.ToString();
                        Session["password"]=obj.Password.ToString();
                      return  RedirectToAction("Index", "Home");  
                    }
                }
            }
            return View(admin_user);
        }

    }
}