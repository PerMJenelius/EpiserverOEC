using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverOEC.Models.Blocks
{
    [ContentType(DisplayName = "InfoStrip", GUID = "c42445a4-48bb-440a-a347-4cd9da1af6ec", Description = "")]
    public class InfoStrip : BlockData
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