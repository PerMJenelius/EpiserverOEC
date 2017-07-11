using EPiServer.Web.Mvc;
using EpiserverOEC.Models.Blocks;
using EpiserverOEC.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiserverOEC.Controllers.Page
{
    public class SignupPageController : PageController<SignupPage>
    {
        public ActionResult Index(SignupPage currentPage)
        {
            return View(currentPage);
        }

        [HttpPost]
        public ActionResult Submit(SignupPage currentPage, SignupInfo Signup)
        {
            return View(currentPage);
            //return RedirectToAction("Index", "Tack för din anmälan. Ett bekräftelsemejl har skickats till den angivna adressen.");
        }
    }
}