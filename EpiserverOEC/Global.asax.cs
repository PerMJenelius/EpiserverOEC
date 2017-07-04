using EPiServer.ServiceLocation;
using EPiServer.Web;
using System;
using System.Web.Mvc;

namespace EpiserverOEC
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            var displayOptions = ServiceLocator.Current.GetInstance<DisplayOptions>();
            displayOptions.Add(
                id: "promo",
                tag: "promo",
                // The name and description properties can also be reference keys to a language resource to allow internationalization.
                name: "Promotion",
                description: "Promotional content is displayed full width and with background highlighing.",
                iconClass: "icon-promo"
            );

            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
        }
    }
}