using EPiServer.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using System.Web.Mvc;
using EPiServer;
using System.Web.Routing;

namespace EpiserverOEC.Business.Initialization
{
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class DisplayOptionsConfig : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            var options = ServiceLocator.Current.GetInstance<DisplayOptions>();
            foreach (var optionId in options.Select(x => x.Id).ToArray())
            {
                options.Remove(optionId);
            }

            options
                .Add("full", DisplayOptionTags.FullWidth, DisplayOptionEnum.Full.ToString(), string.Empty, "epi-icon__layout--full")
                .Add("wide", DisplayOptionTags.TwoThirdsWidth, DisplayOptionEnum.TwoThirds.ToString(), string.Empty, "epi-icon__layout--two-thirds")
                .Add("half", DisplayOptionTags.HalfWidth, DisplayOptionEnum.Half.ToString(), string.Empty, "epi-icon__layout--half")
                .Add("narrow", DisplayOptionTags.OneThirdWidth, DisplayOptionEnum.OneThird.ToString(), string.Empty, "epi-icon__layout--one-third")
                .Add("quarter", DisplayOptionTags.OneFourthWidth, DisplayOptionEnum.OneFourth.ToString(), string.Empty, "epi-icon__layout--one-fourth");
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            RegisterRoutes(routes);
            routes.MapRoute("default", "{AuctionItemPage}/{PostBid}", new { action = "Index" });
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }

    public static class DisplayOptionTags
    {
        public const string FullWidth = "Full Width";
        public const string TwoThirdsWidth = "Two Thirds Width ";
        public const string HalfWidth = "Half Width ";
        public const string OneThirdWidth = "One Third Width ";
        public const string OneFourthWidth = "One Fourth Width ";
    }

    public class DisplayOptionNameAttribute : Attribute
    {
        public string Name { get; set; }
    }

    public class BootstrapClassAttribute : Attribute
    {
        public string Name { get; set; }
    }

    public enum DisplayOptionEnum
    {
        Unknown,

        [BootstrapClass(Name = "col-md-12")]
        [DisplayOptionName(Name = DisplayOptionTags.FullWidth)]
        Full,

        [BootstrapClass(Name = "col-md-8")]
        [DisplayOptionName(Name = DisplayOptionTags.TwoThirdsWidth)]
        TwoThirds,

        [BootstrapClass(Name = "col-md-6")]
        [DisplayOptionName(Name = DisplayOptionTags.HalfWidth)]
        Half,

        [BootstrapClass(Name = "col-md-4")]
        [DisplayOptionName(Name = DisplayOptionTags.OneThirdWidth)]
        OneThird,

        [BootstrapClass(Name = "col-md-3")]
        [DisplayOptionName(Name = DisplayOptionTags.OneFourthWidth)]
        OneFourth
    }
}
