using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverOEC.Models.Blocks
{
    [ContentType(DisplayName = "BigBanner", GUID = "adbf2aca-130d-464c-81c1-074c36575ede", Description = "")]
    public class BigBanner : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "Add a heading.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual String Heading { get; set; }

        [Display(
            Name = "Image", Description = "Add an image (optional)",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual ContentReference Image { get; set; }
    }
}