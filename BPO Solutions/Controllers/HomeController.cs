using BPO_Solutions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BPO_Solutions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(loginModel lg)
        {
            using (BPOContext bpe = new BPOContext())
            {
                if(bpe.Admin.Any(x=>x.AdminId==lg.username && x.Password==lg.password))
                {
                    FormsAuthentication.SetAuthCookie(lg.username, false);
                }
            }
            return RedirectToAction("Index", "Admin");
            
        }

        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return View("login");

        }
    }
}