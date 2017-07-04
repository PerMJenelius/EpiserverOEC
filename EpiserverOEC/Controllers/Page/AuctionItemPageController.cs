using EPiServer.Web.Mvc;
using EpiserverOEC.Models.Pages;
using OEC_webb.Models;
using System.Web.Mvc;

namespace EpiserverOEC.Controllers.Page
{
    public class AuctionItemPageController : PageController<AuctionItemPage>
    {
        public ActionResult Index(AuctionItemPage currentPage)
        {
            var bidHistory = SQLQuery.GetBidHistory(100);

            return View(currentPage);
        }
    }
}