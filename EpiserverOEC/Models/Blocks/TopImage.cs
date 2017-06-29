using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverOEC.Models.Blocks
{
    [ContentType(DisplayName = "TopImage", GUID = "fa92e0bb-0b99-4003-afa2-f704de95b245", Description = "An image without text.")]
    public class TopImage : BlockData
    {
        [Display(
            Name = "Image", Description = "Add an image (optional)",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual ContentReference Image { get; set; }
    }
}