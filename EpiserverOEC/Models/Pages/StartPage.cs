using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverOEC.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "2bc56dd9-3bed-49c3-95b0-bcefa27a35bd", Description = "Basic page type for creating a front page.")]
    public class StartPage : SitePageData
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