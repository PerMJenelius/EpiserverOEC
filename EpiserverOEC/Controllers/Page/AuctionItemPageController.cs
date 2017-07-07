using EPiServer.Web.Mvc;
using EpiserverOEC.Models.Pages;
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
        public ActionResult PostBid(AuctionItemPage bid)
        {
            return JavaScript("alert('controller get!')");
            //return View("Index", bid);
        }
    }
}