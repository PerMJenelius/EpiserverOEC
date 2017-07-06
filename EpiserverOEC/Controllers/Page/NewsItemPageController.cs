using EPiServer.Web.Mvc;
using EpiserverOEC.Models.Pages;
using System.Web.Mvc;

namespace EpiserverOEC.Controllers.Page
{
    public class NewsItemPageController : PageController<NewsItemPage>
    {
        public ActionResult Index(NewsItemPage currentPage)
        {
            return View(currentPage);
        }
    }
}