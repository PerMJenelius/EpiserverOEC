using EPiServer.Web.Mvc;
using EpiserverOEC.Models.Pages;
using System.Web.Mvc;

namespace EpiserverOEC.Controllers.Page
{
    public class SponsorItemPageController : PageController<SponsorItemPage>
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}