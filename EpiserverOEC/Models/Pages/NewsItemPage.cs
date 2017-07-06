using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace EpiserverOEC.Models.Pages
{
    [ContentType(DisplayName = "NewsItemPage", GUID = "c4ccb8e1-9a46-4f28-b55f-2d7ac7b1a47e", Description = "A News Item")]
    public class NewsItemPage : SitePageData
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
            Name = "Category",
            Description = "Add one category.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual String ItemCategory { get; set; }
    }
}