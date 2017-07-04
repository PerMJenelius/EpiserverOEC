using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace EpiserverOEC.Models.Blocks
{
    [ContentType(DisplayName = "AuctionPod", GUID = "f8c4652d-2b88-4add-8dd0-fc2a1f75ce91", Description = "")]
    public class AuctionPod : BlockData
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
    }
}
