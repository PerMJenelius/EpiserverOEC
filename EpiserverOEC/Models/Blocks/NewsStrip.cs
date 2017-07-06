using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverOEC.Models.Blocks
{
    [ContentType(DisplayName = "NewsStrip", GUID = "6dc52cf5-1350-4d4b-b42c-fece8f05f13d", Description = "")]
    public class NewsStrip : BlockData
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