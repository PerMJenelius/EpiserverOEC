using EPiServer.Web.Mvc;
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
    public class SlideShowPageController : PageController<SlideShowPage>
    {
        // GET: SlideShowPage
        public ActionResult Index(SlideShowPage currentPage)
        {
            return View(currentPage);
        }

        [HttpGet]
        public string UpdateBid(int id)
        {
            var result = SQLQuery.GetBidHistory(id);

            return JsonConvert.SerializeObject(result);
        }
    }
}