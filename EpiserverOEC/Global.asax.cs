﻿using EPiServer.ServiceLocation;
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

            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
        }
    }
}