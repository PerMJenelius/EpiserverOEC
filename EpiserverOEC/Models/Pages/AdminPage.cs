using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverOEC.Models.Pages
{
    [ContentType(DisplayName = "AdminPage", GUID = "b0ab5eab-f3ae-464c-becf-14630ab29abb", Description = "")]
    public class AdminPage : SitePageData
    {
        [Display(
            Name = "Main content",
            Description = "Using the editor you can insert text, images or tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [CultureSpecific]
        public virtual ContentArea MainContentArea { get; set; }
    }
}