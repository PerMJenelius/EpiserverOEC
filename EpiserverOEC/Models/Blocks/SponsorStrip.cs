using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverOEC.Models.Blocks
{
    [ContentType(DisplayName = "SponsorStrip", GUID = "215a3000-f8de-4d7e-9d3c-951d539c1972", Description = "")]
    public class SponsorStrip : BlockData
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
    }
}