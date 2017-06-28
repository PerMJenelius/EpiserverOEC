using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverOEC.Models.Pages
{
    [ContentType(DisplayName = "SignupPage", GUID = "d04fa319-59c8-4429-884a-8ef8dda8c930", Description = "")]
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