using EPiServer.Web.Mvc;
using EpiserverOEC.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiserverOEC.Controllers.Page
{
    public class GlobalSettingsController : PageController<GlobalSettings>
    {
        public ActionResult Index(GlobalSettings currentPage)
        {
            return View(currentPage);
        }
    }
}