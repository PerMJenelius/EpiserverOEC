using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EpiserverOEC.Models.Pages;
using EpiserverOEC.Business.Initialization;
using System.Collections.Generic;
using System;
using System.Linq;
using EpiserverOEC.Models;
using EpiserverOEC.Models.Blocks;

namespace EpiserverOEC.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }

        [HttpPost]
        public ActionResult Submit(StartPage currentPage, SignupInfo Signup)
        {
            //Send emails to sender and receiver

            return PartialView("SubmitSuccess");
        }

        protected DisplayOptionEnum GetDisplayOptionTag()
        {
            var renderSettings = this.ControllerContext.RouteData.Values["renderSettings"] as Dictionary<string, object>;
            if (renderSettings == null)
                return DisplayOptionEnum.Unknown;

            object tag;
            if (!renderSettings.TryGetValue("tag", out tag))
                return DisplayOptionEnum.Unknown;

            if (tag == null)
                return DisplayOptionEnum.Unknown;

            return GetDisplayOptionTag(tag.ToString());
        }

        public static DisplayOptionEnum GetDisplayOptionTag(string tag)
        {
            DisplayOptionEnum displayOptionEnum;
            Enum.TryParse<DisplayOptionEnum>(tag, out displayOptionEnum);

            return displayOptionEnum;
        }

        public static string GetDisplayOptionsTag(DisplayOptionEnum value)
        {
            var displayOptionName
                = value.GetAttributeOfEnumValue<DisplayOptionNameAttribute>().ToString();

            return displayOptionName;
        }
    }
}