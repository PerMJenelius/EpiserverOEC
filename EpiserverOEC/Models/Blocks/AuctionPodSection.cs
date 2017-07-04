using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverOEC.Models.Blocks
{
    [ContentType(DisplayName = "AuctionPodSection", GUID = "d2ccd03f-2744-4f5a-876b-59d8380feb4d", Description = "")]
    public class AuctionPodSection : BlockData
    {
        [CultureSpecific]
        [Display(Order = 1)]
        public virtual String Heading { get; set; }

        [CultureSpecific]
        [Display(Order = 2)]
        public virtual XhtmlString BodyText { get; set; }

        [CultureSpecific]
        [Display(Order = 3)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Display(Order = 4)]
        public virtual String Heading1 { get; set; }

        [CultureSpecific]
        [Display(Order = 5)]
        public virtual XhtmlString BodyText1 { get; set; }

        [CultureSpecific]
        [Display(Order = 6)]
        public virtual ContentReference Image1 { get; set; }

        [CultureSpecific]
        [Display(Order = 7)]
        public virtual String Heading2 { get; set; }

        [CultureSpecific]
        [Display(Order = 8)]
        public virtual XhtmlString BodyText2 { get; set; }

        [CultureSpecific]
        [Display(Order = 9)]
        public virtual ContentReference Image2 { get; set; }
    }
}