using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverOEC.Models.Blocks
{
    [ContentType(DisplayName = "PageHead", GUID = "aade4841-2431-4e51-b6ca-83c65e20dd5c", Description = "The information at the top of certain page types.")]
    public class PageHead : BlockData
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
            Order = 1)]
        public virtual String BodyText { get; set; }
    }
}