using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverOEC.Models.Pages
{
    [ContentType(DisplayName = "SignupPage", GUID = "0794c556-d2fc-4ae7-b649-590412634053", Description = "")]
    public class SignupPage : SitePageData
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