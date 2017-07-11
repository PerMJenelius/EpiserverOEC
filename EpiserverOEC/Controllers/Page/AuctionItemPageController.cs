using EPiServer.Web.Mvc;
using EpiserverOEC.Models.Blocks;
using EpiserverOEC.Models.Pages;
using OEC_webb.Models;
using System;
using System.Web.Mvc;

namespace EpiserverOEC.Controllers.Page
{
    public class AuctionItemPageController : PageController<AuctionItemPage>
    {
        public ActionResult Index(AuctionItemPage currentPage)
        {
            return View(currentPage);
        }

        [HttpPost]
        public ActionResult PostBid(AuctionItemPage currentPage, BidStuff BidThing)
        {
            string idStr = currentPage.PageLink.ToString();
            int id = Convert.ToInt32(idStr);

            BidVM bid = new BidVM();
            bid.ItemId = id;
            bid.BidAmount = BidThing.BidAmount;
            bid.NewBidder = BidThing.NewBidder;

            string message = SQLQuery.AddBidToDB(bid);

            return RedirectToAction("Index");
        }
    }
}