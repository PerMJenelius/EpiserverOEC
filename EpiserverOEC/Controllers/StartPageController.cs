﻿using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EpiserverOEC.Models.Pages;

namespace EpiserverOEC.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}