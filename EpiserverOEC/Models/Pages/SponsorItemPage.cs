﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace EpiserverOEC.Models.Pages
{
    [ContentType(DisplayName = "SponsorItemPage", GUID = "0f487412-7c94-4c59-8624-6fa411dc0024", Description = "")]
    public class SponsorItemPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "Add a heading.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual String Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Body Text",
            Description = "Add some text to describe the page.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString BodyText { get; set; }

        [CultureSpecific]

        [Display(
            Name = "Image",
            Description = "Add an image of the item.",
            GroupName = UIHint.Image,
            Order = 3)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Link",
            Description = "Add a link to the sponsor's web/social media site.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual String Link { get; set; }
    }
}