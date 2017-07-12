using EPiServer.Web.Mvc;
using EpiserverOEC.Models.Blocks;
using EpiserverOEC.Models.Pages;
using Newtonsoft.Json;
using OEC_webb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiserverOEC.Controllers.Page
{
    public class AdminPageController : PageController<AdminPage>
    {
        // GET: AdminPage
        public ActionResult Index(AdminPage currentPage)
        {
            return View(currentPage);
        }

        public ActionResult Login(AdminPage currentPage, InlogInfo Inlog)
        {
            if (Inlog.Login == "Per" && Inlog.Password == "abcde12345")
            {
                return PartialView("AdminView");
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public string DeleteBid(int id, int amount)
        {
            bool success = SQLQuery.DeleteBidFromDB(id, amount);

            return JsonConvert.SerializeObject(success);
        }
    }
}