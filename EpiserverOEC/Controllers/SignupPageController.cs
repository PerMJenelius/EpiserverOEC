using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EpiserverOEC.Models.Pages;

namespace EpiserverOEC.Controllers
{
    public class SignupPageController : PageController<SignupPage>
    {
        public ActionResult Index(SignupPage currentPage)
        {
            return View(currentPage);
        }
    }
}